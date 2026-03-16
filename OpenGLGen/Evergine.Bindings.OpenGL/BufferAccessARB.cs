using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum BufferAccessARB : uint
		{
			ReadWrite = 0x88BA,
			WriteOnly = 0x88B9,
		}
	}
}
