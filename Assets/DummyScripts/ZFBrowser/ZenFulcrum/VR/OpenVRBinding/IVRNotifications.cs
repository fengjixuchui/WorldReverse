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
	public struct IVRNotifications // TypeDefIndex: 6428
	{
		// Fields
		internal _CreateNotification CreateNotification; // 0x00
		internal _RemoveNotification RemoveNotification; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId); // TypeDefIndex: 6429; 0x0000000187BF0B00-0x0000000187BF0E20
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId); // TypeDefIndex: 6430; 0x0000000187C04AB0-0x0000000187C04C40
	}
}
