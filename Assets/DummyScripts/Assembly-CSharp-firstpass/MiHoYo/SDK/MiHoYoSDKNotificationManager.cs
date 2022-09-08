/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKNotificationManager // TypeDefIndex: 8687
	{
		// Fields
		private static MiHoYoSDKNotificationManager _instance; // 0x00
	
		// Properties
		public static MiHoYoSDKNotificationManager Instance { /* [XID] */ /* 0x000000018971D3F0-0x000000018971D410 */ get => default; } // 0x0000000185F42990-0x0000000185F42A70 
	
		// Constructors
		public MiHoYoSDKNotificationManager() {} // 0x0000000185F42930-0x0000000185F42990
	
		// Methods
		// [XID] // 0x0000000189724820-0x0000000189724840
		public void SendNotification(string message) {} // 0x0000000185F42360-0x0000000185F42480
		// [XID] // 0x000000018972BF90-0x000000018972BFB0
		public void ShowSDKDialog(string dialogName) {} // 0x0000000185F42830-0x0000000185F42930
		// [XID] // 0x00000001899FDFB0-0x00000001899FDFD0
		public void HideSDKDialog(string dialogName) {} // 0x0000000185F41EC0-0x0000000185F41FC0
		// [XID] // 0x0000000189850690-0x00000001898506B0
		public void SendUniWebView(string url) {} // 0x0000000185F42580-0x0000000185F42680
		// [XID] // 0x0000000189742560-0x0000000189742580
		public void ShowPopNotice() {} // 0x0000000185F42770-0x0000000185F42830
		// [XID] // 0x000000018974A250-0x000000018974A270
		public void ShowNoticeRedPoint(bool isShow) {} // 0x0000000185F42680-0x0000000185F42770
		// [XID] // 0x00000001897515C0-0x00000001897515E0
		public void SendBindMobileAccount(string open_id) {} // 0x0000000185F421A0-0x0000000185F422A0
		// [XID] // 0x00000001897589D0-0x00000001897589F0
		public void SendRealNameAccount(string open_id) {} // 0x0000000185F42480-0x0000000185F42580
		// [XID] // 0x0000000189644240-0x0000000189644260
		public void SendLogout() {} // 0x0000000185F422A0-0x0000000185F42360
		// [XID] // 0x000000018970A580-0x000000018970A5A0
		public void SendBindAccount() {} // 0x0000000185F420E0-0x0000000185F421A0
		// [XID] // 0x000000018976F100-0x000000018976F120
		public void SendAntiAddiction(JSONNode msg) {} // 0x0000000185F41FC0-0x0000000185F420E0
		// [XID] // 0x0000000189776C00-0x0000000189776C20
		public string CreateNotification(string eventName, string param) => default; // 0x0000000185F41D50-0x0000000185F41EC0
	}
}
