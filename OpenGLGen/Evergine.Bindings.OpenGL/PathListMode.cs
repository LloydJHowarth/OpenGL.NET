using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PathListMode : uint
		{
			AccumAdjacentPairsNv = 0x90AD,
			AdjacentPairsNv = 0x90AE,
			FirstToRestNv = 0x90AF,
		}
	}
}
