using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum DrawElementsType : uint
		{
			UnsignedByte = 0x1401,
			UnsignedShort = 0x1403,
			UnsignedInt = 0x1405,
		}
	}
}
