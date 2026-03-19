using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum TextureLayout : uint
		{
			LayoutGeneralExt = 0x958D,
			LayoutColorAttachmentExt = 0x958E,
			LayoutDepthStencilAttachmentExt = 0x958F,
			LayoutDepthStencilReadOnlyExt = 0x9590,
			LayoutShaderReadOnlyExt = 0x9591,
			LayoutTransferSrcExt = 0x9592,
			LayoutTransferDstExt = 0x9593,
			LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
			LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
		}
	}
}
