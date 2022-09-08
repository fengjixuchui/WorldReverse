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

public static class BattlePassStoryExcelConfigLoader // TypeDefIndex: 15256
{
	// Fields
	private static Dictionary<uint, BattlePassStoryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BattlePassStoryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BattlePassStoryExcelConfig, BattlePassStoryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BattlePassStoryExcelConfig>, Dictionary<uint, BattlePassStoryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BattlePassStoryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189916340-0x0000000189916360 */ get; } // 0x0000000182CA0DD0-0x0000000182CA0E80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189925420-0x0000000189925440 */ get; } // 0x0000000182C9FC20-0x0000000182C9FCC0 

	// Methods
	// [XID] // 0x000000018990EBF0-0x000000018990EC10
	public static void Register() {} // 0x0000000182CA11B0-0x0000000182CA1250
	// [XID] // 0x000000018991DC90-0x000000018991DCB0
	public static BattlePassStoryExcelConfig GetData(uint id) => default; // 0x0000000182C9FAF0-0x0000000182C9FC20
	// [XID] // 0x000000018992CA00-0x000000018992CA20
	public static void LoadData() {} // 0x0000000182CA0250-0x0000000182CA0340
	// [XID] // 0x0000000189934000-0x0000000189934020
	private static void RegisterHotfixGenerated() {} // 0x0000000182CA0080-0x0000000182CA0250
	// [XID] // 0x000000018993BC10-0x000000018993BC30
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182C9FCC0-0x0000000182CA0080
	// [IDTag] // 0x0000000189942D70-0x0000000189942DB0
	// [XID] // 0x0000000189942D70-0x0000000189942DB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182CA0730-0x0000000182CA0830
	// [XID] // 0x000000018994D5D0-0x000000018994D5F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BattlePassStoryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182CA0E80-0x0000000182CA11B0
	// [XID] // 0x0000000189954D20-0x0000000189954D40
	private static bool ParseConfigFromLine(string line, out BattlePassStoryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182CA0340-0x0000000182CA0480
	// [IDTag] // 0x000000018995C500-0x000000018995C540
	// [XID] // 0x000000018995C500-0x000000018995C540
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BattlePassStoryExcelConfig> configList) => default; // 0x0000000182CA0480-0x0000000182CA0730
	// [IDTag] // 0x0000000189967010-0x0000000189967050
	// [XID] // 0x0000000189967010-0x0000000189967050
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF055A */, bool useObjectPool = false /* Metadata: 0x00AF055E */) => default; // 0x0000000182CA0B80-0x0000000182CA0DD0
	// [IDTag] // 0x0000000189971A80-0x0000000189971AC0
	// [XID] // 0x0000000189971A80-0x0000000189971AC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF055F */, bool useObjectPool = false /* Metadata: 0x00AF0563 */) => default; // 0x0000000182CA0830-0x0000000182CA0B80
}

