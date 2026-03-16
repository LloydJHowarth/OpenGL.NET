using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum FrontFaceDirection : uint
		{
			Cw = 0x0900,
			Ccw = 0x0901,
		}
	}
}
