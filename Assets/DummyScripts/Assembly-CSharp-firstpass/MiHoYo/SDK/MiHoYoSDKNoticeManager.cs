/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKNoticeManager : MiHoYoSDKBaseClass // TypeDefIndex: 8683
	{
		// Fields
		private const string BrowserPath = "UI/NoticeWebViewCanvas.Prefab"; // Metadata: 0x00AE1F84
		private GameObject canvas; // 0x10
		private GameObject content; // 0x18
		public Browser browser; // 0x20
		private Button closeButton; // 0x28
		private CanvasGroup canvasGroup; // 0x30
		private string currentUrl; // 0x38
		private string loadingUrl; // 0x40
		private bool isLoadingFinish; // 0x48
		private Coroutine coroutine; // 0x50
		private static bool isShowPopNotice; // 0x00
		private List<string> requestList; // 0x58
		private bool isNoticeShow; // 0x60
		private bool isOpenNotice; // 0x61
		private static MiHoYoSDKNoticeManager _instance; // 0x08
	
		// Nested types
		private enum NoticeStatus // TypeDefIndex: 8684
		{
			INIT = 0,
			QUICK_LOAD = 1,
			INDICATOR_LOAD = 2,
			TIMEOUT_LOAD = 3
		}
	
		[Serializable]
		public class WebEventModel // TypeDefIndex: 8685
		{
			// Fields
			public string game; // 0x10
			public string type; // 0x18
			public long time; // 0x20
			public WebEventDataModel data; // 0x28
	
			// Constructors
			public WebEventModel() {} // 0x0000000185F58E10-0x0000000185F58E80
		}
	
		[Serializable]
		public class WebEventDataModel // TypeDefIndex: 8686
		{
			// Fields
			public int num; // 0x10
			public int type; // 0x14
			public int exchange; // 0x18
	
			// Constructors
			public WebEventDataModel() {} // 0x0000000185F58DB0-0x0000000185F58E10
		}
	
		// Constructors
		public MiHoYoSDKNoticeManager() {} // 0x0000000185F41CA0-0x0000000185F41D50
		static MiHoYoSDKNoticeManager() {} // 0x0000000185F41C40-0x0000000185F41CA0
	
		// Methods
		// [XID] // 0x0000000189654190-0x00000001896541B0
		public static MiHoYoSDKNoticeManager Instance() => default; // 0x0000000185F3F9C0-0x0000000185F3FB30
		// [XID] // 0x000000018965BC50-0x000000018965BC70
		public static bool IsExist() => default; // 0x0000000185F3FB30-0x0000000185F3FCF0
		// [XID] // 0x0000000189662F40-0x0000000189662F60
		private void Init() {} // 0x0000000185F3F4C0-0x0000000185F3F9C0
		// [XID] // 0x0000000189A2A360-0x0000000189A2A380
		public void Hide() {} // 0x0000000185F3F0F0-0x0000000185F3F4C0
		// [XID] // 0x0000000189672780-0x00000001896727A0
		public void Show() {} // 0x0000000185F417D0-0x0000000185F41B50
		// [XID] // 0x00000001896C3F40-0x00000001896C3F60
		private void RequestWebURL() {} // 0x0000000185F410A0-0x0000000185F412F0
		// [XID] // 0x0000000189681720-0x0000000189681740
		public static void ClearRequestList() {} // 0x0000000185F3DBD0-0x0000000185F3DD50
		// [XID] // 0x0000000189689160-0x0000000189689180
		private void OnClickEscape() {} // 0x0000000185F40100-0x0000000185F401D0
		// [XID] // 0x00000001899D2B90-0x00000001899D2BB0
		private void OnUpdate() {} // 0x0000000185F40D40-0x0000000185F40F50
		// [XID] // 0x00000001896985F0-0x0000000189698610
		private string GetURLString(string url) => default; // 0x0000000185F3E650-0x0000000185F3F0F0
		// [XID] // 0x000000018969F9F0-0x000000018969FA10
		public void PreLoad(bool isOpen = false /* Metadata: 0x00AE1F83 */) {} // 0x0000000185F40F50-0x0000000185F410A0
		// [XID] // 0x00000001896A6B70-0x00000001896A6B90
		public void LoadUrl(string url) {} // 0x0000000185F3FCF0-0x0000000185F3FEF0
		// [XID] // 0x00000001896AE250-0x00000001896AE270
		public void CheckPopNotice() {} // 0x0000000185F3D9A0-0x0000000185F3DBD0
		// [XID] // 0x00000001896B5940-0x00000001896B5960
		public void ShowNotice() {} // 0x0000000185F415B0-0x0000000185F41670
		// [XID] // 0x00000001896BCBE0-0x00000001896BCC00
		public string ShowPopNotice() => default; // 0x0000000185F41670-0x0000000185F417D0
		// [XID] // 0x0000000189697470-0x0000000189697490
		private void ShowNoticeLoading() {} // 0x0000000185F41440-0x0000000185F415B0
		// [XID] // 0x00000001896CB5A0-0x00000001896CB5C0
		private void ShowLoadError() {} // 0x0000000185F412F0-0x0000000185F41440
		// [XID] // 0x00000001896D2B50-0x00000001896D2B70
		private void StopCoroutine() {} // 0x0000000185F41B50-0x0000000185F41C40
		// [XID] // 0x00000001896DA550-0x00000001896DA570
		private void OnLoad(JSONNode result) {} // 0x0000000185F40710-0x0000000185F408A0
		// [XID] // 0x00000001896FF550-0x00000001896FF570
		private void OnUniWebViewMsgReceive(JSONNode obj) {} // 0x0000000185F408A0-0x0000000185F40D40
		// [XID] // 0x00000001896E92C0-0x00000001896E92E0
		public void OnCloseClicked() {} // 0x0000000185F401D0-0x0000000185F40270
		// [XID] // 0x00000001896F0400-0x00000001896F0420
		private void OnCertError(JSONNode response) {} // 0x0000000185F3FFE0-0x0000000185F40100
		// [XID] // 0x00000001896F7D90-0x00000001896F7DB0
		private void OnFetchError(JSONNode response) {} // 0x0000000185F40270-0x0000000185F40390
		// [XID] // 0x00000001897BE100-0x00000001897BE120
		private void OnBrowserDestroy(Browser destroyBrowser) {} // 0x0000000185F3FEF0-0x0000000185F3FFE0
		// [XID] // 0x0000000189706AC0-0x0000000189706AE0
		private void OnGetCheckPopNotice(string responseString) {} // 0x0000000185F40390-0x0000000185F40710
		// [XID] // 0x000000018970E470-0x000000018970E490
		public void Close() {} // 0x0000000185F3DD50-0x0000000185F3E0A0
		// [XID] // 0x0000000189BD91D0-0x0000000189BD91F0
		private void EnableJoypadControl(bool enabled) {} // 0x0000000185F3E0A0-0x0000000185F3E650
	}
}
