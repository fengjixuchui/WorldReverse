/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RandomQuestEntranceExcelConfigLoader // TypeDefIndex: 15981
{
	// Fields
	private static List<RandomQuestEntranceExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandomQuestEntranceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandomQuestEntranceExcelConfig, RandomQuestEntranceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandomQuestEntranceExcelConfig>, List<RandomQuestEntranceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<RandomQuestEntranceExcelConfig> dataList { /* [XID] */ /* 0x000000018964F180-0x000000018964F1A0 */ get; } // 0x0000000183134400-0x00000001831344B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189656AF0-0x0000000189656B10 */ get; } // 0x0000000183133210-0x00000001831332B0 

	// Methods
	// [XID] // 0x0000000189647AD0-0x0000000189647AF0
	public static void Register() {} // 0x00000001831347E0-0x0000000183134880
	// [XID] // 0x000000018965E1B0-0x000000018965E1D0
	public static void LoadData() {} // 0x00000001831338B0-0x00000001831339A0
	// [XID] // 0x0000000189665870-0x0000000189665890
	private static void RegisterHotfixGenerated() {} // 0x00000001831336E0-0x00000001831338B0
	// [XID] // 0x000000018966CFA0-0x000000018966CFC0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001831332B0-0x00000001831336E0
	// [IDTag] // 0x0000000189674E50-0x0000000189674E90
	// [XID] // 0x0000000189674E50-0x0000000189674E90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183133AE0-0x0000000183133BE0
	// [XID] // 0x000000018967F4E0-0x000000018967F500
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandomQuestEntranceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001831344B0-0x00000001831347E0
	// [XID] // 0x0000000189686D50-0x0000000189686D70
	private static bool ParseConfigFromLine(string line, out RandomQuestEntranceExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001831339A0-0x0000000183133AE0
	// [IDTag] // 0x000000018968EC50-0x000000018968EC90
	// [XID] // 0x000000018968EC50-0x000000018968EC90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandomQuestEntranceExcelConfig> configList) => default; // 0x0000000183133BE0-0x0000000183133E80
	// [IDTag] // 0x00000001896992C0-0x0000000189699300
	// [XID] // 0x00000001896992C0-0x0000000189699300
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2CDE */, bool useObjectPool = false /* Metadata: 0x00AF2CE2 */) => default; // 0x0000000183133E80-0x00000001831340D0
	// [IDTag] // 0x00000001896A36E0-0x00000001896A3720
	// [XID] // 0x00000001896A36E0-0x00000001896A3720
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CE3 */, bool useObjectPool = false /* Metadata: 0x00AF2CE7 */) => default; // 0x00000001831340D0-0x0000000183134400
}

