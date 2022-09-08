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

public static class ReputationCityExcelConfigLoader // TypeDefIndex: 16049
{
	// Fields
	private static Dictionary<uint, ReputationCityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationCityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationCityExcelConfig, ReputationCityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationCityExcelConfig>, Dictionary<uint, ReputationCityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReputationCityExcelConfig> dataDict { /* [XID] */ /* 0x000000018977DB00-0x000000018977DB20 */ get; } // 0x0000000183EABE10-0x0000000183EABEC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018978C810-0x000000018978C830 */ get; } // 0x0000000183EAAC60-0x0000000183EAAD00 

	// Methods
	// [XID] // 0x00000001897763E0-0x0000000189776400
	public static void Register() {} // 0x0000000183EAC1F0-0x0000000183EAC290
	// [XID] // 0x0000000189785300-0x0000000189785320
	public static ReputationCityExcelConfig GetData(uint cityId) => default; // 0x0000000183EAAB30-0x0000000183EAAC60
	// [XID] // 0x0000000189793CC0-0x0000000189793CE0
	public static void LoadData() {} // 0x0000000183EAB290-0x0000000183EAB380
	// [XID] // 0x000000018979C030-0x000000018979C050
	private static void RegisterHotfixGenerated() {} // 0x0000000183EAB0C0-0x0000000183EAB290
	// [XID] // 0x00000001897A34E0-0x00000001897A3500
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183EAAD00-0x0000000183EAB0C0
	// [IDTag] // 0x00000001897AAA80-0x00000001897AAAC0
	// [XID] // 0x00000001897AAA80-0x00000001897AAAC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183EAB4C0-0x0000000183EAB5C0
	// [XID] // 0x00000001897B5CF0-0x00000001897B5D10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationCityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183EABEC0-0x0000000183EAC1F0
	// [XID] // 0x00000001897BDAC0-0x00000001897BDAE0
	private static bool ParseConfigFromLine(string line, out ReputationCityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183EAB380-0x0000000183EAB4C0
	// [IDTag] // 0x00000001897C4E20-0x00000001897C4E60
	// [XID] // 0x00000001897C4E20-0x00000001897C4E60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationCityExcelConfig> configList) => default; // 0x0000000183EAB5C0-0x0000000183EAB870
	// [IDTag] // 0x00000001897CF790-0x00000001897CF7D0
	// [XID] // 0x00000001897CF790-0x00000001897CF7D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2EE2 */, bool useObjectPool = false /* Metadata: 0x00AF2EE6 */) => default; // 0x0000000183EABBC0-0x0000000183EABE10
	// [IDTag] // 0x00000001897DA3D0-0x00000001897DA410
	// [XID] // 0x00000001897DA3D0-0x00000001897DA410
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EE7 */, bool useObjectPool = false /* Metadata: 0x00AF2EEB */) => default; // 0x0000000183EAB870-0x0000000183EABBC0
}

