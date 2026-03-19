using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum GraphicsResetStatus : uint
		{
			GuiltyContextReset = 0x8253,
			InnocentContextReset = 0x8254,
			UnknownContextReset = 0x8255,
		}
	}
}
