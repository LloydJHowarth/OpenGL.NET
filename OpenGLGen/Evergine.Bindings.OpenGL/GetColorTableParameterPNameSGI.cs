using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum GetColorTableParameterPNameSGI : uint
		{
			ColorTableFormat = 0x80D8,
			ColorTableWidth = 0x80D9,
			ColorTableRedSize = 0x80DA,
			ColorTableGreenSize = 0x80DB,
			ColorTableBlueSize = 0x80DC,
			ColorTableAlphaSize = 0x80DD,
			ColorTableLuminanceSize = 0x80DE,
			ColorTableIntensitySize = 0x80DF,
			ColorTableFormatSgi = 0x80D8,
			ColorTableWidthSgi = 0x80D9,
			ColorTableRedSizeSgi = 0x80DA,
			ColorTableGreenSizeSgi = 0x80DB,
			ColorTableBlueSizeSgi = 0x80DC,
			ColorTableAlphaSizeSgi = 0x80DD,
			ColorTableLuminanceSizeSgi = 0x80DE,
			ColorTableIntensitySizeSgi = 0x80DF,
		}
	}
}
