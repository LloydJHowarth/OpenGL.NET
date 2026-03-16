using System;

namespace Engine.OpenGL
{
	public static unsafe partial class GL
	{
		public enum ExternalHandleType : uint
		{
			HandleTypeOpaqueFdExt = 0x9586,
			HandleTypeOpaqueWin32Ext = 0x9587,
			HandleTypeOpaqueWin32KmtExt = 0x9588,
			HandleTypeD3d12TilepoolExt = 0x9589,
			HandleTypeD3d12ResourceExt = 0x958A,
			HandleTypeD3d11ImageExt = 0x958B,
			HandleTypeD3d11ImageKmtExt = 0x958C,
			HandleTypeD3d12FenceExt = 0x9594,
		}
	}
}
