using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum VertexProvokingMode : uint
		{
			FirstVertexConvention = 0x8E4D,
			LastVertexConvention = 0x8E4E,
		}
	}
}
