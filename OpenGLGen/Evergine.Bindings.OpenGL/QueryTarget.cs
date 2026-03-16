using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum QueryTarget : uint
		{
			TransformFeedbackPrimitivesWritten = 0x8C88,
			AnySamplesPassed = 0x8C2F,
			AnySamplesPassedConservative = 0x8D6A,
			TimeElapsed = 0x88BF,
		}
	}
}
