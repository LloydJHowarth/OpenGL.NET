using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PathTransformType : uint
		{
			TranslateXNv = 0x908E,
			TranslateYNv = 0x908F,
			Translate2dNv = 0x9090,
			Translate3dNv = 0x9091,
			Affine2dNv = 0x9092,
			Affine3dNv = 0x9094,
			TransposeAffine2dNv = 0x9096,
			TransposeAffine3dNv = 0x9098,
		}
	}
}
