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

public static class DungeonRosterConfigLoader // TypeDefIndex: 15560
{
	// Fields
	private static Dictionary<uint, DungeonRosterConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonRosterConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonRosterConfig, DungeonRosterConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonRosterConfig>, Dictionary<uint, DungeonRosterConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonRosterConfig> dataDict { /* [XID] */ /* 0x00000001899B9BF0-0x00000001899B9C10 */ get; } // 0x00000001830F4B00-0x00000001830F4BB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899C8CC0-0x00000001899C8CE0 */ get; } // 0x00000001830F3950-0x00000001830F39F0 

	// Methods
	// [XID] // 0x00000001899B2A90-0x00000001899B2AB0
	public static void Register() {} // 0x00000001830F4EE0-0x00000001830F4F80
	// [XID] // 0x00000001899C1750-0x00000001899C1770
	public static DungeonRosterConfig GetData(uint id) => default; // 0x00000001830F3820-0x00000001830F3950
	// [XID] // 0x00000001899D06B0-0x00000001899D06D0
	public static void LoadData() {} // 0x00000001830F3F80-0x00000001830F4070
	// [XID] // 0x00000001899D7B90-0x00000001899D7BB0
	private static void RegisterHotfixGenerated() {} // 0x00000001830F3DB0-0x00000001830F3F80
	// [XID] // 0x00000001899DF070-0x00000001899DF090
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001830F39F0-0x00000001830F3DB0
	// [IDTag] // 0x00000001899E6D10-0x00000001899E6D50
	// [XID] // 0x00000001899E6D10-0x00000001899E6D50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001830F4460-0x00000001830F4560
	// [XID] // 0x00000001899F1130-0x00000001899F1150
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonRosterConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001830F4BB0-0x00000001830F4EE0
	// [XID] // 0x00000001899F89F0-0x00000001899F8A10
	private static bool ParseConfigFromLine(string line, out DungeonRosterConfig data) {
		data = default;
		return default;
	} // 0x00000001830F4070-0x00000001830F41B0
	// [IDTag] // 0x00000001899FFF40-0x00000001899FFF80
	// [XID] // 0x00000001899FFF40-0x00000001899FFF80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonRosterConfig> configList) => default; // 0x00000001830F41B0-0x00000001830F4460
	// [IDTag] // 0x0000000189A0A620-0x0000000189A0A660
	// [XID] // 0x0000000189A0A620-0x0000000189A0A660
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F16 */, bool useObjectPool = false /* Metadata: 0x00AF1F1A */) => default; // 0x00000001830F4560-0x00000001830F47B0
	// [IDTag] // 0x0000000189A14E40-0x0000000189A14E80
	// [XID] // 0x0000000189A14E40-0x0000000189A14E80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F1B */, bool useObjectPool = false /* Metadata: 0x00AF1F1F */) => default; // 0x00000001830F47B0-0x00000001830F4B00
}

