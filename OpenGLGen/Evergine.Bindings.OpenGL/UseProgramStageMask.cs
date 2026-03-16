namespace Engine.OpenGL;

public enum UseProgramStageMask : uint
{
	ComputeShaderBit = 0x00000020,
	VertexShaderBit = 0x00000001,
	FragmentShaderBit = 0x00000002,
	GeometryShaderBit = 0x00000004,
	TessControlShaderBit = 0x00000008,
	TessEvaluationShaderBit = 0x00000010,
	AllShaderBits = 0xFFFFFFFF,
	GeometryShaderBitExt = 0x00000004,
	VertexShaderBitExt = 0x00000001,
	FragmentShaderBitExt = 0x00000002,
	AllShaderBitsExt = 0xFFFFFFFF,
	TessControlShaderBitExt = 0x00000008,
	TessEvaluationShaderBitExt = 0x00000010,
	MeshShaderBitNv = 0x00000040,
	TaskShaderBitNv = 0x00000080,
	GeometryShaderBitOes = 0x00000004,
	TessControlShaderBitOes = 0x00000008,
	TessEvaluationShaderBitOes = 0x00000010,
}
