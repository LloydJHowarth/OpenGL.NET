using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ProgramPropertyARB : uint
		{
			LinkStatus = 0x8B82,
			ValidateStatus = 0x8B83,
			AttachedShaders = 0x8B85,
			ActiveUniforms = 0x8B86,
			ActiveUniformMaxLength = 0x8B87,
			ActiveAttributes = 0x8B89,
			ActiveAttributeMaxLength = 0x8B8A,
			TransformFeedbackVaryingMaxLength = 0x8C76,
			TransformFeedbackBufferMode = 0x8C7F,
			TransformFeedbackVaryings = 0x8C83,
			ActiveUniformBlockMaxNameLength = 0x8A35,
			ActiveUniformBlocks = 0x8A36,
			ProgramBinaryLength = 0x8741,
			ComputeWorkGroupSize = 0x8267,
			ActiveAtomicCounterBuffers = 0x92D9,
		}
	}
}
