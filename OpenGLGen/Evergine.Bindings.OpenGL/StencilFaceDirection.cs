using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum StencilFaceDirection : uint
		{
			Front = 0x0404,
			Back = 0x0405,
			FrontAndBack = 0x0408,
		}
	}
}
