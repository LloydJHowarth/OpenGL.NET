using System;

namespace ENGINE.OPENGL
{
	public static unsafe partial class OpenGL
	{
		public enum QueryObjectParameterName : uint
		{
			QueryResult = 0x8866,
			QueryResultAvailable = 0x8867,
			QueryTarget = 0x82EA,
			QueryResultNoWait = 0x9194,
		}
	}
}
