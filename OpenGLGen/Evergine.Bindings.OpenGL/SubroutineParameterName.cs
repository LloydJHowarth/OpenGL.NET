using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum SubroutineParameterName : uint
		{
			NumCompatibleSubroutines = 0x8E4A,
			CompatibleSubroutines = 0x8E4B,
		}
	}
}
