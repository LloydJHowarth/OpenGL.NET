using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum SyncParameterName : uint
		{
			ObjectType = 0x9112,
			SyncCondition = 0x9113,
			SyncStatus = 0x9114,
			SyncFlags = 0x9115,
		}
	}
}
