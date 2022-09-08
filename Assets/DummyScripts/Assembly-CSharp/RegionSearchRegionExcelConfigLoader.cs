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

public static class RegionSearchRegionExcelConfigLoader // TypeDefIndex: 15161
{
	// Fields
	private static Dictionary<uint, RegionSearchRegionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RegionSearchRegionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RegionSearchRegionExcelConfig, RegionSearchRegionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RegionSearchRegionExcelConfig>, Dictionary<uint, RegionSearchRegionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RegionSearchRegionExcelConfig> dataDict { /* [XID] */ /* 0x00000001897C8450-0x00000001897C8470 */ get; } // 0x00000001850AA1A0-0x00000001850AA250 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897D71E0-0x00000001897D7200 */ get; } // 0x00000001850A8FF0-0x00000001850A9090 

	// Methods
	// [XID] // 0x00000001897C0AC0-0x00000001897C0AE0
	public static void Register() {} // 0x00000001850AA580-0x00000001850AA620
	// [XID] // 0x00000001897CF870-0x00000001897CF890
	public static RegionSearchRegionExcelConfig GetData(uint id) => default; // 0x00000001850A8EC0-0x00000001850A8FF0
	// [XID] // 0x00000001897DE710-0x00000001897DE730
	public static void LoadData() {} // 0x00000001850A9620-0x00000001850A9710
	// [XID] // 0x00000001897E6270-0x00000001897E6290
	private static void RegisterHotfixGenerated() {} // 0x00000001850A9450-0x00000001850A9620
	// [XID] // 0x00000001897EDCD0-0x00000001897EDCF0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001850A9090-0x00000001850A9450
	// [IDTag] // 0x00000001897F5370-0x00000001897F53B0
	// [XID] // 0x00000001897F5370-0x00000001897F53B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001850A9B00-0x00000001850A9C00
	// [XID] // 0x00000001897FFCF0-0x00000001897FFD10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RegionSearchRegionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001850AA250-0x00000001850AA580
	// [XID] // 0x0000000189807370-0x0000000189807390
	private static bool ParseConfigFromLine(string line, out RegionSearchRegionExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001850A9710-0x00000001850A9850
	// [IDTag] // 0x000000018980E970-0x000000018980E9B0
	// [XID] // 0x000000018980E970-0x000000018980E9B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RegionSearchRegionExcelConfig> configList) => default; // 0x00000001850A9850-0x00000001850A9B00
	// [IDTag] // 0x0000000189819530-0x0000000189819570
	// [XID] // 0x0000000189819530-0x0000000189819570
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF027E */, bool useObjectPool = false /* Metadata: 0x00AF0282 */) => default; // 0x00000001850A9F50-0x00000001850AA1A0
	// [IDTag] // 0x00000001898235F0-0x0000000189823630
	// [XID] // 0x00000001898235F0-0x0000000189823630
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0283 */, bool useObjectPool = false /* Metadata: 0x00AF0287 */) => default; // 0x00000001850A9C00-0x00000001850A9F50
}

