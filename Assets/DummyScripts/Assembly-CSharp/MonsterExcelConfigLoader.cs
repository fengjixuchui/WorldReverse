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

public static class MonsterExcelConfigLoader // TypeDefIndex: 14876
{
	// Fields
	private static Dictionary<string, MonsterExcelConfig> _monsterNameDict; // 0x00
	private static Dictionary<uint, MonsterExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MonsterExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<MonsterExcelConfig, MonsterExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MonsterExcelConfig>, Dictionary<uint, MonsterExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<string, MonsterExcelConfig> monsterNameDict { /* [XID] */ /* 0x0000000189AB2100-0x0000000189AB2120 */ get; } // 0x000000018243CF80-0x000000018243D050 
	public static Dictionary<uint, MonsterExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AD0130-0x0000000189AD0150 */ get; } // 0x000000018243EAF0-0x000000018243EBC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ADFAD0-0x0000000189ADFAF0 */ get; } // 0x000000018243D1F0-0x000000018243D290 

	// Constructors
	static MonsterExcelConfigLoader() {} // 0x000000018243EFD0-0x000000018243F060

	// Methods
	// [XID] // 0x0000000189AB9370-0x0000000189AB9390
	public static MonsterExcelConfig GetDataByName(string monsterName) => default; // 0x000000018243DEF0-0x000000018243E000
	// [XID] // 0x0000000189AC0F90-0x0000000189AC0FB0
	public static void InitNameDic() {} // 0x000000018243D9E0-0x000000018243DC80
	// [XID] // 0x0000000189AC8970-0x0000000189AC8990
	public static void Register() {} // 0x000000018243EF10-0x000000018243EFD0
	// [XID] // 0x0000000189AD7EA0-0x0000000189AD7EC0
	public static MonsterExcelConfig GetData(uint id) => default; // 0x000000018243D050-0x000000018243D1F0
	// [XID] // 0x0000000189AE7110-0x0000000189AE7130
	public static void LoadData() {} // 0x000000018243DC80-0x000000018243DDB0
	// [XID] // 0x0000000189AEED80-0x0000000189AEEDA0
	private static void RegisterHotfixGenerated() {} // 0x000000018243D770-0x000000018243D9E0
	// [XID] // 0x0000000189AF6270-0x0000000189AF6290
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018243D290-0x000000018243D770
	// [IDTag] // 0x0000000189AFD930-0x0000000189AFD970
	// [XID] // 0x0000000189AFD930-0x0000000189AFD970
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018243E000-0x000000018243E160
	// [XID] // 0x0000000189B07F50-0x0000000189B07F70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018243EBC0-0x000000018243EF10
	// [XID] // 0x0000000189B0F870-0x0000000189B0F890
	private static bool ParseConfigFromLine(string line, out MonsterExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018243DDB0-0x000000018243DEF0
	// [IDTag] // 0x0000000189B16A50-0x0000000189B16A90
	// [XID] // 0x0000000189B16A50-0x0000000189B16A90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterExcelConfig> configList) => default; // 0x000000018243E160-0x000000018243E4B0
	// [IDTag] // 0x0000000189B210B0-0x0000000189B210F0
	// [XID] // 0x0000000189B210B0-0x0000000189B210F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8B3 */, bool useObjectPool = false /* Metadata: 0x00AEF8B7 */) => default; // 0x000000018243E4B0-0x000000018243E760
	// [IDTag] // 0x0000000189B2B6D0-0x0000000189B2B710
	// [XID] // 0x0000000189B2B6D0-0x0000000189B2B710
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8B8 */, bool useObjectPool = false /* Metadata: 0x00AEF8BC */) => default; // 0x000000018243E760-0x000000018243EAF0
}

