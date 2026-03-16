using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum SyncCondition : uint
		{
			SyncGpuCommandsComplete = 0x9117,
		}
	}
}
