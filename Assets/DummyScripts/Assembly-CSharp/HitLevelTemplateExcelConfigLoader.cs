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

public static class HitLevelTemplateExcelConfigLoader // TypeDefIndex: 15330
{
	// Fields
	private static Dictionary<string, HitLevelTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HitLevelTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HitLevelTemplateExcelConfig, HitLevelTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HitLevelTemplateExcelConfig>, Dictionary<string, HitLevelTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, HitLevelTemplateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189659A10-0x0000000189659A30 */ get; } // 0x00000001842FE5D0-0x00000001842FE680 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189668C00-0x0000000189668C20 */ get; } // 0x00000001842FD430-0x00000001842FD4D0 

	// Methods
	// [XID] // 0x0000000189652320-0x0000000189652340
	public static void Register() {} // 0x00000001842FE9B0-0x00000001842FEA50
	// [XID] // 0x0000000189661150-0x0000000189661170
	public static HitLevelTemplateExcelConfig GetData(string type) => default; // 0x00000001842FD2F0-0x00000001842FD430
	// [XID] // 0x0000000189670770-0x0000000189670790
	public static void LoadData() {} // 0x00000001842FDA60-0x00000001842FDB50
	// [XID] // 0x0000000189677F70-0x0000000189677F90
	private static void RegisterHotfixGenerated() {} // 0x00000001842FD890-0x00000001842FDA60
	// [XID] // 0x000000018967F680-0x000000018967F6A0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001842FD4D0-0x00000001842FD890
	// [IDTag] // 0x0000000189686F10-0x0000000189686F50
	// [XID] // 0x0000000189686F10-0x0000000189686F50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001842FDC90-0x00000001842FDD90
	// [XID] // 0x0000000189691EF0-0x0000000189691F10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HitLevelTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001842FE680-0x00000001842FE9B0
	// [XID] // 0x00000001896993E0-0x0000000189699400
	private static bool ParseConfigFromLine(string line, out HitLevelTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001842FDB50-0x00000001842FDC90
	// [IDTag] // 0x00000001896A0850-0x00000001896A0890
	// [XID] // 0x00000001896A0850-0x00000001896A0890
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HitLevelTemplateExcelConfig> configList) => default; // 0x00000001842FDD90-0x00000001842FE030
	// [IDTag] // 0x00000001896AAC50-0x00000001896AAC90
	// [XID] // 0x00000001896AAC50-0x00000001896AAC90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF07BD */, bool useObjectPool = false /* Metadata: 0x00AF07C1 */) => default; // 0x00000001842FE030-0x00000001842FE280
	// [IDTag] // 0x00000001896B5270-0x00000001896B52B0
	// [XID] // 0x00000001896B5270-0x00000001896B52B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07C2 */, bool useObjectPool = false /* Metadata: 0x00AF07C6 */) => default; // 0x00000001842FE280-0x00000001842FE5D0
}

