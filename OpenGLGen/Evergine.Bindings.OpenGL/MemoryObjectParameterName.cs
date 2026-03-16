using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum MemoryObjectParameterName : uint
		{
			DedicatedMemoryObjectExt = 0x9581,
			ProtectedMemoryObjectExt = 0x959B,
		}
	}
}
