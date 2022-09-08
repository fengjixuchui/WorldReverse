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

public static class BattlePassLevelExcelConfigLoader // TypeDefIndex: 14838
{
	// Fields
	private static uint _maxLevel; // 0x00
	private static Dictionary<uint, BattlePassLevelExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<BattlePassLevelExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<BattlePassLevelExcelConfig, BattlePassLevelExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<BattlePassLevelExcelConfig>, Dictionary<uint, BattlePassLevelExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static uint maxLevel { /* [XID] */ /* 0x00000001896ADB70-0x00000001896ADB90 */ get; } // 0x0000000183D20930-0x0000000183D20A00 
	public static Dictionary<uint, BattlePassLevelExcelConfig> dataDict { /* [XID] */ /* 0x00000001896C3BC0-0x00000001896C3BE0 */ get; } // 0x0000000183D219D0-0x0000000183D21AA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896D2680-0x00000001896D26A0 */ get; } // 0x0000000183D20150-0x0000000183D201F0 

	// Constructors
	static BattlePassLevelExcelConfigLoader() {} // 0x0000000183D21EB0-0x0000000183D21F10

	// Methods
	// [XID] // 0x00000001896B5370-0x00000001896B5390
	public static void BuildData() {} // 0x0000000183D201F0-0x0000000183D20450
	// [XID] // 0x00000001896BC580-0x00000001896BC5A0
	public static void Register() {} // 0x0000000183D21DF0-0x0000000183D21EB0
	// [XID] // 0x00000001896CB070-0x00000001896CB090
	public static BattlePassLevelExcelConfig GetData(uint level) => default; // 0x0000000183D1FFB0-0x0000000183D20150
	// [XID] // 0x00000001896DA130-0x00000001896DA150
	public static void LoadData() {} // 0x0000000183D20C70-0x0000000183D20DA0
	// [XID] // 0x00000001896E1750-0x00000001896E1770
	private static void RegisterHotfixGenerated() {} // 0x0000000183D20A00-0x0000000183D20C70
	// [XID] // 0x00000001896E8B00-0x00000001896E8B20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183D20450-0x0000000183D20930
	// [IDTag] // 0x00000001896EFE40-0x00000001896EFE80
	// [XID] // 0x00000001896EFE40-0x00000001896EFE80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183D21230-0x0000000183D21390
	// [XID] // 0x00000001896FA870-0x00000001896FA890
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BattlePassLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183D21AA0-0x0000000183D21DF0
	// [XID] // 0x0000000189701F00-0x0000000189701F20
	private static bool ParseConfigFromLine(string line, out BattlePassLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183D20DA0-0x0000000183D20EE0
	// [IDTag] // 0x00000001897097A0-0x00000001897097E0
	// [XID] // 0x00000001897097A0-0x00000001897097E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BattlePassLevelExcelConfig> configList) => default; // 0x0000000183D20EE0-0x0000000183D21230
	// [IDTag] // 0x0000000189713E80-0x0000000189713EC0
	// [XID] // 0x0000000189713E80-0x0000000189713EC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF724 */, bool useObjectPool = false /* Metadata: 0x00AEF728 */) => default; // 0x0000000183D21390-0x0000000183D21640
	// [IDTag] // 0x000000018971E520-0x000000018971E560
	// [XID] // 0x000000018971E520-0x000000018971E560
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF729 */, bool useObjectPool = false /* Metadata: 0x00AEF72D */) => default; // 0x0000000183D21640-0x0000000183D219D0
}

