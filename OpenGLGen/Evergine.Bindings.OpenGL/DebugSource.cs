using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum DebugSource : uint
		{
			DebugSourceApi = 0x8246,
			DebugSourceWindowSystem = 0x8247,
			DebugSourceShaderCompiler = 0x8248,
			DebugSourceThirdParty = 0x8249,
			DebugSourceApplication = 0x824A,
			DebugSourceOther = 0x824B,
		}
	}
}
