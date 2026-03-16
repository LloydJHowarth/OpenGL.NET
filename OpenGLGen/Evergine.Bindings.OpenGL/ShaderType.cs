using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ShaderType : uint
		{
			FragmentShader = 0x8B30,
			VertexShader = 0x8B31,
			ComputeShader = 0x91B9,
			FragmentShaderArb = 0x8B30,
			TessEvaluationShader = 0x8E87,
			TessControlShader = 0x8E88,
			VertexShaderArb = 0x8B31,
		}
	}
}
