using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum GraphicsResetStatus : uint
		{
			GuiltyContextReset = 0x8253,
			InnocentContextReset = 0x8254,
			UnknownContextReset = 0x8255,
		}
	}
}
