using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PathCoverMode : uint
		{
			ConvexHullNv = 0x908B,
			BoundingBoxNv = 0x908D,
			BoundingBoxOfBoundingBoxesNv = 0x909C,
		}
	}
}
