using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TextureMagFilter : uint
		{
			Nearest = 0x2600,
			LinearDetailSgis = 0x8097,
			LinearDetailAlphaSgis = 0x8098,
			LinearDetailColorSgis = 0x8099,
			LinearSharpenSgis = 0x80AD,
			LinearSharpenAlphaSgis = 0x80AE,
			LinearSharpenColorSgis = 0x80AF,
		}
	}
}
