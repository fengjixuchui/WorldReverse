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

public static class ExploreAreaTotalExpExcelConfigLoader // TypeDefIndex: 15602
{
	// Fields
	private static Dictionary<uint, ExploreAreaTotalExpExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExploreAreaTotalExpExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExploreAreaTotalExpExcelConfig, ExploreAreaTotalExpExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExploreAreaTotalExpExcelConfig>, Dictionary<uint, ExploreAreaTotalExpExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExploreAreaTotalExpExcelConfig> dataDict { /* [XID] */ /* 0x00000001897DE690-0x00000001897DE6B0 */ get; } // 0x00000001833F1FD0-0x00000001833F2080 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897EDBF0-0x00000001897EDC10 */ get; } // 0x00000001833F0E20-0x00000001833F0EC0 

	// Methods
	// [XID] // 0x00000001897D70E0-0x00000001897D7100
	public static void Register() {} // 0x00000001833F23B0-0x00000001833F2450
	// [XID] // 0x00000001897E61F0-0x00000001897E6210
	public static ExploreAreaTotalExpExcelConfig GetData(uint areaID) => default; // 0x00000001833F0CF0-0x00000001833F0E20
	// [XID] // 0x00000001897F5310-0x00000001897F5330
	public static void LoadData() {} // 0x00000001833F1450-0x00000001833F1540
	// [XID] // 0x00000001897FCCA0-0x00000001897FCCC0
	private static void RegisterHotfixGenerated() {} // 0x00000001833F1280-0x00000001833F1450
	// [XID] // 0x0000000189804330-0x0000000189804350
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001833F0EC0-0x00000001833F1280
	// [IDTag] // 0x000000018980B760-0x000000018980B7A0
	// [XID] // 0x000000018980B760-0x000000018980B7A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833F1930-0x00000001833F1A30
	// [XID] // 0x0000000189815FF0-0x0000000189816010
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExploreAreaTotalExpExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001833F2080-0x00000001833F23B0
	// [XID] // 0x000000018981DA10-0x000000018981DA30
	private static bool ParseConfigFromLine(string line, out ExploreAreaTotalExpExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001833F1540-0x00000001833F1680
	// [IDTag] // 0x0000000189824E40-0x0000000189824E80
	// [XID] // 0x0000000189824E40-0x0000000189824E80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExploreAreaTotalExpExcelConfig> configList) => default; // 0x00000001833F1680-0x00000001833F1930
	// [IDTag] // 0x000000018982F4E0-0x000000018982F520
	// [XID] // 0x000000018982F4E0-0x000000018982F520
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2042 */, bool useObjectPool = false /* Metadata: 0x00AF2046 */) => default; // 0x00000001833F1A30-0x00000001833F1C80
	// [IDTag] // 0x0000000189839AC0-0x0000000189839B00
	// [XID] // 0x0000000189839AC0-0x0000000189839B00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2047 */, bool useObjectPool = false /* Metadata: 0x00AF204B */) => default; // 0x00000001833F1C80-0x00000001833F1FD0
}

