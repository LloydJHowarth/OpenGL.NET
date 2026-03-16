using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PixelStoreSubsampleRate : uint
		{
			PixelSubsample4444Sgix = 0x85A2,
			PixelSubsample2424Sgix = 0x85A3,
			PixelSubsample4242Sgix = 0x85A4,
		}
	}
}
