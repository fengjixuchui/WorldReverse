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

public static class FleurFairDungeonExcelConfigLoader // TypeDefIndex: 15106
{
	// Fields
	private static Dictionary<uint, FleurFairDungeonExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairDungeonExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairDungeonExcelConfig, FleurFairDungeonExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairDungeonExcelConfig>, Dictionary<uint, FleurFairDungeonExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairDungeonExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A7EDC0-0x0000000189A7EDE0 */ get; } // 0x0000000182722800-0x00000001827228B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A8E190-0x0000000189A8E1B0 */ get; } // 0x0000000182721650-0x00000001827216F0 

	// Methods
	// [XID] // 0x0000000189A77510-0x0000000189A77530
	public static void Register() {} // 0x0000000182722BE0-0x0000000182722C80
	// [XID] // 0x0000000189A865D0-0x0000000189A865F0
	public static FleurFairDungeonExcelConfig GetData(uint id) => default; // 0x0000000182721520-0x0000000182721650
	// [XID] // 0x0000000189A95650-0x0000000189A95670
	public static void LoadData() {} // 0x0000000182721C80-0x0000000182721D70
	// [XID] // 0x0000000189A9CF70-0x0000000189A9CF90
	private static void RegisterHotfixGenerated() {} // 0x0000000182721AB0-0x0000000182721C80
	// [XID] // 0x0000000189AA4600-0x0000000189AA4620
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001827216F0-0x0000000182721AB0
	// [IDTag] // 0x0000000189AABC70-0x0000000189AABCB0
	// [XID] // 0x0000000189AABC70-0x0000000189AABCB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182722160-0x0000000182722260
	// [XID] // 0x0000000189AB6620-0x0000000189AB6640
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairDungeonExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001827228B0-0x0000000182722BE0
	// [XID] // 0x0000000189ABE0F0-0x0000000189ABE110
	private static bool ParseConfigFromLine(string line, out FleurFairDungeonExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182721D70-0x0000000182721EB0
	// [IDTag] // 0x0000000189AC5C90-0x0000000189AC5CD0
	// [XID] // 0x0000000189AC5C90-0x0000000189AC5CD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairDungeonExcelConfig> configList) => default; // 0x0000000182721EB0-0x0000000182722160
	// [IDTag] // 0x0000000189AD0070-0x0000000189AD00B0
	// [XID] // 0x0000000189AD0070-0x0000000189AD00B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF00F8 */, bool useObjectPool = false /* Metadata: 0x00AF00FC */) => default; // 0x00000001827225B0-0x0000000182722800
	// [IDTag] // 0x0000000189ADAE40-0x0000000189ADAE80
	// [XID] // 0x0000000189ADAE40-0x0000000189ADAE80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00FD */, bool useObjectPool = false /* Metadata: 0x00AF0101 */) => default; // 0x0000000182722260-0x00000001827225B0
}

