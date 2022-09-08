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

public static class FeatureTagExcelConfigLoader // TypeDefIndex: 15608
{
	// Fields
	private static Dictionary<uint, FeatureTagExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FeatureTagExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FeatureTagExcelConfig, FeatureTagExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FeatureTagExcelConfig>, Dictionary<uint, FeatureTagExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FeatureTagExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AC42A0-0x0000000189AC42C0 */ get; } // 0x0000000182E069F0-0x0000000182E06AA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AD3240-0x0000000189AD3260 */ get; } // 0x0000000182E05840-0x0000000182E058E0 

	// Methods
	// [XID] // 0x0000000189ABC9C0-0x0000000189ABC9E0
	public static void Register() {} // 0x0000000182E06DD0-0x0000000182E06E70
	// [XID] // 0x0000000189ACB7D0-0x0000000189ACB7F0
	public static FeatureTagExcelConfig GetData(uint tagID) => default; // 0x0000000182E05710-0x0000000182E05840
	// [XID] // 0x0000000189ADACC0-0x0000000189ADACE0
	public static void LoadData() {} // 0x0000000182E05E70-0x0000000182E05F60
	// [XID] // 0x0000000189AE2460-0x0000000189AE2480
	private static void RegisterHotfixGenerated() {} // 0x0000000182E05CA0-0x0000000182E05E70
	// [XID] // 0x0000000189AE9D50-0x0000000189AE9D70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E058E0-0x0000000182E05CA0
	// [IDTag] // 0x0000000189AF1B30-0x0000000189AF1B70
	// [XID] // 0x0000000189AF1B30-0x0000000189AF1B70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E06350-0x0000000182E06450
	// [XID] // 0x0000000189AFBDC0-0x0000000189AFBDE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FeatureTagExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E06AA0-0x0000000182E06DD0
	// [XID] // 0x0000000189B03650-0x0000000189B03670
	private static bool ParseConfigFromLine(string line, out FeatureTagExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E05F60-0x0000000182E060A0
	// [IDTag] // 0x0000000189B0ADA0-0x0000000189B0ADE0
	// [XID] // 0x0000000189B0ADA0-0x0000000189B0ADE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FeatureTagExcelConfig> configList) => default; // 0x0000000182E060A0-0x0000000182E06350
	// [IDTag] // 0x0000000189B15210-0x0000000189B15250
	// [XID] // 0x0000000189B15210-0x0000000189B15250
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF206F */, bool useObjectPool = false /* Metadata: 0x00AF2073 */) => default; // 0x0000000182E06450-0x0000000182E066A0
	// [IDTag] // 0x0000000189B1F9A0-0x0000000189B1F9E0
	// [XID] // 0x0000000189B1F9A0-0x0000000189B1F9E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2074 */, bool useObjectPool = false /* Metadata: 0x00AF2078 */) => default; // 0x0000000182E066A0-0x0000000182E069F0
}

