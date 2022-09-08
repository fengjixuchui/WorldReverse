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

public static class AsterMidDifficultyExcelConfigLoader // TypeDefIndex: 15020
{
	// Fields
	private static Dictionary<uint, AsterMidDifficultyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AsterMidDifficultyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AsterMidDifficultyExcelConfig, AsterMidDifficultyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AsterMidDifficultyExcelConfig>, Dictionary<uint, AsterMidDifficultyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AsterMidDifficultyExcelConfig> dataDict { /* [XID] */ /* 0x000000018976A5B0-0x000000018976A5D0 */ get; } // 0x00000001820B8F00-0x00000001820B8FB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189779440-0x0000000189779460 */ get; } // 0x00000001820B7D50-0x00000001820B7DF0 

	// Methods
	// [XID] // 0x0000000189762EF0-0x0000000189762F10
	public static void Register() {} // 0x00000001820B92E0-0x00000001820B9380
	// [XID] // 0x0000000189771D30-0x0000000189771D50
	public static AsterMidDifficultyExcelConfig GetData(uint id) => default; // 0x00000001820B7C20-0x00000001820B7D50
	// [XID] // 0x0000000189780D20-0x0000000189780D40
	public static void LoadData() {} // 0x00000001820B8380-0x00000001820B8470
	// [XID] // 0x0000000189788280-0x00000001897882A0
	private static void RegisterHotfixGenerated() {} // 0x00000001820B81B0-0x00000001820B8380
	// [XID] // 0x000000018978F8A0-0x000000018978F8C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001820B7DF0-0x00000001820B81B0
	// [IDTag] // 0x0000000189797090-0x00000001897970D0
	// [XID] // 0x0000000189797090-0x00000001897970D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820B85B0-0x00000001820B86B0
	// [XID] // 0x00000001897A1E20-0x00000001897A1E40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterMidDifficultyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001820B8FB0-0x00000001820B92E0
	// [XID] // 0x00000001897A9640-0x00000001897A9660
	private static bool ParseConfigFromLine(string line, out AsterMidDifficultyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001820B8470-0x00000001820B85B0
	// [IDTag] // 0x00000001897B0E00-0x00000001897B0E40
	// [XID] // 0x00000001897B0E00-0x00000001897B0E40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterMidDifficultyExcelConfig> configList) => default; // 0x00000001820B86B0-0x00000001820B8960
	// [IDTag] // 0x00000001897BC310-0x00000001897BC350
	// [XID] // 0x00000001897BC310-0x00000001897BC350
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFEA8 */, bool useObjectPool = false /* Metadata: 0x00AEFEAC */) => default; // 0x00000001820B8960-0x00000001820B8BB0
	// [IDTag] // 0x00000001897C6BC0-0x00000001897C6C00
	// [XID] // 0x00000001897C6BC0-0x00000001897C6C00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEAD */, bool useObjectPool = false /* Metadata: 0x00AEFEB1 */) => default; // 0x00000001820B8BB0-0x00000001820B8F00
}

