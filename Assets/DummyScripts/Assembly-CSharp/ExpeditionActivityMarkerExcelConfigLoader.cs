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

public static class ExpeditionActivityMarkerExcelConfigLoader // TypeDefIndex: 15090
{
	// Fields
	private static Dictionary<uint, ExpeditionActivityMarkerExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionActivityMarkerExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionActivityMarkerExcelConfig, ExpeditionActivityMarkerExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionActivityMarkerExcelConfig>, Dictionary<uint, ExpeditionActivityMarkerExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionActivityMarkerExcelConfig> dataDict { /* [XID] */ /* 0x00000001897DB970-0x00000001897DB990 */ get; } // 0x000000018306FB10-0x000000018306FBC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897EA980-0x00000001897EA9A0 */ get; } // 0x000000018306E960-0x000000018306EA00 

	// Methods
	// [XID] // 0x00000001897D4060-0x00000001897D4080
	public static void Register() {} // 0x000000018306FEF0-0x000000018306FF90
	// [XID] // 0x00000001897E3200-0x00000001897E3220
	public static ExpeditionActivityMarkerExcelConfig GetData(uint id) => default; // 0x000000018306E830-0x000000018306E960
	// [XID] // 0x00000001897F2750-0x00000001897F2770
	public static void LoadData() {} // 0x000000018306EF90-0x000000018306F080
	// [XID] // 0x00000001897F9F20-0x00000001897F9F40
	private static void RegisterHotfixGenerated() {} // 0x000000018306EDC0-0x000000018306EF90
	// [XID] // 0x0000000189801500-0x0000000189801520
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018306EA00-0x000000018306EDC0
	// [IDTag] // 0x0000000189808940-0x0000000189808980
	// [XID] // 0x0000000189808940-0x0000000189808980
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018306F470-0x000000018306F570
	// [XID] // 0x0000000189813000-0x0000000189813020
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionActivityMarkerExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018306FBC0-0x000000018306FEF0
	// [XID] // 0x000000018981AAE0-0x000000018981AB00
	private static bool ParseConfigFromLine(string line, out ExpeditionActivityMarkerExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018306F080-0x000000018306F1C0
	// [IDTag] // 0x0000000189822310-0x0000000189822350
	// [XID] // 0x0000000189822310-0x0000000189822350
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionActivityMarkerExcelConfig> configList) => default; // 0x000000018306F1C0-0x000000018306F470
	// [IDTag] // 0x000000018982C970-0x000000018982C9B0
	// [XID] // 0x000000018982C970-0x000000018982C9B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF008A */, bool useObjectPool = false /* Metadata: 0x00AF008E */) => default; // 0x000000018306F570-0x000000018306F7C0
	// [IDTag] // 0x0000000189836E70-0x0000000189836EB0
	// [XID] // 0x0000000189836E70-0x0000000189836EB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF008F */, bool useObjectPool = false /* Metadata: 0x00AF0093 */) => default; // 0x000000018306F7C0-0x000000018306FB10
}

