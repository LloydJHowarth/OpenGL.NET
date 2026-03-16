using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ProgramInterfacePName : uint
		{
			ActiveResources = 0x92F5,
			MaxNameLength = 0x92F6,
			MaxNumActiveVariables = 0x92F7,
			MaxNumCompatibleSubroutines = 0x92F8,
		}
	}
}
