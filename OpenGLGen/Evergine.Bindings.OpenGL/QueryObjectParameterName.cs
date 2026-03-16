using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
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
