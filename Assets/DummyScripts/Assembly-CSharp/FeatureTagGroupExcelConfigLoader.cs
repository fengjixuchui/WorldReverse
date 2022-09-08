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

public static class FeatureTagGroupExcelConfigLoader // TypeDefIndex: 15606
{
	// Fields
	private static Dictionary<uint, FeatureTagGroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FeatureTagGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FeatureTagGroupExcelConfig, FeatureTagGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FeatureTagGroupExcelConfig>, Dictionary<uint, FeatureTagGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FeatureTagGroupExcelConfig> dataDict { /* [XID] */ /* 0x00000001899C3200-0x00000001899C3220 */ get; } // 0x0000000183FEFA10-0x0000000183FEFAC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899D1E00-0x00000001899D1E20 */ get; } // 0x0000000183FEE860-0x0000000183FEE900 

	// Methods
	// [XID] // 0x00000001899BB5F0-0x00000001899BB610
	public static void Register() {} // 0x0000000183FEFDF0-0x0000000183FEFE90
	// [XID] // 0x00000001899CA620-0x00000001899CA640
	public static FeatureTagGroupExcelConfig GetData(uint groupID) => default; // 0x0000000183FEE730-0x0000000183FEE860
	// [XID] // 0x00000001899D9250-0x00000001899D9270
	public static void LoadData() {} // 0x0000000183FEEE90-0x0000000183FEEF80
	// [XID] // 0x00000001899E09E0-0x00000001899E0A00
	private static void RegisterHotfixGenerated() {} // 0x0000000183FEECC0-0x0000000183FEEE90
	// [XID] // 0x00000001899E84E0-0x00000001899E8500
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183FEE900-0x0000000183FEECC0
	// [IDTag] // 0x00000001899EFB10-0x00000001899EFB50
	// [XID] // 0x00000001899EFB10-0x00000001899EFB50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183FEF370-0x0000000183FEF470
	// [XID] // 0x00000001899FA110-0x00000001899FA130
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FeatureTagGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183FEFAC0-0x0000000183FEFDF0
	// [XID] // 0x0000000189A01510-0x0000000189A01530
	private static bool ParseConfigFromLine(string line, out FeatureTagGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183FEEF80-0x0000000183FEF0C0
	// [IDTag] // 0x0000000189A08E50-0x0000000189A08E90
	// [XID] // 0x0000000189A08E50-0x0000000189A08E90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FeatureTagGroupExcelConfig> configList) => default; // 0x0000000183FEF0C0-0x0000000183FEF370
	// [IDTag] // 0x0000000189A13700-0x0000000189A13740
	// [XID] // 0x0000000189A13700-0x0000000189A13740
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2060 */, bool useObjectPool = false /* Metadata: 0x00AF2064 */) => default; // 0x0000000183FEF7C0-0x0000000183FEFA10
	// [IDTag] // 0x0000000189A1DA20-0x0000000189A1DA60
	// [XID] // 0x0000000189A1DA20-0x0000000189A1DA60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2065 */, bool useObjectPool = false /* Metadata: 0x00AF2069 */) => default; // 0x0000000183FEF470-0x0000000183FEF7C0
}

