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

public static class ReputationRequestExcelConfigLoader // TypeDefIndex: 16046
{
	// Fields
	private static Dictionary<uint, ReputationRequestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationRequestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationRequestExcelConfig, ReputationRequestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationRequestExcelConfig>, Dictionary<uint, ReputationRequestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReputationRequestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B04D60-0x0000000189B04D80 */ get; } // 0x0000000181B44560-0x0000000181B44610 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B13AB0-0x0000000189B13AD0 */ get; } // 0x0000000181B433B0-0x0000000181B43450 

	// Methods
	// [XID] // 0x0000000189AFD650-0x0000000189AFD670
	public static void Register() {} // 0x0000000181B44940-0x0000000181B449E0
	// [XID] // 0x0000000189B0C5B0-0x0000000189B0C5D0
	public static ReputationRequestExcelConfig GetData(uint RequestId) => default; // 0x0000000181B43280-0x0000000181B433B0
	// [XID] // 0x0000000189B1B160-0x0000000189B1B180
	public static void LoadData() {} // 0x0000000181B439E0-0x0000000181B43AD0
	// [XID] // 0x0000000189B228D0-0x0000000189B228F0
	private static void RegisterHotfixGenerated() {} // 0x0000000181B43810-0x0000000181B439E0
	// [XID] // 0x0000000189B29E60-0x0000000189B29E80
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181B43450-0x0000000181B43810
	// [IDTag] // 0x0000000189B314B0-0x0000000189B314F0
	// [XID] // 0x0000000189B314B0-0x0000000189B314F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181B43C10-0x0000000181B43D10
	// [XID] // 0x0000000189B3BA50-0x0000000189B3BA70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationRequestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181B44610-0x0000000181B44940
	// [XID] // 0x0000000189B434D0-0x0000000189B434F0
	private static bool ParseConfigFromLine(string line, out ReputationRequestExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181B43AD0-0x0000000181B43C10
	// [IDTag] // 0x0000000189B4AC50-0x0000000189B4AC90
	// [XID] // 0x0000000189B4AC50-0x0000000189B4AC90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationRequestExcelConfig> configList) => default; // 0x0000000181B43D10-0x0000000181B43FC0
	// [IDTag] // 0x0000000189B553F0-0x0000000189B55430
	// [XID] // 0x0000000189B553F0-0x0000000189B55430
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2ECE */, bool useObjectPool = false /* Metadata: 0x00AF2ED2 */) => default; // 0x0000000181B43FC0-0x0000000181B44210
	// [IDTag] // 0x0000000189B5FF60-0x0000000189B5FFA0
	// [XID] // 0x0000000189B5FF60-0x0000000189B5FFA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2ED3 */, bool useObjectPool = false /* Metadata: 0x00AF2ED7 */) => default; // 0x0000000181B44210-0x0000000181B44560
}

