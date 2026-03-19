using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PathFontTarget : uint
		{
			StandardFontNameNv = 0x9072,
			SystemFontNameNv = 0x9073,
			FileNameNv = 0x9074,
		}
	}
}
