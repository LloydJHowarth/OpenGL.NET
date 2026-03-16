using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ConvolutionTargetEXT : uint
		{
			Convolution1d = 0x8010,
			Convolution2d = 0x8011,
			Convolution1dExt = 0x8010,
			Convolution2dExt = 0x8011,
		}
	}
}
