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

public static class MpPlayAbilityGroupExcelConfigLoader // TypeDefIndex: 15880
{
	// Fields
	private static Dictionary<uint, MpPlayAbilityGroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayAbilityGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayAbilityGroupExcelConfig, MpPlayAbilityGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayAbilityGroupExcelConfig>, Dictionary<uint, MpPlayAbilityGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayAbilityGroupExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B804F0-0x0000000189B80510 */ get; } // 0x000000018461FE50-0x000000018461FF00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B8F290-0x0000000189B8F2B0 */ get; } // 0x000000018461ECA0-0x000000018461ED40 

	// Methods
	// [XID] // 0x0000000189B78F60-0x0000000189B78F80
	public static void Register() {} // 0x0000000184620230-0x00000001846202D0
	// [XID] // 0x0000000189B88040-0x0000000189B88060
	public static MpPlayAbilityGroupExcelConfig GetData(uint index) => default; // 0x000000018461EB70-0x000000018461ECA0
	// [XID] // 0x0000000189B96760-0x0000000189B96780
	public static void LoadData() {} // 0x000000018461F2D0-0x000000018461F3C0
	// [XID] // 0x0000000189B9DCC0-0x0000000189B9DCE0
	private static void RegisterHotfixGenerated() {} // 0x000000018461F100-0x000000018461F2D0
	// [XID] // 0x0000000189BA55F0-0x0000000189BA5610
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018461ED40-0x000000018461F100
	// [IDTag] // 0x0000000189BAC7D0-0x0000000189BAC810
	// [XID] // 0x0000000189BAC7D0-0x0000000189BAC810
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018461F7B0-0x000000018461F8B0
	// [XID] // 0x0000000189BB6E50-0x0000000189BB6E70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayAbilityGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018461FF00-0x0000000184620230
	// [XID] // 0x0000000189BBE410-0x0000000189BBE430
	private static bool ParseConfigFromLine(string line, out MpPlayAbilityGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018461F3C0-0x000000018461F500
	// [IDTag] // 0x0000000189BC6160-0x0000000189BC61A0
	// [XID] // 0x0000000189BC6160-0x0000000189BC61A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayAbilityGroupExcelConfig> configList) => default; // 0x000000018461F500-0x000000018461F7B0
	// [IDTag] // 0x0000000189BD0AD0-0x0000000189BD0B10
	// [XID] // 0x0000000189BD0AD0-0x0000000189BD0B10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF293C */, bool useObjectPool = false /* Metadata: 0x00AF2940 */) => default; // 0x000000018461FC00-0x000000018461FE50
	// [IDTag] // 0x0000000189BDB420-0x0000000189BDB460
	// [XID] // 0x0000000189BDB420-0x0000000189BDB460
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2941 */, bool useObjectPool = false /* Metadata: 0x00AF2945 */) => default; // 0x000000018461F8B0-0x000000018461FC00
}

