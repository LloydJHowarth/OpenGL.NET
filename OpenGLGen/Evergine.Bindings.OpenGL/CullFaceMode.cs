using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum CullFaceMode : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}
	}
}
