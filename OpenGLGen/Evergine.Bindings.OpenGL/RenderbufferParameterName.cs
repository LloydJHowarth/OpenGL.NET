using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum RenderbufferParameterName : uint
		{
			RenderbufferWidth = 0x8D42,
			RenderbufferHeight = 0x8D43,
			RenderbufferInternalFormat = 0x8D44,
			RenderbufferRedSize = 0x8D50,
			RenderbufferGreenSize = 0x8D51,
			RenderbufferBlueSize = 0x8D52,
			RenderbufferAlphaSize = 0x8D53,
			RenderbufferDepthSize = 0x8D54,
			RenderbufferStencilSize = 0x8D55,
			RenderbufferSamples = 0x8CAB,
		}
	}
}
