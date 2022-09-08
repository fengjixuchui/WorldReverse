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

public static class ExpeditionBonusExcelConfigLoader // TypeDefIndex: 15088
{
	// Fields
	private static Dictionary<uint, ExpeditionBonusExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionBonusExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionBonusExcelConfig, ExpeditionBonusExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionBonusExcelConfig>, Dictionary<uint, ExpeditionBonusExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionBonusExcelConfig> dataDict { /* [XID] */ /* 0x00000001896B5330-0x00000001896B5350 */ get; } // 0x000000018384CB60-0x000000018384CC10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896C3BA0-0x00000001896C3BC0 */ get; } // 0x000000018384B9B0-0x000000018384BA50 

	// Methods
	// [XID] // 0x00000001896ADB10-0x00000001896ADB30
	public static void Register() {} // 0x000000018384CF40-0x000000018384CFE0
	// [XID] // 0x00000001896BC520-0x00000001896BC540
	public static ExpeditionBonusExcelConfig GetData(uint id) => default; // 0x000000018384B880-0x000000018384B9B0
	// [XID] // 0x00000001896CB050-0x00000001896CB070
	public static void LoadData() {} // 0x000000018384BFE0-0x000000018384C0D0
	// [XID] // 0x00000001896D25E0-0x00000001896D2600
	private static void RegisterHotfixGenerated() {} // 0x000000018384BE10-0x000000018384BFE0
	// [XID] // 0x00000001896DA0B0-0x00000001896DA0D0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018384BA50-0x000000018384BE10
	// [IDTag] // 0x00000001896E16B0-0x00000001896E16F0
	// [XID] // 0x00000001896E16B0-0x00000001896E16F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018384C4C0-0x000000018384C5C0
	// [XID] // 0x00000001896EBA20-0x00000001896EBA40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionBonusExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018384CC10-0x000000018384CF40
	// [XID] // 0x00000001896F2F50-0x00000001896F2F70
	private static bool ParseConfigFromLine(string line, out ExpeditionBonusExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018384C0D0-0x000000018384C210
	// [IDTag] // 0x00000001896FA770-0x00000001896FA7B0
	// [XID] // 0x00000001896FA770-0x00000001896FA7B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionBonusExcelConfig> configList) => default; // 0x000000018384C210-0x000000018384C4C0
	// [IDTag] // 0x0000000189704DF0-0x0000000189704E30
	// [XID] // 0x0000000189704DF0-0x0000000189704E30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF007B */, bool useObjectPool = false /* Metadata: 0x00AF007F */) => default; // 0x000000018384C5C0-0x000000018384C810
	// [IDTag] // 0x000000018970F840-0x000000018970F880
	// [XID] // 0x000000018970F840-0x000000018970F880
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0080 */, bool useObjectPool = false /* Metadata: 0x00AF0084 */) => default; // 0x000000018384C810-0x000000018384CB60
}

