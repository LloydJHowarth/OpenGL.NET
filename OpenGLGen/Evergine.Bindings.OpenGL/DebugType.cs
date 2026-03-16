namespace Engine.OpenGL;

public enum DebugType : uint
{
	DebugTypeError = 0x824C,
	DebugTypeDeprecatedBehavior = 0x824D,
	DebugTypeUndefinedBehavior = 0x824E,
	DebugTypePortability = 0x824F,
	DebugTypePerformance = 0x8250,
	DebugTypeOther = 0x8251,
	DebugTypeMarker = 0x8268,
	DebugTypePushGroup = 0x8269,
	DebugTypePopGroup = 0x826A,
}
