/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct RenderModel_t_Packed // TypeDefIndex: 6592
	{
		// Fields
		public IntPtr rVertexData; // 0x00
		public uint unVertexCount; // 0x08
		public IntPtr rIndexData; // 0x0C
		public uint unTriangleCount; // 0x14
		public int diffuseTextureId; // 0x18
	
		// Constructors
		public RenderModel_t_Packed(RenderModel_t unpacked) {
			rVertexData = default;
			unVertexCount = default;
			rIndexData = default;
			unTriangleCount = default;
			diffuseTextureId = default;
		} // 0x0000000188323D90-0x0000000188323ED0
	
		// Methods
		public void Unpack(ref RenderModel_t unpacked) {} // 0x0000000188323D80-0x0000000188323D90
	}
}
