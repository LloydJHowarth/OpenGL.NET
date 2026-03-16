using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum FramebufferAttachmentParameterName : uint
		{
			FramebufferAttachmentObjectName = 0x8CD1,
			FramebufferAttachmentTextureLevel = 0x8CD2,
			FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
			FramebufferAttachmentColorEncoding = 0x8210,
			FramebufferAttachmentComponentType = 0x8211,
			FramebufferAttachmentRedSize = 0x8212,
			FramebufferAttachmentGreenSize = 0x8213,
			FramebufferAttachmentBlueSize = 0x8214,
			FramebufferAttachmentAlphaSize = 0x8215,
			FramebufferAttachmentDepthSize = 0x8216,
			FramebufferAttachmentStencilSize = 0x8217,
			FramebufferAttachmentTextureLayer = 0x8CD4,
		}
	}
}
