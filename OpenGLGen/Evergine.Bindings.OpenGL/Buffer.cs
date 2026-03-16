using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum Buffer : uint
		{
			Color = 0x1800,
			Depth = 0x1801,
			Stencil = 0x1802,
		}
	}
}
