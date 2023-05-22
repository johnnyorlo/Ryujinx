using System;

namespace ARMeilleure.Translation
{
    class DelegateInfo
    {
        private readonly Delegate _dlg; // Ensure that this delegate will not be garbage collected.

        public IntPtr FuncPtr { get; }

        public DelegateInfo(Delegate dlg, IntPtr funcPtr)
        {
            _dlg = dlg;
            FuncPtr = funcPtr;
        }
    }
}
