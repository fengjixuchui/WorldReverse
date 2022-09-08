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

public static class SeaLampSectionExcelConfigLoader // TypeDefIndex: 14918
{
	// Fields
	private static List<uint> _sectionList; // 0x00
	private static List<SeaLampSectionExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<SeaLampSectionExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<SeaLampSectionExcelConfig, SeaLampSectionExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<SeaLampSectionExcelConfig>, List<SeaLampSectionExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<SeaLampSectionExcelConfig> dataList { /* [XID] */ /* 0x0000000189A22370-0x0000000189A22390 */ get; } // 0x0000000182D6CCF0-0x0000000182D6CDA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A29720-0x0000000189A29740 */ get; } // 0x0000000182D6B950-0x0000000182D6B9F0 

	// Methods
	// [XID] // 0x0000000189A0BF30-0x0000000189A0BF50
	public static SeaLampSectionExcelConfig GetSeaLampSectionExcelConfig(uint sectionID) => default; // 0x0000000182D6CB40-0x0000000182D6CCF0
	// [XID] // 0x0000000189A138C0-0x0000000189A138E0
	public static List<uint> GetSectionIDList(uint activityID) => default; // 0x0000000182D6D170-0x0000000182D6D370
	// [XID] // 0x0000000189A1AA10-0x0000000189A1AA30
	public static void Register() {} // 0x0000000182D6D0D0-0x0000000182D6D170
	// [XID] // 0x0000000189A30BD0-0x0000000189A30BF0
	public static void LoadData() {} // 0x0000000182D6BFF0-0x0000000182D6C0E0
	// [XID] // 0x0000000189A38630-0x0000000189A38650
	private static void RegisterHotfixGenerated() {} // 0x0000000182D6BE20-0x0000000182D6BFF0
	// [XID] // 0x0000000189A3FDA0-0x0000000189A3FDC0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D6B9F0-0x0000000182D6BE20
	// [IDTag] // 0x0000000189A47450-0x0000000189A47490
	// [XID] // 0x0000000189A47450-0x0000000189A47490
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D6C4C0-0x0000000182D6C5C0
	// [XID] // 0x0000000189A51C90-0x0000000189A51CB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SeaLampSectionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D6CDA0-0x0000000182D6D0D0
	// [XID] // 0x0000000189A59400-0x0000000189A59420
	private static bool ParseConfigFromLine(string line, out SeaLampSectionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D6C0E0-0x0000000182D6C220
	// [IDTag] // 0x0000000189A60DA0-0x0000000189A60DE0
	// [XID] // 0x0000000189A60DA0-0x0000000189A60DE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SeaLampSectionExcelConfig> configList) => default; // 0x0000000182D6C220-0x0000000182D6C4C0
	// [IDTag] // 0x0000000189A6B850-0x0000000189A6B890
	// [XID] // 0x0000000189A6B850-0x0000000189A6B890
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9E7 */, bool useObjectPool = false /* Metadata: 0x00AEF9EB */) => default; // 0x0000000182D6C8F0-0x0000000182D6CB40
	// [IDTag] // 0x0000000189A75DB0-0x0000000189A75DF0
	// [XID] // 0x0000000189A75DB0-0x0000000189A75DF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9EC */, bool useObjectPool = false /* Metadata: 0x00AEF9F0 */) => default; // 0x0000000182D6C5C0-0x0000000182D6C8F0
}

