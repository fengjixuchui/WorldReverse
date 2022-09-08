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

public static class ActivitySalesmanDailyExcelConfigLoader // TypeDefIndex: 15171
{
	// Fields
	private static Dictionary<uint, ActivitySalesmanDailyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivitySalesmanDailyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivitySalesmanDailyExcelConfig, ActivitySalesmanDailyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivitySalesmanDailyExcelConfig>, Dictionary<uint, ActivitySalesmanDailyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivitySalesmanDailyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A3B2C0-0x0000000189A3B2E0 */ get; } // 0x0000000182B4F3B0-0x0000000182B4F460 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A4A220-0x0000000189A4A240 */ get; } // 0x0000000182B4E200-0x0000000182B4E2A0 

	// Methods
	// [XID] // 0x0000000189A33B60-0x0000000189A33B80
	public static void Register() {} // 0x0000000182B4F790-0x0000000182B4F830
	// [XID] // 0x0000000189A42D90-0x0000000189A42DB0
	public static ActivitySalesmanDailyExcelConfig GetData(uint dailyConfigId) => default; // 0x0000000182B4E0D0-0x0000000182B4E200
	// [XID] // 0x0000000189A51C10-0x0000000189A51C30
	public static void LoadData() {} // 0x0000000182B4E830-0x0000000182B4E920
	// [XID] // 0x0000000189A59320-0x0000000189A59340
	private static void RegisterHotfixGenerated() {} // 0x0000000182B4E660-0x0000000182B4E830
	// [XID] // 0x0000000189A60CC0-0x0000000189A60CE0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B4E2A0-0x0000000182B4E660
	// [IDTag] // 0x0000000189A68950-0x0000000189A68990
	// [XID] // 0x0000000189A68950-0x0000000189A68990
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B4ED10-0x0000000182B4EE10
	// [XID] // 0x0000000189A72EA0-0x0000000189A72EC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivitySalesmanDailyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B4F460-0x0000000182B4F790
	// [XID] // 0x0000000189A7AA90-0x0000000189A7AAB0
	private static bool ParseConfigFromLine(string line, out ActivitySalesmanDailyExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B4E920-0x0000000182B4EA60
	// [IDTag] // 0x0000000189A81F10-0x0000000189A81F50
	// [XID] // 0x0000000189A81F10-0x0000000189A81F50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivitySalesmanDailyExcelConfig> configList) => default; // 0x0000000182B4EA60-0x0000000182B4ED10
	// [IDTag] // 0x0000000189A8C970-0x0000000189A8C9B0
	// [XID] // 0x0000000189A8C970-0x0000000189A8C9B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF02CC */, bool useObjectPool = false /* Metadata: 0x00AF02D0 */) => default; // 0x0000000182B4F160-0x0000000182B4F3B0
	// [IDTag] // 0x0000000189A96FE0-0x0000000189A97020
	// [XID] // 0x0000000189A96FE0-0x0000000189A97020
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02D1 */, bool useObjectPool = false /* Metadata: 0x00AF02D5 */) => default; // 0x0000000182B4EE10-0x0000000182B4F160
}

