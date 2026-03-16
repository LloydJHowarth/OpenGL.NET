using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PathFontTarget : uint
		{
			StandardFontNameNv = 0x9072,
			SystemFontNameNv = 0x9073,
			FileNameNv = 0x9074,
		}
	}
}
