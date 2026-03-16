using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum PathHandleMissingGlyphs : uint
		{
			SkipMissingGlyphNv = 0x90A9,
			UseMissingGlyphNv = 0x90AA,
		}
	}
}
