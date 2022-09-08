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

public static class LockTemplateExcelConfigLoader // TypeDefIndex: 15328
{
	// Fields
	private static Dictionary<string, LockTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LockTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LockTemplateExcelConfig, LockTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LockTemplateExcelConfig>, Dictionary<string, LockTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, LockTemplateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B44ED0-0x0000000189B44EF0 */ get; } // 0x0000000182920140-0x00000001829201F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B53D20-0x0000000189B53D40 */ get; } // 0x000000018291EFA0-0x000000018291F040 

	// Methods
	// [XID] // 0x0000000189B3D060-0x0000000189B3D080
	public static void Register() {} // 0x0000000182920520-0x00000001829205C0
	// [XID] // 0x0000000189916AB0-0x0000000189916AD0
	public static LockTemplateExcelConfig GetData(string type) => default; // 0x000000018291EE60-0x000000018291EFA0
	// [XID] // 0x0000000189B5B630-0x0000000189B5B650
	public static void LoadData() {} // 0x000000018291F5D0-0x000000018291F6C0
	// [XID] // 0x0000000189B62AA0-0x0000000189B62AC0
	private static void RegisterHotfixGenerated() {} // 0x000000018291F400-0x000000018291F5D0
	// [XID] // 0x0000000189B6A590-0x0000000189B6A5B0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018291F040-0x000000018291F400
	// [IDTag] // 0x0000000189B71C90-0x0000000189B71CD0
	// [XID] // 0x0000000189B71C90-0x0000000189B71CD0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018291F800-0x000000018291F900
	// [XID] // 0x0000000189B7C030-0x0000000189B7C050
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LockTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001829201F0-0x0000000182920520
	// [XID] // 0x0000000189B83940-0x0000000189B83960
	private static bool ParseConfigFromLine(string line, out LockTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018291F6C0-0x000000018291F800
	// [IDTag] // 0x0000000189B8ABB0-0x0000000189B8ABF0
	// [XID] // 0x0000000189B8ABB0-0x0000000189B8ABF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LockTemplateExcelConfig> configList) => default; // 0x000000018291F900-0x000000018291FBA0
	// [IDTag] // 0x0000000189B950D0-0x0000000189B95110
	// [XID] // 0x0000000189B950D0-0x0000000189B95110
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF07AE */, bool useObjectPool = false /* Metadata: 0x00AF07B2 */) => default; // 0x000000018291FEF0-0x0000000182920140
	// [IDTag] // 0x0000000189B9F570-0x0000000189B9F5B0
	// [XID] // 0x0000000189B9F570-0x0000000189B9F5B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07B3 */, bool useObjectPool = false /* Metadata: 0x00AF07B7 */) => default; // 0x000000018291FBA0-0x000000018291FEF0
}

