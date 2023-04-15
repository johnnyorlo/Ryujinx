namespace Ryujinx.Graphics.GAL
{
    public struct ShaderInfo
    {
        public int FragmentOutputMap { get; }
        public bool HasBindless { get; }
        public ProgramPipelineState? State { get; }
        public bool FromCache { get; set; }

        public ShaderInfo(int fragmentOutputMap, bool hasBindless, ProgramPipelineState state, bool fromCache = false)
        {
            FragmentOutputMap = fragmentOutputMap;
            HasBindless = hasBindless;
            State = state;
            FromCache = fromCache;
        }

        public ShaderInfo(int fragmentOutputMap, bool hasBindless, bool fromCache = false)
        {
            FragmentOutputMap = fragmentOutputMap;
            HasBindless = hasBindless;
            State = null;
            FromCache = fromCache;
        }
    }
}