using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum TextureEnvMode : uint
		{
			ReplaceExt = 0x8062,
			TextureEnvBiasSgix = 0x80BE,
		}
	}
}
