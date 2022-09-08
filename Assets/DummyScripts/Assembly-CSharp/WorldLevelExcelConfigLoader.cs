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

public static class WorldLevelExcelConfigLoader // TypeDefIndex: 16097
{
	// Fields
	private static Dictionary<uint, WorldLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WorldLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WorldLevelExcelConfig, WorldLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WorldLevelExcelConfig>, Dictionary<uint, WorldLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WorldLevelExcelConfig> dataDict { /* [XID] */ /* 0x00000001899CA400-0x00000001899CA420 */ get; } // 0x0000000182FAD640-0x0000000182FAD6F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899D90F0-0x00000001899D9110 */ get; } // 0x0000000182FAC490-0x0000000182FAC530 

	// Methods
	// [XID] // 0x00000001899C3020-0x00000001899C3040
	public static void Register() {} // 0x0000000182FADA20-0x0000000182FADAC0
	// [XID] // 0x0000000189876650-0x0000000189876670
	public static WorldLevelExcelConfig GetData(uint level) => default; // 0x0000000182FAC360-0x0000000182FAC490
	// [XID] // 0x00000001899E08A0-0x00000001899E08C0
	public static void LoadData() {} // 0x0000000182FACAC0-0x0000000182FACBB0
	// [XID] // 0x00000001899E8380-0x00000001899E83A0
	private static void RegisterHotfixGenerated() {} // 0x0000000182FAC8F0-0x0000000182FACAC0
	// [XID] // 0x00000001899EF990-0x00000001899EF9B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182FAC530-0x0000000182FAC8F0
	// [IDTag] // 0x00000001899F7150-0x00000001899F7190
	// [XID] // 0x00000001899F7150-0x00000001899F7190
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182FACFA0-0x0000000182FAD0A0
	// [XID] // 0x0000000189A013D0-0x0000000189A013F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WorldLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182FAD6F0-0x0000000182FADA20
	// [XID] // 0x0000000189A08D50-0x0000000189A08D70
	private static bool ParseConfigFromLine(string line, out WorldLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182FACBB0-0x0000000182FACCF0
	// [IDTag] // 0x0000000189A102F0-0x0000000189A10330
	// [XID] // 0x0000000189A102F0-0x0000000189A10330
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WorldLevelExcelConfig> configList) => default; // 0x0000000182FACCF0-0x0000000182FACFA0
	// [IDTag] // 0x0000000189A1A6F0-0x0000000189A1A730
	// [XID] // 0x0000000189A1A6F0-0x0000000189A1A730
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF302C */, bool useObjectPool = false /* Metadata: 0x00AF3030 */) => default; // 0x0000000182FAD0A0-0x0000000182FAD2F0
	// [IDTag] // 0x0000000189A24CD0-0x0000000189A24D10
	// [XID] // 0x0000000189A24CD0-0x0000000189A24D10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3031 */, bool useObjectPool = false /* Metadata: 0x00AF3035 */) => default; // 0x0000000182FAD2F0-0x0000000182FAD640
}

