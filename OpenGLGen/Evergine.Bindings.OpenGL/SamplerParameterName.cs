using System;

namespace Engine.OpenGL
{
	public enum SamplerParameterName : uint
	{
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
		TextureWrapR = 0x8072,
		TextureMinFilter = 0x2801,
		TextureMagFilter = 0x2800,
		TextureBorderColor = 0x1004,
		TextureMinLod = 0x813A,
		TextureMaxLod = 0x813B,
		TextureCompareMode = 0x884C,
		TextureCompareFunc = 0x884D,
	}
}
