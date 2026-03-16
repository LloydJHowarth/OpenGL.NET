using System;

namespace Engine.OpenGL
{
	public enum GetConvolutionParameter : uint
	{
		ConvolutionFormat = 0x8017,
		ConvolutionWidth = 0x8018,
		ConvolutionHeight = 0x8019,
		MaxConvolutionWidth = 0x801A,
		MaxConvolutionHeight = 0x801B,
		ConvolutionBorderColor = 0x8154,
		ConvolutionFormatExt = 0x8017,
		ConvolutionWidthExt = 0x8018,
		ConvolutionHeightExt = 0x8019,
		MaxConvolutionWidthExt = 0x801A,
		MaxConvolutionHeightExt = 0x801B,
	}
}
