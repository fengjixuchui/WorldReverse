/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRNotifications // TypeDefIndex: 6477
	{
		// Fields
		private IVRNotifications FnTable; // 0x10
	
		// Constructors
		public CVRNotifications() {} // Dummy constructor
		internal CVRNotifications(IntPtr pInterface) {} // 0x000000018646B240-0x000000018646B360
	
		// Methods
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId) => default; // 0x000000018646B0E0-0x000000018646B1C0
		public EVRNotificationError RemoveNotification(uint notificationId) => default; // 0x000000018646B1C0-0x000000018646B240
	}
}
