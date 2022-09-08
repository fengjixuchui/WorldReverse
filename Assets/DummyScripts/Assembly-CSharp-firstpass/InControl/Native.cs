/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	internal static class Native // TypeDefIndex: 7811
	{
		// Fields
		private const string LibraryName = "InControlNative"; // Metadata: 0x00ADF238
	
		// Methods
		public static extern void Init(NativeInputOptions options); // 0x0000000188873530-0x0000000188873630
		public static extern void Stop(); // 0x0000000188873940-0x0000000188873B40
		public static extern void GetVersionInfo(out NativeVersionInfo versionInfo); // 0x0000000188873430-0x0000000188873530
		public static extern bool GetDeviceInfo(uint handle, out NativeDeviceInfo deviceInfo); // 0x0000000188873150-0x0000000188873320
		public static extern bool GetDeviceState(uint handle, out IntPtr deviceState); // 0x0000000188873320-0x0000000188873430
		public static extern int GetDeviceEvents(out IntPtr deviceEvents); // 0x0000000188873040-0x0000000188873150
		public static extern void SetHapticState(uint handle, byte motor0, byte motor1); // 0x0000000188873630-0x0000000188873730
		public static extern void SetLightColor(uint handle, byte red, byte green, byte blue); // 0x0000000188873730-0x0000000188873840
		public static extern void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration); // 0x0000000188873840-0x0000000188873940
	}
}
