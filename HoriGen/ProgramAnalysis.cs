using ARMeilleure.Decoders;
using ARMeilleure.Memory;
using System;
using System.Net;

namespace HoriGen
{
    internal class ProgramAnalysis
    {
        public static (ulong, int) FindProcessAddressAndCommandId(IMemoryManager mm, ulong funcAddress)
        {
            var decodedFunc = Decoder.Decode(mm, funcAddress, ARMeilleure.State.ExecutionMode.Aarch64, true, DecoderMode.MultipleBlocks);
            var bbWithCall = FindLastBBWithCall(decodedFunc);

            if (bbWithCall == null)
            {
                return (0UL, -1);
            }

            // This assumes that the Process function will be called at the end.
            // The command ID is always the last argument passed to that function.
            // This is quite fragile because in some cases it does not call the Process function,
            // and the way how it find the last argument is pretty crude.

            int[] movConstMapPerReg = new int[32];
            bool[] movConstExistsPerReg = new bool[32];
            ulong processFuncAddress = 0UL;

            foreach (var inst in bbWithCall.OpCodes)
            {
                // Extract constant value from possible move instructions.
                if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Movz)
                {
                    // MOVZ Rd, #Imm16
                    var op = (OpCodeMov)inst;
                    movConstMapPerReg[op.Rd] = (int)op.Immediate;
                    movConstExistsPerReg[op.Rd] = true;
                }
                else if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Movk)
                {
                    // MOVK Rd, #Imm16, #Shift
                    var op = (OpCodeMov)inst;
                    movConstMapPerReg[op.Rd] = (movConstMapPerReg[op.Rd] & ~(0xffff << op.Bit)) | (int)op.Immediate;
                    movConstExistsPerReg[op.Rd] = true;
                }
                else if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Orr &&
                         inst is OpCodeAluImm orrImm &&
                         orrImm.Rn == 31)
                {
                    // ORR Rd, ZR, #ImmX, also called MOV Rd, #ImmX
                    movConstMapPerReg[orrImm.Rd] = (int)orrImm.Immediate;
                    movConstExistsPerReg[orrImm.Rd] = true;
                }
                else if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Orr &&
                         inst is OpCodeAluRs orrReg &&
                         orrReg.Rn == 31 &&
                         orrReg.Rm == 31)
                {
                    // ORR Rd, ZR, ZR, also called MOV Rd, ZR
                    movConstMapPerReg[orrReg.Rd] = 0;
                    movConstExistsPerReg[orrReg.Rd] = true;
                }
                else if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Bl &&
                         inst is OpCodeBImmAl bl)
                {
                    processFuncAddress = (ulong)bl.Immediate;
                    break;
                }
                else if (inst is OpCodeMul opMul)
                {
                    // Sometimes it needs to move constants to a register for size multiplications.
                    // This is not the command ID so we should ignore those constants.
                    movConstExistsPerReg[opMul.Rn] = false;
                    movConstExistsPerReg[opMul.Rm] = false;
                    movConstExistsPerReg[opMul.Ra] = false;
                }
            }

            int commandId = -1;

            for (int i = 0; i < 29; i++)
            {
                if (movConstExistsPerReg[i])
                {
                    commandId = movConstMapPerReg[i];
                }
            }

            return (processFuncAddress, commandId);
        }

        public static ulong GetTargetAddressFromThunk(IMemoryManager mm, ulong thunkAddress)
        {
            var decodedFunc = Decoder.Decode(mm, thunkAddress, ARMeilleure.State.ExecutionMode.Aarch64, true, DecoderMode.MultipleBlocks);

            if (decodedFunc.Length != 1)
            {
                return 0UL;
            }

            Block bb = decodedFunc[0];

            if (bb.OpCodes.Count < 4)
            {
                return 0UL;
            }

            if (!(bb.OpCodes[0] is OpCodeAdr opAdr) || opAdr.Instruction.Name != ARMeilleure.Instructions.InstName.Adrp)
            {
                return 0UL;
            }

            if (!(bb.OpCodes[1] is OpCodeMemImm opLdr) || opLdr.Instruction.Name != ARMeilleure.Instructions.InstName.Ldr)
            {
                return 0UL;
            }

            if (!(bb.OpCodes[2] is OpCodeAluImm opAdd) || opAdd.Instruction.Name != ARMeilleure.Instructions.InstName.Add)
            {
                return 0UL;
            }

            ulong targetAddress = (opAdr.Address & ~0xfffUL) + ((ulong)opAdr.Immediate << 12);
            targetAddress += (ulong)opLdr.Immediate;

            ulong funcAddress = mm.Read<ulong>(targetAddress);

            return funcAddress;
        }

        private static Block FindLastBBWithCall(Block[] bbs)
        {
            Block bb = null;

            foreach (var block in bbs)
            {
                foreach (var inst in block.OpCodes)
                {
                    if (inst.Instruction.Name == ARMeilleure.Instructions.InstName.Bl)
                    {
                        bb = block;
                        break;
                    }
                }
            }

            return bb;
        }

        public static void Relocate(IMemoryManager mm, Mod0Loader.Image image)
        {
            ulong relAddress = image.RelAddress;
            ulong relCount = image.RelCount;

            for (ulong i = 0; i < relCount; i++)
            {
                ulong relaEntryAddress = relAddress + i * 0x18;

                ulong toRelocOffset = mm.Read<ulong>(relaEntryAddress);
                ulong relocInfo = mm.Read<ulong>(relaEntryAddress + 8);
                ulong relocAddend = mm.Read<ulong>(relaEntryAddress + 0x10);

                uint type = (uint)relocInfo;
                uint symIndex = (uint)(relocInfo >> 32);

                if (type == 1026)
                {
                    mm.Write(toRelocOffset, relocAddend + image.Symbols[symIndex].Value);
                }
            }
        }
    }
}
