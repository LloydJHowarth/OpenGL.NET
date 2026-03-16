using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PathFillMode : uint
		{
			PathFillModeNv = 0x9080,
			CountUpNv = 0x9088,
			CountDownNv = 0x9089,
		}
	}
}
