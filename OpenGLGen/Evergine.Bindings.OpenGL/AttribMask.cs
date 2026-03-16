using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum AttribMask : uint
		{
			DepthBufferBit = 0x00000100,
			StencilBufferBit = 0x00000400,
			ColorBufferBit = 0x00004000,
			MultisampleBit3dfx = 0x20000000,
			MultisampleBitArb = 0x20000000,
			MultisampleBitExt = 0x20000000,
		}
	}
}
