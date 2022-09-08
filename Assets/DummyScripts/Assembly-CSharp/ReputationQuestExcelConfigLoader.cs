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

public static class ReputationQuestExcelConfigLoader // TypeDefIndex: 14905
{
	// Fields
	private static List<ReputationQuestExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationQuestExcelConfig, ReputationQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationQuestExcelConfig>, List<ReputationQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReputationQuestExcelConfig> dataList { /* [XID] */ /* 0x0000000189725B60-0x0000000189725B80 */ get; } // 0x000000018394F7C0-0x000000018394F870 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018972D120-0x000000018972D140 */ get; } // 0x000000018394E3D0-0x000000018394E470 

	// Methods
	// [XID] // 0x0000000189716B00-0x0000000189716B20
	public static List<ReputationQuestExcelConfig> GetCityConfigList(uint cityId) => default; // 0x000000018394ECA0-0x000000018394EEA0
	// [XID] // 0x000000018971E500-0x000000018971E520
	public static void Register() {} // 0x000000018394FBA0-0x000000018394FC40
	// [XID] // 0x00000001897348D0-0x00000001897348F0
	public static void LoadData() {} // 0x000000018394EA70-0x000000018394EB60
	// [XID] // 0x000000018973C260-0x000000018973C280
	private static void RegisterHotfixGenerated() {} // 0x000000018394E8A0-0x000000018394EA70
	// [XID] // 0x00000001897439F0-0x0000000189743A10
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018394E470-0x000000018394E8A0
	// [IDTag] // 0x000000018974B520-0x000000018974B560
	// [XID] // 0x000000018974B520-0x000000018974B560
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018394EEA0-0x000000018394EFA0
	// [XID] // 0x0000000189755AB0-0x0000000189755AD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018394F870-0x000000018394FBA0
	// [XID] // 0x000000018975CD90-0x000000018975CDB0
	private static bool ParseConfigFromLine(string line, out ReputationQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018394EB60-0x000000018394ECA0
	// [IDTag] // 0x00000001897645E0-0x0000000189764620
	// [XID] // 0x00000001897645E0-0x0000000189764620
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationQuestExcelConfig> configList) => default; // 0x000000018394EFA0-0x000000018394F240
	// [IDTag] // 0x000000018976EB80-0x000000018976EBC0
	// [XID] // 0x000000018976EB80-0x000000018976EBC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF97E */, bool useObjectPool = false /* Metadata: 0x00AEF982 */) => default; // 0x000000018394F570-0x000000018394F7C0
	// [IDTag] // 0x00000001897794C0-0x0000000189779500
	// [XID] // 0x00000001897794C0-0x0000000189779500
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF983 */, bool useObjectPool = false /* Metadata: 0x00AEF987 */) => default; // 0x000000018394F240-0x000000018394F570
}

