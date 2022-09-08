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

public static class ReputationEntranceExcelConfigLoader // TypeDefIndex: 14907
{
	// Fields
	private static List<ReputationEntranceExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationEntranceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationEntranceExcelConfig, ReputationEntranceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationEntranceExcelConfig>, List<ReputationEntranceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReputationEntranceExcelConfig> dataList { /* [XID] */ /* 0x00000001898FFB70-0x00000001898FFB90 */ get; } // 0x00000001852112F0-0x00000001852113A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189907350-0x0000000189907370 */ get; } // 0x0000000185210100-0x00000001852101A0 

	// Methods
	// [XID] // 0x00000001898F0AA0-0x00000001898F0AC0
	public static ReputationEntranceExcelConfig GetConfig(uint cityId, ReputationEntranceType entranceType) => default; // 0x000000018520FF00-0x0000000185210100
	// [XID] // 0x00000001898F83D0-0x00000001898F83F0
	public static void Register() {} // 0x00000001852116D0-0x0000000185211770
	// [XID] // 0x000000018990ED10-0x000000018990ED30
	public static void LoadData() {} // 0x00000001852107A0-0x0000000185210890
	// [XID] // 0x00000001899163E0-0x0000000189916400
	private static void RegisterHotfixGenerated() {} // 0x00000001852105D0-0x00000001852107A0
	// [XID] // 0x000000018991DD70-0x000000018991DD90
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001852101A0-0x00000001852105D0
	// [IDTag] // 0x00000001899254C0-0x0000000189925500
	// [XID] // 0x00000001899254C0-0x0000000189925500
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001852109D0-0x0000000185210AD0
	// [XID] // 0x000000018992FA40-0x000000018992FA60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationEntranceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001852113A0-0x00000001852116D0
	// [XID] // 0x0000000189936F70-0x0000000189936F90
	private static bool ParseConfigFromLine(string line, out ReputationEntranceExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185210890-0x00000001852109D0
	// [IDTag] // 0x000000018993EB30-0x000000018993EB70
	// [XID] // 0x000000018993EB30-0x000000018993EB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationEntranceExcelConfig> configList) => default; // 0x0000000185210AD0-0x0000000185210D70
	// [IDTag] // 0x0000000189949140-0x0000000189949180
	// [XID] // 0x0000000189949140-0x0000000189949180
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF98D */, bool useObjectPool = false /* Metadata: 0x00AEF991 */) => default; // 0x0000000185210D70-0x0000000185210FC0
	// [IDTag] // 0x00000001899536B0-0x00000001899536F0
	// [XID] // 0x00000001899536B0-0x00000001899536F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF992 */, bool useObjectPool = false /* Metadata: 0x00AEF996 */) => default; // 0x0000000185210FC0-0x00000001852112F0
}

