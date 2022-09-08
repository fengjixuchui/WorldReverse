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

public static class ElementCoeffExcelConfigLoader // TypeDefIndex: 15562
{
	// Fields
	private static Dictionary<uint, ElementCoeffExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ElementCoeffExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ElementCoeffExcelConfig, ElementCoeffExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ElementCoeffExcelConfig>, Dictionary<uint, ElementCoeffExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ElementCoeffExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AD9610-0x0000000189AD9630 */ get; } // 0x0000000185525BA0-0x0000000185525C50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE8490-0x0000000189AE84B0 */ get; } // 0x00000001855249F0-0x0000000185524A90 

	// Methods
	// [XID] // 0x0000000189AD18F0-0x0000000189AD1910
	public static void Register() {} // 0x0000000185525F80-0x0000000185526020
	// [XID] // 0x0000000189AE10C0-0x0000000189AE10E0
	public static ElementCoeffExcelConfig GetData(uint level) => default; // 0x00000001855248C0-0x00000001855249F0
	// [XID] // 0x0000000189AF0470-0x0000000189AF0490
	public static void LoadData() {} // 0x0000000185525020-0x0000000185525110
	// [XID] // 0x0000000189AF7920-0x0000000189AF7940
	private static void RegisterHotfixGenerated() {} // 0x0000000185524E50-0x0000000185525020
	// [XID] // 0x0000000189AFEEF0-0x0000000189AFEF10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185524A90-0x0000000185524E50
	// [IDTag] // 0x0000000189B067A0-0x0000000189B067E0
	// [XID] // 0x0000000189B067A0-0x0000000189B067E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185525250-0x0000000185525350
	// [XID] // 0x0000000189B11050-0x0000000189B11070
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ElementCoeffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185525C50-0x0000000185525F80
	// [XID] // 0x0000000189B182E0-0x0000000189B18300
	private static bool ParseConfigFromLine(string line, out ElementCoeffExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185525110-0x0000000185525250
	// [IDTag] // 0x0000000189B1F9E0-0x0000000189B1FA20
	// [XID] // 0x0000000189B1F9E0-0x0000000189B1FA20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ElementCoeffExcelConfig> configList) => default; // 0x0000000185525350-0x0000000185525600
	// [IDTag] // 0x0000000189B29F60-0x0000000189B29FA0
	// [XID] // 0x0000000189B29F60-0x0000000189B29FA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F25 */, bool useObjectPool = false /* Metadata: 0x00AF1F29 */) => default; // 0x0000000185525950-0x0000000185525BA0
	// [IDTag] // 0x0000000189B34200-0x0000000189B34240
	// [XID] // 0x0000000189B34200-0x0000000189B34240
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F2A */, bool useObjectPool = false /* Metadata: 0x00AF1F2E */) => default; // 0x0000000185525600-0x0000000185525950
}

