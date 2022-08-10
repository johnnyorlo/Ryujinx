using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Null
{
    internal class CounterEvent : ICounterEvent
    {
        public bool Invalid { get; set; }

        public void Dispose()
        {
        }

        public void Flush()
        {
        }

        public bool ReserveForHostAccess()
        {
            return true;
        }
    }
}
