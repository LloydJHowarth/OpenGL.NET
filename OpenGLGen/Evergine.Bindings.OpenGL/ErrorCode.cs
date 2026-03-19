using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum ErrorCode : uint
		{
			NoError = 0,
			InvalidEnum = 0x0500,
			InvalidValue = 0x0501,
			InvalidOperation = 0x0502,
			OutOfMemory = 0x0505,
			InvalidFramebufferOperation = 0x0506,
			TableTooLarge = 0x8031,
			InvalidFramebufferOperationExt = 0x0506,
			TableTooLargeExt = 0x8031,
			TextureTooLargeExt = 0x8065,
			StackOverflow = 0x0503,
			StackUnderflow = 0x0504,
			InvalidFramebufferOperationOes = 0x0506,
		}
	}
}
