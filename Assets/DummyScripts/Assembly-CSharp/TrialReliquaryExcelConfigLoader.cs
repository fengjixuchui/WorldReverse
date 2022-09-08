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

public static class TrialReliquaryExcelConfigLoader // TypeDefIndex: 16243
{
	// Fields
	private static Dictionary<uint, TrialReliquaryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TrialReliquaryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TrialReliquaryExcelConfig, TrialReliquaryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TrialReliquaryExcelConfig>, Dictionary<uint, TrialReliquaryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TrialReliquaryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189ADF750-0x0000000189ADF770 */ get; } // 0x0000000182E95E60-0x0000000182E95F10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AEEA60-0x0000000189AEEA80 */ get; } // 0x0000000182E94CB0-0x0000000182E94D50 

	// Methods
	// [XID] // 0x0000000189AD7C60-0x0000000189AD7C80
	public static void Register() {} // 0x0000000182E96240-0x0000000182E962E0
	// [XID] // 0x0000000189AE6F50-0x0000000189AE6F70
	public static TrialReliquaryExcelConfig GetData(uint id) => default; // 0x0000000182E94B80-0x0000000182E94CB0
	// [XID] // 0x0000000189AF6070-0x0000000189AF6090
	public static void LoadData() {} // 0x0000000182E952E0-0x0000000182E953D0
	// [XID] // 0x0000000189AFD570-0x0000000189AFD590
	private static void RegisterHotfixGenerated() {} // 0x0000000182E95110-0x0000000182E952E0
	// [XID] // 0x0000000189B04D00-0x0000000189B04D20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E94D50-0x0000000182E95110
	// [IDTag] // 0x0000000189B0C4B0-0x0000000189B0C4F0
	// [XID] // 0x0000000189B0C4B0-0x0000000189B0C4F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E957C0-0x0000000182E958C0
	// [XID] // 0x0000000189B167B0-0x0000000189B167D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TrialReliquaryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E95F10-0x0000000182E96240
	// [XID] // 0x0000000189B1DE50-0x0000000189B1DE70
	private static bool ParseConfigFromLine(string line, out TrialReliquaryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E953D0-0x0000000182E95510
	// [IDTag] // 0x0000000189B25720-0x0000000189B25760
	// [XID] // 0x0000000189B25720-0x0000000189B25760
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TrialReliquaryExcelConfig> configList) => default; // 0x0000000182E95510-0x0000000182E957C0
	// [IDTag] // 0x0000000189B2F8B0-0x0000000189B2F8F0
	// [XID] // 0x0000000189B2F8B0-0x0000000189B2F8F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF355A */, bool useObjectPool = false /* Metadata: 0x00AF355E */) => default; // 0x0000000182E958C0-0x0000000182E95B10
	// [IDTag] // 0x0000000189B3A370-0x0000000189B3A3B0
	// [XID] // 0x0000000189B3A370-0x0000000189B3A3B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF355F */, bool useObjectPool = false /* Metadata: 0x00AF3563 */) => default; // 0x0000000182E95B10-0x0000000182E95E60
}

