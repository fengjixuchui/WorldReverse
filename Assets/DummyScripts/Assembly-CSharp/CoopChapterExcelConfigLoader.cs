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

public static class CoopChapterExcelConfigLoader // TypeDefIndex: 14858
{
	// Fields
	private static Dictionary<uint, CoopChapterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CoopChapterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CoopChapterExcelConfig, CoopChapterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CoopChapterExcelConfig>, Dictionary<uint, CoopChapterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CoopChapterExcelConfig> dataDict { /* [XID] */ /* 0x00000001897EAA80-0x00000001897EAAA0 */ get; } // 0x0000000183A64650-0x0000000183A64700 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897F9FE0-0x00000001897FA000 */ get; } // 0x0000000183A630B0-0x0000000183A63150 

	// Methods
	// [XID] // 0x00000001897ADE50-0x00000001897ADE70
	public static uint GetConfidenceValueLimit(uint configId) => default; // 0x0000000183A64960-0x0000000183A64A90
	// [XID] // 0x00000001897B5F30-0x00000001897B5F50
	public static string GetChapterTitle(uint configId) => default; // 0x0000000183A636E0-0x0000000183A63810
	// [XID] // 0x00000001897BDD40-0x00000001897BDD60
	public static string GetChapterIcon(uint configId) => default; // 0x0000000183A64700-0x0000000183A64830
	// [XID] // 0x00000001897C5100-0x00000001897C5120
	public static uint GetAvatarId(uint configId) => default; // 0x0000000183A64830-0x0000000183A64960
	// [XID] // 0x00000001897CC950-0x00000001897CC970
	public static uint GetAvatarSortId(uint configId) => default; // 0x0000000183A64A90-0x0000000183A64BC0
	// [XID] // 0x00000001897D4120-0x00000001897D4140
	public static uint GetChapterSortId(uint configId) => default; // 0x0000000183A63BD0-0x0000000183A63D00
	// [XID] // 0x00000001897DBA10-0x00000001897DBA30
	public static string GetChapterLockReasonString(uint configId, uint reason) => default; // 0x0000000183A63A40-0x0000000183A63BD0
	// [XID] // 0x00000001897E3320-0x00000001897E3340
	public static void Register() {} // 0x0000000183A64EF0-0x0000000183A64F90
	// [XID] // 0x00000001897F27F0-0x00000001897F2810
	public static CoopChapterExcelConfig GetData(uint id) => default; // 0x0000000183A62F80-0x0000000183A630B0
	// [XID] // 0x00000001898015A0-0x00000001898015C0
	public static void LoadData() {} // 0x0000000183A63810-0x0000000183A63900
	// [XID] // 0x0000000189808A40-0x0000000189808A60
	private static void RegisterHotfixGenerated() {} // 0x0000000183A63510-0x0000000183A636E0
	// [XID] // 0x0000000189810410-0x0000000189810430
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183A63150-0x0000000183A63510
	// [IDTag] // 0x0000000189817B20-0x0000000189817B60
	// [XID] // 0x0000000189817B20-0x0000000189817B60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183A63D00-0x0000000183A63E00
	// [XID] // 0x0000000189822410-0x0000000189822430
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopChapterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183A64BC0-0x0000000183A64EF0
	// [XID] // 0x00000001898298F0-0x0000000189829910
	private static bool ParseConfigFromLine(string line, out CoopChapterExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183A63900-0x0000000183A63A40
	// [IDTag] // 0x0000000189830E60-0x0000000189830EA0
	// [XID] // 0x0000000189830E60-0x0000000189830EA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopChapterExcelConfig> configList) => default; // 0x0000000183A63E00-0x0000000183A640B0
	// [IDTag] // 0x000000018983B3A0-0x000000018983B3E0
	// [XID] // 0x000000018983B3A0-0x000000018983B3E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF7F9 */, bool useObjectPool = false /* Metadata: 0x00AEF7FD */) => default; // 0x0000000183A64400-0x0000000183A64650
	// [IDTag] // 0x0000000189845B10-0x0000000189845B50
	// [XID] // 0x0000000189845B10-0x0000000189845B50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7FE */, bool useObjectPool = false /* Metadata: 0x00AEF802 */) => default; // 0x0000000183A640B0-0x0000000183A64400
}

