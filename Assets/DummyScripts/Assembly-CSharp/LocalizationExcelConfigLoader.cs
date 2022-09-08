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

public static class LocalizationExcelConfigLoader // TypeDefIndex: 14872
{
	// Fields
	private static Dictionary<string, uint> _defaultPathDic; // 0x00
	private static Dictionary<uint, LocalizationExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<LocalizationExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<LocalizationExcelConfig, LocalizationExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<LocalizationExcelConfig>, Dictionary<uint, LocalizationExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, LocalizationExcelConfig> dataDict { /* [XID] */ /* 0x0000000189754120-0x0000000189754140 */ get; } // 0x00000001828CB580-0x00000001828CB650 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189762FF0-0x0000000189763010 */ get; } // 0x00000001828C9BB0-0x00000001828C9C50 

	// Constructors
	static LocalizationExcelConfigLoader() {} // 0x00000001828CBA60-0x00000001828CBAF0

	// Methods
	// [XID] // 0x000000018973DE70-0x000000018973DE90
	public static void BuildPathToIdMap() {} // 0x00000001828C9C50-0x00000001828C9F80
	// [XID] // 0x00000001897452B0-0x00000001897452D0
	public static LocalizationExcelConfig GetLocalizationConfigByDefaultPath(string defaultPath) => default; // 0x00000001828CA940-0x00000001828CAA90
	// [XID] // 0x000000018974CDA0-0x000000018974CDC0
	public static void Register() {} // 0x00000001828CB9A0-0x00000001828CBA60
	// [XID] // 0x000000018975B520-0x000000018975B540
	public static LocalizationExcelConfig GetData(uint id) => default; // 0x00000001828C9A10-0x00000001828C9BB0
	// [XID] // 0x000000018976A5F0-0x000000018976A610
	public static void LoadData() {} // 0x00000001828CA6D0-0x00000001828CA800
	// [XID] // 0x0000000189771D70-0x0000000189771D90
	private static void RegisterHotfixGenerated() {} // 0x00000001828CA460-0x00000001828CA6D0
	// [XID] // 0x0000000189779520-0x0000000189779540
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001828C9F80-0x00000001828CA460
	// [IDTag] // 0x0000000189780DE0-0x0000000189780E20
	// [XID] // 0x0000000189780DE0-0x0000000189780E20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001828CAA90-0x00000001828CABF0
	// [XID] // 0x000000018978B580-0x000000018978B5A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LocalizationExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001828CB650-0x00000001828CB9A0
	// [XID] // 0x0000000189792A40-0x0000000189792A60
	private static bool ParseConfigFromLine(string line, out LocalizationExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001828CA800-0x00000001828CA940
	// [IDTag] // 0x0000000189799FD0-0x000000018979A010
	// [XID] // 0x0000000189799FD0-0x000000018979A010
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LocalizationExcelConfig> configList) => default; // 0x00000001828CABF0-0x00000001828CAF40
	// [IDTag] // 0x00000001897A5110-0x00000001897A5150
	// [XID] // 0x00000001897A5110-0x00000001897A5150
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF896 */, bool useObjectPool = false /* Metadata: 0x00AEF89A */) => default; // 0x00000001828CAF40-0x00000001828CB1F0
	// [IDTag] // 0x00000001897AF830-0x00000001897AF870
	// [XID] // 0x00000001897AF830-0x00000001897AF870
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF89B */, bool useObjectPool = false /* Metadata: 0x00AEF89F */) => default; // 0x00000001828CB1F0-0x00000001828CB580
}

