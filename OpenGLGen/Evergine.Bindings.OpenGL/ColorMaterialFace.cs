using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ColorMaterialFace : uint
		{
			Front = 0x0404,
			Back = 0x0405,
			FrontAndBack = 0x0408,
		}
	}
}
