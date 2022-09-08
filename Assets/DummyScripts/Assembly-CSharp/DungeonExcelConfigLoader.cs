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

public static class DungeonExcelConfigLoader // TypeDefIndex: 15547
{
	// Fields
	private static Dictionary<uint, DungeonExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonExcelConfig, DungeonExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonExcelConfig>, Dictionary<uint, DungeonExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonExcelConfig> dataDict { /* [XID] */ /* 0x00000001897B5D70-0x00000001897B5D90 */ get; } // 0x00000001816AC5D0-0x00000001816AC680 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897C4F80-0x00000001897C4FA0 */ get; } // 0x00000001816AB420-0x00000001816AB4C0 

	// Methods
	// [XID] // 0x00000001897ADBF0-0x00000001897ADC10
	public static void Register() {} // 0x00000001816AC9B0-0x00000001816ACA50
	// [XID] // 0x00000001897BDBA0-0x00000001897BDBC0
	public static DungeonExcelConfig GetData(uint id) => default; // 0x00000001816AB2F0-0x00000001816AB420
	// [XID] // 0x00000001897CC770-0x00000001897CC790
	public static void LoadData() {} // 0x00000001816ABA50-0x00000001816ABB40
	// [XID] // 0x00000001897D3FE0-0x00000001897D4000
	private static void RegisterHotfixGenerated() {} // 0x00000001816AB880-0x00000001816ABA50
	// [XID] // 0x00000001897DB910-0x00000001897DB930
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001816AB4C0-0x00000001816AB880
	// [IDTag] // 0x00000001897E3160-0x00000001897E31A0
	// [XID] // 0x00000001897E3160-0x00000001897E31A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001816ABF30-0x00000001816AC030
	// [XID] // 0x00000001897EDC10-0x00000001897EDC30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001816AC680-0x00000001816AC9B0
	// [XID] // 0x00000001897F5330-0x00000001897F5350
	private static bool ParseConfigFromLine(string line, out DungeonExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001816ABB40-0x00000001816ABC80
	// [IDTag] // 0x00000001897FCCC0-0x00000001897FCD00
	// [XID] // 0x00000001897FCCC0-0x00000001897FCD00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonExcelConfig> configList) => default; // 0x00000001816ABC80-0x00000001816ABF30
	// [IDTag] // 0x0000000189807270-0x00000001898072B0
	// [XID] // 0x0000000189807270-0x00000001898072B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1EBC */, bool useObjectPool = false /* Metadata: 0x00AF1EC0 */) => default; // 0x00000001816AC030-0x00000001816AC280
	// [IDTag] // 0x0000000189811820-0x0000000189811860
	// [XID] // 0x0000000189811820-0x0000000189811860
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EC1 */, bool useObjectPool = false /* Metadata: 0x00AF1EC5 */) => default; // 0x00000001816AC280-0x00000001816AC5D0
}

