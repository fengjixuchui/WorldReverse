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

public static class ReliquaryLevelExcelConfigLoader // TypeDefIndex: 16022
{
	// Fields
	private static List<ReliquaryLevelExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryLevelExcelConfig, ReliquaryLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryLevelExcelConfig>, List<ReliquaryLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReliquaryLevelExcelConfig> dataList { /* [XID] */ /* 0x0000000189893650-0x0000000189893670 */ get; } // 0x00000001826F9AC0-0x00000001826F9B70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018989AD50-0x000000018989AD70 */ get; } // 0x00000001826F88D0-0x00000001826F8970 

	// Methods
	// [XID] // 0x000000018988C100-0x000000018988C120
	public static void Register() {} // 0x00000001826F9EA0-0x00000001826F9F40
	// [XID] // 0x00000001898A20E0-0x00000001898A2100
	public static void LoadData() {} // 0x00000001826F8F70-0x00000001826F9060
	// [XID] // 0x00000001898A98B0-0x00000001898A98D0
	private static void RegisterHotfixGenerated() {} // 0x00000001826F8DA0-0x00000001826F8F70
	// [XID] // 0x00000001898B11C0-0x00000001898B11E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001826F8970-0x00000001826F8DA0
	// [IDTag] // 0x00000001898B8A40-0x00000001898B8A80
	// [XID] // 0x00000001898B8A40-0x00000001898B8A80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001826F91A0-0x00000001826F92A0
	// [XID] // 0x00000001898C2FC0-0x00000001898C2FE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001826F9B70-0x00000001826F9EA0
	// [XID] // 0x00000001898CA900-0x00000001898CA920
	private static bool ParseConfigFromLine(string line, out ReliquaryLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001826F9060-0x00000001826F91A0
	// [IDTag] // 0x00000001898D2010-0x00000001898D2050
	// [XID] // 0x00000001898D2010-0x00000001898D2050
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryLevelExcelConfig> configList) => default; // 0x00000001826F92A0-0x00000001826F9540
	// [IDTag] // 0x00000001898DCA10-0x00000001898DCA50
	// [XID] // 0x00000001898DCA10-0x00000001898DCA50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E22 */, bool useObjectPool = false /* Metadata: 0x00AF2E26 */) => default; // 0x00000001826F9870-0x00000001826F9AC0
	// [IDTag] // 0x00000001898E7910-0x00000001898E7950
	// [XID] // 0x00000001898E7910-0x00000001898E7950
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E27 */, bool useObjectPool = false /* Metadata: 0x00AF2E2B */) => default; // 0x00000001826F9540-0x00000001826F9870
}

