using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum MapTextureFormatINTEL : uint
		{
			LayoutDefaultIntel = 0,
			LayoutLinearIntel = 1,
			LayoutLinearCpuCachedIntel = 2,
		}
	}
}
