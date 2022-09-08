/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public class CloudInputMessage : ICloudInput // TypeDefIndex: 6874
	{
		// Fields
		private const int WM_USER = 1024; // Metadata: 0x00ADDF7C
		private const int INPUT_MESSAGE = 1160; // Metadata: 0x00ADDF80
		private static readonly IntPtr _ptrWnd; // 0x00
		private static IntPtr ptrWnd; // 0x08
	
		// Nested types
		private delegate bool WNDENUMPROC(IntPtr hwnd, uint lParam); // TypeDefIndex: 6875; 0x000000018540A760-0x000000018540A920
	
		// Constructors
		static CloudInputMessage() {} // 0x00000001853FAF20-0x00000001853FB100
		public CloudInputMessage() {} // 0x00000001853FB100-0x00000001853FB160
	
		// Methods
		private static extern IntPtr PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam); // 0x00000001853FA8A0-0x00000001853FA9B0
		private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam); // 0x00000001853FA9B0-0x00000001853FAAC0
		private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, uint lParam); // 0x00000001853FA390-0x00000001853FA4A0
		private static extern IntPtr GetParent(IntPtr hWnd); // 0x00000001853FA4A0-0x00000001853FA590
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint lpdwProcessId); // 0x00000001853FA7A0-0x00000001853FA8A0
		private static extern void SetLastError(uint dwErrCode); // 0x00000001853FAAC0-0x00000001853FABA0
		// [XID] // 0x0000000189A32810-0x0000000189A32830
		public void Show(string value, bool password) {} // 0x00000001853FABA0-0x00000001853FAF20
		// [XID] // 0x00000001898E63F0-0x00000001898E6410
		public void Close() {} // 0x00000001853FA170-0x00000001853FA210
		// [XID] // 0x00000001899494F0-0x0000000189949510
		private static IntPtr GetProcessWnd() => default; // 0x00000001853FA590-0x00000001853FA7A0
		[MonoPInvokeCallback] // 0x0000000189ABE800-0x0000000189ABE840
		// [XID] // 0x0000000189ABE800-0x0000000189ABE840
		private static bool EnumWindowsCallback(IntPtr hwnd, uint lParam) => default; // 0x00000001853FA210-0x00000001853FA390
	}
}
