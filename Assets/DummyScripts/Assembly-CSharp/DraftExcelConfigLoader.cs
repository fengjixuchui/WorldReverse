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

public static class DraftExcelConfigLoader // TypeDefIndex: 15499
{
	// Fields
	private static Dictionary<uint, DraftExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DraftExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DraftExcelConfig, DraftExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DraftExcelConfig>, Dictionary<uint, DraftExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DraftExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B28690-0x0000000189B286B0 */ get; } // 0x000000018415DF80-0x000000018415E030 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B373F0-0x0000000189B37410 */ get; } // 0x000000018415CDD0-0x000000018415CE70 

	// Methods
	// [XID] // 0x0000000189B20F50-0x0000000189B20F70
	public static void Register() {} // 0x000000018415E360-0x000000018415E400
	// [XID] // 0x0000000189B2FA50-0x0000000189B2FA70
	public static DraftExcelConfig GetData(uint id) => default; // 0x000000018415CCA0-0x000000018415CDD0
	// [XID] // 0x0000000189B3EC60-0x0000000189B3EC80
	public static void LoadData() {} // 0x000000018415D400-0x000000018415D4F0
	// [XID] // 0x0000000189B46720-0x0000000189B46740
	private static void RegisterHotfixGenerated() {} // 0x000000018415D230-0x000000018415D400
	// [XID] // 0x0000000189B4DCA0-0x0000000189B4DCC0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018415CE70-0x000000018415D230
	// [IDTag] // 0x0000000189B554F0-0x0000000189B55530
	// [XID] // 0x0000000189B554F0-0x0000000189B55530
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018415D630-0x000000018415D730
	// [XID] // 0x0000000189B60060-0x0000000189B60080
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DraftExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018415E030-0x000000018415E360
	// [XID] // 0x0000000189B67720-0x0000000189B67740
	private static bool ParseConfigFromLine(string line, out DraftExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018415D4F0-0x000000018415D630
	// [IDTag] // 0x0000000189B6E980-0x0000000189B6E9C0
	// [XID] // 0x0000000189B6E980-0x0000000189B6E9C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DraftExcelConfig> configList) => default; // 0x000000018415D730-0x000000018415D9E0
	// [IDTag] // 0x0000000189B78FC0-0x0000000189B79000
	// [XID] // 0x0000000189B78FC0-0x0000000189B79000
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1C68 */, bool useObjectPool = false /* Metadata: 0x00AF1C6C */) => default; // 0x000000018415DD30-0x000000018415DF80
	// [IDTag] // 0x0000000189B838E0-0x0000000189B83920
	// [XID] // 0x0000000189B838E0-0x0000000189B83920
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C6D */, bool useObjectPool = false /* Metadata: 0x00AF1C71 */) => default; // 0x000000018415D9E0-0x000000018415DD30
}

