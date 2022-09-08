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

public static class DailyDungeonConfigLoader // TypeDefIndex: 15554
{
	// Fields
	private static Dictionary<uint, DailyDungeonConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DailyDungeonConfig>> customApplyHotfixAction; // 0x08
	public static Action<DailyDungeonConfig, DailyDungeonConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DailyDungeonConfig>, Dictionary<uint, DailyDungeonConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DailyDungeonConfig> dataDict { /* [XID] */ /* 0x0000000189686EB0-0x0000000189686ED0 */ get; } // 0x0000000182387200-0x00000001823872B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189696690-0x00000001896966B0 */ get; } // 0x0000000182386050-0x00000001823860F0 

	// Methods
	// [XID] // 0x000000018967F640-0x000000018967F660
	public static void Register() {} // 0x00000001823875E0-0x0000000182387680
	// [XID] // 0x000000018968ED30-0x000000018968ED50
	public static DailyDungeonConfig GetData(uint id) => default; // 0x0000000182385F20-0x0000000182386050
	// [XID] // 0x000000018969DD10-0x000000018969DD30
	public static void LoadData() {} // 0x0000000182386680-0x0000000182386770
	// [XID] // 0x00000001896A4D00-0x00000001896A4D20
	private static void RegisterHotfixGenerated() {} // 0x00000001823864B0-0x0000000182386680
	// [XID] // 0x00000001896AC530-0x00000001896AC550
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823860F0-0x00000001823864B0
	// [IDTag] // 0x00000001896B3790-0x00000001896B37D0
	// [XID] // 0x00000001896B3790-0x00000001896B37D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182386B60-0x0000000182386C60
	// [XID] // 0x00000001896BDA40-0x00000001896BDA60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DailyDungeonConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823872B0-0x00000001823875E0
	// [XID] // 0x00000001896C5230-0x00000001896C5250
	private static bool ParseConfigFromLine(string line, out DailyDungeonConfig data) {
		data = default;
		return default;
	} // 0x0000000182386770-0x00000001823868B0
	// [IDTag] // 0x00000001896CC830-0x00000001896CC870
	// [XID] // 0x00000001896CC830-0x00000001896CC870
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DailyDungeonConfig> configList) => default; // 0x00000001823868B0-0x0000000182386B60
	// [IDTag] // 0x00000001896D6D20-0x00000001896D6D60
	// [XID] // 0x00000001896D6D20-0x00000001896D6D60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1EEE */, bool useObjectPool = false /* Metadata: 0x00AF1EF2 */) => default; // 0x0000000182386FB0-0x0000000182387200
	// [IDTag] // 0x00000001896E1570-0x00000001896E15B0
	// [XID] // 0x00000001896E1570-0x00000001896E15B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EF3 */, bool useObjectPool = false /* Metadata: 0x00AF1EF7 */) => default; // 0x0000000182386C60-0x0000000182386FB0
}

