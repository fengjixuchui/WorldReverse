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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKMultiLanguageManager // TypeDefIndex: 8680
	{
		// Fields
		private const string LANGUAGE_VERSION = "MIHOYOSDK_LANGUAGE_VERSION_"; // Metadata: 0x00AE1F48
		private const string LANGUAGE_FILE = "MIHOYOSDK_LANGUAGE_FILE_"; // Metadata: 0x00AE1F67
		private int newVersion; // 0x10
		private string currentLanguage; // 0x18
		private bool isRequest; // 0x20
		private static MiHoYoSDKMultiLanguageManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKMultiLanguageManager() {} // 0x0000000185F3BA60-0x0000000185F3BAD0
	
		// Methods
		// [XID] // 0x0000000189A4FEA0-0x0000000189A4FEC0
		public static MiHoYoSDKMultiLanguageManager Instance() => default; // 0x0000000185F3AC70-0x0000000185F3AD50
		// [XID] // 0x0000000189B7F5A0-0x0000000189B7F5C0
		public void UpdateLanguageModel() {} // 0x0000000185F3B8E0-0x0000000185F3BA60
		// [XID] // 0x0000000189A5EF70-0x0000000189A5EF90
		public MiHoYoSDKLanguageModel GetLanguageModel(string language) => default; // 0x0000000185F3A7A0-0x0000000185F3A990
		// [XID] // 0x00000001899E7F60-0x00000001899E7F80
		private int GetLanguageVersion() => default; // 0x0000000185F3A990-0x0000000185F3AC70
		// [XID] // 0x0000000189B95860-0x0000000189B95880
		private void SetLanguageVersion(int version) {} // 0x0000000185F3B620-0x0000000185F3B8E0
		// [XID] // 0x0000000189B9CD20-0x0000000189B9CD40
		private void OnGetVersion(string responseString) {} // 0x0000000185F3B0D0-0x0000000185F3B3B0
		// [XID] // 0x0000000189BA4550-0x0000000189BA4570
		private void OnGetLanguage(string responseString) {} // 0x0000000185F3ADF0-0x0000000185F3B0D0
		// [XID] // 0x0000000189B40020-0x0000000189B40040
		private void OnGetLanguageTimeOut() {} // 0x0000000185F3AD50-0x0000000185F3ADF0
		[DebuggerHidden] // 0x0000000189BB2FE0-0x0000000189BB3020
		// [XID] // 0x0000000189BB2FE0-0x0000000189BB3020
		private IEnumerator RequestVersion(Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185F3B4F0-0x0000000185F3B620
		[DebuggerHidden] // 0x0000000189BBD5C0-0x0000000189BBD600
		// [XID] // 0x0000000189BBD5C0-0x0000000189BBD600
		private IEnumerator RequestLanguage(Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185F3B3B0-0x0000000185F3B4F0
	}
}
