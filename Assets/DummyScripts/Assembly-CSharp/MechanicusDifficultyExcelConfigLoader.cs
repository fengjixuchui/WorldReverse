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

public static class MechanicusDifficultyExcelConfigLoader // TypeDefIndex: 14920
{
	// Fields
	private static List<MechanicusDifficultyExcelConfig> configList; // 0x00
	private static Dictionary<uint, MechanicusDifficultyExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MechanicusDifficultyExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<MechanicusDifficultyExcelConfig, MechanicusDifficultyExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MechanicusDifficultyExcelConfig>, Dictionary<uint, MechanicusDifficultyExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, MechanicusDifficultyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B40540-0x0000000189B40560 */ get; } // 0x0000000182B64240-0x0000000182B642F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B4F670-0x0000000189B4F690 */ get; } // 0x0000000182B62AD0-0x0000000182B62B70 

	// Methods
	// [XID] // 0x0000000189B22A10-0x0000000189B22A30
	private static void BuildData() {} // 0x0000000182B62B70-0x0000000182B62EB0
	// [XID] // 0x0000000189B2A080-0x0000000189B2A0A0
	public static List<MechanicusDifficultyExcelConfig> GetDifficultDataList() => default; // 0x0000000182B628C0-0x0000000182B62990
	// [XID] // 0x0000000189B31770-0x0000000189B31790
	public static uint GetDifficultLevelByDungeonID(uint dungeonID) => default; // 0x0000000182B63670-0x0000000182B638F0
	// [XID] // 0x0000000189B38B10-0x0000000189B38B30
	public static void Register() {} // 0x0000000182B64620-0x0000000182B646C0
	// [XID] // 0x0000000189B47EE0-0x0000000189B47F00
	public static MechanicusDifficultyExcelConfig GetData(uint level) => default; // 0x0000000182B62990-0x0000000182B62AD0
	// [XID] // 0x0000000189B56F10-0x0000000189B56F30
	public static void LoadData() {} // 0x0000000182B63440-0x0000000182B63530
	// [XID] // 0x0000000189B5E880-0x0000000189B5E8A0
	private static void RegisterHotfixGenerated() {} // 0x0000000182B63270-0x0000000182B63440
	// [XID] // 0x0000000189B65E00-0x0000000189B65E20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B62EB0-0x0000000182B63270
	// [IDTag] // 0x0000000189B6D3E0-0x0000000189B6D420
	// [XID] // 0x0000000189B6D3E0-0x0000000189B6D420
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B638F0-0x0000000182B639F0
	// [XID] // 0x0000000189B77930-0x0000000189B77950
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusDifficultyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B642F0-0x0000000182B64620
	// [XID] // 0x0000000189B7EF80-0x0000000189B7EFA0
	private static bool ParseConfigFromLine(string line, out MechanicusDifficultyExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B63530-0x0000000182B63670
	// [IDTag] // 0x0000000189B86B40-0x0000000189B86B80
	// [XID] // 0x0000000189B86B40-0x0000000189B86B80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusDifficultyExcelConfig> configList) => default; // 0x0000000182B639F0-0x0000000182B63CA0
	// [IDTag] // 0x0000000189B90F50-0x0000000189B90F90
	// [XID] // 0x0000000189B90F50-0x0000000189B90F90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9FB */, bool useObjectPool = false /* Metadata: 0x00AEF9FF */) => default; // 0x0000000182B63CA0-0x0000000182B63EF0
	// [IDTag] // 0x0000000189B9B240-0x0000000189B9B280
	// [XID] // 0x0000000189B9B240-0x0000000189B9B280
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA00 */, bool useObjectPool = false /* Metadata: 0x00AEFA04 */) => default; // 0x0000000182B63EF0-0x0000000182B64240
}

