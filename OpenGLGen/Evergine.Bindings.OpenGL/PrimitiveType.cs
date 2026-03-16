namespace Engine.OpenGL;

public enum PrimitiveType : uint
{
	Points = 0x0000,
	Lines = 0x0001,
	LineLoop = 0x0002,
	LineStrip = 0x0003,
	Triangles = 0x0004,
	TriangleStrip = 0x0005,
	TriangleFan = 0x0006,
	LinesAdjacencyArb = 0x000A,
	LineStripAdjacencyArb = 0x000B,
	TrianglesAdjacencyArb = 0x000C,
	TriangleStripAdjacencyArb = 0x000D,
	Patches = 0x000E,
	Quads = 0x0007,
	LinesAdjacencyExt = 0x000A,
	LineStripAdjacencyExt = 0x000B,
	TrianglesAdjacencyExt = 0x000C,
	TriangleStripAdjacencyExt = 0x000D,
	PatchesExt = 0x000E,
	QuadsExt = 0x0007,
}
