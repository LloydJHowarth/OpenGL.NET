using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PixelFormat : uint
		{
			DepthComponent = 0x1902,
			Alpha = 0x1906,
			Rgb = 0x1907,
			Rgba = 0x1908,
			Luminance = 0x1909,
			LuminanceAlpha = 0x190A,
			Red = 0x1903,
			RedInteger = 0x8D94,
			RgbInteger = 0x8D98,
			RgbaInteger = 0x8D99,
			DepthStencil = 0x84F9,
			Rg = 0x8227,
			RgInteger = 0x8228,
			Green = 0x1904,
			Blue = 0x1905,
			StencilIndex = 0x1901,
			Bgra = 0x80E1,
			AbgrExt = 0x8000,
			CmykExt = 0x800C,
			CmykaExt = 0x800D,
			RedExt = 0x1903,
			Ycrcb422Sgix = 0x81BB,
			Ycrcb444Sgix = 0x81BC,
		}
	}
}
