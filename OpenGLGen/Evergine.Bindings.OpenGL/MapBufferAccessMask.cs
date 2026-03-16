using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum MapBufferAccessMask : uint
		{
			MapInvalidateRangeBit = 0x0004,
			MapInvalidateBufferBit = 0x0008,
			MapFlushExplicitBit = 0x0010,
			MapUnsynchronizedBit = 0x0020,
			MapInvalidateRangeBitExt = 0x0004,
			MapInvalidateBufferBitExt = 0x0008,
			MapFlushExplicitBitExt = 0x0010,
			MapUnsynchronizedBitExt = 0x0020,
		}
	}
}
