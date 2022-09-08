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

public static class LoadingTipsExcelConfigLoader // TypeDefIndex: 15787
{
	// Fields
	private static Dictionary<uint, LoadingTipsExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LoadingTipsExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LoadingTipsExcelConfig, LoadingTipsExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LoadingTipsExcelConfig>, Dictionary<uint, LoadingTipsExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, LoadingTipsExcelConfig> dataDict { /* [XID] */ /* 0x00000001897869E0-0x0000000189786A00 */ get; } // 0x0000000182AEE1D0-0x0000000182AEE280 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189795780-0x00000001897957A0 */ get; } // 0x0000000182AED020-0x0000000182AED0C0 

	// Methods
	// [XID] // 0x000000018977EFC0-0x000000018977EFE0
	public static void Register() {} // 0x0000000182AEE5B0-0x0000000182AEE6F0
	// [XID] // 0x000000018978E090-0x000000018978E0B0
	public static LoadingTipsExcelConfig GetData(uint id) => default; // 0x0000000182AECEF0-0x0000000182AED020
	// [XID] // 0x000000018979DBD0-0x000000018979DBF0
	public static void LoadData() {} // 0x0000000182AED650-0x0000000182AED740
	// [XID] // 0x00000001897A4F50-0x00000001897A4F70
	private static void RegisterHotfixGenerated() {} // 0x0000000182AED480-0x0000000182AED650
	// [XID] // 0x00000001897AC4E0-0x00000001897AC500
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182AED0C0-0x0000000182AED480
	// [IDTag] // 0x00000001897B4430-0x00000001897B4470
	// [XID] // 0x00000001897B4430-0x00000001897B4470
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182AEDB30-0x0000000182AEDC30
	// [XID] // 0x00000001897BF390-0x00000001897BF3B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LoadingTipsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182AEE280-0x0000000182AEE5B0
	// [XID] // 0x00000001897C6A00-0x00000001897C6A20
	private static bool ParseConfigFromLine(string line, out LoadingTipsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182AED740-0x0000000182AED880
	// [IDTag] // 0x00000001897CE1E0-0x00000001897CE220
	// [XID] // 0x00000001897CE1E0-0x00000001897CE220
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LoadingTipsExcelConfig> configList) => default; // 0x0000000182AED880-0x0000000182AEDB30
	// [IDTag] // 0x00000001897D8E50-0x00000001897D8E90
	// [XID] // 0x00000001897D8E50-0x00000001897D8E90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF25FC */, bool useObjectPool = false /* Metadata: 0x00AF2600 */) => default; // 0x0000000182AEDF80-0x0000000182AEE1D0
	// [IDTag] // 0x00000001897E30A0-0x00000001897E30E0
	// [XID] // 0x00000001897E30A0-0x00000001897E30E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2601 */, bool useObjectPool = false /* Metadata: 0x00AF2605 */) => default; // 0x0000000182AEDC30-0x0000000182AEDF80
}

