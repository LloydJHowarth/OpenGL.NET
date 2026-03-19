using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ContextFlagMask : uint
		{
			ContextFlagRobustAccessBitArb = 0x00000004,
			ContextFlagProtectedContentBitExt = 0x00000010,
			ContextFlagDebugBit = 0x00000002,
			ContextFlagDebugBitKhr = 0x00000002,
			ContextFlagNoErrorBitKhr = 0x00000008,
		}
	}
}
