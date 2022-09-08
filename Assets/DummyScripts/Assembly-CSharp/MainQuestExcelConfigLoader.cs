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

public static class MainQuestExcelConfigLoader // TypeDefIndex: 15968
{
	// Fields
	private static Dictionary<uint, MainQuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MainQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MainQuestExcelConfig, MainQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MainQuestExcelConfig>, Dictionary<uint, MainQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MainQuestExcelConfig> dataDict { /* [XID] */ /* 0x00000001898E9100-0x00000001898E9120 */ get; } // 0x0000000182ACD900-0x0000000182ACD9B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898F8230-0x00000001898F8250 */ get; } // 0x0000000182ACC750-0x0000000182ACC7F0 

	// Methods
	// [XID] // 0x00000001898E1630-0x00000001898E1650
	public static void Register() {} // 0x0000000182ACDCE0-0x0000000182ACDD80
	// [XID] // 0x00000001898F08C0-0x00000001898F08E0
	public static MainQuestExcelConfig GetData(uint id) => default; // 0x0000000182ACC620-0x0000000182ACC750
	// [XID] // 0x00000001898FF890-0x00000001898FF8B0
	public static void LoadData() {} // 0x0000000182ACCD80-0x0000000182ACCE70
	// [XID] // 0x0000000189907070-0x0000000189907090
	private static void RegisterHotfixGenerated() {} // 0x0000000182ACCBB0-0x0000000182ACCD80
	// [XID] // 0x000000018990EA30-0x000000018990EA50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182ACC7F0-0x0000000182ACCBB0
	// [IDTag] // 0x0000000189916120-0x0000000189916160
	// [XID] // 0x0000000189916120-0x0000000189916160
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182ACD260-0x0000000182ACD360
	// [XID] // 0x0000000189920990-0x00000001899209B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MainQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182ACD9B0-0x0000000182ACDCE0
	// [XID] // 0x0000000189928310-0x0000000189928330
	private static bool ParseConfigFromLine(string line, out MainQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182ACCE70-0x0000000182ACCFB0
	// [IDTag] // 0x000000018992F8A0-0x000000018992F8E0
	// [XID] // 0x000000018992F8A0-0x000000018992F8E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MainQuestExcelConfig> configList) => default; // 0x0000000182ACCFB0-0x0000000182ACD260
	// [IDTag] // 0x000000018993A370-0x000000018993A3B0
	// [XID] // 0x000000018993A370-0x000000018993A3B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C84 */, bool useObjectPool = false /* Metadata: 0x00AF2C88 */) => default; // 0x0000000182ACD6B0-0x0000000182ACD900
	// [IDTag] // 0x00000001899447C0-0x0000000189944800
	// [XID] // 0x00000001899447C0-0x0000000189944800
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C89 */, bool useObjectPool = false /* Metadata: 0x00AF2C8D */) => default; // 0x0000000182ACD360-0x0000000182ACD6B0
}

