/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AOT;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKBiliBiliInterface // TypeDefIndex: 8701
	{
		// Fields
		private static IntPtr ptrWnd; // 0x00
	
		// Nested types
		public delegate void LoginCallback(string buf, int buflen); // TypeDefIndex: 8702; 0x00000001859E0D80-0x00000001859E1030
	
		public delegate void PayCallback(string buf, int buflen); // TypeDefIndex: 8703; 0x00000001859F3220-0x00000001859F34D0
	
		public delegate void AntiAddictionCallback(string buf, int buflen); // TypeDefIndex: 8704; 0x00000001859D5A80-0x00000001859D5D30
	
		public delegate bool WNDENUMPROC(IntPtr hwnd, uint lParam); // TypeDefIndex: 8705; 0x00000001859F6380-0x00000001859F6540
	
		// Constructors
		public MiHoYoSDKBiliBiliInterface() {} // 0x00000001859EDD10-0x00000001859EDD70
		static MiHoYoSDKBiliBiliInterface() {} // 0x00000001859EDCB0-0x00000001859EDD10
	
		// Methods
		public static extern int SDKInit(string gameID, IntPtr hwndParent); // 0x00000001859ED500-0x00000001859ED610
		public static extern int SDKShowLoginPanel(string appKey, bool backToLogin, LoginCallback callBack); // 0x00000001859ED810-0x00000001859ED930
		public static extern int SDKShowPayPanel(string info, PayCallback callBack); // 0x00000001859ED930-0x00000001859EDA50
		public static extern int SDKOpenAntiAddiction(string info, AntiAddictionCallback callBack); // 0x00000001859ED6F0-0x00000001859ED810
		public static extern int SDKLogout(); // 0x00000001859ED610-0x00000001859ED6F0
		public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, uint lParam); // 0x00000001859ECFB0-0x00000001859ED0C0
		public static extern IntPtr GetParent(IntPtr hWnd); // 0x00000001859ED0C0-0x00000001859ED1B0
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint lpdwProcessId); // 0x00000001859ED400-0x00000001859ED500
		public static extern void SetLastError(uint dwErrCode); // 0x00000001859EDA50-0x00000001859EDB30
		// [XID] // 0x0000000189A7E980-0x0000000189A7E9A0
		public static IntPtr GetProcessWnd() => default; // 0x00000001859ED1B0-0x00000001859ED400
		// [MonoPInvokeCallback] // 0x0000000189AFF650-0x0000000189AFF6B0
		// [XID] // 0x0000000189AFF650-0x0000000189AFF6B0
		private static bool WindowProccess(IntPtr hwnd, uint lParam) => default; // 0x00000001859EDB30-0x00000001859EDCB0
	}
}
