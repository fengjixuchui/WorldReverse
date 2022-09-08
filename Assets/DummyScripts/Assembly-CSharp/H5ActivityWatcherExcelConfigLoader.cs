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

public static class H5ActivityWatcherExcelConfigLoader // TypeDefIndex: 15696
{
	// Fields
	private static Dictionary<uint, H5ActivityWatcherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<H5ActivityWatcherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<H5ActivityWatcherExcelConfig, H5ActivityWatcherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<H5ActivityWatcherExcelConfig>, Dictionary<uint, H5ActivityWatcherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, H5ActivityWatcherExcelConfig> dataDict { /* [XID] */ /* 0x00000001896BC420-0x00000001896BC440 */ get; } // 0x00000001844F4FA0-0x00000001844F5050 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896CAE70-0x00000001896CAE90 */ get; } // 0x00000001844F3DF0-0x00000001844F3E90 

	// Methods
	// [XID] // 0x00000001896B5250-0x00000001896B5270
	public static void Register() {} // 0x00000001844F5380-0x00000001844F5420
	// [XID] // 0x00000001896C3A00-0x00000001896C3A20
	public static H5ActivityWatcherExcelConfig GetData(uint id) => default; // 0x00000001844F3CC0-0x00000001844F3DF0
	// [XID] // 0x00000001896D24E0-0x00000001896D2500
	public static void LoadData() {} // 0x00000001844F4420-0x00000001844F4510
	// [XID] // 0x00000001896D9F50-0x00000001896D9F70
	private static void RegisterHotfixGenerated() {} // 0x00000001844F4250-0x00000001844F4420
	// [XID] // 0x00000001896E1550-0x00000001896E1570
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001844F3E90-0x00000001844F4250
	// [IDTag] // 0x00000001896E88C0-0x00000001896E8900
	// [XID] // 0x00000001896E88C0-0x00000001896E8900
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001844F4650-0x00000001844F4750
	// [XID] // 0x00000001896F2D70-0x00000001896F2D90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<H5ActivityWatcherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001844F5050-0x00000001844F5380
	// [XID] // 0x00000001896FA690-0x00000001896FA6B0
	private static bool ParseConfigFromLine(string line, out H5ActivityWatcherExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001844F4510-0x00000001844F4650
	// [IDTag] // 0x0000000189701D40-0x0000000189701D80
	// [XID] // 0x0000000189701D40-0x0000000189701D80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<H5ActivityWatcherExcelConfig> configList) => default; // 0x00000001844F4750-0x00000001844F4A00
	// [IDTag] // 0x000000018970C410-0x000000018970C450
	// [XID] // 0x000000018970C410-0x000000018970C450
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2354 */, bool useObjectPool = false /* Metadata: 0x00AF2358 */) => default; // 0x00000001844F4D50-0x00000001844F4FA0
	// [IDTag] // 0x00000001897169C0-0x0000000189716A00
	// [XID] // 0x00000001897169C0-0x0000000189716A00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2359 */, bool useObjectPool = false /* Metadata: 0x00AF235D */) => default; // 0x00000001844F4A00-0x00000001844F4D50
}

