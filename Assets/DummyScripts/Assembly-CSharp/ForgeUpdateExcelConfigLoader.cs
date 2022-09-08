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

public static class ForgeUpdateExcelConfigLoader // TypeDefIndex: 15626
{
	// Fields
	private static Dictionary<uint, ForgeUpdateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ForgeUpdateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ForgeUpdateExcelConfig, ForgeUpdateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ForgeUpdateExcelConfig>, Dictionary<uint, ForgeUpdateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ForgeUpdateExcelConfig> dataDict { /* [XID] */ /* 0x000000018985CC10-0x000000018985CC30 */ get; } // 0x0000000183757B20-0x0000000183757BD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018986BC00-0x000000018986BC20 */ get; } // 0x0000000183756970-0x0000000183756A10 

	// Methods
	// [XID] // 0x0000000189855790-0x00000001898557B0
	public static void Register() {} // 0x0000000183757F00-0x0000000183757FA0
	// [XID] // 0x0000000189864610-0x0000000189864630
	public static ForgeUpdateExcelConfig GetData(uint playerLevel) => default; // 0x0000000183756840-0x0000000183756970
	// [XID] // 0x0000000189872F50-0x0000000189872F70
	public static void LoadData() {} // 0x0000000183756FA0-0x0000000183757090
	// [XID] // 0x000000018987AC70-0x000000018987AC90
	private static void RegisterHotfixGenerated() {} // 0x0000000183756DD0-0x0000000183756FA0
	// [XID] // 0x0000000189881C00-0x0000000189881C20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183756A10-0x0000000183756DD0
	// [IDTag] // 0x0000000189889300-0x0000000189889340
	// [XID] // 0x0000000189889300-0x0000000189889340
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837571D0-0x00000001837572D0
	// [XID] // 0x0000000189893710-0x0000000189893730
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ForgeUpdateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183757BD0-0x0000000183757F00
	// [XID] // 0x000000018989AE30-0x000000018989AE50
	private static bool ParseConfigFromLine(string line, out ForgeUpdateExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183757090-0x00000001837571D0
	// [IDTag] // 0x00000001898A2200-0x00000001898A2240
	// [XID] // 0x00000001898A2200-0x00000001898A2240
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ForgeUpdateExcelConfig> configList) => default; // 0x00000001837572D0-0x0000000183757580
	// [IDTag] // 0x00000001898ACA20-0x00000001898ACA60
	// [XID] // 0x00000001898ACA20-0x00000001898ACA60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF20F8 */, bool useObjectPool = false /* Metadata: 0x00AF20FC */) => default; // 0x0000000183757580-0x00000001837577D0
	// [IDTag] // 0x00000001898B7010-0x00000001898B7050
	// [XID] // 0x00000001898B7010-0x00000001898B7050
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20FD */, bool useObjectPool = false /* Metadata: 0x00AF2101 */) => default; // 0x00000001837577D0-0x0000000183757B20
}

