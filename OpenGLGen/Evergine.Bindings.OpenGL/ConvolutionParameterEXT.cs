using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ConvolutionParameterEXT : uint
		{
			ConvolutionBorderMode = 0x8013,
			ConvolutionFilterScale = 0x8014,
			ConvolutionFilterBias = 0x8015,
			ConvolutionBorderModeExt = 0x8013,
			ConvolutionFilterScaleExt = 0x8014,
			ConvolutionFilterBiasExt = 0x8015,
		}
	}
}
