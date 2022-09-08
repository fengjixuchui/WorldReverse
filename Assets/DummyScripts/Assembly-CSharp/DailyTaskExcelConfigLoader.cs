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

public static class DailyTaskExcelConfigLoader // TypeDefIndex: 15481
{
	// Fields
	private static Dictionary<uint, DailyTaskExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DailyTaskExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DailyTaskExcelConfig, DailyTaskExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DailyTaskExcelConfig>, Dictionary<uint, DailyTaskExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DailyTaskExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A80340-0x0000000189A80360 */ get; } // 0x0000000181805530-0x00000001818055E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A8F970-0x0000000189A8F990 */ get; } // 0x0000000181804380-0x0000000181804420 

	// Methods
	// [XID] // 0x0000000189A78E80-0x0000000189A78EA0
	public static void Register() {} // 0x0000000181805910-0x00000001818059B0
	// [XID] // 0x0000000189A880E0-0x0000000189A88100
	public static DailyTaskExcelConfig GetData(uint ID) => default; // 0x0000000181804250-0x0000000181804380
	// [XID] // 0x0000000189A96F80-0x0000000189A96FA0
	public static void LoadData() {} // 0x00000001818049B0-0x0000000181804AA0
	// [XID] // 0x0000000189A9E330-0x0000000189A9E350
	private static void RegisterHotfixGenerated() {} // 0x00000001818047E0-0x00000001818049B0
	// [XID] // 0x0000000189AA5CE0-0x0000000189AA5D00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181804420-0x00000001818047E0
	// [IDTag] // 0x0000000189AAD360-0x0000000189AAD3A0
	// [XID] // 0x0000000189AAD360-0x0000000189AAD3A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181804BE0-0x0000000181804CE0
	// [XID] // 0x0000000189AB7C00-0x0000000189AB7C20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DailyTaskExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001818055E0-0x0000000181805910
	// [XID] // 0x0000000189ABF710-0x0000000189ABF730
	private static bool ParseConfigFromLine(string line, out DailyTaskExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181804AA0-0x0000000181804BE0
	// [IDTag] // 0x0000000189AC70C0-0x0000000189AC7100
	// [XID] // 0x0000000189AC70C0-0x0000000189AC7100
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DailyTaskExcelConfig> configList) => default; // 0x0000000181804CE0-0x0000000181804F90
	// [IDTag] // 0x0000000189AD1910-0x0000000189AD1950
	// [XID] // 0x0000000189AD1910-0x0000000189AD1950
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1BEB */, bool useObjectPool = false /* Metadata: 0x00AF1BEF */) => default; // 0x00000001818052E0-0x0000000181805530
	// [IDTag] // 0x0000000189ADC740-0x0000000189ADC780
	// [XID] // 0x0000000189ADC740-0x0000000189ADC780
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BF0 */, bool useObjectPool = false /* Metadata: 0x00AF1BF4 */) => default; // 0x0000000181804F90-0x00000001818052E0
}

