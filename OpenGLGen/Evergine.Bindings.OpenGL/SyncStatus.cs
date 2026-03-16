using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum SyncStatus : uint
		{
			AlreadySignaled = 0x911A,
			TimeoutExpired = 0x911B,
			ConditionSatisfied = 0x911C,
			WaitFailed = 0x911D,
		}
	}
}
