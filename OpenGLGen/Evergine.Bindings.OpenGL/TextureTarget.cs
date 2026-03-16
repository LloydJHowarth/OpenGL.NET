using System;

namespace Engine.OpenGL
{
	public enum TextureTarget : uint
	{
		TextureCubeMap = 0x8513,
		TextureCubeMapPositiveX = 0x8515,
		TextureCubeMapNegativeX = 0x8516,
		TextureCubeMapPositiveY = 0x8517,
		TextureCubeMapNegativeY = 0x8518,
		TextureCubeMapPositiveZ = 0x8519,
		TextureCubeMapNegativeZ = 0x851A,
		Texture3d = 0x806F,
		Texture2dArray = 0x8C1A,
		Texture1dArray = 0x8C18,
		TextureCubeMapArray = 0x9009,
		TextureRectangle = 0x84F5,
		Texture2dMultisample = 0x9100,
		Texture2dMultisampleArray = 0x9102,
		ProxyTextureCubeMapArb = 0x851B,
		TextureCubeMapArrayArb = 0x9009,
		ProxyTextureCubeMapArrayArb = 0x900B,
		ProxyTexture2dMultisample = 0x9101,
		ProxyTexture2dMultisampleArray = 0x9103,
		ProxyTextureRectangleArb = 0x84F7,
		TextureCubeMapArrayOes = 0x9009,
		ProxyTexture1dExt = 0x8063,
		ProxyTexture2dExt = 0x8064,
		ProxyTexture3dExt = 0x8070,
		ProxyTexture1dArrayExt = 0x8C19,
		ProxyTexture2dArrayExt = 0x8C1B,
		ProxyTextureCubeMapExt = 0x851B,
		TextureCubeMapArrayExt = 0x9009,
		ProxyTextureRectangleNv = 0x84F7,
		Texture3dOes = 0x806F,
		DetailTexture2dSgis = 0x8095,
		ProxyTexture4dSgis = 0x8135,
	}
}
