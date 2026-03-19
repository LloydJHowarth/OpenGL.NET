using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum PathMetricMask : uint
		{
			GlyphWidthBitNv = 0x01,
			GlyphHeightBitNv = 0x02,
			GlyphHorizontalBearingXBitNv = 0x04,
			GlyphHorizontalBearingYBitNv = 0x08,
			GlyphHorizontalBearingAdvanceBitNv = 0x10,
			GlyphVerticalBearingXBitNv = 0x20,
			GlyphVerticalBearingYBitNv = 0x40,
			GlyphVerticalBearingAdvanceBitNv = 0x80,
			GlyphHasKerningBitNv = 0x100,
			FontXMinBoundsBitNv = 0x00010000,
			FontYMinBoundsBitNv = 0x00020000,
			FontXMaxBoundsBitNv = 0x00040000,
			FontYMaxBoundsBitNv = 0x00080000,
			FontUnitsPerEmBitNv = 0x00100000,
			FontAscenderBitNv = 0x00200000,
			FontDescenderBitNv = 0x00400000,
			FontHeightBitNv = 0x00800000,
			FontMaxAdvanceWidthBitNv = 0x01000000,
			FontMaxAdvanceHeightBitNv = 0x02000000,
			FontUnderlinePositionBitNv = 0x04000000,
			FontUnderlineThicknessBitNv = 0x08000000,
			FontHasKerningBitNv = 0x10000000,
			FontNumGlyphIndicesBitNv = 0x20000000,
		}
	}
}
