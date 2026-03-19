using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum UniformBlockPName : uint
		{
			UniformBlockBinding = 0x8A3F,
			UniformBlockDataSize = 0x8A40,
			UniformBlockNameLength = 0x8A41,
			UniformBlockActiveUniforms = 0x8A42,
			UniformBlockActiveUniformIndices = 0x8A43,
			UniformBlockReferencedByVertexShader = 0x8A44,
			UniformBlockReferencedByFragmentShader = 0x8A46,
			UniformBlockReferencedByComputeShader = 0x90EC,
			UniformBlockReferencedByTessControlShader = 0x84F0,
			UniformBlockReferencedByTessEvaluationShader = 0x84F1,
			UniformBlockReferencedByGeometryShader = 0x8A45,
		}
	}
}
