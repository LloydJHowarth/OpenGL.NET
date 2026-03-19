using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ProgramStagePName : uint
		{
			ActiveSubroutines = 0x8DE5,
			ActiveSubroutineUniforms = 0x8DE6,
			ActiveSubroutineUniformLocations = 0x8E47,
			ActiveSubroutineMaxLength = 0x8E48,
			ActiveSubroutineUniformMaxLength = 0x8E49,
		}
	}
}
