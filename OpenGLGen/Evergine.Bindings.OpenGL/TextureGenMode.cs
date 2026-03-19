using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TextureGenMode : uint
		{
			EyeDistanceToPointSgis = 0x81F0,
			ObjectDistanceToPointSgis = 0x81F1,
			EyeDistanceToLineSgis = 0x81F2,
			ObjectDistanceToLineSgis = 0x81F3,
		}
	}
}
