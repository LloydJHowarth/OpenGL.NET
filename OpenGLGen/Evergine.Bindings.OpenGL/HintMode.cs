using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum HintMode : uint
		{
			DontCare = 0x1100,
			Fastest = 0x1101,
			Nicest = 0x1102,
		}
	}
}
