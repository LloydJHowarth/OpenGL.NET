using System;

namespace Engine.OpenGL
{
	public enum BufferTargetARB : uint
	{
		ArrayBuffer = 0x8892,
		ElementArrayBuffer = 0x8893,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		TransformFeedbackBuffer = 0x8C8E,
		CopyReadBuffer = 0x8F36,
		CopyWriteBuffer = 0x8F37,
		UniformBuffer = 0x8A11,
	}
}
