using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum BufferStorageMask : uint
		{
			MapReadBit = 0x0001,
			MapWriteBit = 0x0002,
			MapPersistentBit = 0x0040,
			MapCoherentBit = 0x0080,
			DynamicStorageBit = 0x0100,
			ClientStorageBit = 0x0200,
			SparseStorageBitArb = 0x0400,
			MapPersistentBitExt = 0x0040,
			MapCoherentBitExt = 0x0080,
			DynamicStorageBitExt = 0x0100,
			ClientStorageBitExt = 0x0200,
			MapReadBitExt = 0x0001,
			MapWriteBitExt = 0x0002,
			LgpuSeparateStorageBitNvx = 0x0800,
			PerGpuStorageBitNv = 0x0800,
		}
	}
}
