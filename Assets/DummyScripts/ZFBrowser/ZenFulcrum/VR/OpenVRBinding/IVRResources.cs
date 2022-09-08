/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRResources // TypeDefIndex: 6452
	{
		// Fields
		internal _LoadSharedResource LoadSharedResource; // 0x00
		internal _GetResourceFullPath GetResourceFullPath; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen); // TypeDefIndex: 6453; 0x0000000188333870-0x0000000188333B60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, string pchPathBuffer, uint unBufferLen); // TypeDefIndex: 6454; 0x000000018832D6A0-0x000000018832D9F0
	}
}
