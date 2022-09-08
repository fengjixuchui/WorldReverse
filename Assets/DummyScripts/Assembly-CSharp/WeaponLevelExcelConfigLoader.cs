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

public static class WeaponLevelExcelConfigLoader // TypeDefIndex: 16274
{
	// Fields
	private static Dictionary<uint, WeaponLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeaponLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeaponLevelExcelConfig, WeaponLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeaponLevelExcelConfig>, Dictionary<uint, WeaponLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WeaponLevelExcelConfig> dataDict { /* [XID] */ /* 0x00000001899133E0-0x0000000189913400 */ get; } // 0x0000000185B33920-0x0000000185B339D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189922360-0x0000000189922380 */ get; } // 0x0000000185B32770-0x0000000185B32810 

	// Methods
	// [XID] // 0x000000018990B6F0-0x000000018990B710
	public static void Register() {} // 0x0000000185B33D00-0x0000000185B33DA0
	// [XID] // 0x000000018991AB30-0x000000018991AB50
	public static WeaponLevelExcelConfig GetData(uint level) => default; // 0x0000000185B32640-0x0000000185B32770
	// [XID] // 0x0000000189929B20-0x0000000189929B40
	public static void LoadData() {} // 0x0000000185B32DA0-0x0000000185B32E90
	// [XID] // 0x0000000189931060-0x0000000189931080
	private static void RegisterHotfixGenerated() {} // 0x0000000185B32BD0-0x0000000185B32DA0
	// [XID] // 0x0000000189938510-0x0000000189938530
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185B32810-0x0000000185B32BD0
	// [IDTag] // 0x000000018993FF20-0x000000018993FF60
	// [XID] // 0x000000018993FF20-0x000000018993FF60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185B33280-0x0000000185B33380
	// [XID] // 0x000000018994A3A0-0x000000018994A3C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeaponLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185B339D0-0x0000000185B33D00
	// [XID] // 0x0000000189951E70-0x0000000189951E90
	private static bool ParseConfigFromLine(string line, out WeaponLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185B32E90-0x0000000185B32FD0
	// [IDTag] // 0x0000000189959410-0x0000000189959450
	// [XID] // 0x0000000189959410-0x0000000189959450
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeaponLevelExcelConfig> configList) => default; // 0x0000000185B32FD0-0x0000000185B33280
	// [IDTag] // 0x0000000189963CE0-0x0000000189963D20
	// [XID] // 0x0000000189963CE0-0x0000000189963D20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3621 */, bool useObjectPool = false /* Metadata: 0x00AF3625 */) => default; // 0x0000000185B33380-0x0000000185B335D0
	// [IDTag] // 0x000000018996E120-0x000000018996E160
	// [XID] // 0x000000018996E120-0x000000018996E160
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3626 */, bool useObjectPool = false /* Metadata: 0x00AF362A */) => default; // 0x0000000185B335D0-0x0000000185B33920
}

