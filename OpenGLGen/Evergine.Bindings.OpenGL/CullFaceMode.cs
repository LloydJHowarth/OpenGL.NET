using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum CullFaceMode : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}
	}
}
