using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum TransformFeedbackPName : uint
		{
			TransformFeedbackPaused = 0x8E23,
			TransformFeedbackActive = 0x8E24,
		}
	}
}
