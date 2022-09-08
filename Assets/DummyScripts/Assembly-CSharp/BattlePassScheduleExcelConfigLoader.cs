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

public static class BattlePassScheduleExcelConfigLoader // TypeDefIndex: 15250
{
	// Fields
	private static Dictionary<uint, BattlePassScheduleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BattlePassScheduleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BattlePassScheduleExcelConfig, BattlePassScheduleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BattlePassScheduleExcelConfig>, Dictionary<uint, BattlePassScheduleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BattlePassScheduleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BA2930-0x0000000189BA2950 */ get; } // 0x0000000183566020-0x00000001835660D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BB1610-0x0000000189BB1630 */ get; } // 0x0000000183564E70-0x0000000183564F10 

	// Methods
	// [XID] // 0x0000000189B9B080-0x0000000189B9B0A0
	public static void Register() {} // 0x0000000183566400-0x00000001835664A0
	// [XID] // 0x0000000189BA9DA0-0x0000000189BA9DC0
	public static BattlePassScheduleExcelConfig GetData(uint id) => default; // 0x0000000183564D40-0x0000000183564E70
	// [XID] // 0x0000000189BB8580-0x0000000189BB85A0
	public static void LoadData() {} // 0x00000001835654A0-0x0000000183565590
	// [XID] // 0x0000000189BBFF10-0x0000000189BBFF30
	private static void RegisterHotfixGenerated() {} // 0x00000001835652D0-0x00000001835654A0
	// [XID] // 0x0000000189BC79A0-0x0000000189BC79C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183564F10-0x00000001835652D0
	// [IDTag] // 0x0000000189BCF4B0-0x0000000189BCF4F0
	// [XID] // 0x0000000189BCF4B0-0x0000000189BCF4F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183565980-0x0000000183565A80
	// [XID] // 0x0000000189BD9A80-0x0000000189BD9AA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BattlePassScheduleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001835660D0-0x0000000183566400
	// [XID] // 0x00000001895E6550-0x00000001895E6570
	private static bool ParseConfigFromLine(string line, out BattlePassScheduleExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183565590-0x00000001835656D0
	// [IDTag] // 0x00000001895EDF70-0x00000001895EDFB0
	// [XID] // 0x00000001895EDF70-0x00000001895EDFB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BattlePassScheduleExcelConfig> configList) => default; // 0x00000001835656D0-0x0000000183565980
	// [IDTag] // 0x00000001895F8910-0x00000001895F8950
	// [XID] // 0x00000001895F8910-0x00000001895F8950
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0532 */, bool useObjectPool = false /* Metadata: 0x00AF0536 */) => default; // 0x0000000183565DD0-0x0000000183566020
	// [IDTag] // 0x0000000189602E10-0x0000000189602E50
	// [XID] // 0x0000000189602E10-0x0000000189602E50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0537 */, bool useObjectPool = false /* Metadata: 0x00AF053B */) => default; // 0x0000000183565A80-0x0000000183565DD0
}

