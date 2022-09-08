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
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKWebManager // TypeDefIndex: 8886
	{
		// Fields
		private const string WebViewPerfabPath = "UI/ZFWebViewCanvas.Prefab"; // Metadata: 0x00AE4880
		private const string CanvasName = "ZFWebViewCanvas"; // Metadata: 0x00AE489D
		private bool getTitle; // 0x10
		public bool isShowTitle; // 0x11
		private GameObject canvas; // 0x18
		private GameObject bg; // 0x20
		private Browser browser; // 0x28
		private UnityEngine.UI.Text titleText; // 0x30
		private Button backButton; // 0x38
		private Button closeButton; // 0x40
		private Image progress; // 0x48
		public Action<string, string> OnRegisterAccount; // 0x50
		public Action<string, string> OnForgetPassword; // 0x58
		private static MiHoYoSDKWebManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKWebManager() {} // 0x0000000185A79C90-0x0000000185A79D00
	
		// Methods
		// [XID] // 0x0000000189B38E30-0x0000000189B38E50
		public static MiHoYoSDKWebManager Instance() => default; // 0x0000000185A78C10-0x0000000185A78CF0
		// [XID] // 0x00000001898B45A0-0x00000001898B45C0
		private void Init() {} // 0x0000000185A786E0-0x0000000185A78C10
		// [XID] // 0x0000000189646900-0x0000000189646920
		public void LoadUrl(string url) {} // 0x0000000185A78CF0-0x0000000185A78E50
		// [XID] // 0x00000001898C3790-0x00000001898C37B0
		public void SetUserAgent(string content = "" /* Metadata: 0x00AE487C */) {} // 0x0000000185A79A90-0x0000000185A79BC0
		// [XID] // 0x0000000189A1B630-0x0000000189A1B650
		private void OnLoad(JSONNode obj) {} // 0x0000000185A79120-0x0000000185A791D0
		// [XID] // 0x0000000189617080-0x00000001896170A0
		private void OnUniWebViewMsgReceive(JSONNode obj) {} // 0x0000000185A79460-0x0000000185A79970
		// [XID] // 0x00000001899172B0-0x00000001899172D0
		public void OnBackClicked() {} // 0x0000000185A78E50-0x0000000185A78F70
		// [XID] // 0x00000001898E1DD0-0x00000001898E1DF0
		public void OnForwardClicked() {} // 0x0000000185A79010-0x0000000185A79120
		// [XID] // 0x00000001898E9AD0-0x00000001898E9AF0
		public void OnReloadClicked() {} // 0x0000000185A79370-0x0000000185A79460
		// [XID] // 0x00000001898F0F60-0x00000001898F0F80
		public void OnCloseClicked() {} // 0x0000000185A78F70-0x0000000185A79010
		// [XID] // 0x0000000189A4F7F0-0x0000000189A4F810
		public void Close() {} // 0x0000000185A78260-0x0000000185A78420
		[DebuggerHidden] // 0x0000000189900270-0x00000001899002B0
		// [XID] // 0x0000000189900270-0x00000001899002B0
		public IEnumerator GetTitle() => default; // 0x0000000185A78420-0x0000000185A78530
		// [XID] // 0x000000018990A720-0x000000018990A740
		private void SetWebTitle(string title) {} // 0x0000000185A79BC0-0x0000000185A79C90
		[DebuggerHidden] // 0x00000001899120D0-0x0000000189912110
		// [XID] // 0x00000001899120D0-0x0000000189912110
		private IEnumerator SetProgress(float value) => default; // 0x0000000185A79970-0x0000000185A79A90
		// [XID] // 0x0000000189725F40-0x0000000189725F60
		private void OnNavStateChange() {} // 0x0000000185A791D0-0x0000000185A79370
		// [XID] // 0x0000000189877090-0x00000001898770B0
		public static string GetmiHoYoWebUserAgent() => default; // 0x0000000185A78530-0x0000000185A785D0
		// [XID] // 0x00000001896E3160-0x00000001896E3180
		public void HideBG(bool flag) {} // 0x0000000185A785D0-0x0000000185A786E0
	}
}
