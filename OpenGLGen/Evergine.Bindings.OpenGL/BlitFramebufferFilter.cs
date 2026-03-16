using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum BlitFramebufferFilter : uint
		{
			Nearest = 0x2600,
			Linear = 0x2601,
		}
	}
}
