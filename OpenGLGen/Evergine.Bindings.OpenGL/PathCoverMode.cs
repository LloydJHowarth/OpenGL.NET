using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PathCoverMode : uint
		{
			ConvexHullNv = 0x908B,
			BoundingBoxNv = 0x908D,
			BoundingBoxOfBoundingBoxesNv = 0x909C,
		}
	}
}
