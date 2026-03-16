using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ClipControlDepth : uint
		{
			NegativeOneToOne = 0x935E,
			ZeroToOne = 0x935F,
		}
	}
}
