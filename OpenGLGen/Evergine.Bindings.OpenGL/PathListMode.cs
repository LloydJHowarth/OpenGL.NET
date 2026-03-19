using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PathListMode : uint
		{
			AccumAdjacentPairsNv = 0x90AD,
			AdjacentPairsNv = 0x90AE,
			FirstToRestNv = 0x90AF,
		}
	}
}
