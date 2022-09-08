/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRDriverManager // TypeDefIndex: 6455
	{
		// Fields
		internal _GetDriverCount GetDriverCount; // 0x00
		internal _GetDriverName GetDriverName; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetDriverCount(); // TypeDefIndex: 6456; 0x0000000187BF5970-0x0000000187BF5AE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6457; 0x0000000187BF5CC0-0x0000000187BF5E90
	}
}
