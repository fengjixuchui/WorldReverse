/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ActivityMistTrialStatisticsListExcelConfigLoader // TypeDefIndex: 15144
{
	// Fields
	private static Dictionary<uint, ActivityMistTrialStatisticsListExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityMistTrialStatisticsListExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityMistTrialStatisticsListExcelConfig, ActivityMistTrialStatisticsListExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityMistTrialStatisticsListExcelConfig>, Dictionary<uint, ActivityMistTrialStatisticsListExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityMistTrialStatisticsListExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BA3EB0-0x0000000189BA3ED0 */ get; } // 0x0000000183060E10-0x0000000183060EC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BB29F0-0x0000000189BB2A10 */ get; } // 0x000000018305FC60-0x000000018305FD00 

	// Methods
	// [XID] // 0x0000000189B9C800-0x0000000189B9C820
	public static void Register() {} // 0x00000001830611F0-0x0000000183061290
	// [XID] // 0x0000000189BAB420-0x0000000189BAB440
	public static ActivityMistTrialStatisticsListExcelConfig GetData(uint Id) => default; // 0x000000018305FB30-0x000000018305FC60
	// [XID] // 0x0000000189BB9E40-0x0000000189BB9E60
	public static void LoadData() {} // 0x0000000183060290-0x0000000183060380
	// [XID] // 0x0000000189BC1DF0-0x0000000189BC1E10
	private static void RegisterHotfixGenerated() {} // 0x00000001830600C0-0x0000000183060290
	// [XID] // 0x0000000189BC93A0-0x0000000189BC93C0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018305FD00-0x00000001830600C0
	// [IDTag] // 0x0000000189BD0B50-0x0000000189BD0B90
	// [XID] // 0x0000000189BD0B50-0x0000000189BD0B90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001830604C0-0x00000001830605C0
	// [XID] // 0x0000000189BDB560-0x0000000189BDB580
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityMistTrialStatisticsListExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183060EC0-0x00000001830611F0
	// [XID] // 0x00000001895E7ED0-0x00000001895E7EF0
	private static bool ParseConfigFromLine(string line, out ActivityMistTrialStatisticsListExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183060380-0x00000001830604C0
	// [IDTag] // 0x00000001895EF840-0x00000001895EF880
	// [XID] // 0x00000001895EF840-0x00000001895EF880
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityMistTrialStatisticsListExcelConfig> configList) => default; // 0x00000001830605C0-0x0000000183060870
	// [IDTag] // 0x00000001895F9F40-0x00000001895F9F80
	// [XID] // 0x00000001895F9F40-0x00000001895F9F80
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0217 */, bool useObjectPool = false /* Metadata: 0x00AF021B */) => default; // 0x0000000183060870-0x0000000183060AC0
	// [IDTag] // 0x0000000189604690-0x00000001896046D0
	// [XID] // 0x0000000189604690-0x00000001896046D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF021C */, bool useObjectPool = false /* Metadata: 0x00AF0220 */) => default; // 0x0000000183060AC0-0x0000000183060E10
}

