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

public static class AbilityStateResistanceByIDExcelConfigLoader // TypeDefIndex: 15229
{
	// Fields
	private static Dictionary<uint, AbilityStateResistanceByIDExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AbilityStateResistanceByIDExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AbilityStateResistanceByIDExcelConfig, AbilityStateResistanceByIDExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AbilityStateResistanceByIDExcelConfig>, Dictionary<uint, AbilityStateResistanceByIDExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AbilityStateResistanceByIDExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A7EDA0-0x0000000189A7EDC0 */ get; } // 0x0000000181F1F1B0-0x0000000181F1F260 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A8E170-0x0000000189A8E190 */ get; } // 0x0000000181F1E000-0x0000000181F1E0A0 

	// Methods
	// [XID] // 0x0000000189A774F0-0x0000000189A77510
	public static void Register() {} // 0x0000000181F1F590-0x0000000181F1F630
	// [XID] // 0x0000000189A865B0-0x0000000189A865D0
	public static AbilityStateResistanceByIDExcelConfig GetData(uint id) => default; // 0x0000000181F1DED0-0x0000000181F1E000
	// [XID] // 0x0000000189A955F0-0x0000000189A95610
	public static void LoadData() {} // 0x0000000181F1E630-0x0000000181F1E720
	// [XID] // 0x0000000189A9CEF0-0x0000000189A9CF10
	private static void RegisterHotfixGenerated() {} // 0x0000000181F1E460-0x0000000181F1E630
	// [XID] // 0x0000000189AA45C0-0x0000000189AA45E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F1E0A0-0x0000000181F1E460
	// [IDTag] // 0x0000000189AABBF0-0x0000000189AABC30
	// [XID] // 0x0000000189AABBF0-0x0000000189AABC30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F1E860-0x0000000181F1E960
	// [XID] // 0x0000000189AB6560-0x0000000189AB6580
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AbilityStateResistanceByIDExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F1F260-0x0000000181F1F590
	// [XID] // 0x0000000189ABE070-0x0000000189ABE090
	private static bool ParseConfigFromLine(string line, out AbilityStateResistanceByIDExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F1E720-0x0000000181F1E860
	// [IDTag] // 0x0000000189AC5B90-0x0000000189AC5BD0
	// [XID] // 0x0000000189AC5B90-0x0000000189AC5BD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AbilityStateResistanceByIDExcelConfig> configList) => default; // 0x0000000181F1E960-0x0000000181F1EC10
	// [IDTag] // 0x0000000189ACFFB0-0x0000000189ACFFF0
	// [XID] // 0x0000000189ACFFB0-0x0000000189ACFFF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0467 */, bool useObjectPool = false /* Metadata: 0x00AF046B */) => default; // 0x0000000181F1EC10-0x0000000181F1EE60
	// [IDTag] // 0x0000000189ADAD40-0x0000000189ADAD80
	// [XID] // 0x0000000189ADAD40-0x0000000189ADAD80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF046C */, bool useObjectPool = false /* Metadata: 0x00AF0470 */) => default; // 0x0000000181F1EE60-0x0000000181F1F1B0
}

