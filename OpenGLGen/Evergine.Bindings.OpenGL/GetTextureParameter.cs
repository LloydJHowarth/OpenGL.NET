using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum GetTextureParameter : uint
		{
			TextureMagFilter = 0x2800,
			TextureMinFilter = 0x2801,
			TextureWrapS = 0x2802,
			TextureWrapT = 0x2803,
		}
	}
}
