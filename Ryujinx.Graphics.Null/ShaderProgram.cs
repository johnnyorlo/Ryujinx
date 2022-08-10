using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Null
{
    class ShaderProgram : IProgram
    {
        public ProgramLinkStatus CheckProgramLink(bool blocking)
        {
            return ProgramLinkStatus.Success;
        }

        public void Dispose()
        {
        }

        public byte[]? GetBinary()
        {
            return null;
        }
    }
}
