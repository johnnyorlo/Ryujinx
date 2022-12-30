using Ryujinx.HLE.Loaders.Elf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HoriGen
{
    class Mod0Loader
    {
        private ref struct Reader
        {
            private ReadOnlySpan<byte> _message;

            public int Length => _message.Length;

            public Reader(ReadOnlySpan<byte> message)
            {
                _message = message;
            }

            public T Read<T>(ulong offset) where T : unmanaged
            {
                return MemoryMarshal.Cast<byte, T>(_message.Slice((int)offset))[0];
            }
        }

        private const int Mod0 = 'M' << 0 | 'O' << 8 | 'D' << 16 | '0' << 24;

        public class Image
        {
            public ulong BaseAddress { get; }
            public ulong Size { get; }
            public ulong EndAddress => BaseAddress + Size;

            public ulong RelAddress { get; }
            public ulong RelCount { get;  }

            public ElfSymbol[] Symbols { get; }
            public IReadOnlyDictionary<ulong, ElfSymbol> SymbolsByAddress { get; }

            public Image(ulong baseAddress, ulong size, ulong relAddress, ulong relEntryCount, ElfSymbol[] symbols, IReadOnlyDictionary<ulong, ElfSymbol> symbolsByAddress)
            {
                BaseAddress = baseAddress;
                Size = size;
                RelAddress = relAddress;
                RelCount = relEntryCount;
                Symbols = symbols;
                SymbolsByAddress = symbolsByAddress;
            }
        }

        public static Image Load(ReadOnlySpan<byte> data, ulong textOffset, ulong textSize)
        {
            Reader reader = new Reader(data);

            ulong mod0Offset = textOffset + reader.Read<uint>(textOffset + 4);

            if (mod0Offset < textOffset || (mod0Offset & 3) != 0)
            {
                return null;
            }

            Dictionary<ElfDynamicTag, ulong> dynamic = new Dictionary<ElfDynamicTag, ulong>();

            int mod0Magic = reader.Read<int>(mod0Offset + 0x0);

            if (mod0Magic != Mod0)
            {
                return null;
            }

            ulong dynamicOffset = reader.Read<uint>(mod0Offset + 0x4) + mod0Offset;
            ulong bssStartOffset = reader.Read<uint>(mod0Offset + 0x8) + mod0Offset;
            ulong bssEndOffset = reader.Read<uint>(mod0Offset + 0xc) + mod0Offset;
            ulong ehHdrStartOffset = reader.Read<uint>(mod0Offset + 0x10) + mod0Offset;
            ulong ehHdrEndOffset = reader.Read<uint>(mod0Offset + 0x14) + mod0Offset;
            ulong modObjOffset = reader.Read<uint>(mod0Offset + 0x18) + mod0Offset;

            bool isAArch32 = reader.Read<ulong>(dynamicOffset) > 0xFFFFFFFF || reader.Read<ulong>(dynamicOffset + 0x10) > 0xFFFFFFFF;

            while (true)
            {
                ulong tagVal;
                ulong value;

                if (isAArch32)
                {
                    tagVal = reader.Read<uint>(dynamicOffset + 0);
                    value = reader.Read<uint>(dynamicOffset + 4);

                    dynamicOffset += 0x8;
                }
                else
                {
                    tagVal = reader.Read<ulong>(dynamicOffset + 0);
                    value = reader.Read<ulong>(dynamicOffset + 8);

                    dynamicOffset += 0x10;
                }

                ElfDynamicTag tag = (ElfDynamicTag)tagVal;

                if (tag == ElfDynamicTag.DT_NULL)
                {
                    break;
                }

                dynamic[tag] = value;
            }

            if (!dynamic.TryGetValue(ElfDynamicTag.DT_STRTAB, out ulong strTab) ||
                !dynamic.TryGetValue(ElfDynamicTag.DT_SYMTAB, out ulong symTab) ||
                !dynamic.TryGetValue(ElfDynamicTag.DT_SYMENT, out ulong symEntSize))
            {
                return null;
            }

            ulong strTblAddr = textOffset + strTab;
            ulong symTblAddr = textOffset + symTab;

            List<ElfSymbol> symbols = new List<ElfSymbol>();
            Dictionary<ulong, ElfSymbol> symbolsByAddress = new Dictionary<ulong, ElfSymbol>();

            while (symTblAddr < strTblAddr)
            {
                ElfSymbol sym = isAArch32 ? GetSymbol32(ref reader, symTblAddr, strTblAddr) : GetSymbol64(ref reader, symTblAddr, strTblAddr);

                symbols.Add(sym);
                symbolsByAddress.TryAdd(sym.Value, sym);

                symTblAddr += symEntSize;
            }

            if (!dynamic.TryGetValue(ElfDynamicTag.DT_JMPREL, out ulong relAdress) ||
                !dynamic.TryGetValue(ElfDynamicTag.DT_PLTRELSZ, out ulong relSize))
            {
                return null;
            }

            return new Image(textOffset, textSize, relAdress, relSize / 0x18, symbols.ToArray(), symbolsByAddress);
        }

        private static ElfSymbol GetSymbol64(ref Reader reader, ulong address, ulong strTblAddr)
        {
            ElfSymbol64 sym = reader.Read<ElfSymbol64>(address);

            uint nameIndex = sym.NameOffset;

            string name = string.Empty;

            for (int chr; (chr = reader.Read<byte>(strTblAddr + nameIndex++)) != 0;)
            {
                name += (char)chr;
            }

            return new ElfSymbol(name, sym.Info, sym.Other, sym.SectionIndex, sym.ValueAddress, sym.Size);
        }

        private static ElfSymbol GetSymbol32(ref Reader reader, ulong address, ulong strTblAddr)
        {
            ElfSymbol32 sym = reader.Read<ElfSymbol32>(address);

            uint nameIndex = sym.NameOffset;

            string name = string.Empty;

            for (int chr; (chr = reader.Read<byte>(strTblAddr + nameIndex++)) != 0;)
            {
                name += (char)chr;
            }

            return new ElfSymbol(name, sym.Info, sym.Other, sym.SectionIndex, sym.ValueAddress, sym.Size);
        }
    }
}
