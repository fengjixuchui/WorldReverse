/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	// [RequireComponent] // 0x0000000189816740-0x00000001898167E0
	// [RequireComponent] // 0x0000000189816740-0x00000001898167E0
	// [RequireComponent] // 0x0000000189816740-0x00000001898167E0
	public class MiHoYoSDKBrowser : MonoBehaviour // TypeDefIndex: 8884
	{
		// Fields
		public Action<MiHoYoSDKBrowser, string> OnPageFinished; // 0x18
		public Action<MiHoYoSDKBrowser, string> OnMessageReceived; // 0x20
		public Action<MiHoYoSDKBrowser, int, string> OnPageErrorReceived; // 0x28
		private CanvasGroup _canvasGroup; // 0x30
		private Browser _browser; // 0x38
	
		// Properties
		public float Alpha { /* [XID] */ /* 0x00000001898373F0-0x0000000189837410 */ get => default; /* [XID] */ /* 0x000000018983E9B0-0x000000018983E9D0 */ set {} } // 0x0000000186412F90-0x0000000186413050 0x00000001864131B0-0x0000000186413270
		public bool CanGoBack { /* [XID] */ /* 0x0000000189846000-0x0000000189846020 */ get => default; } // 0x0000000186413050-0x0000000186413100 
		public bool CanGoForward { /* [XID] */ /* 0x00000001896852C0-0x00000001896852E0 */ get => default; } // 0x0000000186413100-0x00000001864131B0 
	
		// Constructors
		public MiHoYoSDKBrowser() {} // 0x0000000186412F30-0x0000000186412F90
	
		// Methods
		// [XID] // 0x0000000189828880-0x00000001898288A0
		private void Awake() {} // 0x0000000186412200-0x00000001864123A0
		// [XID] // 0x0000000189694900-0x0000000189694920
		private void OnDestroy() {} // 0x0000000186412730-0x0000000186412800
		// [XID] // 0x00000001899EC6F0-0x00000001899EC710
		private void InitCanvasGroup() {} // 0x0000000186412500-0x0000000186412650
		// [XID] // 0x000000018985C0E0-0x000000018985C100
		public void SetFullScreen(bool fullScreen, float offset) {} // 0x0000000186412DC0-0x0000000186412F30
		// [XID] // 0x00000001898639B0-0x00000001898639D0
		private void OnFetchError(JSONNode obj) {} // 0x0000000186412800-0x0000000186412A10
		// [XID] // 0x000000018986AC40-0x000000018986AC60
		private void OnLoad(JSONNode obj) {} // 0x0000000186412A10-0x0000000186412BF0
		// [XID] // 0x0000000189872060-0x0000000189872080
		private void OnUniWebViewMsgReceive(JSONNode obj) {} // 0x0000000186412BF0-0x0000000186412D10
		// [XID] // 0x0000000189879820-0x0000000189879840
		public void GoBack() {} // 0x00000001864123A0-0x0000000186412450
		// [XID] // 0x0000000189880E30-0x0000000189880E50
		public void GoForward() {} // 0x0000000186412450-0x0000000186412500
		// [XID] // 0x00000001898881F0-0x0000000189888210
		public void Reload() {} // 0x0000000186412D10-0x0000000186412DC0
		// [XID] // 0x0000000189934080-0x00000001899340A0
		public void LoadURL(string url, bool v) {} // 0x0000000186412650-0x0000000186412730
	}
}
