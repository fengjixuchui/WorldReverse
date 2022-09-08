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

public static class DungeonEntryExcelConfigLoader // TypeDefIndex: 14863
{
	// Fields
	private static Dictionary<uint, uint> _dungeonEntryID2IndexDic; // 0x00
	private static Dictionary<uint, uint> _dungeonEntryID2DefaultDic; // 0x08
	private static Dictionary<uint, DungeonEntryExcelConfig> _dataDict; // 0x10
	public static Action<List<DataHotfixMeta>, List<DungeonEntryExcelConfig>> customApplyHotfixAction; // 0x18
	public static Action<DungeonEntryExcelConfig, DungeonEntryExcelConfig> onUpdateConfig; // 0x20
	public static Action onApplyHotfixFinish; // 0x28
	public static Func<List<DataHotfixMeta>, List<DungeonEntryExcelConfig>, Dictionary<uint, DungeonEntryExcelConfig>, string, bool> customValidateFunc; // 0x30

	// Properties
	public static Dictionary<uint, DungeonEntryExcelConfig> dataDict { /* [XID] */ /* 0x000000018961DF30-0x000000018961DF50 */ get; } // 0x0000000183A1CDE0-0x0000000183A1CEB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018962CB70-0x000000018962CB90 */ get; } // 0x0000000183A1B2B0-0x0000000183A1B350 

	// Constructors
	static DungeonEntryExcelConfigLoader() {} // 0x0000000183A1D610-0x0000000183A1D680

	// Methods
	// [XID] // 0x00000001895F0F80-0x00000001895F0FA0
	public static string GetDungeonEntryDescription(DungunEntryType type) => default; // 0x0000000183A1B520-0x0000000183A1B6A0
	// [XID] // 0x00000001895F8A50-0x00000001895F8A70
	public static void BuildDungeonEntryID2IndexDic() {} // 0x0000000183A1CEB0-0x0000000183A1D200
	// [XID] // 0x000000018999C2B0-0x000000018999C2D0
	public static uint GetDungeonEntryIndex(uint dungeonEntryId) => default; // 0x0000000183A1C6A0-0x0000000183A1C7A0
	// [XID] // 0x00000001896075A0-0x00000001896075C0
	public static void SetDefaultDungeonID(uint entryId, uint dungeonId) {} // 0x0000000183A1B6A0-0x0000000183A1B830
	// [XID] // 0x000000018960F0A0-0x000000018960F0C0
	public static uint GetDefaultDungeonID(uint entryId) => default; // 0x0000000183A1B350-0x0000000183A1B520
	// [XID] // 0x00000001896166E0-0x0000000189616700
	public static void Register() {} // 0x0000000183A1D550-0x0000000183A1D610
	// [XID] // 0x0000000189625390-0x00000001896253B0
	public static DungeonEntryExcelConfig GetData(uint id) => default; // 0x0000000183A1B110-0x0000000183A1B2B0
	// [XID] // 0x0000000189634850-0x0000000189634870
	public static void LoadData() {} // 0x0000000183A1BF80-0x0000000183A1C0B0
	// [XID] // 0x000000018963BF60-0x000000018963BF80
	private static void RegisterHotfixGenerated() {} // 0x0000000183A1BD10-0x0000000183A1BF80
	// [XID] // 0x00000001896436A0-0x00000001896436C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183A1B830-0x0000000183A1BD10
	// [IDTag] // 0x000000018964AC80-0x000000018964ACC0
	// [XID] // 0x000000018964AC80-0x000000018964ACC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183A1C1F0-0x0000000183A1C350
	// [XID] // 0x0000000189655580-0x00000001896555A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonEntryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183A1D200-0x0000000183A1D550
	// [XID] // 0x000000018965CD40-0x000000018965CD60
	private static bool ParseConfigFromLine(string line, out DungeonEntryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183A1C0B0-0x0000000183A1C1F0
	// [IDTag] // 0x0000000189664240-0x0000000189664280
	// [XID] // 0x0000000189664240-0x0000000189664280
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonEntryExcelConfig> configList) => default; // 0x0000000183A1C350-0x0000000183A1C6A0
	// [IDTag] // 0x000000018966ED60-0x000000018966EDA0
	// [XID] // 0x000000018966ED60-0x000000018966EDA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF825 */, bool useObjectPool = false /* Metadata: 0x00AEF829 */) => default; // 0x0000000183A1C7A0-0x0000000183A1CA50
	// [IDTag] // 0x0000000189679A10-0x0000000189679A50
	// [XID] // 0x0000000189679A10-0x0000000189679A50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF82A */, bool useObjectPool = false /* Metadata: 0x00AEF82E */) => default; // 0x0000000183A1CA50-0x0000000183A1CDE0
}

