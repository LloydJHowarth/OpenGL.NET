using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TransformFeedbackPName : uint
		{
			TransformFeedbackPaused = 0x8E23,
			TransformFeedbackActive = 0x8E24,
		}
	}
}
