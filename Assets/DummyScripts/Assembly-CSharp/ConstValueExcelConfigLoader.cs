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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ConstValueExcelConfigLoader // TypeDefIndex: 14850
{
	// Fields
	public static float CONST_VALUE_DEFENSE_RESIST_RATIO_A1; // 0x00
	public static float CONST_VALUE_DEFENSE_RESIST_RATIO_B1; // 0x04
	public static float CONST_VALUE_DEFENSE_RESIST_RATIO_C; // 0x08
	public static float CONST_VALUE_CRITICAL_LIMIT_MIN; // 0x0C
	public static float CONST_VALUE_CRITICAL_LIMIT_MAX; // 0x10
	public static int CONST_VALUE_ELEMENTREACTION_AREALEVELDELTA_LIMIT; // 0x14
	public static float CONST_VALUE_SUPERCONDUCTOR_DURABILITY; // 0x18
	public static float CONST_VALUE_SWIRL_MAX; // 0x1C
	public static float CONST_VALUE_SWIRL_SUB; // 0x20
	public static float[] CONST_CRASH_PARAM; // 0x28
	public static Vector3 CONST_CRASH_VECTOR; // 0x30
	public static float CONST_VALUE_ELEMENT_MASTERY_C1; // 0x3C
	public static float CONST_VALUE_ELEMENT_MASTERY_C2; // 0x40
	public static float CONST_VALUE_ELEMENT_MASTERY_C3; // 0x44
	public static float CONST_VALUE_ELEMENT_MASTERY_C4; // 0x48
	public static float CONST_VALUE_WORLD_LEVEL_FORMULA_N; // 0x4C
	public static float CONST_VALUE_WORLD_LEVEL_FORMULA_M; // 0x50
	public static float CONST_VALUE_WORLD_LEVEL_FORMULA_B; // 0x54
	public static Dictionary<int, int> CONST_VALUE_LIMIT_REGION_OPENSTATE_INDEX_DIC; // 0x58
	public static List<Tuple<int, string>> CONST_VALUE_LIMIT_REGION_CONFIG_LIST; // 0x60
	public static Dictionary<string, int> CONST_VALUE_LIMIT_REGION_NAME_INDEX_DIC; // 0x68
	public static uint[] CONST_VALUE_SEA_LAMP_QUEST; // 0x70
	public static float CONST_VALUE_SPEECH_BUBBLE_DEFAULT_DURATION; // 0x78
	public static float CONST_VALUE_SPEECH_BUBBLE_EXTRA_DURATION; // 0x7C
	public static float CONST_VALUE_REMINDER_INTERRUPT_SHOW_DELAY; // 0x80
	public static float CONST_VALUE_ROOM_MINIMAP_DEFAULT_SCALE; // 0x84
	public static float CONST_VALUE_HOME_EXTERIOR_MINIMAP_DEFAULT_SCALE; // 0x88
	public static float CONST_VALUE_HOME_INTERIOR_MINIMAP_DEFAULT_SCALE; // 0x8C
	public static uint CONST_VALUE_DJINN_GADGET_ID; // 0x90
	public static uint CONST_VALUE_DJINN_MAIN_QUEST_ID; // 0x94
	public static uint CONST_VALUE_MAINHOUSE_ID; // 0x98
	public static uint CONST_VALUE_HOME_RESOURCE_PRODUCE_INTERVAL_HOMECOIN; // 0x9C
	public static uint CONST_VALUE_HOME_RESOURCE_PRODUCE_INTERVAL_COMPANIONSHIPEXP; // 0xA0
	private static Dictionary<int, ConstValueExcelConfig> _dataDict; // 0xA8
	public static Action<List<DataHotfixMeta>, List<ConstValueExcelConfig>> customApplyHotfixAction; // 0xB0
	public static Action<ConstValueExcelConfig, ConstValueExcelConfig> onUpdateConfig; // 0xB8
	public static Action onApplyHotfixFinish; // 0xC0
	public static Func<List<DataHotfixMeta>, List<ConstValueExcelConfig>, Dictionary<int, ConstValueExcelConfig>, string, bool> customValidateFunc; // 0xC8

	// Properties
	public static Dictionary<int, ConstValueExcelConfig> dataDict { /* [XID] */ /* 0x000000018987F160-0x000000018987F180 */ get; } // 0x0000000182148870-0x0000000182148940 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018988D900-0x000000018988D920 */ get; } // 0x0000000182145900-0x00000001821459A0 

	// Constructors
	static ConstValueExcelConfigLoader() {} // 0x0000000182148D50-0x0000000182148F90

	// Methods
	// [XID] // 0x0000000189852980-0x00000001898529A0
	public static void ParseData() {} // 0x0000000182146800-0x0000000182147BE0
	// [XID] // 0x000000018985A3F0-0x000000018985A410
	public static RewardItemConfig GetFirstShareRewardConfig() => default; // 0x0000000182148090-0x0000000182148220
	// [XID] // 0x0000000189861610-0x0000000189861630
	public static uint BlessingRewardNum() => default; // 0x00000001821459A0-0x0000000182145AB0
	// [XID] // 0x0000000189868DF0-0x0000000189868E10
	public static List<uint> BlessingRewardPreviewIdList() => default; // 0x0000000182145AB0-0x0000000182145CB0
	// [XID] // 0x0000000189870220-0x0000000189870240
	public static uint ExpeditionEnterRegionInterval() => default; // 0x0000000182146430-0x0000000182146590
	// [XID] // 0x0000000189877870-0x0000000189877890
	public static void Register() {} // 0x0000000182148C90-0x0000000182148D50
	// [XID] // 0x0000000189886760-0x0000000189886780
	public static ConstValueExcelConfig GetData(ConstValueType name) => default; // 0x0000000182145760-0x0000000182145900
	// [XID] // 0x0000000189895010-0x0000000189895030
	public static void LoadData() {} // 0x0000000182146590-0x00000001821466C0
	// [XID] // 0x000000018989C680-0x000000018989C6A0
	private static void RegisterHotfixGenerated() {} // 0x00000001821461B0-0x0000000182146430
	// [XID] // 0x00000001898A3E20-0x00000001898A3E40
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182145CB0-0x00000001821461B0
	// [IDTag] // 0x00000001898AB060-0x00000001898AB0A0
	// [XID] // 0x00000001898AB060-0x00000001898AB0A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182147BE0-0x0000000182147D40
	// [XID] // 0x00000001898B5AB0-0x00000001898B5AD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ConstValueExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182148940-0x0000000182148C90
	// [XID] // 0x00000001898BD500-0x00000001898BD520
	private static bool ParseConfigFromLine(string line, out ConstValueExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821466C0-0x0000000182146800
	// [IDTag] // 0x00000001898C4CA0-0x00000001898C4CE0
	// [XID] // 0x00000001898C4CA0-0x00000001898C4CE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ConstValueExcelConfig> configList) => default; // 0x0000000182147D40-0x0000000182148090
	// [IDTag] // 0x00000001898CF3B0-0x00000001898CF3F0
	// [XID] // 0x00000001898CF3B0-0x00000001898CF3F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF7B6 */, bool useObjectPool = false /* Metadata: 0x00AEF7BA */) => default; // 0x00000001821485C0-0x0000000182148870
	// [IDTag] // 0x00000001898D9BB0-0x00000001898D9BF0
	// [XID] // 0x00000001898D9BB0-0x00000001898D9BF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7BB */, bool useObjectPool = false /* Metadata: 0x00AEF7BF */) => default; // 0x0000000182148220-0x00000001821485C0
}

