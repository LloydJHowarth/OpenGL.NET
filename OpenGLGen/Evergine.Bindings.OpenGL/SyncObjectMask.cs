using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum SyncObjectMask : uint
		{
			SyncFlushCommandsBit = 0x00000001,
			SyncFlushCommandsBitApple = 0x00000001,
		}
	}
}
