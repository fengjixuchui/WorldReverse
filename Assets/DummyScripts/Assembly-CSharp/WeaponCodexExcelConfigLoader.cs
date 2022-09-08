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

public static class WeaponCodexExcelConfigLoader // TypeDefIndex: 15310
{
	// Fields
	private static Dictionary<uint, WeaponCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeaponCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeaponCodexExcelConfig, WeaponCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeaponCodexExcelConfig>, Dictionary<uint, WeaponCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WeaponCodexExcelConfig> dataDict { /* [XID] */ /* 0x00000001895EDF50-0x00000001895EDF70 */ get; } // 0x000000018167A2A0-0x000000018167A350 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895FCCD0-0x00000001895FCCF0 */ get; } // 0x00000001816790F0-0x0000000181679190 

	// Methods
	// [XID] // 0x00000001895E64F0-0x00000001895E6510
	public static void Register() {} // 0x000000018167A680-0x000000018167A720
	// [XID] // 0x00000001895F56F0-0x00000001895F5710
	public static WeaponCodexExcelConfig GetData(uint Id) => default; // 0x0000000181678FC0-0x00000001816790F0
	// [XID] // 0x0000000189604650-0x0000000189604670
	public static void LoadData() {} // 0x0000000181679720-0x0000000181679810
	// [XID] // 0x000000018960BF80-0x000000018960BFA0
	private static void RegisterHotfixGenerated() {} // 0x0000000181679550-0x0000000181679720
	// [XID] // 0x0000000189613500-0x0000000189613520
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181679190-0x0000000181679550
	// [IDTag] // 0x000000018961AD40-0x000000018961AD80
	// [XID] // 0x000000018961AD40-0x000000018961AD80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181679C00-0x0000000181679D00
	// [XID] // 0x0000000189625190-0x00000001896251B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeaponCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018167A350-0x000000018167A680
	// [XID] // 0x000000018962C9B0-0x000000018962C9D0
	private static bool ParseConfigFromLine(string line, out WeaponCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181679810-0x0000000181679950
	// [IDTag] // 0x0000000189634710-0x0000000189634750
	// [XID] // 0x0000000189634710-0x0000000189634750
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeaponCodexExcelConfig> configList) => default; // 0x0000000181679950-0x0000000181679C00
	// [IDTag] // 0x000000018963EC00-0x000000018963EC40
	// [XID] // 0x000000018963EC00-0x000000018963EC40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0727 */, bool useObjectPool = false /* Metadata: 0x00AF072B */) => default; // 0x0000000181679D00-0x0000000181679F50
	// [IDTag] // 0x0000000189649560-0x00000001896495A0
	// [XID] // 0x0000000189649560-0x00000001896495A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF072C */, bool useObjectPool = false /* Metadata: 0x00AF0730 */) => default; // 0x0000000181679F50-0x000000018167A2A0
}

