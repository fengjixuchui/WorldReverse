/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class OpenVRInterop // TypeDefIndex: 6482
	{
		// Constructors
		public OpenVRInterop() {} // 0x0000000188322A70-0x0000000188322AD0
	
		// Methods
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType); // 0x00000001883225C0-0x00000001883226C0
		internal static extern void ShutdownInternal(); // 0x0000000188322990-0x0000000188322A70
		internal static extern bool IsHmdPresent(); // 0x00000001883226C0-0x00000001883227A0
		internal static extern bool IsRuntimeInstalled(); // 0x00000001883228B0-0x0000000188322990
		internal static extern IntPtr GetStringForHmdError(EVRInitError error); // 0x00000001883224D0-0x00000001883225C0
		internal static extern IntPtr GetGenericInterface(in string pchInterfaceVersion, ref EVRInitError peError); // 0x00000001883222E0-0x00000001883223F0
		internal static extern bool IsInterfaceVersionValid(in string pchInterfaceVersion); // 0x00000001883227A0-0x00000001883228B0
		internal static extern uint GetInitToken(); // 0x00000001883223F0-0x00000001883224D0
	}
}
