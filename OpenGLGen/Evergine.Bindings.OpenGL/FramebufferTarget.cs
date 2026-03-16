using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum FramebufferTarget : uint
		{
			Framebuffer = 0x8D40,
			ReadFramebuffer = 0x8CA8,
			DrawFramebuffer = 0x8CA9,
		}
	}
}
