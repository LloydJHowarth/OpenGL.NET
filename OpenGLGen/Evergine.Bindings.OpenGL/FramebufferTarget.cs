using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum FramebufferTarget : uint
		{
			Framebuffer = 0x8D40,
			ReadFramebuffer = 0x8CA8,
			DrawFramebuffer = 0x8CA9,
		}
	}
}
