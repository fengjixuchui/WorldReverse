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

public static class TowerScheduleExcelConfigLoader // TypeDefIndex: 16194
{
	// Fields
	private static Dictionary<uint, TowerScheduleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TowerScheduleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TowerScheduleExcelConfig, TowerScheduleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TowerScheduleExcelConfig>, Dictionary<uint, TowerScheduleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TowerScheduleExcelConfig> dataDict { /* [XID] */ /* 0x00000001899862F0-0x0000000189986310 */ get; } // 0x0000000181BC6490-0x0000000181BC6540 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189995A30-0x0000000189995A50 */ get; } // 0x0000000181BC52E0-0x0000000181BC5380 

	// Methods
	// [XID] // 0x000000018997E960-0x000000018997E980
	public static void Register() {} // 0x0000000181BC6870-0x0000000181BC6910
	// [XID] // 0x000000018998DEC0-0x000000018998DEE0
	public static TowerScheduleExcelConfig GetData(uint scheduleId) => default; // 0x0000000181BC51B0-0x0000000181BC52E0
	// [XID] // 0x000000018999D330-0x000000018999D350
	public static void LoadData() {} // 0x0000000181BC5910-0x0000000181BC5A00
	// [XID] // 0x00000001899A4CF0-0x00000001899A4D10
	private static void RegisterHotfixGenerated() {} // 0x0000000181BC5740-0x0000000181BC5910
	// [XID] // 0x00000001899AC870-0x00000001899AC890
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181BC5380-0x0000000181BC5740
	// [IDTag] // 0x00000001899B3FE0-0x00000001899B4020
	// [XID] // 0x00000001899B3FE0-0x00000001899B4020
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181BC5B40-0x0000000181BC5C40
	// [XID] // 0x00000001899BE690-0x00000001899BE6B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TowerScheduleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181BC6540-0x0000000181BC6870
	// [XID] // 0x00000001899C5E90-0x00000001899C5EB0
	private static bool ParseConfigFromLine(string line, out TowerScheduleExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181BC5A00-0x0000000181BC5B40
	// [IDTag] // 0x00000001899CD5F0-0x00000001899CD630
	// [XID] // 0x00000001899CD5F0-0x00000001899CD630
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TowerScheduleExcelConfig> configList) => default; // 0x0000000181BC5C40-0x0000000181BC5EF0
	// [IDTag] // 0x00000001899D7A70-0x00000001899D7AB0
	// [XID] // 0x00000001899D7A70-0x00000001899D7AB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF33D4 */, bool useObjectPool = false /* Metadata: 0x00AF33D8 */) => default; // 0x0000000181BC6240-0x0000000181BC6490
	// [IDTag] // 0x00000001899E2380-0x00000001899E23C0
	// [XID] // 0x00000001899E2380-0x00000001899E23C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33D9 */, bool useObjectPool = false /* Metadata: 0x00AF33DD */) => default; // 0x0000000181BC5EF0-0x0000000181BC6240
}

