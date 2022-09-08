/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class ConfigChannel // TypeDefIndex: 14771
	{
		// Fields
		public string ChannelName; // 0x10
		public string BundleIdentifier; // 0x18
		public string PS4ClientID; // 0x20
		public string PS5ClientID; // 0x28
		public string ProductName; // 0x30
		public string PreDefines; // 0x38
		public string TimeZones; // 0x40
		public List<ConfigDispatchUrl> DispatchConfigs; // 0x48
		public int VersionCode; // 0x50
		public bool Obb; // 0x54
		public bool DataUseAssetBundle; // 0x55
		public bool EventUseAssetBundle; // 0x56
		public bool BetaMark; // 0x57
		public string CVDefault; // 0x58
		public string FAQUrl; // 0x60
		public string ExceptionReportUrl; // 0x68
		public string NetworkErrReportUrl; // 0x70
		public string MediumReportUrl; // 0x78
		public string CrashReportUrl; // 0x80
		public string LogRecorderUrl; // 0x88
		public AccountBranchType AccountBranch; // 0x90
		public PaymentBranchType PaymentBranch; // 0x94
		public string GVoiceAppID; // 0x98
		public string GVoiceAppKey; // 0xA0
		public string GVoiceServerInfo; // 0xA8
		public string BaseTextLang; // 0xB0
		public string BaseAudioLang; // 0xB8
	
		// Constructors
		public ConfigChannel() {} // 0x0000000186B5E3B0-0x0000000186B5E410
	
		// Methods
		// [XID] // 0x000000018962CC50-0x000000018962CC70
		public bool IsOversea() => default; // 0x0000000186B5E220-0x0000000186B5E3B0
	}
}
