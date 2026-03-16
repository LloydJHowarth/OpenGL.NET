using System;

namespace Engine.OpenGL
{
	public enum BlendEquationModeEXT : uint
	{
		FuncAdd = 0x8006,
		FuncSubtract = 0x800A,
		FuncReverseSubtract = 0x800B,
		Min = 0x8007,
		Max = 0x8008,
		MinExt = 0x8007,
		MaxExt = 0x8008,
		FuncAddExt = 0x8006,
		FuncSubtractExt = 0x800A,
		FuncReverseSubtractExt = 0x800B,
		AlphaMinSgix = 0x8320,
		AlphaMaxSgix = 0x8321,
	}
}
