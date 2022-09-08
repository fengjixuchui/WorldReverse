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

public static class StrengthenBasePointExcelConfigLoader // TypeDefIndex: 16176
{
	// Fields
	private static Dictionary<uint, StrengthenBasePointExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<StrengthenBasePointExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<StrengthenBasePointExcelConfig, StrengthenBasePointExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<StrengthenBasePointExcelConfig>, Dictionary<uint, StrengthenBasePointExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, StrengthenBasePointExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A102B0-0x0000000189A102D0 */ get; } // 0x0000000184555C20-0x0000000184555CD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A1EF10-0x0000000189A1EF30 */ get; } // 0x0000000184554A70-0x0000000184554B10 

	// Methods
	// [XID] // 0x0000000189A08CD0-0x0000000189A08CF0
	public static void Register() {} // 0x0000000184556000-0x00000001845560A0
	// [XID] // 0x0000000189A178B0-0x0000000189A178D0
	public static StrengthenBasePointExcelConfig GetData(uint dungeonId) => default; // 0x0000000184554940-0x0000000184554A70
	// [XID] // 0x0000000189A26580-0x0000000189A265A0
	public static void LoadData() {} // 0x00000001845550A0-0x0000000184555190
	// [XID] // 0x0000000189A2D8F0-0x0000000189A2D910
	private static void RegisterHotfixGenerated() {} // 0x0000000184554ED0-0x00000001845550A0
	// [XID] // 0x0000000189A354B0-0x0000000189A354D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184554B10-0x0000000184554ED0
	// [IDTag] // 0x0000000189A3C940-0x0000000189A3C980
	// [XID] // 0x0000000189A3C940-0x0000000189A3C980
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184555580-0x0000000184555680
	// [XID] // 0x0000000189A47210-0x0000000189A47230
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<StrengthenBasePointExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184555CD0-0x0000000184556000
	// [XID] // 0x0000000189A4EB50-0x0000000189A4EB70
	private static bool ParseConfigFromLine(string line, out StrengthenBasePointExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184555190-0x00000001845552D0
	// [IDTag] // 0x0000000189A561E0-0x0000000189A56220
	// [XID] // 0x0000000189A561E0-0x0000000189A56220
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<StrengthenBasePointExcelConfig> configList) => default; // 0x00000001845552D0-0x0000000184555580
	// [IDTag] // 0x0000000189A60AE0-0x0000000189A60B20
	// [XID] // 0x0000000189A60AE0-0x0000000189A60B20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3365 */, bool useObjectPool = false /* Metadata: 0x00AF3369 */) => default; // 0x00000001845559D0-0x0000000184555C20
	// [IDTag] // 0x0000000189A6B590-0x0000000189A6B5D0
	// [XID] // 0x0000000189A6B590-0x0000000189A6B5D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF336A */, bool useObjectPool = false /* Metadata: 0x00AF336E */) => default; // 0x0000000184555680-0x00000001845559D0
}

