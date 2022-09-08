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

public static class ExpeditionDataExcelConfigLoader // TypeDefIndex: 15598
{
	// Fields
	private static Dictionary<uint, ExpeditionDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionDataExcelConfig, ExpeditionDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionDataExcelConfig>, Dictionary<uint, ExpeditionDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionDataExcelConfig> dataDict { /* [XID] */ /* 0x00000001895F9E80-0x00000001895F9EA0 */ get; } // 0x0000000180E5AF80-0x0000000180E5B030 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189608F70-0x0000000189608F90 */ get; } // 0x0000000180E59DD0-0x0000000180E59E70 

	// Methods
	// [XID] // 0x00000001895F2490-0x00000001895F24B0
	public static void Register() {} // 0x0000000180E5B360-0x0000000180E5B400
	// [XID] // 0x00000001896016E0-0x0000000189601700
	public static ExpeditionDataExcelConfig GetData(uint ID) => default; // 0x0000000180E59CA0-0x0000000180E59DD0
	// [XID] // 0x00000001896106F0-0x0000000189610710
	public static void LoadData() {} // 0x0000000180E5A400-0x0000000180E5A4F0
	// [XID] // 0x0000000189617A30-0x0000000189617A50
	private static void RegisterHotfixGenerated() {} // 0x0000000180E5A230-0x0000000180E5A400
	// [XID] // 0x000000018961F640-0x000000018961F660
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000180E59E70-0x0000000180E5A230
	// [IDTag] // 0x0000000189626A60-0x0000000189626AA0
	// [XID] // 0x0000000189626A60-0x0000000189626AA0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000180E5A8E0-0x0000000180E5A9E0
	// [XID] // 0x00000001896314A0-0x00000001896314C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000180E5B030-0x0000000180E5B360
	// [XID] // 0x0000000189638ED0-0x0000000189638EF0
	private static bool ParseConfigFromLine(string line, out ExpeditionDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000180E5A4F0-0x0000000180E5A630
	// [IDTag] // 0x00000001896402B0-0x00000001896402F0
	// [XID] // 0x00000001896402B0-0x00000001896402F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionDataExcelConfig> configList) => default; // 0x0000000180E5A630-0x0000000180E5A8E0
	// [IDTag] // 0x000000018964AAE0-0x000000018964AB20
	// [XID] // 0x000000018964AAE0-0x000000018964AB20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2024 */, bool useObjectPool = false /* Metadata: 0x00AF2028 */) => default; // 0x0000000180E5A9E0-0x0000000180E5AC30
	// [IDTag] // 0x0000000189655400-0x0000000189655440
	// [XID] // 0x0000000189655400-0x0000000189655440
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2029 */, bool useObjectPool = false /* Metadata: 0x00AF202D */) => default; // 0x0000000180E5AC30-0x0000000180E5AF80
}

