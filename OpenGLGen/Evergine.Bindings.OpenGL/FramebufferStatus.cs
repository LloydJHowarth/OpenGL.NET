namespace Engine.OpenGL;

public enum FramebufferStatus : uint
{
	FramebufferComplete = 0x8CD5,
	FramebufferIncompleteAttachment = 0x8CD6,
	FramebufferIncompleteMissingAttachment = 0x8CD7,
	FramebufferUnsupported = 0x8CDD,
	FramebufferUndefined = 0x8219,
	FramebufferIncompleteMultisample = 0x8D56,
	FramebufferIncompleteDrawBuffer = 0x8CDB,
	FramebufferIncompleteReadBuffer = 0x8CDC,
}
