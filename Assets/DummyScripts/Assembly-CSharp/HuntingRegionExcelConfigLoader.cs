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

public static class HuntingRegionExcelConfigLoader // TypeDefIndex: 15747
{
	// Fields
	private static Dictionary<uint, HuntingRegionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingRegionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingRegionExcelConfig, HuntingRegionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingRegionExcelConfig>, Dictionary<uint, HuntingRegionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingRegionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189960DC0-0x0000000189960DE0 */ get; } // 0x00000001818017C0-0x0000000181801870 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018996FA20-0x000000018996FA40 */ get; } // 0x0000000181800610-0x00000001818006B0 

	// Methods
	// [XID] // 0x0000000189959510-0x0000000189959530
	public static void Register() {} // 0x0000000181801BA0-0x0000000181801C40
	// [XID] // 0x0000000189968520-0x0000000189968540
	public static HuntingRegionExcelConfig GetData(uint id) => default; // 0x00000001818004E0-0x0000000181800610
	// [XID] // 0x0000000189977800-0x0000000189977820
	public static void LoadData() {} // 0x0000000181800C40-0x0000000181800D30
	// [XID] // 0x000000018997EA60-0x000000018997EA80
	private static void RegisterHotfixGenerated() {} // 0x0000000181800A70-0x0000000181800C40
	// [XID] // 0x0000000189986370-0x0000000189986390
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001818006B0-0x0000000181800A70
	// [IDTag] // 0x000000018998DF80-0x000000018998DFC0
	// [XID] // 0x000000018998DF80-0x000000018998DFC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181801120-0x0000000181801220
	// [XID] // 0x0000000189998C50-0x0000000189998C70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingRegionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181801870-0x0000000181801BA0
	// [XID] // 0x00000001899A0550-0x00000001899A0570
	private static bool ParseConfigFromLine(string line, out HuntingRegionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181800D30-0x0000000181800E70
	// [IDTag] // 0x00000001899A8020-0x00000001899A8060
	// [XID] // 0x00000001899A8020-0x00000001899A8060
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingRegionExcelConfig> configList) => default; // 0x0000000181800E70-0x0000000181801120
	// [IDTag] // 0x00000001899B2A10-0x00000001899B2A50
	// [XID] // 0x00000001899B2A10-0x00000001899B2A50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF24EA */, bool useObjectPool = false /* Metadata: 0x00AF24EE */) => default; // 0x0000000181801220-0x0000000181801470
	// [IDTag] // 0x00000001899BCE50-0x00000001899BCE90
	// [XID] // 0x00000001899BCE50-0x00000001899BCE90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24EF */, bool useObjectPool = false /* Metadata: 0x00AF24F3 */) => default; // 0x0000000181801470-0x00000001818017C0
}

