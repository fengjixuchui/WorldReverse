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

public static class ShopmallSubTabExcelConfigLoader // TypeDefIndex: 16134
{
	// Fields
	private static Dictionary<uint, ShopmallSubTabExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopmallSubTabExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopmallSubTabExcelConfig, ShopmallSubTabExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopmallSubTabExcelConfig>, Dictionary<uint, ShopmallSubTabExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ShopmallSubTabExcelConfig> dataDict { /* [XID] */ /* 0x000000018994A3E0-0x000000018994A400 */ get; } // 0x00000001812F24C0-0x00000001812F2570 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189959450-0x0000000189959470 */ get; } // 0x00000001812F1310-0x00000001812F13B0 

	// Methods
	// [XID] // 0x0000000189942BF0-0x0000000189942C10
	public static void Register() {} // 0x00000001812F28A0-0x00000001812F2940
	// [XID] // 0x0000000189951ED0-0x0000000189951EF0
	public static ShopmallSubTabExcelConfig GetData(uint ID) => default; // 0x00000001812F11E0-0x00000001812F1310
	// [XID] // 0x0000000189960D00-0x0000000189960D20
	public static void LoadData() {} // 0x00000001812F1940-0x00000001812F1A30
	// [XID] // 0x0000000189968480-0x00000001899684A0
	private static void RegisterHotfixGenerated() {} // 0x00000001812F1770-0x00000001812F1940
	// [XID] // 0x000000018996F960-0x000000018996F980
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812F13B0-0x00000001812F1770
	// [IDTag] // 0x0000000189977700-0x0000000189977740
	// [XID] // 0x0000000189977700-0x0000000189977740
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001812F1B70-0x00000001812F1C70
	// [XID] // 0x0000000189981FE0-0x0000000189982000
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopmallSubTabExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001812F2570-0x00000001812F28A0
	// [XID] // 0x0000000189989860-0x0000000189989880
	private static bool ParseConfigFromLine(string line, out ShopmallSubTabExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001812F1A30-0x00000001812F1B70
	// [IDTag] // 0x00000001899910B0-0x00000001899910F0
	// [XID] // 0x00000001899910B0-0x00000001899910F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopmallSubTabExcelConfig> configList) => default; // 0x00000001812F1C70-0x00000001812F1F20
	// [IDTag] // 0x000000018999BB80-0x000000018999BBC0
	// [XID] // 0x000000018999BB80-0x000000018999BBC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3218 */, bool useObjectPool = false /* Metadata: 0x00AF321C */) => default; // 0x00000001812F2270-0x00000001812F24C0
	// [IDTag] // 0x00000001899A6650-0x00000001899A6690
	// [XID] // 0x00000001899A6650-0x00000001899A6690
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF321D */, bool useObjectPool = false /* Metadata: 0x00AF3221 */) => default; // 0x00000001812F1F20-0x00000001812F2270
}

