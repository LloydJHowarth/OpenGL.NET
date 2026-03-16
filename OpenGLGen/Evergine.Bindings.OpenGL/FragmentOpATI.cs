using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum FragmentOpATI : uint
		{
			MovAti = 0x8961,
			AddAti = 0x8963,
			MulAti = 0x8964,
			SubAti = 0x8965,
			Dot3Ati = 0x8966,
			Dot4Ati = 0x8967,
			MadAti = 0x8968,
			LerpAti = 0x8969,
			CndAti = 0x896A,
			Cnd0Ati = 0x896B,
			Dot2AddAti = 0x896C,
		}
	}
}
