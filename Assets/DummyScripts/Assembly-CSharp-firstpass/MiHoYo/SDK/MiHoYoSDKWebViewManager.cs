/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKWebViewManager : MonoBehaviour, INewWindowHandler // TypeDefIndex: 8935
	{
		// Fields
		private const string WebViewPerfabPath = "UI/MiHoYoWebView.Prefab"; // Metadata: 0x00AE4E71
		private const string CanvasName = "MiHoYoSDKWebView"; // Metadata: 0x00AE4E8C
		private const float TimeOutTime = 5f; // Metadata: 0x00AE4EA0
		private const string PreLoadWebName = "MiHoYoSDKPreLoadWeb"; // Metadata: 0x00AE4EA4
		private const string PreLoadEnable = "MiHoYoSDKPreLoadEnable"; // Metadata: 0x00AE4EBB
		private static Dictionary<string, MiHoYoSDKWebViewManager> webViewDic; // 0x00
		public string id; // 0x18
		private bool isSetFrame; // 0x20
		private string loadingURL; // 0x28
		private Coroutine timeoutCoroutine; // 0x30
		private GameObject content; // 0x38
		private GameObject bg; // 0x40
		private GameObject loadingImage; // 0x48
		private GameObject navBar; // 0x50
		private GameObject browserObject; // 0x58
		private GameObject loadingView; // 0x60
		private Button closeButton; // 0x68
		private Button backButton; // 0x70
		private Button forwardButton; // 0x78
		private Button reloadButton; // 0x80
		private CanvasGroup canvasGroup; // 0x88
		public Browser browser; // 0x90
	
		// Nested types
		[Serializable]
		public class WebEventModel // TypeDefIndex: 8936
		{
			// Fields
			public string game; // 0x10
			public string type; // 0x18
			public long time; // 0x20
	
			// Constructors
			public WebEventModel() {} // 0x0000000185A91D40-0x0000000185A91DB0
		}
	
		// Constructors
		public MiHoYoSDKWebViewManager() {} // 0x0000000185A82EA0-0x0000000185A82F00
		static MiHoYoSDKWebViewManager() {} // 0x0000000185A82E10-0x0000000185A82EA0
	
		// Methods
		// [XID] // 0x00000001899DCEB0-0x00000001899DCED0
		public static MiHoYoSDKWebViewManager GetWebViewManager(string name) => default; // 0x0000000185A7DDD0-0x0000000185A7DED0
		// [XID] // 0x00000001899E0120-0x00000001899E0140
		private static void RemoveWebViewManagerInDictionary(string name) {} // 0x0000000185A817C0-0x0000000185A81900
		// [XID] // 0x00000001895F12A0-0x00000001895F12C0
		public static void Init(string name) {} // 0x0000000185A7ECB0-0x0000000185A7EED0
		// [XID] // 0x00000001899538D0-0x00000001899538F0
		public void Load(string url) {} // 0x0000000185A7F060-0x0000000185A7F280
		// [XID] // 0x0000000189A5B080-0x0000000189A5B0A0
		public void Show() {} // 0x0000000185A82520-0x0000000185A826C0
		// [XID] // 0x000000018994C6D0-0x000000018994C6F0
		public void Hide() {} // 0x0000000185A7E4B0-0x0000000185A7E640
		// [XID] // 0x0000000189A6A660-0x0000000189A6A680
		public void Close() {} // 0x0000000185A7D760-0x0000000185A7D810
		// [XID] // 0x0000000189A71A50-0x0000000189A71A70
		public void SetZoomEnabled(bool enabled) {} // 0x0000000185A82090-0x0000000185A82140
		// [XID] // 0x0000000189A5ED50-0x0000000189A5ED70
		public void SetBouncesEnabled(bool enabled) {} // 0x0000000185A81A60-0x0000000185A81B10
		// [XID] // 0x0000000189B83F00-0x0000000189B83F20
		public void HideNavigationBar(bool enabled) {} // 0x0000000185A7E1A0-0x0000000185A7E4B0
		// [XID] // 0x0000000189A88640-0x0000000189A88660
		public void SetFrame(float x, float y, float width, float height) {} // 0x0000000185A81B10-0x0000000185A81D30
		// [XID] // 0x0000000189A8FF90-0x0000000189A8FFB0
		public string GetUserAgent() => default; // 0x0000000185A7DD20-0x0000000185A7DDD0
		// [XID] // 0x0000000189A977D0-0x0000000189A977F0
		public void SetUserAgent(string content = "" /* Metadata: 0x00AE4E69 */) {} // 0x0000000185A81FE0-0x0000000185A82090
		// [XID] // 0x0000000189A9EAB0-0x0000000189A9EAD0
		public static string GetGlobalUserAgent() => default; // 0x0000000185A7DB40-0x0000000185A7DBE0
		// [XID] // 0x0000000189AA64E0-0x0000000189AA6500
		public static void SetGlobalUserAgent(string content = "" /* Metadata: 0x00AE4E6D */) {} // 0x0000000185A81D30-0x0000000185A81EF0
		// [XID] // 0x00000001899F4EC0-0x00000001899F4EE0
		public void SetNewWindow(Browser.NewWindowAction type) {} // 0x0000000185A81EF0-0x0000000185A81FE0
		// [XID] // 0x0000000189AB52C0-0x0000000189AB52E0
		public Browser CreateBrowser(Browser parent) => default; // 0x0000000185A7D810-0x0000000185A7D920
		// [XID] // 0x0000000189ABCEB0-0x0000000189ABCED0
		public void CallFacebookLogin() {} // 0x0000000185A7C810-0x0000000185A7C9C0
		// [XID] // 0x0000000189AC4850-0x0000000189AC4870
		public static void PreLoad(string env, string gameBiz) {} // 0x0000000185A80720-0x0000000185A80BA0
		// [XID] // 0x00000001898CC7D0-0x00000001898CC7F0
		private static void PreLoadSWURL(RequestUrl requestUrl, string gameBiz, string url) {} // 0x0000000185A7FF30-0x0000000185A80720
		// [XID] // 0x0000000189898760-0x0000000189898780
		public void ShowDevTools(bool isShow) {} // 0x0000000185A82230-0x0000000185A82340
		[DebuggerHidden] // 0x0000000189ADB430-0x0000000189ADB470
		// [XID] // 0x0000000189ADB430-0x0000000189ADB470
		private static IEnumerator RequestSWConfig(string url, JSONObject query, Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185A81900-0x0000000185A81A60
		// [XID] // 0x000000018973D0F0-0x000000018973D110
		private void InitUI() {} // 0x0000000185A7E640-0x0000000185A7ECB0
		// [XID] // 0x0000000189AED5D0-0x0000000189AED5F0
		private void RegisterEvent() {} // 0x0000000185A80BA0-0x0000000185A80EF0
		// [XID] // 0x00000001899D3EA0-0x00000001899D3EC0
		private void UnRegisterEvent() {} // 0x0000000185A829F0-0x0000000185A82D40
		// [XID] // 0x0000000189A00720-0x0000000189A00740
		private void Awake() {} // 0x0000000185A7C750-0x0000000185A7C810
		// [XID] // 0x0000000189B03D70-0x0000000189B03D90
		private void Start() {} // 0x0000000185A82860-0x0000000185A82900
		// [XID] // 0x0000000189B0B480-0x0000000189B0B4A0
		private void Update() {} // 0x0000000185A82D40-0x0000000185A82E10
		// [XID] // 0x0000000189B12C80-0x0000000189B12CA0
		private void OnDestroy() {} // 0x0000000185A7F650-0x0000000185A7F710
		// [XID] // 0x0000000189B1A0D0-0x0000000189B1A0F0
		private void DestroyWeb() {} // 0x0000000185A7D920-0x0000000185A7DA30
		// [XID] // 0x000000018972DEF0-0x000000018972DF10
		private void ClickCloseButton() {} // 0x0000000185A7D390-0x0000000185A7D430
		// [XID] // 0x0000000189B28D50-0x0000000189B28D70
		private void ClickBackButton() {} // 0x0000000185A7D1E0-0x0000000185A7D390
		// [XID] // 0x00000001898CB830-0x00000001898CB850
		private void ClickForwardButton() {} // 0x0000000185A7D430-0x0000000185A7D5E0
		// [XID] // 0x0000000189B37A20-0x0000000189B37A40
		private void ClickReloadButton() {} // 0x0000000185A7D5E0-0x0000000185A7D760
		// [XID] // 0x0000000189B3F3A0-0x0000000189B3F3C0
		private void ShowLoadingView() {} // 0x0000000185A82430-0x0000000185A82520
		// [XID] // 0x0000000189BB19A0-0x0000000189BB19C0
		private void HideLoadingView() {} // 0x0000000185A7E0B0-0x0000000185A7E1A0
		// [XID] // 0x0000000189B4E4F0-0x0000000189B4E510
		private void ShowBGView() {} // 0x0000000185A82140-0x0000000185A82230
		// [XID] // 0x0000000189B55B20-0x0000000189B55B40
		private void HideBGView() {} // 0x0000000185A7DED0-0x0000000185A7DFC0
		// [XID] // 0x0000000189B5D580-0x0000000189B5D5A0
		private void ShowLoadingImage() {} // 0x0000000185A82340-0x0000000185A82430
		// [XID] // 0x0000000189B64D20-0x0000000189B64D40
		private void HideLoadingImage() {} // 0x0000000185A7DFC0-0x0000000185A7E0B0
		// [XID] // 0x0000000189B6C0D0-0x0000000189B6C0F0
		private void StartTimeOutCoroutine() {} // 0x0000000185A826C0-0x0000000185A82860
		// [XID] // 0x000000018975AAA0-0x000000018975AAC0
		private void StopTimeOutCoroutine() {} // 0x0000000185A82900-0x0000000185A829F0
		// [XID] // 0x00000001897651C0-0x00000001897651E0
		private void OnLoadingTimeOut() {} // 0x0000000185A7FC10-0x0000000185A7FCC0
		// [XID] // 0x0000000189B82840-0x0000000189B82860
		private void OnLoad(ZenFulcrum.EmbeddedBrowser.JSONNode result) {} // 0x0000000185A7F980-0x0000000185A7FC10
		// [XID] // 0x0000000189B89F00-0x0000000189B89F20
		private void OnFetchError(ZenFulcrum.EmbeddedBrowser.JSONNode result) {} // 0x0000000185A7F710-0x0000000185A7F980
		// [XID] // 0x0000000189B91570-0x0000000189B91590
		private void OnCertError(ZenFulcrum.EmbeddedBrowser.JSONNode result) {} // 0x0000000185A7F380-0x0000000185A7F580
		// [XID] // 0x00000001899B5CE0-0x00000001899B5D00
		private void OnUniWebviewMsgReceive(ZenFulcrum.EmbeddedBrowser.JSONNode result) {} // 0x0000000185A7FDF0-0x0000000185A7FF30
		// [XID] // 0x0000000189B9FD40-0x0000000189B9FD60
		private void OnClose() {} // 0x0000000185A7F580-0x0000000185A7F650
		// [XID] // 0x00000001899BDA00-0x00000001899BDA20
		private void OnNavStateChange() {} // 0x0000000185A7FCC0-0x0000000185A7FDF0
		// [XID] // 0x0000000189A88480-0x0000000189A884A0
		private bool GetMiHoYoSDKWebView(out MiHoYoSDKWebView web) {
			web = default;
			return default;
		} // 0x0000000185A7DBE0-0x0000000185A7DD20
		// [XID] // 0x0000000189BB5F30-0x0000000189BB5F50
		private bool IsNeedFullScreen(string url) => default; // 0x0000000185A7EED0-0x0000000185A7F060
		// [XID] // 0x00000001899CC7F0-0x00000001899CC810
		private void OnAnyBrowserDestroyed(Browser destroyBrowser) {} // 0x0000000185A7F280-0x0000000185A7F380
		// [XID] // 0x0000000189BC5240-0x0000000189BC5260
		private void CallWebViewWillAppear() {} // 0x0000000185A7CEC0-0x0000000185A7CF70
		// [XID] // 0x00000001896E3D70-0x00000001896E3D90
		private void CallWebViewWillDisappear() {} // 0x0000000185A7CF70-0x0000000185A7D020
		// [XID] // 0x000000018960F390-0x000000018960F3B0
		private void CallWebViewWillDispose() {} // 0x0000000185A7D020-0x0000000185A7D0D0
		// [XID] // 0x0000000189634B60-0x0000000189634B80
		private void CallJSFunction(string typeString) {} // 0x0000000185A7C9C0-0x0000000185A7CEC0
		// [XID] // 0x00000001895E85F0-0x00000001895E8610
		public void RegisterJSFunction() {} // 0x0000000185A80EF0-0x0000000185A817C0
		// [XID] // 0x00000001895EFE10-0x00000001895EFE30
		public void ClearCookies() {} // 0x0000000185A7D0D0-0x0000000185A7D1E0
		// [XID] // 0x00000001895F7730-0x00000001895F7750
		private void DisableInput() {} // 0x0000000185A7DA30-0x0000000185A7DB40
	}
}
