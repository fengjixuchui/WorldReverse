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
	public class MiHoYoSDKWebViewCloud // TypeDefIndex: 8923
	{
		// Fields
		private static System.Type MiHoYoSDKWebCloud; // 0x00
		private static object[] parameters2; // 0x08
	
		// Nested types
		[Serializable]
		public class WebResponseData // TypeDefIndex: 8924
		{
			// Fields
			public string name; // 0x10
			public string data; // 0x18
	
			// Constructors
			public WebResponseData() {} // 0x0000000185A91DB0-0x0000000185A91E10
		}
	
		// Constructors
		public MiHoYoSDKWebViewCloud() {} // 0x0000000185A7C2F0-0x0000000185A7C350
		static MiHoYoSDKWebViewCloud() {} // 0x0000000185A7C220-0x0000000185A7C2F0
	
		// Methods
		// [XID] // 0x00000001897978A0-0x00000001897978C0
		public static void Init(string name) {} // 0x0000000185A7AA30-0x0000000185A7ABA0
		// [XID] // 0x000000018994C2A0-0x000000018994C2C0
		public static void Load(string name, string url) {} // 0x0000000185A7ABA0-0x0000000185A7AD50
		// [XID] // 0x00000001897A6C80-0x00000001897A6CA0
		public static void Show(string name) {} // 0x0000000185A7C0B0-0x0000000185A7C220
		// [XID] // 0x00000001897AE4F0-0x00000001897AE510
		public static void Hide(string name) {} // 0x0000000185A7A8C0-0x0000000185A7AA30
		// [XID] // 0x00000001897B6590-0x00000001897B65B0
		public static void Close(string name) {} // 0x0000000185A79ED0-0x0000000185A7A040
		// [XID] // 0x00000001897BE2C0-0x00000001897BE2E0
		public static void SetZoomEnabled(string name, bool enabled) {} // 0x0000000185A7BE50-0x0000000185A7C000
		// [XID] // 0x00000001898EB280-0x00000001898EB2A0
		public static void SetBouncesEnabled(string name, bool enabled) {} // 0x0000000185A7B670-0x0000000185A7B820
		// [XID] // 0x00000001897CD110-0x00000001897CD130
		public static void HideNavigationBar(string name, bool enabled) {} // 0x0000000185A7A710-0x0000000185A7A8C0
		// [XID] // 0x0000000189825710-0x0000000189825730
		public static void SetFrame(string name, int x, int y, int width, int height) {} // 0x0000000185A7B820-0x0000000185A7BA80
		// [XID] // 0x00000001897DBE00-0x00000001897DBE20
		public static string GetUserAgent(string name) => default; // 0x0000000185A7A400-0x0000000185A7A710
		// [XID] // 0x00000001897E37D0-0x00000001897E37F0
		public static void SetUserAgent(string name, string content = "" /* Metadata: 0x00AE4E4D */) {} // 0x0000000185A7BCA0-0x0000000185A7BE50
		// [XID] // 0x0000000189988A40-0x0000000189988A60
		public static string GetGlobalUserAgent() => default; // 0x0000000185A7A040-0x0000000185A7A2C0
		// [XID] // 0x00000001897F2C90-0x00000001897F2CB0
		public static void SetGlobalUserAgent(string content = "" /* Metadata: 0x00AE4E51 */) {} // 0x0000000185A7BA80-0x0000000185A7BBF0
		// [XID] // 0x000000018990B1F0-0x000000018990B210
		public static void SetBackButtonEnabled(string name, bool enabled) {} // 0x0000000185A7B4C0-0x0000000185A7B670
		// [XID] // 0x0000000189B99BA0-0x0000000189B99BC0
		public static void SetNewWindowType(string name, int type) {} // 0x0000000185A7BBF0-0x0000000185A7BCA0
		// [XID] // 0x0000000189808FD0-0x0000000189808FF0
		public static void CallFacebookLogin(string name) {} // 0x0000000185A79D00-0x0000000185A79DA0
		// [XID] // 0x0000000189912DE0-0x0000000189912E00
		public static void PreLoad(string env, string gameBiz) {} // 0x0000000185A7B220-0x0000000185A7B3D0
		// [XID] // 0x00000001897F1E50-0x00000001897F1E70
		public static void ShowDevTools(string name, bool isShow) {} // 0x0000000185A7C000-0x0000000185A7C0B0
		// [XID] // 0x0000000189990240-0x0000000189990260
		public static void ClearCookies(string name) {} // 0x0000000185A79E30-0x0000000185A79ED0
		// [XID] // 0x0000000189997D10-0x0000000189997D30
		private static void CheckPlatform() {} // 0x0000000185A79DA0-0x0000000185A79E30
		// [XID] // 0x000000018982E4D0-0x000000018982E4F0
		private static void SendCloudWebData(string f, string p, int i = -1 /* Metadata: 0x00AE4E55 */) {} // 0x0000000185A7B3D0-0x0000000185A7B4C0
		// [XID] // 0x0000000189835D10-0x0000000189835D30
		private static bool GetMiHoYoSDKWebView(string name, out MiHoYoSDKWebView web) {
			web = default;
			return default;
		} // 0x0000000185A7A2C0-0x0000000185A7A400
		// [XID] // 0x000000018983D270-0x000000018983D290
		public static void OnGetWebEvent(string f, string p) {} // 0x0000000185A7AD50-0x0000000185A7B220
		// [XID] // 0x0000000189844B70-0x0000000189844B90
		public static void on_get_uni_webview_message(string name, string data) {} // 0x0000000185A7C350-0x0000000185A7C450
		// [XID] // 0x00000001895E8F30-0x00000001895E8F50
		public static void on_get_webview_page_finish(string name, string data) {} // 0x0000000185A7C650-0x0000000185A7C750
		// [XID] // 0x0000000189852D70-0x0000000189852D90
		public static void on_get_webview_page_error(string name, string data) {} // 0x0000000185A7C550-0x0000000185A7C650
		// [XID] // 0x000000018985A9F0-0x000000018985AA10
		public static void on_get_webview_page_close(string name, string data) {} // 0x0000000185A7C450-0x0000000185A7C550
	}
}
