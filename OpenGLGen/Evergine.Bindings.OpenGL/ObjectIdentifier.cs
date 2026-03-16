using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ObjectIdentifier : uint
		{
			Sampler = 0x82E6,
			Buffer = 0x82E0,
			Shader = 0x82E1,
			Program = 0x82E2,
			Query = 0x82E3,
			ProgramPipeline = 0x82E4,
		}
	}
}
