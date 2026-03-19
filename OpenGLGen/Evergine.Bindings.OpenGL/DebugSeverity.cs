using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum DebugSeverity : uint
		{
			DebugSeverityNotification = 0x826B,
			DebugSeverityHigh = 0x9146,
			DebugSeverityMedium = 0x9147,
			DebugSeverityLow = 0x9148,
		}
	}
}
