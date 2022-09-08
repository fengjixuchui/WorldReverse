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

public static class DraftTextDataExcelConfigLoader // TypeDefIndex: 15501
{
	// Fields
	private static Dictionary<uint, DraftTextDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DraftTextDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DraftTextDataExcelConfig, DraftTextDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DraftTextDataExcelConfig>, Dictionary<uint, DraftTextDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DraftTextDataExcelConfig> dataDict { /* [XID] */ /* 0x000000018971CC20-0x000000018971CC40 */ get; } // 0x00000001823D0240-0x00000001823D02F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018972B7F0-0x000000018972B810 */ get; } // 0x00000001823CF090-0x00000001823CF130 

	// Methods
	// [XID] // 0x0000000189715110-0x0000000189715130
	public static void Register() {} // 0x00000001823D0620-0x00000001823D06C0
	// [XID] // 0x0000000189724090-0x00000001897240B0
	public static DraftTextDataExcelConfig GetData(uint draftId) => default; // 0x00000001823CEF60-0x00000001823CF090
	// [XID] // 0x0000000189732FC0-0x0000000189732FE0
	public static void LoadData() {} // 0x00000001823CF6C0-0x00000001823CF7B0
	// [XID] // 0x000000018973A610-0x000000018973A630
	private static void RegisterHotfixGenerated() {} // 0x00000001823CF4F0-0x00000001823CF6C0
	// [XID] // 0x0000000189742040-0x0000000189742060
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823CF130-0x00000001823CF4F0
	// [IDTag] // 0x0000000189749A80-0x0000000189749AC0
	// [XID] // 0x0000000189749A80-0x0000000189749AC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823CFBA0-0x00000001823CFCA0
	// [XID] // 0x0000000189753EC0-0x0000000189753EE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DraftTextDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823D02F0-0x00000001823D0620
	// [XID] // 0x000000018975B400-0x000000018975B420
	private static bool ParseConfigFromLine(string line, out DraftTextDataExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001823CF7B0-0x00000001823CF8F0
	// [IDTag] // 0x0000000189762DF0-0x0000000189762E30
	// [XID] // 0x0000000189762DF0-0x0000000189762E30
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DraftTextDataExcelConfig> configList) => default; // 0x00000001823CF8F0-0x00000001823CFBA0
	// [IDTag] // 0x000000018976D3C0-0x000000018976D400
	// [XID] // 0x000000018976D3C0-0x000000018976D400
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1C77 */, bool useObjectPool = false /* Metadata: 0x00AF1C7B */) => default; // 0x00000001823CFCA0-0x00000001823CFEF0
	// [IDTag] // 0x0000000189777950-0x0000000189777990
	// [XID] // 0x0000000189777950-0x0000000189777990
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C7C */, bool useObjectPool = false /* Metadata: 0x00AF1C80 */) => default; // 0x00000001823CFEF0-0x00000001823D0240
}

