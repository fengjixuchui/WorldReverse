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

public static class TemplateReminderExcelConfigLoader // TypeDefIndex: 16036
{
	// Fields
	private static Dictionary<uint, TemplateReminderExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TemplateReminderExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TemplateReminderExcelConfig, TemplateReminderExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TemplateReminderExcelConfig>, Dictionary<uint, TemplateReminderExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TemplateReminderExcelConfig> dataDict { /* [XID] */ /* 0x0000000189732F60-0x0000000189732F80 */ get; } // 0x0000000185614950-0x0000000185614A00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189741FA0-0x0000000189741FC0 */ get; } // 0x00000001856137A0-0x0000000185613840 

	// Methods
	// [XID] // 0x000000018972B770-0x000000018972B790
	public static void Register() {} // 0x0000000185614D30-0x0000000185614DD0
	// [XID] // 0x000000018973A5F0-0x000000018973A610
	public static TemplateReminderExcelConfig GetData(uint id) => default; // 0x0000000185613670-0x00000001856137A0
	// [XID] // 0x00000001897499E0-0x0000000189749A00
	public static void LoadData() {} // 0x0000000185613DD0-0x0000000185613EC0
	// [XID] // 0x0000000189750EE0-0x0000000189750F00
	private static void RegisterHotfixGenerated() {} // 0x0000000185613C00-0x0000000185613DD0
	// [XID] // 0x0000000189758350-0x0000000189758370
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185613840-0x0000000185613C00
	// [IDTag] // 0x000000018975FDF0-0x000000018975FE30
	// [XID] // 0x000000018975FDF0-0x000000018975FE30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001856142B0-0x00000001856143B0
	// [XID] // 0x000000018976A290-0x000000018976A2B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TemplateReminderExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185614A00-0x0000000185614D30
	// [XID] // 0x0000000189771B10-0x0000000189771B30
	private static bool ParseConfigFromLine(string line, out TemplateReminderExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185613EC0-0x0000000185614000
	// [IDTag] // 0x00000001897792A0-0x00000001897792E0
	// [XID] // 0x00000001897792A0-0x00000001897792E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TemplateReminderExcelConfig> configList) => default; // 0x0000000185614000-0x00000001856142B0
	// [IDTag] // 0x0000000189783AB0-0x0000000189783AF0
	// [XID] // 0x0000000189783AB0-0x0000000189783AF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E82 */, bool useObjectPool = false /* Metadata: 0x00AF2E86 */) => default; // 0x0000000185614700-0x0000000185614950
	// [IDTag] // 0x000000018978DF10-0x000000018978DF50
	// [XID] // 0x000000018978DF10-0x000000018978DF50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E87 */, bool useObjectPool = false /* Metadata: 0x00AF2E8B */) => default; // 0x00000001856143B0-0x0000000185614700
}

