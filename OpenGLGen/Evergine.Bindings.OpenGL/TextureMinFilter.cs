using System;

namespace Engine.OpenGL
{
	public enum TextureMinFilter : uint
	{
		NearestMipmapNearest = 0x2700,
		LinearMipmapNearest = 0x2701,
		NearestMipmapLinear = 0x2702,
		LinearMipmapLinear = 0x2703,
		LinearClipmapLinearSgix = 0x8170,
		NearestClipmapNearestSgix = 0x844D,
		NearestClipmapLinearSgix = 0x844E,
		LinearClipmapNearestSgix = 0x844F,
	}
}
