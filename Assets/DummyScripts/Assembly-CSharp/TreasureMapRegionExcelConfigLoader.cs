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

public static class TreasureMapRegionExcelConfigLoader // TypeDefIndex: 15199
{
	// Fields
	private static Dictionary<uint, TreasureMapRegionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TreasureMapRegionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TreasureMapRegionExcelConfig, TreasureMapRegionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TreasureMapRegionExcelConfig>, Dictionary<uint, TreasureMapRegionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TreasureMapRegionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189972EF0-0x0000000189972F10 */ get; } // 0x00000001833F5BF0-0x00000001833F5CA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899821C0-0x00000001899821E0 */ get; } // 0x00000001833F4A40-0x00000001833F4AE0 

	// Methods
	// [XID] // 0x000000018996B430-0x000000018996B450
	public static void Register() {} // 0x00000001833F5FD0-0x00000001833F6070
	// [XID] // 0x000000018997A7F0-0x000000018997A810
	public static TreasureMapRegionExcelConfig GetData(uint id) => default; // 0x00000001833F4910-0x00000001833F4A40
	// [XID] // 0x00000001899899A0-0x00000001899899C0
	public static void LoadData() {} // 0x00000001833F5070-0x00000001833F5160
	// [XID] // 0x0000000189991250-0x0000000189991270
	private static void RegisterHotfixGenerated() {} // 0x00000001833F4EA0-0x00000001833F5070
	// [XID] // 0x0000000189998D30-0x0000000189998D50
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001833F4AE0-0x00000001833F4EA0
	// [IDTag] // 0x00000001899A05B0-0x00000001899A05F0
	// [XID] // 0x00000001899A05B0-0x00000001899A05F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833F5550-0x00000001833F5650
	// [XID] // 0x00000001899AB120-0x00000001899AB140
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TreasureMapRegionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001833F5CA0-0x00000001833F5FD0
	// [XID] // 0x00000001899B2B70-0x00000001899B2B90
	private static bool ParseConfigFromLine(string line, out TreasureMapRegionExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001833F5160-0x00000001833F52A0
	// [IDTag] // 0x00000001899B9D30-0x00000001899B9D70
	// [XID] // 0x00000001899B9D30-0x00000001899B9D70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TreasureMapRegionExcelConfig> configList) => default; // 0x00000001833F52A0-0x00000001833F5550
	// [IDTag] // 0x00000001899C48A0-0x00000001899C48E0
	// [XID] // 0x00000001899C48A0-0x00000001899C48E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF039A */, bool useObjectPool = false /* Metadata: 0x00AF039E */) => default; // 0x00000001833F5650-0x00000001833F58A0
	// [IDTag] // 0x00000001899CEE60-0x00000001899CEEA0
	// [XID] // 0x00000001899CEE60-0x00000001899CEEA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF039F */, bool useObjectPool = false /* Metadata: 0x00AF03A3 */) => default; // 0x00000001833F58A0-0x00000001833F5BF0
}

