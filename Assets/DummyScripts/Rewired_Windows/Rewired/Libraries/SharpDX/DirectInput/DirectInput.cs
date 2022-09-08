/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Rewired.Utils.Attributes;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

namespace Rewired.Libraries.SharpDX.DirectInput
{
	// [Guid] // 0x00000001897EE350-0x00000001897EE380
	internal class DirectInput : gZHsmLYRWYRWOYtXCrCKGLdQONK // TypeDefIndex: 5703
	{
		// Nested types
		private static class GetDeviceCountHelper // TypeDefIndex: 5704
		{
			// Fields
			private static DirectInputEnumDevicesDelegate _callback; // 0x00
			private static IntPtr _callbackPointer; // 0x08
			private static int _count; // 0x10
	
			// Properties
			public static IntPtr callbackPointer { get; } // 0x0000000183E84720-0x0000000183E847B0 
	
			// Nested types
			// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
			private unsafe delegate int DirectInputEnumDevicesDelegate(void* deviceInstance, IntPtr data); // TypeDefIndex: 5705; 0x0000000183E80F30-0x0000000183E810F0
	
			// Constructors
			static GetDeviceCountHelper() {} // 0x0000000183E84600-0x0000000183E84720
	
			// Methods
			public static int GetCountAndClear() => default; // 0x0000000183E84570-0x0000000183E84600
			public static void Clear() {} // 0x0000000183E84450-0x0000000183E844E0
			// [MonoPInvokeCallback] // 0x0000000189805FB0-0x0000000189806000
			private static unsafe int DirectInputEnumDevicesImpl(void* deviceInstance, IntPtr data) => default; // 0x0000000183E844E0-0x0000000183E84570
		}
	
		// Constructors
		public DirectInput() {} // 0x0000000183E84020-0x0000000183E84170
	
		// Methods
		public IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> GetDevices() => default; // 0x0000000183E83E10-0x0000000183E83E80
		public IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> GetDevices(FTxufsFYYZLjZuOhPwjajrbMvoj deviceClass, jQHcAazllAfioxyWFvAxWLMcwIf deviceEnumFlags) => default; // 0x0000000183E83E80-0x0000000183E84020
		public int GetDeviceCount(FTxufsFYYZLjZuOhPwjajrbMvoj deviceClass, jQHcAazllAfioxyWFvAxWLMcwIf deviceEnumFlags) => default; // 0x0000000183E83D30-0x0000000183E83E10
		[SuppressUnmanagedCodeSecurity] // 0x00000001896C9E80-0x00000001896C9E90
		private static unsafe extern int CreateDevice_(void* pIDirectInput8, void* rguid, void* lplpDirectInputDevice, void* pUnkOuter); // 0x0000000183E83850-0x0000000183E83960
		[SuppressUnmanagedCodeSecurity] // 0x00000001896C9E80-0x00000001896C9E90
		private static unsafe extern int EnumDevices_(void* pIDirectInput8, int dwDevType, void* lpCallback, void* pvRef, int dwFlags); // 0x0000000183E83AA0-0x0000000183E83BC0
		internal void CreateDevice(Guid arg0, out IntPtr arg1, gZHsmLYRWYRWOYtXCrCKGLdQONK arg2) {
			arg1 = default;
		} // 0x0000000183E83960-0x0000000183E83AA0
		internal void EnumDevices(int arg0, OtePkBPourhUvkDWmfXOEFfIPPx arg1, IntPtr arg2, jQHcAazllAfioxyWFvAxWLMcwIf arg3) {} // 0x0000000183E83BC0-0x0000000183E83D30
	}
}
