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

public static class TauntLevelTemplateExcelConfigLoader // TypeDefIndex: 15326
{
	// Fields
	private static Dictionary<int, TauntLevelTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TauntLevelTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TauntLevelTemplateExcelConfig, TauntLevelTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TauntLevelTemplateExcelConfig>, Dictionary<int, TauntLevelTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, TauntLevelTemplateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A33B00-0x0000000189A33B20 */ get; } // 0x000000018146E230-0x000000018146E2E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A42D50-0x0000000189A42D70 */ get; } // 0x000000018146D080-0x000000018146D120 

	// Methods
	// [XID] // 0x0000000189A2C3D0-0x0000000189A2C3F0
	public static void Register() {} // 0x000000018146E610-0x000000018146E6B0
	// [XID] // 0x0000000189A3B2A0-0x0000000189A3B2C0
	public static TauntLevelTemplateExcelConfig GetData(TauntLevel type) => default; // 0x000000018146CF50-0x000000018146D080
	// [XID] // 0x0000000189A4A1E0-0x0000000189A4A200
	public static void LoadData() {} // 0x000000018146D6B0-0x000000018146D7A0
	// [XID] // 0x0000000189A51BB0-0x0000000189A51BD0
	private static void RegisterHotfixGenerated() {} // 0x000000018146D4E0-0x000000018146D6B0
	// [XID] // 0x0000000189A59300-0x0000000189A59320
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018146D120-0x000000018146D4E0
	// [IDTag] // 0x0000000189A60C80-0x0000000189A60CC0
	// [XID] // 0x0000000189A60C80-0x0000000189A60CC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018146DB90-0x000000018146DC90
	// [XID] // 0x0000000189A6B790-0x0000000189A6B7B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TauntLevelTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018146E2E0-0x000000018146E610
	// [XID] // 0x0000000189A72E60-0x0000000189A72E80
	private static bool ParseConfigFromLine(string line, out TauntLevelTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018146D7A0-0x000000018146D8E0
	// [IDTag] // 0x0000000189A7AA30-0x0000000189A7AA70
	// [XID] // 0x0000000189A7AA30-0x0000000189A7AA70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TauntLevelTemplateExcelConfig> configList) => default; // 0x000000018146D8E0-0x000000018146DB90
	// [IDTag] // 0x0000000189A85020-0x0000000189A85060
	// [XID] // 0x0000000189A85020-0x0000000189A85060
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF079F */, bool useObjectPool = false /* Metadata: 0x00AF07A3 */) => default; // 0x000000018146DC90-0x000000018146DEE0
	// [IDTag] // 0x0000000189A8F990-0x0000000189A8F9D0
	// [XID] // 0x0000000189A8F990-0x0000000189A8F9D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07A4 */, bool useObjectPool = false /* Metadata: 0x00AF07A8 */) => default; // 0x000000018146DEE0-0x000000018146E230
}

