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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKMmtManager // TypeDefIndex: 8731
	{
		// Fields
		public const string MMT_ID = "mmt"; // Metadata: 0x00AE2117
		public const string GEETEST_C = "geetest_challenge"; // Metadata: 0x00AE211E
		public const string GEETEST_S = "geetest_seccode"; // Metadata: 0x00AE2133
		public const string GEETEST_V = "geetest_validate"; // Metadata: 0x00AE2146
		public const string HEADER_RISKY = "x-rpc-risky"; // Metadata: 0x00AE215A
		public static readonly MiHoYoSDKMmtManager Instance; // 0x00
		public Action<int, string> OnGetMmtResult; // 0x10
	
		// Nested types
		[Serializable]
		private class CheckResultModel // TypeDefIndex: 8732
		{
			// Fields
			public string action; // 0x10
			public string id; // 0x18
			public GeetestModel geetest; // 0x20
	
			// Constructors
			public CheckResultModel() {} // 0x0000000185F380B0-0x0000000185F38120
		}
	
		[Serializable]
		private class GeetestModel // TypeDefIndex: 8733
		{
			// Fields
			public string challenge; // 0x10
			public string gt; // 0x18
			public string new_captcha; // 0x20
			public string success; // 0x28
	
			// Constructors
			public GeetestModel() {} // 0x0000000185F38120-0x0000000185F381A0
		}
	
		// Constructors
		public MiHoYoSDKMmtManager() {} // 0x0000000185F3A740-0x0000000185F3A7A0
		static MiHoYoSDKMmtManager() {} // 0x0000000185F3A680-0x0000000185F3A740
	
		// Methods
		// [XID] // 0x0000000189ACB080-0x0000000189ACB0A0
		private void ShowMmtWeb(string parameters = null) {} // 0x0000000185F3A2A0-0x0000000185F3A680
		// [XID] // 0x00000001896F4EE0-0x00000001896F4F00
		private void GetMmtResult(int ret, string mmt) {} // 0x0000000185F39CA0-0x0000000185F39D80
		// [XID] // 0x00000001896FC690-0x00000001896FC6B0
		private void OnGetUniWebViewMessage(MiHoYoSDKUniWebViewMessage message) {} // 0x0000000185F39D80-0x0000000185F39F50
		// [XID] // 0x0000000189703C20-0x0000000189703C40
		private void OnPageClose() {} // 0x0000000185F3A040-0x0000000185F3A0F0
		// [XID] // 0x00000001899EB490-0x00000001899EB4B0
		public string GetMmtHeader(string mmt) => default; // 0x0000000185F39680-0x0000000185F39CA0
		// [XID] // 0x00000001898A1A80-0x00000001898A1AA0
		public void CreateMmt(string actionType, string url, string email, string mobile, string username, Action<int, string> callback) {} // 0x0000000185F39420-0x0000000185F39680
		// [XID] // 0x0000000189ADA4E0-0x0000000189ADA500
		private void OnMmtCallback(Action<int, string> callback, int code, string mmt) {} // 0x0000000185F39F50-0x0000000185F3A040
		[DebuggerHidden] // 0x0000000189721840-0x0000000189721880
		// [XID] // 0x0000000189721840-0x0000000189721880
		public IEnumerator RequestCheck(string actionType, string url, string email, string mobile, string username, Action<string> callback, Action timeoutCallback) => default; // 0x0000000185F3A0F0-0x0000000185F3A2A0
	}
}
