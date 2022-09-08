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

public static class NewActivitySaleExcelConfigLoader // TypeDefIndex: 14878
{
	// Fields
	private static Dictionary<uint, NewActivitySaleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivitySaleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivitySaleExcelConfig, NewActivitySaleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivitySaleExcelConfig>, Dictionary<uint, NewActivitySaleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivitySaleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BD6920-0x0000000189BD6940 */ get; } // 0x0000000181091470-0x0000000181091520 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895EB170-0x00000001895EB190 */ get; } // 0x00000001810902C0-0x0000000181090360 

	// Methods
	// [XID] // 0x0000000189BC7AE0-0x0000000189BC7B00
	public static NewActivitySaleExcelConfig GetDataBySaleType(uint param0, NewActivitySaleType saleType, HashSet<uint> filterIds = null) => default; // 0x0000000181091520-0x0000000181091930
	// [XID] // 0x0000000189BCF590-0x0000000189BCF5B0
	public static void Register() {} // 0x0000000181091C60-0x0000000181091D00
	// [XID] // 0x0000000189BDE6E0-0x0000000189BDE700
	public static NewActivitySaleExcelConfig GetData(uint id) => default; // 0x0000000181090190-0x00000001810902C0
	// [XID] // 0x00000001895F2650-0x00000001895F2670
	public static void LoadData() {} // 0x00000001810908F0-0x00000001810909E0
	// [XID] // 0x00000001895FA060-0x00000001895FA080
	private static void RegisterHotfixGenerated() {} // 0x0000000181090720-0x00000001810908F0
	// [XID] // 0x00000001896017C0-0x00000001896017E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181090360-0x0000000181090720
	// [IDTag] // 0x00000001896090B0-0x00000001896090F0
	// [XID] // 0x00000001896090B0-0x00000001896090F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181090DD0-0x0000000181090ED0
	// [XID] // 0x0000000189613600-0x0000000189613620
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivitySaleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181091930-0x0000000181091C60
	// [XID] // 0x000000018961AEA0-0x000000018961AEC0
	private static bool ParseConfigFromLine(string line, out NewActivitySaleExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001810909E0-0x0000000181090B20
	// [IDTag] // 0x00000001896223C0-0x0000000189622400
	// [XID] // 0x00000001896223C0-0x0000000189622400
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivitySaleExcelConfig> configList) => default; // 0x0000000181090B20-0x0000000181090DD0
	// [IDTag] // 0x000000018962CB30-0x000000018962CB70
	// [XID] // 0x000000018962CB30-0x000000018962CB70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8C7 */, bool useObjectPool = false /* Metadata: 0x00AEF8CB */) => default; // 0x0000000181090ED0-0x0000000181091120
	// [IDTag] // 0x0000000189637940-0x0000000189637980
	// [XID] // 0x0000000189637940-0x0000000189637980
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8CC */, bool useObjectPool = false /* Metadata: 0x00AEF8D0 */) => default; // 0x0000000181091120-0x0000000181091470
}

