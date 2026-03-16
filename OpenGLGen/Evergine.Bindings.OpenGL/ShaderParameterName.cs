using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ShaderParameterName : uint
		{
			ShaderType = 0x8B4F,
			DeleteStatus = 0x8B80,
			CompileStatus = 0x8B81,
			InfoLogLength = 0x8B84,
			ShaderSourceLength = 0x8B88,
		}
	}
}
