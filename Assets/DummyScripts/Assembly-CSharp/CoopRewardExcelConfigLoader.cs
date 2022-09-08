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

public static class CoopRewardExcelConfigLoader // TypeDefIndex: 14857
{
	// Fields
	private static Dictionary<uint, CoopRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CoopRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CoopRewardExcelConfig, CoopRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CoopRewardExcelConfig>, Dictionary<uint, CoopRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CoopRewardExcelConfig> dataDict { /* [XID] */ /* 0x0000000189739010-0x0000000189739030 */ get; } // 0x0000000184B88840-0x0000000184B888F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189748320-0x0000000189748340 */ get; } // 0x0000000184B87560-0x0000000184B87600 

	// Methods
	// [XID] // 0x0000000189722A40-0x0000000189722A60
	public static uint GetSortId(uint configId) => default; // 0x0000000184B88170-0x0000000184B882A0
	// [XID] // 0x000000018972A1A0-0x000000018972A1C0
	public static uint GetChapterId(uint configId) => default; // 0x0000000184B88C20-0x0000000184B88D50
	// [XID] // 0x0000000189731820-0x0000000189731840
	public static void Register() {} // 0x0000000184B88D50-0x0000000184B88DF0
	// [XID] // 0x0000000189740DC0-0x0000000189740DE0
	public static CoopRewardExcelConfig GetData(uint id) => default; // 0x0000000184B87430-0x0000000184B87560
	// [XID] // 0x000000018974FBF0-0x000000018974FC10
	public static void LoadData() {} // 0x0000000184B87B90-0x0000000184B87C80
	// [XID] // 0x00000001897571E0-0x0000000189757200
	private static void RegisterHotfixGenerated() {} // 0x0000000184B879C0-0x0000000184B87B90
	// [XID] // 0x000000018975E7B0-0x000000018975E7D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184B87600-0x0000000184B879C0
	// [IDTag] // 0x0000000189765D70-0x0000000189765DB0
	// [XID] // 0x0000000189765D70-0x0000000189765DB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184B87DC0-0x0000000184B87EC0
	// [XID] // 0x0000000189770470-0x0000000189770490
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184B888F0-0x0000000184B88C20
	// [XID] // 0x0000000189777B50-0x0000000189777B70
	private static bool ParseConfigFromLine(string line, out CoopRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184B87C80-0x0000000184B87DC0
	// [IDTag] // 0x000000018977F200-0x000000018977F240
	// [XID] // 0x000000018977F200-0x000000018977F240
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopRewardExcelConfig> configList) => default; // 0x0000000184B87EC0-0x0000000184B88170
	// [IDTag] // 0x00000001897899C0-0x0000000189789A00
	// [XID] // 0x00000001897899C0-0x0000000189789A00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF7EF */, bool useObjectPool = false /* Metadata: 0x00AEF7F3 */) => default; // 0x0000000184B882A0-0x0000000184B884F0
	// [IDTag] // 0x0000000189793DE0-0x0000000189793E20
	// [XID] // 0x0000000189793DE0-0x0000000189793E20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7F4 */, bool useObjectPool = false /* Metadata: 0x00AEF7F8 */) => default; // 0x0000000184B884F0-0x0000000184B88840
}

