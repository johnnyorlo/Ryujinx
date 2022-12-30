using System;
using System.Runtime.InteropServices;

namespace ARMeilleure.Memory
{
    internal class SimpleMemoryManager : IMemoryManager
    {
        public int AddressSpaceBits => 39;

        public nint PageTablePointer => IntPtr.Zero;

        public MemoryManagerType Type => MemoryManagerType.HostMappedUnsafe;

        public event Action<ulong, ulong> UnmapEvent;

        private readonly byte[] _data;

        public SimpleMemoryManager(byte[] data)
        {
            _data = data;
        }

        public ref T GetRef<T>(ulong va) where T : unmanaged
        {
            return ref MemoryMarshal.Cast<byte, T>(_data.AsSpan().Slice((int)va))[0];
        }

        public ReadOnlySpan<byte> GetSpan(ulong va, int size, bool tracked = false)
        {
            return _data.AsSpan().Slice((int)va, size);
        }

        public bool IsMapped(ulong va)
        {
            return (uint)va == va && (uint)va < (uint)_data.Length;
        }

        public T Read<T>(ulong va) where T : unmanaged
        {
            return GetRef<T>(va);
        }

        public T ReadTracked<T>(ulong va) where T : unmanaged
        {
            return GetRef<T>(va);
        }

        public void SignalMemoryTracking(ulong va, ulong size, bool write, bool precise = false)
        {
        }

        public void Write<T>(ulong va, T value) where T : unmanaged
        {
            GetRef<T>(va) = value;
        }
    }
}
