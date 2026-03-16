using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum FragmentLightModelParameterSGIX : uint
		{
			FragmentLightModelLocalViewerSgix = 0x8408,
			FragmentLightModelTwoSideSgix = 0x8409,
			FragmentLightModelAmbientSgix = 0x840A,
			FragmentLightModelNormalInterpolationSgix = 0x840B,
		}
	}
}
