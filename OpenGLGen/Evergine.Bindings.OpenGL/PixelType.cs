using System;

namespace Engine.OpenGL
{
	public enum PixelType : uint
	{
		UnsignedShort4444 = 0x8033,
		UnsignedShort5551 = 0x8034,
		UnsignedByte332Ext = 0x8032,
		UnsignedShort4444Ext = 0x8033,
		UnsignedShort5551Ext = 0x8034,
		UnsignedInt8888Ext = 0x8035,
		UnsignedInt1010102Ext = 0x8036,
	}
}
