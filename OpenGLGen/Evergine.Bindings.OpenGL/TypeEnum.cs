using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TypeEnum : uint
		{
			QueryWait = 0x8E13,
			QueryNoWait = 0x8E14,
			QueryByRegionWait = 0x8E15,
			QueryByRegionNoWait = 0x8E16,
		}
	}
}
