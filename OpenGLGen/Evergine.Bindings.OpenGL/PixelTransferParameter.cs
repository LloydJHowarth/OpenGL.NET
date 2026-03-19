using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PixelTransferParameter : uint
		{
			PostConvolutionRedScale = 0x801C,
			PostConvolutionGreenScale = 0x801D,
			PostConvolutionBlueScale = 0x801E,
			PostConvolutionAlphaScale = 0x801F,
			PostConvolutionRedBias = 0x8020,
			PostConvolutionGreenBias = 0x8021,
			PostConvolutionBlueBias = 0x8022,
			PostConvolutionAlphaBias = 0x8023,
			PostColorMatrixRedScale = 0x80B4,
			PostColorMatrixGreenScale = 0x80B5,
			PostColorMatrixBlueScale = 0x80B6,
			PostColorMatrixAlphaScale = 0x80B7,
			PostColorMatrixRedBias = 0x80B8,
			PostColorMatrixGreenBias = 0x80B9,
			PostColorMatrixBlueBias = 0x80BA,
			PostColorMatrixAlphaBias = 0x80BB,
		}
	}
}
