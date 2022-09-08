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

public static class AchievementExcelConfigLoader // TypeDefIndex: 14994
{
	// Fields
	private static Dictionary<uint, AchievementExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AchievementExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AchievementExcelConfig, AchievementExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AchievementExcelConfig>, Dictionary<uint, AchievementExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AchievementExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AD7E20-0x0000000189AD7E40 */ get; } // 0x000000018511D740-0x000000018511D7F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE7070-0x0000000189AE7090 */ get; } // 0x000000018511C590-0x000000018511C630 

	// Methods
	// [XID] // 0x0000000189AD00B0-0x0000000189AD00D0
	public static void Register() {} // 0x000000018511DB20-0x000000018511DBC0
	// [XID] // 0x0000000189ADFA10-0x0000000189ADFA30
	public static AchievementExcelConfig GetData(uint id) => default; // 0x000000018511C460-0x000000018511C590
	// [XID] // 0x0000000189AEECC0-0x0000000189AEECE0
	public static void LoadData() {} // 0x000000018511CBC0-0x000000018511CCB0
	// [XID] // 0x0000000189AF61F0-0x0000000189AF6210
	private static void RegisterHotfixGenerated() {} // 0x000000018511C9F0-0x000000018511CBC0
	// [XID] // 0x0000000189AFD870-0x0000000189AFD890
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018511C630-0x000000018511C9F0
	// [IDTag] // 0x0000000189B04FE0-0x0000000189B05020
	// [XID] // 0x0000000189B04FE0-0x0000000189B05020
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018511CDF0-0x000000018511CEF0
	// [XID] // 0x0000000189B0F7F0-0x0000000189B0F810
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AchievementExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018511D7F0-0x000000018511DB20
	// [XID] // 0x0000000189B169F0-0x0000000189B16A10
	private static bool ParseConfigFromLine(string line, out AchievementExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018511CCB0-0x000000018511CDF0
	// [IDTag] // 0x0000000189B1E050-0x0000000189B1E090
	// [XID] // 0x0000000189B1E050-0x0000000189B1E090
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AchievementExcelConfig> configList) => default; // 0x000000018511CEF0-0x000000018511D1A0
	// [IDTag] // 0x0000000189B28750-0x0000000189B28790
	// [XID] // 0x0000000189B28750-0x0000000189B28790
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFDE4 */, bool useObjectPool = false /* Metadata: 0x00AEFDE8 */) => default; // 0x000000018511D1A0-0x000000018511D3F0
	// [IDTag] // 0x0000000189B32B20-0x0000000189B32B60
	// [XID] // 0x0000000189B32B20-0x0000000189B32B60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDE9 */, bool useObjectPool = false /* Metadata: 0x00AEFDED */) => default; // 0x000000018511D3F0-0x000000018511D740
}

