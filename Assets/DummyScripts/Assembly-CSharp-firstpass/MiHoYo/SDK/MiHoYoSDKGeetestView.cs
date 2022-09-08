/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKGeetestView : MiHoYoSDKBaseDialog // TypeDefIndex: 8853
	{
		// Fields
		private const string GeetestViewbPath = "UI/MiHoYoSDKGeetestView.Prefab"; // Metadata: 0x00AE30EA
		private Button closeButton; // 0x20
		private Browser browser; // 0x28
		private static MiHoYoSDKGeetestView _instance; // 0x00
	
		// Events
		public event Action OnClose;
		public event Action<MiHoYoSDKUniWebViewMessage> OnGetUniWebMessage;
	
		// Constructors
		public MiHoYoSDKGeetestView() {} // 0x0000000184DF5BA0-0x0000000184DF5C00
	
		// Methods
		// [XID] // 0x00000001898F0F80-0x00000001898F0FA0
		public static MiHoYoSDKGeetestView Instance() => default; // 0x0000000184DF5560-0x0000000184DF5670
		// [XID] // 0x0000000189A4B240-0x0000000189A4B260
		public static bool IsExist() => default; // 0x0000000184DF5670-0x0000000184DF5770
		// [XID] // 0x0000000189B00050-0x0000000189B00070
		private void Init() {} // 0x0000000184DF5260-0x0000000184DF5560
		// [XID] // 0x0000000189973EF0-0x0000000189973F10
		public void Show(string url) {} // 0x0000000184DF5AD0-0x0000000184DF5BA0
		// [XID] // 0x00000001896488D0-0x00000001896488F0
		public void LoadUrl(string url) {} // 0x0000000184DF5770-0x0000000184DF5840
		// [XID] // 0x00000001896E25A0-0x00000001896E25C0
		public void Close() {} // 0x0000000184DF50F0-0x0000000184DF5260
		// [XID] // 0x000000018991E2C0-0x000000018991E2E0
		private void OnUniWebviewMsgReceive(JSONNode result) {} // 0x0000000184DF5960-0x0000000184DF5AD0
		// [XID] // 0x0000000189B07550-0x0000000189B07570
		private void OnLoad(JSONNode result) {} // 0x0000000184DF5840-0x0000000184DF5960
	}
}
