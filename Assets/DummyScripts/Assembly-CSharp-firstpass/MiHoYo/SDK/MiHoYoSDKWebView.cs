/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKWebView : MonoBehaviour // TypeDefIndex: 8928
	{
		// Fields
		private string id; // 0x18
		public string webViewName; // 0x20
		public bool isHide; // 0x28
	
		// Events
		public event OnUniWebViewMessageDelegate OnUniWebViewMessage;
		public event OnWebViewPageFinish OnPageFinish;
		public event OnWebViewPageError OnPageError;
		public event OnWebViewPageClose OnPageClose;
	
		// Nested types
		public delegate void OnUniWebViewMessageDelegate(MiHoYoSDKWebView webView, MiHoYoSDKUniWebViewMessage message); // TypeDefIndex: 8929; 0x0000000185A85300-0x0000000185A856C0
	
		public delegate void OnWebViewPageFinish(MiHoYoSDKWebView webView, string url); // TypeDefIndex: 8930; 0x0000000185A86140-0x0000000185A863F0
	
		public delegate void OnWebViewPageError(MiHoYoSDKWebView webView, string url, int errorCode, string errorMessage); // TypeDefIndex: 8931; 0x0000000185A85C60-0x0000000185A85FC0
	
		public delegate void OnWebViewPageClose(MiHoYoSDKWebView webView); // TypeDefIndex: 8932; 0x0000000185A85850-0x0000000185A85AB0
	
		// Constructors
		public MiHoYoSDKWebView() {} // 0x0000000185A843D0-0x0000000185A84440
	
		// Methods
		// [XID] // 0x0000000189BDD190-0x0000000189BDD1B0
		public static MiHoYoSDKWebView Init() => default; // 0x0000000185A833A0-0x0000000185A834F0
		// [XID] // 0x0000000189955440-0x0000000189955460
		public static void PreLoad(string env, string gameBiz) {} // 0x0000000185A83BD0-0x0000000185A83C90
		// [XID] // 0x0000000189999430-0x0000000189999450
		public void Load(string url) {} // 0x0000000185A834F0-0x0000000185A835B0
		// [XID] // 0x00000001897EBD80-0x00000001897EBDA0
		public void Show() {} // 0x0000000185A84320-0x0000000185A843D0
		// [XID] // 0x00000001899A8680-0x00000001899A86A0
		public void Hide() {} // 0x0000000185A832F0-0x0000000185A833A0
		// [XID] // 0x00000001899AFEB0-0x00000001899AFED0
		public void Close() {} // 0x0000000185A83040-0x0000000185A830E0
		// [XID] // 0x0000000189929F20-0x0000000189929F40
		public void SetZoomEnabled(bool enabled) {} // 0x0000000185A841A0-0x0000000185A84260
		// [XID] // 0x0000000189962E30-0x0000000189962E50
		public void SetBouncesEnabled(bool enabled) {} // 0x0000000185A83D50-0x0000000185A83E10
		// [XID] // 0x000000018996A130-0x000000018996A150
		public void HideNavigationBar(bool enabled) {} // 0x0000000185A83230-0x0000000185A832F0
		// [XID] // 0x00000001899CDCF0-0x00000001899CDD10
		public void SetBackButtonEnabled(bool enabled) {} // 0x0000000185A83C90-0x0000000185A83D50
		// [XID] // 0x0000000189979800-0x0000000189979820
		public void SetFrame(int x, int y, int width, int height) {} // 0x0000000185A83E10-0x0000000185A83F10
		// [XID] // 0x00000001899F3140-0x00000001899F3160
		public string GetUserAgent() => default; // 0x0000000185A83180-0x0000000185A83230
		// [XID] // 0x00000001899FA7D0-0x00000001899FA7F0
		public void SetUserAgent(string content = "" /* Metadata: 0x00AE4E61 */) {} // 0x0000000185A840B0-0x0000000185A841A0
		// [XID] // 0x0000000189A6A460-0x0000000189A6A480
		public static string GetGlobalUserAgent() => default; // 0x0000000185A830E0-0x0000000185A83180
		// [XID] // 0x0000000189A71890-0x0000000189A718B0
		public static void SetGlobalUserAgent(string content = "" /* Metadata: 0x00AE4E65 */) {} // 0x0000000185A83F10-0x0000000185A83FF0
		// [XID] // 0x00000001899FAA70-0x00000001899FAA90
		public void SetNewWindowType(int type) {} // 0x0000000185A83FF0-0x0000000185A840B0
		// [XID] // 0x0000000189A01C00-0x0000000189A01C20
		public void ShowDevTools(bool isShow) {} // 0x0000000185A84260-0x0000000185A84320
		// [XID] // 0x00000001899201D0-0x00000001899201F0
		public void CallFacebookLogin() {} // 0x0000000185A82F00-0x0000000185A82FA0
		// [XID] // 0x000000018963C260-0x000000018963C280
		public void ClearCookies() {} // 0x0000000185A82FA0-0x0000000185A83040
		// [XID] // 0x00000001897DDFF0-0x00000001897DE010
		public void OnGetUniWebViewMessage(string result) {} // 0x0000000185A83650-0x0000000185A837D0
		// [XID] // 0x0000000189A1F7F0-0x0000000189A1F810
		public void OnGetWebViewPageFinish(string url) {} // 0x0000000185A83AA0-0x0000000185A83BD0
		// [XID] // 0x000000018989F940-0x000000018989F960
		public void OnGetWebViewPageClose(string message) {} // 0x0000000185A837D0-0x0000000185A83930
		// [XID] // 0x0000000189A2E310-0x0000000189A2E330
		public void OnGetWebViewPageError(string message) {} // 0x0000000185A83930-0x0000000185A83AA0
		// [XID] // 0x0000000189A809C0-0x0000000189A809E0
		private void OnDestroy() {} // 0x0000000185A835B0-0x0000000185A83650
	}
}
