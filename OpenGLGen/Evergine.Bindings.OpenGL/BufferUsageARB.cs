using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum BufferUsageARB : uint
		{
			StreamDraw = 0x88E0,
			StaticDraw = 0x88E4,
			DynamicDraw = 0x88E8,
			StreamRead = 0x88E1,
			StreamCopy = 0x88E2,
			StaticRead = 0x88E5,
			StaticCopy = 0x88E6,
			DynamicRead = 0x88E9,
			DynamicCopy = 0x88EA,
		}
	}
}
