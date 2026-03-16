using System;

namespace Engine.OpenGL
{
	public enum TextureWrapMode : uint
	{
		Repeat = 0x2901,
		ClampToEdge = 0x812F,
		ClampToBorderArb = 0x812D,
		ClampToBorderNv = 0x812D,
		ClampToBorderSgis = 0x812D,
		ClampToEdgeSgis = 0x812F,
	}
}
