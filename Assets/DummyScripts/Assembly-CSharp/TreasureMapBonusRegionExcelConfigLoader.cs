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

public static class TreasureMapBonusRegionExcelConfigLoader // TypeDefIndex: 15197
{
	// Fields
	private static Dictionary<uint, TreasureMapBonusRegionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TreasureMapBonusRegionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TreasureMapBonusRegionExcelConfig, TreasureMapBonusRegionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TreasureMapBonusRegionExcelConfig>, Dictionary<uint, TreasureMapBonusRegionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TreasureMapBonusRegionExcelConfig> dataDict { /* [XID] */ /* 0x00000001897AF6F0-0x00000001897AF710 */ get; } // 0x0000000183E67830-0x0000000183E678E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897BF450-0x00000001897BF470 */ get; } // 0x0000000183E66680-0x0000000183E66720 

	// Methods
	// [XID] // 0x00000001897A7C80-0x00000001897A7CA0
	public static void Register() {} // 0x0000000183E67C10-0x0000000183E67CB0
	// [XID] // 0x00000001897B75D0-0x00000001897B75F0
	public static TreasureMapBonusRegionExcelConfig GetData(uint id) => default; // 0x0000000183E66550-0x0000000183E66680
	// [XID] // 0x00000001897C6B60-0x00000001897C6B80
	public static void LoadData() {} // 0x0000000183E66CB0-0x0000000183E66DA0
	// [XID] // 0x00000001897CE300-0x00000001897CE320
	private static void RegisterHotfixGenerated() {} // 0x0000000183E66AE0-0x0000000183E66CB0
	// [XID] // 0x00000001897D5850-0x00000001897D5870
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183E66720-0x0000000183E66AE0
	// [IDTag] // 0x00000001897DCF50-0x00000001897DCF90
	// [XID] // 0x00000001897DCF50-0x00000001897DCF90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183E66EE0-0x0000000183E66FE0
	// [XID] // 0x00000001897E77F0-0x00000001897E7810
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TreasureMapBonusRegionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183E678E0-0x0000000183E67C10
	// [XID] // 0x00000001897EF3D0-0x00000001897EF3F0
	private static bool ParseConfigFromLine(string line, out TreasureMapBonusRegionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183E66DA0-0x0000000183E66EE0
	// [IDTag] // 0x00000001897F6A40-0x00000001897F6A80
	// [XID] // 0x00000001897F6A40-0x00000001897F6A80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TreasureMapBonusRegionExcelConfig> configList) => default; // 0x0000000183E66FE0-0x0000000183E67290
	// [IDTag] // 0x00000001898014A0-0x00000001898014E0
	// [XID] // 0x00000001898014A0-0x00000001898014E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF038B */, bool useObjectPool = false /* Metadata: 0x00AF038F */) => default; // 0x0000000183E67290-0x0000000183E674E0
	// [IDTag] // 0x000000018980B7C0-0x000000018980B800
	// [XID] // 0x000000018980B7C0-0x000000018980B800
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0390 */, bool useObjectPool = false /* Metadata: 0x00AF0394 */) => default; // 0x0000000183E674E0-0x0000000183E67830
}

