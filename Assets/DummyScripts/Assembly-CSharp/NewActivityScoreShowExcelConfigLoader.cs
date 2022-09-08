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

public static class NewActivityScoreShowExcelConfigLoader // TypeDefIndex: 15906
{
	// Fields
	private static Dictionary<uint, NewActivityScoreShowExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityScoreShowExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityScoreShowExcelConfig, NewActivityScoreShowExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityScoreShowExcelConfig>, Dictionary<uint, NewActivityScoreShowExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityScoreShowExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B182A0-0x0000000189B182C0 */ get; } // 0x00000001847EDF10-0x00000001847EDFC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B27180-0x0000000189B271A0 */ get; } // 0x00000001847ECD60-0x00000001847ECE00 

	// Methods
	// [XID] // 0x0000000189B10FD0-0x0000000189B10FF0
	public static void Register() {} // 0x00000001847EE2F0-0x00000001847EE390
	// [XID] // 0x0000000189B1F900-0x0000000189B1F920
	public static NewActivityScoreShowExcelConfig GetData(uint id) => default; // 0x00000001847ECC30-0x00000001847ECD60
	// [XID] // 0x0000000189B2E2F0-0x0000000189B2E310
	public static void LoadData() {} // 0x00000001847ED390-0x00000001847ED480
	// [XID] // 0x0000000189B35740-0x0000000189B35760
	private static void RegisterHotfixGenerated() {} // 0x00000001847ED1C0-0x00000001847ED390
	// [XID] // 0x0000000189B3CF80-0x0000000189B3CFA0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847ECE00-0x00000001847ED1C0
	// [IDTag] // 0x0000000189B44D70-0x0000000189B44DB0
	// [XID] // 0x0000000189B44D70-0x0000000189B44DB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001847ED870-0x00000001847ED970
	// [XID] // 0x0000000189B4F4D0-0x0000000189B4F4F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityScoreShowExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001847EDFC0-0x00000001847EE2F0
	// [XID] // 0x0000000189B56DD0-0x0000000189B56DF0
	private static bool ParseConfigFromLine(string line, out NewActivityScoreShowExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001847ED480-0x00000001847ED5C0
	// [IDTag] // 0x0000000189B5E700-0x0000000189B5E740
	// [XID] // 0x0000000189B5E700-0x0000000189B5E740
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityScoreShowExcelConfig> configList) => default; // 0x00000001847ED5C0-0x00000001847ED870
	// [IDTag] // 0x0000000189B68E80-0x0000000189B68EC0
	// [XID] // 0x0000000189B68E80-0x0000000189B68EC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2ACD */, bool useObjectPool = false /* Metadata: 0x00AF2AD1 */) => default; // 0x00000001847ED970-0x00000001847EDBC0
	// [IDTag] // 0x0000000189B731F0-0x0000000189B73230
	// [XID] // 0x0000000189B731F0-0x0000000189B73230
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AD2 */, bool useObjectPool = false /* Metadata: 0x00AF2AD6 */) => default; // 0x00000001847EDBC0-0x00000001847EDF10
}

