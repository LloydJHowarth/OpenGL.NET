using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum VertexBufferObjectParameter : uint
		{
			BufferSize = 0x8764,
			BufferUsage = 0x8765,
			BufferMapped = 0x88BC,
			BufferAccessFlags = 0x911F,
			BufferMapLength = 0x9120,
			BufferMapOffset = 0x9121,
			BufferImmutableStorage = 0x821F,
			BufferStorageFlags = 0x8220,
		}
	}
}
