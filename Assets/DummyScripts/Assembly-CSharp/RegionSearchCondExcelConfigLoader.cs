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

public static class RegionSearchCondExcelConfigLoader // TypeDefIndex: 15159
{
	// Fields
	private static Dictionary<uint, RegionSearchCondExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RegionSearchCondExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RegionSearchCondExcelConfig, RegionSearchCondExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RegionSearchCondExcelConfig>, Dictionary<uint, RegionSearchCondExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RegionSearchCondExcelConfig> dataDict { /* [XID] */ /* 0x000000018966D140-0x000000018966D160 */ get; } // 0x000000018560EF10-0x000000018560EFC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018967C840-0x000000018967C860 */ get; } // 0x000000018560DD60-0x000000018560DE00 

	// Methods
	// [XID] // 0x0000000189665A90-0x0000000189665AB0
	public static void Register() {} // 0x000000018560F2F0-0x000000018560F7D0
	// [XID] // 0x0000000189675070-0x0000000189675090
	public static RegionSearchCondExcelConfig GetData(uint id) => default; // 0x000000018560DC30-0x000000018560DD60
	// [XID] // 0x0000000189683F10-0x0000000189683F30
	public static void LoadData() {} // 0x000000018560E390-0x000000018560E480
	// [XID] // 0x000000018968BA90-0x000000018968BAB0
	private static void RegisterHotfixGenerated() {} // 0x000000018560E1C0-0x000000018560E390
	// [XID] // 0x00000001896936E0-0x0000000189693700
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018560DE00-0x000000018560E1C0
	// [IDTag] // 0x000000018969A9D0-0x000000018969AA10
	// [XID] // 0x000000018969A9D0-0x000000018969AA10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018560E5C0-0x000000018560E6C0
	// [XID] // 0x00000001896A4D60-0x00000001896A4D80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RegionSearchCondExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018560EFC0-0x000000018560F2F0
	// [XID] // 0x00000001896AC610-0x00000001896AC630
	private static bool ParseConfigFromLine(string line, out RegionSearchCondExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018560E480-0x000000018560E5C0
	// [IDTag] // 0x00000001896B3870-0x00000001896B38B0
	// [XID] // 0x00000001896B3870-0x00000001896B38B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RegionSearchCondExcelConfig> configList) => default; // 0x000000018560E6C0-0x000000018560E970
	// [IDTag] // 0x00000001896BDAA0-0x00000001896BDAE0
	// [XID] // 0x00000001896BDAA0-0x00000001896BDAE0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF026F */, bool useObjectPool = false /* Metadata: 0x00AF0273 */) => default; // 0x000000018560ECC0-0x000000018560EF10
	// [IDTag] // 0x00000001896C8170-0x00000001896C81B0
	// [XID] // 0x00000001896C8170-0x00000001896C81B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0274 */, bool useObjectPool = false /* Metadata: 0x00AF0278 */) => default; // 0x000000018560E970-0x000000018560ECC0
}

