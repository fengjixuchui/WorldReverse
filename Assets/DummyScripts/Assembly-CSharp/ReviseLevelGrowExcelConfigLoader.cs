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

public static class ReviseLevelGrowExcelConfigLoader // TypeDefIndex: 16066
{
	// Fields
	private static Dictionary<uint, ReviseLevelGrowExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReviseLevelGrowExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReviseLevelGrowExcelConfig, ReviseLevelGrowExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReviseLevelGrowExcelConfig>, Dictionary<uint, ReviseLevelGrowExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReviseLevelGrowExcelConfig> dataDict { /* [XID] */ /* 0x000000018998AF80-0x000000018998AFA0 */ get; } // 0x0000000183B1ABC0-0x0000000183B1AC70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018999A650-0x000000018999A670 */ get; } // 0x0000000183B19A10-0x0000000183B19AB0 

	// Methods
	// [XID] // 0x0000000189983730-0x0000000189983750
	public static void Register() {} // 0x0000000183B1AFA0-0x0000000183B1B040
	// [XID] // 0x00000001899928D0-0x00000001899928F0
	public static ReviseLevelGrowExcelConfig GetData(uint id) => default; // 0x0000000183B198E0-0x0000000183B19A10
	// [XID] // 0x00000001899A1CF0-0x00000001899A1D10
	public static void LoadData() {} // 0x0000000183B1A040-0x0000000183B1A130
	// [XID] // 0x00000001899A9660-0x00000001899A9680
	private static void RegisterHotfixGenerated() {} // 0x0000000183B19E70-0x0000000183B1A040
	// [XID] // 0x00000001899B10B0-0x00000001899B10D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183B19AB0-0x0000000183B19E70
	// [IDTag] // 0x00000001899B82B0-0x00000001899B82F0
	// [XID] // 0x00000001899B82B0-0x00000001899B82F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183B1A270-0x0000000183B1A370
	// [XID] // 0x00000001899C3040-0x00000001899C3060
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReviseLevelGrowExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183B1AC70-0x0000000183B1AFA0
	// [XID] // 0x00000001899CA420-0x00000001899CA440
	private static bool ParseConfigFromLine(string line, out ReviseLevelGrowExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183B1A130-0x0000000183B1A270
	// [IDTag] // 0x00000001899D1C40-0x00000001899D1C80
	// [XID] // 0x00000001899D1C40-0x00000001899D1C80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReviseLevelGrowExcelConfig> configList) => default; // 0x0000000183B1A370-0x0000000183B1A620
	// [IDTag] // 0x00000001899DC150-0x00000001899DC190
	// [XID] // 0x00000001899DC150-0x00000001899DC190
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F5C */, bool useObjectPool = false /* Metadata: 0x00AF2F60 */) => default; // 0x0000000183B1A970-0x0000000183B1ABC0
	// [IDTag] // 0x00000001899E6B70-0x00000001899E6BB0
	// [XID] // 0x00000001899E6B70-0x00000001899E6BB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F61 */, bool useObjectPool = false /* Metadata: 0x00AF2F65 */) => default; // 0x0000000183B1A620-0x0000000183B1A970
}

