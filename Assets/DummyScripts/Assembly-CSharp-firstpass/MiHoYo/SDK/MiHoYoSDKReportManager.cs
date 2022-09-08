/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKReportManager // TypeDefIndex: 8698
	{
		// Fields
		public static string Version; // 0x00
		private const string ReportSecret = "mihoyo2020hk4e"; // Metadata: 0x00AE1FF2
		private List<MiHoYoSDKGameReportModel> reportList; // 0x10
		private List<MiHoYoSDKGameReportModel> reportingList; // 0x18
		private ReportInfo baseReportInfo; // 0x20
		private bool isSending; // 0x28
		private static MiHoYoSDKReportManager _instance; // 0x08
	
		// Properties
		public static MiHoYoSDKReportManager Instance { /* [XID] */ /* 0x00000001899E73F0-0x00000001899E7410 */ get => default; } // 0x000000018595CEA0-0x000000018595CFE0 
	
		// Constructors
		public MiHoYoSDKReportManager() {} // 0x000000018595CDD0-0x000000018595CEA0
		static MiHoYoSDKReportManager() {} // 0x000000018595CD60-0x000000018595CDD0
	
		// Methods
		// [XID] // 0x0000000189A45210-0x0000000189A45230
		public void Report(int actionId, string actionName, string cBody = null, string level = null) {} // 0x000000018595C090-0x000000018595C2F0
		// [XID] // 0x00000001899F6110-0x00000001899F6130
		public void CloudReport(int actionId, string actionName, string cBody = null, string level = null) {} // 0x000000018595AD30-0x000000018595AFC0
		// [XID] // 0x0000000189671640-0x0000000189671660
		public void SetReportInfo(string jsonString) {} // 0x000000018595C6D0-0x000000018595CD60
		// [XID] // 0x0000000189A04E40-0x0000000189A04E60
		private void SendReport() {} // 0x000000018595C410-0x000000018595C6D0
		// [XID] // 0x0000000189A0C510-0x0000000189A0C530
		private MiHoYoSDKGameReportModel GetBaseModel() => default; // 0x000000018595AFC0-0x000000018595B280
		// [XID] // 0x000000018974F030-0x000000018974F050
		private MiHoYoSDKGameReportModel GetModel() => default; // 0x000000018595B280-0x000000018595B920
		// [XID] // 0x0000000189A1B0E0-0x0000000189A1B100
		private string GetPlatform() => default; // 0x000000018595B920-0x000000018595BAA0
		// [XID] // 0x0000000189A22A60-0x0000000189A22A80
		private string GetReportContent(List<MiHoYoSDKGameReportModel> reportingList) => default; // 0x000000018595BAA0-0x000000018595BD00
		[DebuggerHidden] // 0x0000000189A29C20-0x0000000189A29C60
		// [XID] // 0x0000000189A29C20-0x0000000189A29C60
		public IEnumerator SendReportRequest(List<MiHoYoSDKGameReportModel> reportingList) => default; // 0x000000018595C2F0-0x000000018595C410
		// [XID] // 0x00000001899F7EA0-0x00000001899F7EC0
		private void OnReportCallback(string responseString) {} // 0x000000018595BD00-0x000000018595BFC0
		// [XID] // 0x00000001899E1A30-0x00000001899E1A50
		private void OnTimeOut() {} // 0x000000018595BFC0-0x000000018595C090
	}
}
