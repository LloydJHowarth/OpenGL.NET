using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TextureGenParameter : uint
		{
			EyePlane = 0x2502,
			EyePointSgis = 0x81F4,
			ObjectPointSgis = 0x81F5,
			EyeLineSgis = 0x81F6,
			ObjectLineSgis = 0x81F7,
		}
	}
}
