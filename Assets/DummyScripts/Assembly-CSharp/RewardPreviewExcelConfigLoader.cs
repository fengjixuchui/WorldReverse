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

public static class RewardPreviewExcelConfigLoader // TypeDefIndex: 16069
{
	// Fields
	private static Dictionary<uint, RewardPreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RewardPreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RewardPreviewExcelConfig, RewardPreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RewardPreviewExcelConfig>, Dictionary<uint, RewardPreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RewardPreviewExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A16360-0x0000000189A16380 */ get; } // 0x0000000184B26F90-0x0000000184B27040 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A24D10-0x0000000189A24D30 */ get; } // 0x0000000184B25DE0-0x0000000184B25E80 

	// Methods
	// [XID] // 0x0000000189A0EB70-0x0000000189A0EB90
	public static void Register() {} // 0x0000000184B27370-0x0000000184B27410
	// [XID] // 0x0000000189A1D900-0x0000000189A1D920
	public static RewardPreviewExcelConfig GetData(uint id) => default; // 0x0000000184B25CB0-0x0000000184B25DE0
	// [XID] // 0x0000000189A2C310-0x0000000189A2C330
	public static void LoadData() {} // 0x0000000184B26410-0x0000000184B26500
	// [XID] // 0x0000000189A339C0-0x0000000189A339E0
	private static void RegisterHotfixGenerated() {} // 0x0000000184B26240-0x0000000184B26410
	// [XID] // 0x0000000189A3B1A0-0x0000000189A3B1C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184B25E80-0x0000000184B26240
	// [IDTag] // 0x0000000189A42B70-0x0000000189A42BB0
	// [XID] // 0x0000000189A42B70-0x0000000189A42BB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184B26640-0x0000000184B26740
	// [XID] // 0x0000000189A4D1C0-0x0000000189A4D1E0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RewardPreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184B27040-0x0000000184B27370
	// [XID] // 0x0000000189A548F0-0x0000000189A54910
	private static bool ParseConfigFromLine(string line, out RewardPreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184B26500-0x0000000184B26640
	// [IDTag] // 0x0000000189A5C380-0x0000000189A5C3C0
	// [XID] // 0x0000000189A5C380-0x0000000189A5C3C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RewardPreviewExcelConfig> configList) => default; // 0x0000000184B26740-0x0000000184B269F0
	// [IDTag] // 0x0000000189A66B00-0x0000000189A66B40
	// [XID] // 0x0000000189A66B00-0x0000000189A66B40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F6E */, bool useObjectPool = false /* Metadata: 0x00AF2F72 */) => default; // 0x0000000184B26D40-0x0000000184B26F90
	// [IDTag] // 0x0000000189A71100-0x0000000189A71140
	// [XID] // 0x0000000189A71100-0x0000000189A71140
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F73 */, bool useObjectPool = false /* Metadata: 0x00AF2F77 */) => default; // 0x0000000184B269F0-0x0000000184B26D40
}

