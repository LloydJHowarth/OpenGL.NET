using System;

namespace Engine.OpenGL
{
	public enum OcclusionQueryEventMaskAMD : uint
	{
		QueryDepthPassEventBitAmd = 0x00000001,
		QueryDepthFailEventBitAmd = 0x00000002,
		QueryStencilFailEventBitAmd = 0x00000004,
		QueryDepthBoundsFailEventBitAmd = 0x00000008,
		QueryAllEventBitsAmd = 0xFFFFFFFF,
	}
}
