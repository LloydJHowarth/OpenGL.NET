namespace Engine.OpenGL;

public enum CopyBufferSubDataTarget : uint
{
	ArrayBuffer = 0x8892,
	AtomicCounterBuffer = 0x92C0,
	CopyReadBuffer = 0x8F36,
	CopyWriteBuffer = 0x8F37,
	DispatchIndirectBuffer = 0x90EE,
	DrawIndirectBuffer = 0x8F3F,
	ElementArrayBuffer = 0x8893,
	PixelPackBuffer = 0x88EB,
	PixelUnpackBuffer = 0x88EC,
	QueryBuffer = 0x9192,
	ShaderStorageBuffer = 0x90D2,
	TextureBuffer = 0x8C2A,
	TransformFeedbackBuffer = 0x8C8E,
	UniformBuffer = 0x8A11,
}
