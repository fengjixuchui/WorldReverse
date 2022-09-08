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

public static class CampExcelConfigLoader // TypeDefIndex: 14842
{
	// Fields
	public static SimpleSafeUInt32[] allCampIDs; // 0x00
	private static Dictionary<uint, CampExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<CampExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<CampExcelConfig, CampExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<CampExcelConfig>, Dictionary<uint, CampExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, CampExcelConfig> dataDict { /* [XID] */ /* 0x00000001898F0AE0-0x00000001898F0B00 */ get; } // 0x00000001856A2150-0x00000001856A2220 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898FFBB0-0x00000001898FFBD0 */ get; } // 0x00000001856A0C00-0x00000001856A0CA0 

	// Constructors
	static CampExcelConfigLoader() {} // 0x00000001856A2BE0-0x00000001856A2C40

	// Methods
	// [XID] // 0x00000001898E1790-0x00000001898E17B0
	public static void LoadDataEnd() {} // 0x00000001856A2630-0x00000001856A2BE0
	// [XID] // 0x00000001898E9320-0x00000001898E9340
	public static void Register() {} // 0x00000001856A2570-0x00000001856A2630
	// [XID] // 0x00000001897D7950-0x00000001897D7970
	public static CampExcelConfig GetData(uint id) => default; // 0x00000001856A0A60-0x00000001856A0C00
	// [XID] // 0x0000000189907390-0x00000001899073B0
	public static void LoadData() {} // 0x00000001856A13F0-0x00000001856A1520
	// [XID] // 0x000000018990ED50-0x000000018990ED70
	private static void RegisterHotfixGenerated() {} // 0x00000001856A1180-0x00000001856A13F0
	// [XID] // 0x0000000189916420-0x0000000189916440
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001856A0CA0-0x00000001856A1180
	// [IDTag] // 0x000000018991DDB0-0x000000018991DDF0
	// [XID] // 0x000000018991DDB0-0x000000018991DDF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001856A19B0-0x00000001856A1B10
	// [XID] // 0x0000000189928610-0x0000000189928630
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CampExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001856A2220-0x00000001856A2570
	// [XID] // 0x000000018992FA80-0x000000018992FAA0
	private static bool ParseConfigFromLine(string line, out CampExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001856A1520-0x00000001856A1660
	// [IDTag] // 0x0000000189936FB0-0x0000000189936FF0
	// [XID] // 0x0000000189936FB0-0x0000000189936FF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CampExcelConfig> configList) => default; // 0x00000001856A1660-0x00000001856A19B0
	// [IDTag] // 0x00000001899415C0-0x0000000189941600
	// [XID] // 0x00000001899415C0-0x0000000189941600
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF747 */, bool useObjectPool = false /* Metadata: 0x00AEF74B */) => default; // 0x00000001856A1B10-0x00000001856A1DC0
	// [IDTag] // 0x000000018994C000-0x000000018994C040
	// [XID] // 0x000000018994C000-0x000000018994C040
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF74C */, bool useObjectPool = false /* Metadata: 0x00AEF750 */) => default; // 0x00000001856A1DC0-0x00000001856A2150
}

