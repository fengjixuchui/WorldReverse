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

public static class CityTaskOpenExcelConfigLoader // TypeDefIndex: 15488
{
	// Fields
	private static List<CityTaskOpenExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<CityTaskOpenExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CityTaskOpenExcelConfig, CityTaskOpenExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CityTaskOpenExcelConfig>, List<CityTaskOpenExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<CityTaskOpenExcelConfig> dataList { /* [XID] */ /* 0x0000000189801420-0x0000000189801440 */ get; } // 0x0000000185498C60-0x0000000185498D10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189808860-0x0000000189808880 */ get; } // 0x0000000185497A70-0x0000000185497B10 

	// Methods
	// [XID] // 0x00000001897F9EA0-0x00000001897F9EC0
	public static void Register() {} // 0x0000000185499040-0x00000001854990E0
	// [XID] // 0x0000000189810210-0x0000000189810230
	public static void LoadData() {} // 0x0000000185498110-0x0000000185498200
	// [XID] // 0x0000000189817880-0x00000001898178A0
	private static void RegisterHotfixGenerated() {} // 0x0000000185497F40-0x0000000185498110
	// [XID] // 0x000000018981F220-0x000000018981F240
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185497B10-0x0000000185497F40
	// [IDTag] // 0x0000000189826710-0x0000000189826750
	// [XID] // 0x0000000189826710-0x0000000189826750
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001854985E0-0x00000001854986E0
	// [XID] // 0x0000000189830D60-0x0000000189830D80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CityTaskOpenExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185498D10-0x0000000185499040
	// [XID] // 0x00000001898384A0-0x00000001898384C0
	private static bool ParseConfigFromLine(string line, out CityTaskOpenExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185498200-0x0000000185498340
	// [IDTag] // 0x000000018983FAB0-0x000000018983FAF0
	// [XID] // 0x000000018983FAB0-0x000000018983FAF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CityTaskOpenExcelConfig> configList) => default; // 0x0000000185498340-0x00000001854985E0
	// [IDTag] // 0x0000000189849F10-0x0000000189849F50
	// [XID] // 0x0000000189849F10-0x0000000189849F50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1C1D */, bool useObjectPool = false /* Metadata: 0x00AF1C21 */) => default; // 0x0000000185498A10-0x0000000185498C60
	// [IDTag] // 0x0000000189854080-0x00000001898540C0
	// [XID] // 0x0000000189854080-0x00000001898540C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C22 */, bool useObjectPool = false /* Metadata: 0x00AF1C26 */) => default; // 0x00000001854986E0-0x0000000185498A10
}

