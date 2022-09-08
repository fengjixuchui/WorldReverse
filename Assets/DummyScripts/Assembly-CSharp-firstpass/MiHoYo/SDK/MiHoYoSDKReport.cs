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
	public class MiHoYoSDKReport // TypeDefIndex: 8915
	{
		// Fields
		private long lastTime; // 0x10
		private int days; // 0x18
		private const string MIHOYO_SDK_REPORT_DAYS = "MIHOYO_SDK_REPORT_DAYS_KEY"; // Metadata: 0x00AE4E24
		public Action<string> OnReport; // 0x20
		private static MiHoYoSDKReport _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKReport() {} // 0x000000018595E0C0-0x000000018595E130
	
		// Methods
		// [XID] // 0x0000000189BDBD00-0x0000000189BDBD20
		public static MiHoYoSDKReport Instance() => default; // 0x000000018595DB30-0x000000018595DC30
		// [XID] // 0x000000018963FD30-0x000000018963FD50
		public void Report(string key, Dictionary<string, string> event_extra = null) {} // 0x000000018595DEC0-0x000000018595E000
		[DebuggerHidden] // 0x00000001895EFE30-0x00000001895EFE70
		// [XID] // 0x00000001895EFE30-0x00000001895EFE70
		public IEnumerator ReportData(string key, Dictionary<string, string> event_extra = null) => default; // 0x000000018595DD80-0x000000018595DEC0
		// [XID] // 0x0000000189812A20-0x0000000189812A40
		private TrackInfo GetTrackInfo(string key) => default; // 0x000000018595D390-0x000000018595DB30
		// [XID] // 0x0000000189601DD0-0x0000000189601DF0
		private void OnReportCallback(string responseString) {} // 0x000000018595DC30-0x000000018595DCE0
		// [XID] // 0x00000001898EA5B0-0x00000001898EA5D0
		private void OnTimeOut() {} // 0x000000018595DCE0-0x000000018595DD80
		// [XID] // 0x0000000189610DC0-0x0000000189610DE0
		private void SetReportDays(string reportValue) {} // 0x000000018595E000-0x000000018595E0C0
		// [XID] // 0x0000000189629570-0x0000000189629590
		public int GetReportDays() => default; // 0x000000018595D070-0x000000018595D390
	}
}
