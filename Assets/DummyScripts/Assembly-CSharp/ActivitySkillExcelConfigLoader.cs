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

public static class ActivitySkillExcelConfigLoader // TypeDefIndex: 15231
{
	// Fields
	private static Dictionary<uint, ActivitySkillExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivitySkillExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivitySkillExcelConfig, ActivitySkillExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivitySkillExcelConfig>, Dictionary<uint, ActivitySkillExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivitySkillExcelConfig> dataDict { /* [XID] */ /* 0x0000000189656C30-0x0000000189656C50 */ get; } // 0x00000001817E3350-0x00000001817E3400 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189665A70-0x0000000189665A90 */ get; } // 0x00000001817E21A0-0x00000001817E2240 

	// Methods
	// [XID] // 0x000000018964F2A0-0x000000018964F2C0
	public static void Register() {} // 0x00000001817E3730-0x00000001817E37D0
	// [XID] // 0x000000018965E330-0x000000018965E350
	public static ActivitySkillExcelConfig GetData(uint id) => default; // 0x00000001817E2070-0x00000001817E21A0
	// [XID] // 0x000000018966D120-0x000000018966D140
	public static void LoadData() {} // 0x00000001817E27D0-0x00000001817E28C0
	// [XID] // 0x0000000189675050-0x0000000189675070
	private static void RegisterHotfixGenerated() {} // 0x00000001817E2600-0x00000001817E27D0
	// [XID] // 0x000000018967C820-0x000000018967C840
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001817E2240-0x00000001817E2600
	// [IDTag] // 0x0000000189683ED0-0x0000000189683F10
	// [XID] // 0x0000000189683ED0-0x0000000189683F10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001817E2A00-0x00000001817E2B00
	// [XID] // 0x000000018968ED70-0x000000018968ED90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivitySkillExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001817E3400-0x00000001817E3730
	// [XID] // 0x00000001896966D0-0x00000001896966F0
	private static bool ParseConfigFromLine(string line, out ActivitySkillExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001817E28C0-0x00000001817E2A00
	// [IDTag] // 0x000000018969DD50-0x000000018969DD90
	// [XID] // 0x000000018969DD50-0x000000018969DD90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivitySkillExcelConfig> configList) => default; // 0x00000001817E2B00-0x00000001817E2DB0
	// [IDTag] // 0x00000001896A7E60-0x00000001896A7EA0
	// [XID] // 0x00000001896A7E60-0x00000001896A7EA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0476 */, bool useObjectPool = false /* Metadata: 0x00AF047A */) => default; // 0x00000001817E3100-0x00000001817E3350
	// [IDTag] // 0x00000001896B1C90-0x00000001896B1CD0
	// [XID] // 0x00000001896B1C90-0x00000001896B1CD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF047B */, bool useObjectPool = false /* Metadata: 0x00AF047F */) => default; // 0x00000001817E2DB0-0x00000001817E3100
}

