using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PatchParameterName : uint
		{
			PatchVertices = 0x8E72,
			PatchDefaultInnerLevel = 0x8E73,
			PatchDefaultOuterLevel = 0x8E74,
		}
	}
}
