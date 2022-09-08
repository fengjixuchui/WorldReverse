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

public static class FleurFairChapterExcelConfigLoader // TypeDefIndex: 15101
{
	// Fields
	private static Dictionary<uint, FleurFairChapterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairChapterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairChapterExcelConfig, FleurFairChapterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairChapterExcelConfig>, Dictionary<uint, FleurFairChapterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairChapterExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BC93C0-0x0000000189BC93E0 */ get; } // 0x000000018184BD00-0x000000018184BDB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BD8110-0x0000000189BD8130 */ get; } // 0x000000018184AB50-0x000000018184ABF0 

	// Methods
	// [XID] // 0x0000000189BC1E10-0x0000000189BC1E30
	public static void Register() {} // 0x000000018184C0E0-0x000000018184C180
	// [XID] // 0x0000000189BD0B90-0x0000000189BD0BB0
	public static FleurFairChapterExcelConfig GetData(uint id) => default; // 0x000000018184AA20-0x000000018184AB50
	// [XID] // 0x0000000189BDFC40-0x0000000189BDFC60
	public static void LoadData() {} // 0x000000018184B180-0x000000018184B270
	// [XID] // 0x00000001895EC7F0-0x00000001895EC810
	private static void RegisterHotfixGenerated() {} // 0x000000018184AFB0-0x000000018184B180
	// [XID] // 0x00000001895F3E10-0x00000001895F3E30
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018184ABF0-0x000000018184AFB0
	// [IDTag] // 0x00000001895FB6F0-0x00000001895FB730
	// [XID] // 0x00000001895FB6F0-0x00000001895FB730
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018184B3B0-0x000000018184B4B0
	// [XID] // 0x0000000189605F30-0x0000000189605F50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairChapterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018184BDB0-0x000000018184C0E0
	// [XID] // 0x000000018960D740-0x000000018960D760
	private static bool ParseConfigFromLine(string line, out FleurFairChapterExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018184B270-0x000000018184B3B0
	// [IDTag] // 0x0000000189614F80-0x0000000189614FC0
	// [XID] // 0x0000000189614F80-0x0000000189614FC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairChapterExcelConfig> configList) => default; // 0x000000018184B4B0-0x000000018184B760
	// [IDTag] // 0x000000018961F740-0x000000018961F780
	// [XID] // 0x000000018961F740-0x000000018961F780
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF00D5 */, bool useObjectPool = false /* Metadata: 0x00AF00D9 */) => default; // 0x000000018184B760-0x000000018184B9B0
	// [IDTag] // 0x0000000189629D50-0x0000000189629D90
	// [XID] // 0x0000000189629D50-0x0000000189629D90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00DA */, bool useObjectPool = false /* Metadata: 0x00AF00DE */) => default; // 0x000000018184B9B0-0x000000018184BD00
}

