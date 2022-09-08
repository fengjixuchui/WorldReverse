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

public static class DailyTaskLevelExcelConfigLoader // TypeDefIndex: 15486
{
	// Fields
	private static List<DailyTaskLevelExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<DailyTaskLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DailyTaskLevelExcelConfig, DailyTaskLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DailyTaskLevelExcelConfig>, List<DailyTaskLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<DailyTaskLevelExcelConfig> dataList { /* [XID] */ /* 0x0000000189715130-0x0000000189715150 */ get; } // 0x0000000184EC5890-0x0000000184EC5940 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018971CC40-0x000000018971CC60 */ get; } // 0x0000000184EC46A0-0x0000000184EC4740 

	// Methods
	// [XID] // 0x000000018970DCB0-0x000000018970DCD0
	public static void Register() {} // 0x0000000184EC5C70-0x0000000184EC5D10
	// [XID] // 0x00000001897240B0-0x00000001897240D0
	public static void LoadData() {} // 0x0000000184EC4D40-0x0000000184EC4E30
	// [XID] // 0x000000018972B810-0x000000018972B830
	private static void RegisterHotfixGenerated() {} // 0x0000000184EC4B70-0x0000000184EC4D40
	// [XID] // 0x0000000189732FE0-0x0000000189733000
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184EC4740-0x0000000184EC4B70
	// [IDTag] // 0x000000018973A630-0x000000018973A670
	// [XID] // 0x000000018973A630-0x000000018973A670
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184EC4F70-0x0000000184EC5070
	// [XID] // 0x00000001897450B0-0x00000001897450D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DailyTaskLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184EC5940-0x0000000184EC5C70
	// [XID] // 0x000000018974CBA0-0x000000018974CBC0
	private static bool ParseConfigFromLine(string line, out DailyTaskLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184EC4E30-0x0000000184EC4F70
	// [IDTag] // 0x0000000189753EE0-0x0000000189753F20
	// [XID] // 0x0000000189753EE0-0x0000000189753F20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DailyTaskLevelExcelConfig> configList) => default; // 0x0000000184EC5070-0x0000000184EC5310
	// [IDTag] // 0x000000018975E5B0-0x000000018975E5F0
	// [XID] // 0x000000018975E5B0-0x000000018975E5F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1C0E */, bool useObjectPool = false /* Metadata: 0x00AF1C12 */) => default; // 0x0000000184EC5640-0x0000000184EC5890
	// [IDTag] // 0x0000000189768BA0-0x0000000189768BE0
	// [XID] // 0x0000000189768BA0-0x0000000189768BE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C13 */, bool useObjectPool = false /* Metadata: 0x00AF1C17 */) => default; // 0x0000000184EC5310-0x0000000184EC5640
}

