/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MiHoYo.SDK;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class WebViewGeneralLogic // TypeDefIndex: 20643
{
	// Fields
	private static string CLOUD_GAME_URL_PARA; // 0x00

	// Constructors
	static WebViewGeneralLogic() {} // 0x0000000184914420-0x0000000184914490

	// Methods
	// [XID] // 0x00000001897251A0-0x00000001897251C0
	public static void LoadUrl(string url, bool transparent = false /* Metadata: 0x00AFDF5D */, bool toolBar = false /* Metadata: 0x00AFDF5E */) {} // 0x0000000184913B80-0x0000000184914030
	// [XID] // 0x000000018972C880-0x000000018972C8A0
	private static void OnPageInTransReceivedMessage(MiHoYoSDKWebView webView, MiHoYoSDKUniWebViewMessage message) {} // 0x0000000184913290-0x0000000184913B80
	// [XID] // 0x0000000189733F90-0x0000000189733FB0
	private static void OnGetWebViewPageError(MiHoYoSDKWebView webView, string url, int errorCode, string errorMessage) {} // 0x00000001849140C0-0x00000001849141F0
	// [XID] // 0x000000018973B730-0x000000018973B750
	private static void OnGetWebViewPageFinish(MiHoYoSDKWebView webView, string url) {} // 0x00000001849141F0-0x00000001849142A0
	// [XID] // 0x00000001897431E0-0x0000000189743200
	private static void OnGetWebViewPageClose(MiHoYoSDKWebView webView) {} // 0x0000000184913000-0x00000001849130E0
	// [XID] // 0x000000018974AD60-0x000000018974AD80
	private static void GameGoTo(string msg) {} // 0x0000000184914380-0x0000000184914420
	// [XID] // 0x0000000189751E10-0x0000000189751E30
	private static string ProcessUrlUnderCloudGame(string url) => default; // 0x00000001849130E0-0x0000000184913290
}

