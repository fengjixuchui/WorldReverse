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

public static class PlayerLevelExcelConfigLoader // TypeDefIndex: 14885
{
	// Fields
	private static Dictionary<uint, PlayerLevelExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<PlayerLevelExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<PlayerLevelExcelConfig, PlayerLevelExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<PlayerLevelExcelConfig>, Dictionary<uint, PlayerLevelExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static uint maxLevel { /* [XID] */ /* 0x000000018999A910-0x000000018999A950 */ get; /* [XID] */ /* 0x00000001899A4FF0-0x00000001899A5030 */ private set; } // 0x0000000185115590-0x00000001851155F0 0x0000000185116D10-0x0000000185116D70
	public static uint maxLevelExp { /* [XID] */ /* 0x00000001899AF930-0x00000001899AF950 */ get; } // 0x0000000185114EF0-0x0000000185114FF0 
	public static Dictionary<uint, PlayerLevelExcelConfig> dataDict { /* [XID] */ /* 0x00000001899C6130-0x00000001899C6150 */ get; } // 0x0000000185116340-0x00000001851163F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899D4D70-0x00000001899D4D90 */ get; } // 0x0000000185115130-0x00000001851151D0 

	// Methods
	// [XID] // 0x00000001899B6DD0-0x00000001899B6DF0
	public static void BuildMaxLevel() {} // 0x00000001851163F0-0x0000000185116940
	// [XID] // 0x00000001899BE890-0x00000001899BE8B0
	public static void Register() {} // 0x0000000185116C70-0x0000000185116D10
	// [XID] // 0x00000001899CD870-0x00000001899CD890
	public static PlayerLevelExcelConfig GetData(uint level) => default; // 0x0000000185114FF0-0x0000000185115130
	// [XID] // 0x00000001899DC470-0x00000001899DC490
	public static void LoadData() {} // 0x00000001851157C0-0x00000001851158B0
	// [XID] // 0x00000001899E3C90-0x00000001899E3CB0
	private static void RegisterHotfixGenerated() {} // 0x00000001851155F0-0x00000001851157C0
	// [XID] // 0x00000001899EB0A0-0x00000001899EB0C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001851151D0-0x0000000185115590
	// [IDTag] // 0x00000001899F2D00-0x00000001899F2D40
	// [XID] // 0x00000001899F2D00-0x00000001899F2D40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185115CA0-0x0000000185115DA0
	// [XID] // 0x00000001899FD230-0x00000001899FD250
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PlayerLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185116940-0x0000000185116C70
	// [XID] // 0x0000000189A047F0-0x0000000189A04810
	private static bool ParseConfigFromLine(string line, out PlayerLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001851158B0-0x00000001851159F0
	// [IDTag] // 0x0000000189A0BF50-0x0000000189A0BF90
	// [XID] // 0x0000000189A0BF50-0x0000000189A0BF90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PlayerLevelExcelConfig> configList) => default; // 0x00000001851159F0-0x0000000185115CA0
	// [IDTag] // 0x0000000189A16520-0x0000000189A16560
	// [XID] // 0x0000000189A16520-0x0000000189A16560
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8EA */, bool useObjectPool = false /* Metadata: 0x00AEF8EE */) => default; // 0x0000000185115DA0-0x0000000185115FF0
	// [IDTag] // 0x0000000189A209F0-0x0000000189A20A30
	// [XID] // 0x0000000189A209F0-0x0000000189A20A30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8EF */, bool useObjectPool = false /* Metadata: 0x00AEF8F3 */) => default; // 0x0000000185115FF0-0x0000000185116340
}

