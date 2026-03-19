using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PixelStoreResampleMode : uint
		{
			ResampleReplicateSgix = 0x8433,
			ResampleZeroFillSgix = 0x8434,
			ResampleDecimateSgix = 0x8430,
		}
	}
}
