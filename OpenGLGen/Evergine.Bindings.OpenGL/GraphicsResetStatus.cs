namespace Engine.OpenGL;

public enum GraphicsResetStatus : uint
{
	GuiltyContextReset = 0x8253,
	InnocentContextReset = 0x8254,
	UnknownContextReset = 0x8255,
}
