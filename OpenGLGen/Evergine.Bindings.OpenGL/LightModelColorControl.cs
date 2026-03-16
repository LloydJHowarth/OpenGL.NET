using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum LightModelColorControl : uint
		{
			SingleColorExt = 0x81F9,
			SeparateSpecularColorExt = 0x81FA,
		}
	}
}
