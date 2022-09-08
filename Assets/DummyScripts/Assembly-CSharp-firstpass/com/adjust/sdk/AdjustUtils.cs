/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class AdjustUtils // TypeDefIndex: 6736
	{
		// Fields
		public static string KeyAdid; // 0x00
		public static string KeyMessage; // 0x08
		public static string KeyNetwork; // 0x10
		public static string KeyAdgroup; // 0x18
		public static string KeyCampaign; // 0x20
		public static string KeyCreative; // 0x28
		public static string KeyWillRetry; // 0x30
		public static string KeyTimestamp; // 0x38
		public static string KeyCallbackId; // 0x40
		public static string KeyEventToken; // 0x48
		public static string KeyClickLabel; // 0x50
		public static string KeyTrackerName; // 0x58
		public static string KeyTrackerToken; // 0x60
		public static string KeyJsonResponse; // 0x68
		public static string KeyTestOptionsBaseUrl; // 0x70
		public static string KeyTestOptionsGdprUrl; // 0x78
		public static string KeyTestOptionsSubscriptionUrl; // 0x80
		public static string KeyTestOptionsExtraPath; // 0x88
		public static string KeyTestOptionsBasePath; // 0x90
		public static string KeyTestOptionsGdprPath; // 0x98
		public static string KeyTestOptionsDeleteState; // 0xA0
		public static string KeyTestOptionsUseTestConnectionOptions; // 0xA8
		public static string KeyTestOptionsTimerIntervalInMilliseconds; // 0xB0
		public static string KeyTestOptionsTimerStartInMilliseconds; // 0xB8
		public static string KeyTestOptionsSessionIntervalInMilliseconds; // 0xC0
		public static string KeyTestOptionsSubsessionIntervalInMilliseconds; // 0xC8
		public static string KeyTestOptionsTeardown; // 0xD0
		public static string KeyTestOptionsNoBackoffWait; // 0xD8
		public static string KeyTestOptionsiAdFrameworkEnabled; // 0xE0
	
		// Constructors
		public AdjustUtils() {} // 0x0000000186692E00-0x0000000186692E60
		static AdjustUtils() {} // 0x0000000186692AB0-0x0000000186692E00
	
		// Methods
		// [XID] // 0x0000000189AC1430-0x0000000189AC1450
		public static int ConvertLogLevel(AdjustLogLevel? logLevel) => default; // 0x0000000186691D00-0x0000000186691DD0
		// [XID] // 0x0000000189AD5830-0x0000000189AD5850
		public static int ConvertBool(bool? value) => default; // 0x0000000186691940-0x0000000186691A10
		// [XID] // 0x0000000189630130-0x0000000189630150
		public static double ConvertDouble(double? value) => default; // 0x0000000186691A10-0x0000000186691AF0
		// [XID] // 0x0000000189AE5F60-0x0000000189AE5F80
		public static long ConvertLong(long? value) => default; // 0x0000000186691DD0-0x0000000186691EA0
		// [XID] // 0x0000000189AEBFF0-0x0000000189AEC010
		public static string ConvertListToJson(List<string> list) => default; // 0x0000000186691AF0-0x0000000186691D00
		// [XID] // 0x000000018960ACE0-0x000000018960AD00
		public static string GetJsonResponseCompact(Dictionary<string, object> dictionary) => default; // 0x0000000186691EA0-0x0000000186692510
		// [XID] // 0x0000000189999220-0x0000000189999240
		public static string GetJsonString(JSONNode node, string key) => default; // 0x0000000186692510-0x00000001866926A0
		// [XID] // 0x0000000189B028B0-0x0000000189B028D0
		public static void WriteJsonResponseDictionary(JSONClass jsonObject, Dictionary<string, object> output) {} // 0x00000001866927C0-0x0000000186692AB0
		// [XID] // 0x0000000189B09F30-0x0000000189B09F50
		public static string TryGetValue(Dictionary<string, string> dictionary, string key) => default; // 0x00000001866926A0-0x00000001866927C0
	}
}
