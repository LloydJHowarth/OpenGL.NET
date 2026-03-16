namespace Engine.OpenGL;

public enum StencilOp : uint
{
	Zero = 0,
	Keep = 0x1E00,
	Incr = 0x1E02,
	Decr = 0x1E03,
	IncrWrap = 0x8507,
	DecrWrap = 0x8508,
}
