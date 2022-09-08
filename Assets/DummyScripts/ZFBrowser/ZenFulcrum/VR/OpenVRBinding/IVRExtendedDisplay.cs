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
	public struct IVRExtendedDisplay // TypeDefIndex: 6204
	{
		// Fields
		internal _GetWindowBounds GetWindowBounds; // 0x00
		internal _GetEyeOutputViewport GetEyeOutputViewport; // 0x08
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6205; 0x0000000187C00F90-0x0000000187C011D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6206; 0x0000000187BF60E0-0x0000000187BF6370
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex); // TypeDefIndex: 6207; 0x0000000187BF5270-0x0000000187BF5430
	}
}
