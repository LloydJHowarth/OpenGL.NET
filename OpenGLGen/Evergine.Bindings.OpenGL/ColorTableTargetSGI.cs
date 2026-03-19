using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ColorTableTargetSGI : uint
		{
			ColorTable = 0x80D0,
			PostConvolutionColorTable = 0x80D1,
			PostColorMatrixColorTable = 0x80D2,
			ProxyColorTable = 0x80D3,
			ProxyPostConvolutionColorTable = 0x80D4,
			ProxyPostColorMatrixColorTable = 0x80D5,
			ColorTableSgi = 0x80D0,
			PostConvolutionColorTableSgi = 0x80D1,
			PostColorMatrixColorTableSgi = 0x80D2,
			ProxyColorTableSgi = 0x80D3,
			ProxyPostConvolutionColorTableSgi = 0x80D4,
			ProxyPostColorMatrixColorTableSgi = 0x80D5,
			TextureColorTableSgi = 0x80BC,
			ProxyTextureColorTableSgi = 0x80BD,
		}
	}
}
