/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKUserCenterManager : MiHoYoSDKBaseClass // TypeDefIndex: 8782
	{
		// Fields
		private MiHoYoSDKWebView webView; // 0x10
		private static MiHoYoSDKUserCenterManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKUserCenterManager() {} // 0x000000018596F7A0-0x000000018596F800
	
		// Methods
		// [XID] // 0x000000018988B760-0x000000018988B780
		public static MiHoYoSDKUserCenterManager Instance() => default; // 0x000000018596E200-0x000000018596E2E0
		// [XID] // 0x000000018985F030-0x000000018985F050
		public bool CanOpenUserCenter() => default; // 0x000000018596E020-0x000000018596E100
		// [XID] // 0x00000001898A1750-0x00000001898A1770
		public void Open() {} // 0x000000018596EA70-0x000000018596F7A0
		// [XID] // 0x0000000189848B60-0x0000000189848B80
		public void Close() {} // 0x000000018596E100-0x000000018596E200
		// [XID] // 0x0000000189850480-0x00000001898504A0
		private void OnGetPageClose(MiHoYoSDKWebView webView) {} // 0x000000018596E2E0-0x000000018596E440
		// [XID] // 0x00000001897C9260-0x00000001897C9280
		private void OnGetUniWebViewMessage(MiHoYoSDKWebView webView, MiHoYoSDKUniWebViewMessage message) {} // 0x000000018596E440-0x000000018596E9A0
		// [XID] // 0x00000001899FB250-0x00000001899FB270
		private void OnLogout(string response) {} // 0x000000018596E9A0-0x000000018596EA70
	}
}
