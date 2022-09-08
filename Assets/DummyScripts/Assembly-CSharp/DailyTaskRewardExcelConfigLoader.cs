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

public static class DailyTaskRewardExcelConfigLoader // TypeDefIndex: 15484
{
	// Fields
	private static Dictionary<uint, DailyTaskRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DailyTaskRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DailyTaskRewardExcelConfig, DailyTaskRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DailyTaskRewardExcelConfig>, Dictionary<uint, DailyTaskRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DailyTaskRewardExcelConfig> dataDict { /* [XID] */ /* 0x00000001895E7E10-0x00000001895E7E30 */ get; } // 0x000000018201DE50-0x000000018201DF00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895F70C0-0x00000001895F70E0 */ get; } // 0x000000018201CCA0-0x000000018201CD40 

	// Methods
	// [XID] // 0x0000000189BDB500-0x0000000189BDB520
	public static void Register() {} // 0x000000018201E230-0x000000018201E2D0
	// [XID] // 0x00000001895EF7A0-0x00000001895EF7C0
	public static DailyTaskRewardExcelConfig GetData(uint ID) => default; // 0x000000018201CB70-0x000000018201CCA0
	// [XID] // 0x00000001895FE4C0-0x00000001895FE4E0
	public static void LoadData() {} // 0x000000018201D2D0-0x000000018201D3C0
	// [XID] // 0x0000000189605E50-0x0000000189605E70
	private static void RegisterHotfixGenerated() {} // 0x000000018201D100-0x000000018201D2D0
	// [XID] // 0x000000018960D6A0-0x000000018960D6C0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018201CD40-0x000000018201D100
	// [IDTag] // 0x0000000189614E80-0x0000000189614EC0
	// [XID] // 0x0000000189614E80-0x0000000189614EC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018201D7B0-0x000000018201D8B0
	// [XID] // 0x000000018961F6A0-0x000000018961F6C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DailyTaskRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018201DF00-0x000000018201E230
	// [XID] // 0x0000000189626AA0-0x0000000189626AC0
	private static bool ParseConfigFromLine(string line, out DailyTaskRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018201D3C0-0x000000018201D500
	// [IDTag] // 0x000000018962E370-0x000000018962E3B0
	// [XID] // 0x000000018962E370-0x000000018962E3B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DailyTaskRewardExcelConfig> configList) => default; // 0x000000018201D500-0x000000018201D7B0
	// [IDTag] // 0x0000000189638EF0-0x0000000189638F30
	// [XID] // 0x0000000189638EF0-0x0000000189638F30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1BFF */, bool useObjectPool = false /* Metadata: 0x00AF1C03 */) => default; // 0x000000018201D8B0-0x000000018201DB00
	// [IDTag] // 0x00000001896434E0-0x0000000189643520
	// [XID] // 0x00000001896434E0-0x0000000189643520
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C04 */, bool useObjectPool = false /* Metadata: 0x00AF1C08 */) => default; // 0x000000018201DB00-0x000000018201DE50
}

