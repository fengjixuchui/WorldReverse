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

public static class ReliquaryExcelConfigLoader // TypeDefIndex: 16016
{
	// Fields
	private static Dictionary<uint, ReliquaryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryExcelConfig, ReliquaryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryExcelConfig>, Dictionary<uint, ReliquaryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReliquaryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B24100-0x0000000189B24120 */ get; } // 0x00000001847A4FE0-0x00000001847A5090 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B32AC0-0x0000000189B32AE0 */ get; } // 0x00000001847A3E30-0x00000001847A3ED0 

	// Methods
	// [XID] // 0x0000000189B1CB90-0x0000000189B1CBB0
	public static void Register() {} // 0x00000001847A53C0-0x00000001847A5460
	// [XID] // 0x0000000189B2B530-0x0000000189B2B550
	public static ReliquaryExcelConfig GetData(uint id) => default; // 0x00000001847A3D00-0x00000001847A3E30
	// [XID] // 0x0000000189B3A3F0-0x0000000189B3A410
	public static void LoadData() {} // 0x00000001847A4460-0x00000001847A4550
	// [XID] // 0x0000000189B41DF0-0x0000000189B41E10
	private static void RegisterHotfixGenerated() {} // 0x00000001847A4290-0x00000001847A4460
	// [XID] // 0x0000000189B49760-0x0000000189B49780
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847A3ED0-0x00000001847A4290
	// [IDTag] // 0x0000000189B50DC0-0x0000000189B50E00
	// [XID] // 0x0000000189B50DC0-0x0000000189B50E00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001847A4690-0x00000001847A4790
	// [XID] // 0x0000000189B5B450-0x0000000189B5B470
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001847A5090-0x00000001847A53C0
	// [XID] // 0x0000000189B628E0-0x0000000189B62900
	private static bool ParseConfigFromLine(string line, out ReliquaryExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001847A4550-0x00000001847A4690
	// [IDTag] // 0x0000000189B6A450-0x0000000189B6A490
	// [XID] // 0x0000000189B6A450-0x0000000189B6A490
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryExcelConfig> configList) => default; // 0x00000001847A4790-0x00000001847A4A40
	// [IDTag] // 0x0000000189B747F0-0x0000000189B74830
	// [XID] // 0x0000000189B747F0-0x0000000189B74830
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2DF5 */, bool useObjectPool = false /* Metadata: 0x00AF2DF9 */) => default; // 0x00000001847A4A40-0x00000001847A4C90
	// [IDTag] // 0x0000000189B7ECC0-0x0000000189B7ED00
	// [XID] // 0x0000000189B7ECC0-0x0000000189B7ED00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DFA */, bool useObjectPool = false /* Metadata: 0x00AF2DFE */) => default; // 0x00000001847A4C90-0x00000001847A4FE0
}

