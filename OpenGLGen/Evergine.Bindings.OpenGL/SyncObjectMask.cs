using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum SyncObjectMask : uint
		{
			SyncFlushCommandsBit = 0x00000001,
			SyncFlushCommandsBitApple = 0x00000001,
		}
	}
}
