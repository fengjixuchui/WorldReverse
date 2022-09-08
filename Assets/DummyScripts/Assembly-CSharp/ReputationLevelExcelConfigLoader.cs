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

public static class ReputationLevelExcelConfigLoader // TypeDefIndex: 14904
{
	// Fields
	private static List<ReputationLevelExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationLevelExcelConfig, ReputationLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationLevelExcelConfig>, List<ReputationLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReputationLevelExcelConfig> dataList { /* [XID] */ /* 0x00000001896AAD90-0x00000001896AADB0 */ get; } // 0x000000018179EB00-0x000000018179EBB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896B1DD0-0x00000001896B1DF0 */ get; } // 0x000000018179D710-0x000000018179D7B0 

	// Methods
	// [XID] // 0x0000000189694CE0-0x0000000189694D00
	public static ReputationLevelExcelConfig GetConfig(uint cityId, uint level) => default; // 0x000000018179D510-0x000000018179D710
	// [XID] // 0x000000018969C460-0x000000018969C480
	public static List<ReputationLevelExcelConfig> GetCityConfigList(uint cityId) => default; // 0x000000018179DFE0-0x000000018179E1E0
	// [XID] // 0x00000001896A3900-0x00000001896A3920
	public static void Register() {} // 0x000000018179EEE0-0x000000018179EF80
	// [XID] // 0x00000001896B9870-0x00000001896B9890
	public static void LoadData() {} // 0x000000018179DDB0-0x000000018179DEA0
	// [XID] // 0x00000001896C0BC0-0x00000001896C0BE0
	private static void RegisterHotfixGenerated() {} // 0x000000018179DBE0-0x000000018179DDB0
	// [XID] // 0x00000001896C8290-0x00000001896C82B0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018179D7B0-0x000000018179DBE0
	// [IDTag] // 0x00000001896CFC50-0x00000001896CFC90
	// [XID] // 0x00000001896CFC50-0x00000001896CFC90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018179E1E0-0x000000018179E2E0
	// [XID] // 0x00000001896DA110-0x00000001896DA130
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018179EBB0-0x000000018179EEE0
	// [XID] // 0x00000001896E16F0-0x00000001896E1710
	private static bool ParseConfigFromLine(string line, out ReputationLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018179DEA0-0x000000018179DFE0
	// [IDTag] // 0x00000001896E8AC0-0x00000001896E8B00
	// [XID] // 0x00000001896E8AC0-0x00000001896E8B00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationLevelExcelConfig> configList) => default; // 0x000000018179E2E0-0x000000018179E580
	// [IDTag] // 0x00000001896F3010-0x00000001896F3050
	// [XID] // 0x00000001896F3010-0x00000001896F3050
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF974 */, bool useObjectPool = false /* Metadata: 0x00AEF978 */) => default; // 0x000000018179E8B0-0x000000018179EB00
	// [IDTag] // 0x00000001896FD990-0x00000001896FD9D0
	// [XID] // 0x00000001896FD990-0x00000001896FD9D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF979 */, bool useObjectPool = false /* Metadata: 0x00AEF97D */) => default; // 0x000000018179E580-0x000000018179E8B0
}

