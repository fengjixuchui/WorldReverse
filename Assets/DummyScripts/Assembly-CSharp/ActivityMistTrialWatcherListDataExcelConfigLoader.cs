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

public static class ActivityMistTrialWatcherListDataExcelConfigLoader // TypeDefIndex: 15142
{
	// Fields
	private static Dictionary<uint, ActivityMistTrialWatcherListDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityMistTrialWatcherListDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityMistTrialWatcherListDataExcelConfig, ActivityMistTrialWatcherListDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityMistTrialWatcherListDataExcelConfig>, Dictionary<uint, ActivityMistTrialWatcherListDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityMistTrialWatcherListDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A93D70-0x0000000189A93D90 */ get; } // 0x00000001822B1AC0-0x00000001822B1B70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AA2C00-0x0000000189AA2C20 */ get; } // 0x00000001822B0910-0x00000001822B09B0 

	// Methods
	// [XID] // 0x0000000189A8C9B0-0x0000000189A8C9D0
	public static void Register() {} // 0x00000001822B1EA0-0x00000001822B1F40
	// [XID] // 0x0000000189A9B820-0x0000000189A9B840
	public static ActivityMistTrialWatcherListDataExcelConfig GetData(uint Id) => default; // 0x00000001822B07E0-0x00000001822B0910
	// [XID] // 0x0000000189AAA200-0x0000000189AAA220
	public static void LoadData() {} // 0x00000001822B0F40-0x00000001822B1030
	// [XID] // 0x0000000189AB2040-0x0000000189AB2060
	private static void RegisterHotfixGenerated() {} // 0x00000001822B0D70-0x00000001822B0F40
	// [XID] // 0x0000000189AB9290-0x0000000189AB92B0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001822B09B0-0x00000001822B0D70
	// [IDTag] // 0x0000000189AC0EB0-0x0000000189AC0EF0
	// [XID] // 0x0000000189AC0EB0-0x0000000189AC0EF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001822B1420-0x00000001822B1520
	// [XID] // 0x0000000189ACB8B0-0x0000000189ACB8D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityMistTrialWatcherListDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001822B1B70-0x00000001822B1EA0
	// [XID] // 0x0000000189AD3360-0x0000000189AD3380
	private static bool ParseConfigFromLine(string line, out ActivityMistTrialWatcherListDataExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001822B1030-0x00000001822B1170
	// [IDTag] // 0x0000000189ADADA0-0x0000000189ADADE0
	// [XID] // 0x0000000189ADADA0-0x0000000189ADADE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityMistTrialWatcherListDataExcelConfig> configList) => default; // 0x00000001822B1170-0x00000001822B1420
	// [IDTag] // 0x0000000189AE5A60-0x0000000189AE5AA0
	// [XID] // 0x0000000189AE5A60-0x0000000189AE5AA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0208 */, bool useObjectPool = false /* Metadata: 0x00AF020C */) => default; // 0x00000001822B1870-0x00000001822B1AC0
	// [IDTag] // 0x0000000189AF0550-0x0000000189AF0590
	// [XID] // 0x0000000189AF0550-0x0000000189AF0590
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF020D */, bool useObjectPool = false /* Metadata: 0x00AF0211 */) => default; // 0x00000001822B1520-0x00000001822B1870
}

