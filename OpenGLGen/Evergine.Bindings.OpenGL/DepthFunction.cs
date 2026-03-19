using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum DepthFunction : uint
		{
			Always = 0x0207,
			Equal = 0x0202,
			Gequal = 0x0206,
			Greater = 0x0204,
			Lequal = 0x0203,
			Less = 0x0201,
			Never = 0x0200,
			Notequal = 0x0205,
		}
	}
}
