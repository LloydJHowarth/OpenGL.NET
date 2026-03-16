using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PixelStoreParameter : uint
		{
			PackAlignment = 0x0D05,
			PackImageDepthSgis = 0x8131,
			PackImageHeight = 0x806C,
			PackImageHeightExt = 0x806C,
			PackLsbFirst = 0x0D01,
			PackResampleOml = 0x8984,
			PackResampleSgix = 0x842E,
			PackRowLength = 0x0D02,
			PackSkipImages = 0x806B,
			PackSkipImagesExt = 0x806B,
			PackSkipPixels = 0x0D04,
			PackSkipRows = 0x0D03,
			PackSkipVolumesSgis = 0x8130,
			PackSubsampleRateSgix = 0x85A0,
			PackSwapBytes = 0x0D00,
			PixelTileCacheSizeSgix = 0x8145,
			PixelTileGridDepthSgix = 0x8144,
			PixelTileGridHeightSgix = 0x8143,
			PixelTileGridWidthSgix = 0x8142,
			PixelTileHeightSgix = 0x8141,
			PixelTileWidthSgix = 0x8140,
			UnpackAlignment = 0x0CF5,
			UnpackImageDepthSgis = 0x8133,
			UnpackImageHeight = 0x806E,
			UnpackImageHeightExt = 0x806E,
			UnpackLsbFirst = 0x0CF1,
			UnpackResampleOml = 0x8985,
			UnpackResampleSgix = 0x842F,
			UnpackRowLength = 0x0CF2,
			UnpackRowLengthExt = 0x0CF2,
			UnpackSkipImages = 0x806D,
			UnpackSkipImagesExt = 0x806D,
			UnpackSkipPixels = 0x0CF4,
			UnpackSkipPixelsExt = 0x0CF4,
			UnpackSkipRows = 0x0CF3,
			UnpackSkipRowsExt = 0x0CF3,
			UnpackSkipVolumesSgis = 0x8132,
			UnpackSubsampleRateSgix = 0x85A1,
			UnpackSwapBytes = 0x0CF0,
		}
	}
}
