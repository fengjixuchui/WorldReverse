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

public static class RefreshIndexExcelConfigLoader // TypeDefIndex: 16012
{
	// Fields
	private static List<RefreshIndexExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<RefreshIndexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RefreshIndexExcelConfig, RefreshIndexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RefreshIndexExcelConfig>, List<RefreshIndexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<RefreshIndexExcelConfig> dataList { /* [XID] */ /* 0x000000018997BBE0-0x000000018997BC00 */ get; } // 0x0000000182E8B960-0x0000000182E8BA10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189983750-0x0000000189983770 */ get; } // 0x0000000182E8A770-0x0000000182E8A810 

	// Methods
	// [XID] // 0x00000001899745F0-0x0000000189974610
	public static void Register() {} // 0x0000000182E8BD40-0x0000000182E8BDE0
	// [XID] // 0x000000018998AFA0-0x000000018998AFC0
	public static void LoadData() {} // 0x0000000182E8AE10-0x0000000182E8AF00
	// [XID] // 0x00000001899928F0-0x0000000189992910
	private static void RegisterHotfixGenerated() {} // 0x0000000182E8AC40-0x0000000182E8AE10
	// [XID] // 0x000000018999A6B0-0x000000018999A6D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E8A810-0x0000000182E8AC40
	// [IDTag] // 0x00000001899A1D10-0x00000001899A1D50
	// [XID] // 0x00000001899A1D10-0x00000001899A1D50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E8B040-0x0000000182E8B140
	// [XID] // 0x00000001899AC8D0-0x00000001899AC8F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RefreshIndexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E8BA10-0x0000000182E8BD40
	// [XID] // 0x00000001899B40A0-0x00000001899B40C0
	private static bool ParseConfigFromLine(string line, out RefreshIndexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E8AF00-0x0000000182E8B040
	// [IDTag] // 0x00000001899BB4F0-0x00000001899BB530
	// [XID] // 0x00000001899BB4F0-0x00000001899BB530
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RefreshIndexExcelConfig> configList) => default; // 0x0000000182E8B140-0x0000000182E8B3E0
	// [IDTag] // 0x00000001899C5EF0-0x00000001899C5F30
	// [XID] // 0x00000001899C5EF0-0x00000001899C5F30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2DB2 */, bool useObjectPool = false /* Metadata: 0x00AF2DB6 */) => default; // 0x0000000182E8B710-0x0000000182E8B960
	// [IDTag] // 0x00000001899D0610-0x00000001899D0650
	// [XID] // 0x00000001899D0610-0x00000001899D0650
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DB7 */, bool useObjectPool = false /* Metadata: 0x00AF2DBB */) => default; // 0x0000000182E8B3E0-0x0000000182E8B710
}

