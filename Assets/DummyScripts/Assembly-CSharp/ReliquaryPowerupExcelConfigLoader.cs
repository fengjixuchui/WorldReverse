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

public static class ReliquaryPowerupExcelConfigLoader // TypeDefIndex: 16025
{
	// Fields
	private static List<ReliquaryPowerupExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryPowerupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryPowerupExcelConfig, ReliquaryPowerupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryPowerupExcelConfig>, List<ReliquaryPowerupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReliquaryPowerupExcelConfig> dataList { /* [XID] */ /* 0x0000000189A309D0-0x0000000189A309F0 */ get; } // 0x00000001835AF2A0-0x00000001835AF350 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A383F0-0x0000000189A38410 */ get; } // 0x00000001835AE0B0-0x00000001835AE150 

	// Methods
	// [XID] // 0x0000000189A29400-0x0000000189A29420
	public static void Register() {} // 0x00000001835AF680-0x00000001835AF720
	// [XID] // 0x0000000189A3FB80-0x0000000189A3FBA0
	public static void LoadData() {} // 0x00000001835AE750-0x00000001835AE840
	// [XID] // 0x0000000189A47270-0x0000000189A47290
	private static void RegisterHotfixGenerated() {} // 0x00000001835AE580-0x00000001835AE750
	// [XID] // 0x0000000189A4EB70-0x0000000189A4EB90
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001835AE150-0x00000001835AE580
	// [IDTag] // 0x0000000189A56220-0x0000000189A56260
	// [XID] // 0x0000000189A56220-0x0000000189A56260
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001835AEC20-0x00000001835AED20
	// [XID] // 0x0000000189A60B80-0x0000000189A60BA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryPowerupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001835AF350-0x00000001835AF680
	// [XID] // 0x0000000189A688F0-0x0000000189A68910
	private static bool ParseConfigFromLine(string line, out ReliquaryPowerupExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001835AE840-0x00000001835AE980
	// [IDTag] // 0x0000000189A6FCA0-0x0000000189A6FCE0
	// [XID] // 0x0000000189A6FCA0-0x0000000189A6FCE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryPowerupExcelConfig> configList) => default; // 0x00000001835AE980-0x00000001835AEC20
	// [IDTag] // 0x0000000189A7A8D0-0x0000000189A7A910
	// [XID] // 0x0000000189A7A8D0-0x0000000189A7A910
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E36 */, bool useObjectPool = false /* Metadata: 0x00AF2E3A */) => default; // 0x00000001835AED20-0x00000001835AEF70
	// [IDTag] // 0x0000000189A84EE0-0x0000000189A84F20
	// [XID] // 0x0000000189A84EE0-0x0000000189A84F20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E3B */, bool useObjectPool = false /* Metadata: 0x00AF2E3F */) => default; // 0x00000001835AEF70-0x00000001835AF2A0
}

