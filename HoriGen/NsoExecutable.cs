using LibHac.Common.FixedArrays;
using LibHac.Fs;
using LibHac.FsSystem;
using LibHac.Loader;
using LibHac.Tools.FsSystem;
using System;
using System.IO;

namespace HoriGen
{
    partial class NsoExecutable
    {
        public byte[] Program { get; }
        public Span<byte> Text => Program.AsSpan((int)TextOffset, (int)TextSize);
        public Span<byte> Ro => Program.AsSpan((int)RoOffset, (int)RoSize);
        public Span<byte> Data => Program.AsSpan((int)DataOffset, (int)DataSize);

        public uint TextOffset { get; }
        public uint RoOffset { get; }
        public uint DataOffset { get; }
        public uint BssOffset => DataOffset + (uint)Data.Length;

        public uint TextSize { get; }
        public uint RoSize { get; }
        public uint DataSize { get; }
        public uint BssSize { get; }

        public Array32<byte> BuildId;

        public NsoExecutable(string filePath)
        {
            NsoReader reader = new NsoReader();

            using var storage = new LocalStorage(filePath, FileAccess.Read);

            reader.Initialize(storage.AsFile(OpenMode.Read)).ThrowIfFailure();

            TextOffset = reader.Header.Segments[0].MemoryOffset;
            RoOffset = reader.Header.Segments[1].MemoryOffset;
            DataOffset = reader.Header.Segments[2].MemoryOffset;
            BssSize = reader.Header.BssSize;

            reader.GetSegmentSize(NsoReader.SegmentType.Data, out uint uncompressedSize).ThrowIfFailure();

            Program = new byte[DataOffset + uncompressedSize];

            TextSize = DecompressSection(reader, NsoReader.SegmentType.Text, TextOffset);
            RoSize = DecompressSection(reader, NsoReader.SegmentType.Ro, RoOffset);
            DataSize = DecompressSection(reader, NsoReader.SegmentType.Data, DataOffset);
            BuildId = reader.Header.ModuleId;
        }

        private uint DecompressSection(NsoReader reader, NsoReader.SegmentType segmentType, uint offset)
        {
            reader.GetSegmentSize(segmentType, out uint uncompressedSize).ThrowIfFailure();

            var span = Program.AsSpan((int)offset, (int)uncompressedSize);

            reader.ReadSegment(segmentType, span).ThrowIfFailure();

            return uncompressedSize;
        }
    }
}