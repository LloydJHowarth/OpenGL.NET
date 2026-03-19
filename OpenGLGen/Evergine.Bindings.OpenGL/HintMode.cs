using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum HintMode : uint
		{
			DontCare = 0x1100,
			Fastest = 0x1101,
			Nicest = 0x1102,
		}
	}
}
