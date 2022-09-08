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

public static class EndureTemplateExcelConfigLoader // TypeDefIndex: 15570
{
	// Fields
	private static Dictionary<int, EndureTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EndureTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EndureTemplateExcelConfig, EndureTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EndureTemplateExcelConfig>, Dictionary<int, EndureTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, EndureTemplateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189995B50-0x0000000189995B70 */ get; } // 0x00000001820AC310-0x00000001820AC3C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A4D70-0x00000001899A4D90 */ get; } // 0x00000001820AB160-0x00000001820AB200 

	// Methods
	// [XID] // 0x000000018998DFE0-0x000000018998E000
	public static void Register() {} // 0x00000001820AC6F0-0x00000001820AC790
	// [XID] // 0x000000018999D490-0x000000018999D4B0
	public static EndureTemplateExcelConfig GetData(EndureType type) => default; // 0x00000001820AB030-0x00000001820AB160
	// [XID] // 0x00000001899AC970-0x00000001899AC990
	public static void LoadData() {} // 0x00000001820AB790-0x00000001820AB880
	// [XID] // 0x00000001899B4180-0x00000001899B41A0
	private static void RegisterHotfixGenerated() {} // 0x00000001820AB5C0-0x00000001820AB790
	// [XID] // 0x00000001899BB610-0x00000001899BB630
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001820AB200-0x00000001820AB5C0
	// [IDTag] // 0x00000001899C3220-0x00000001899C3260
	// [XID] // 0x00000001899C3220-0x00000001899C3260
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820ABC70-0x00000001820ABD70
	// [XID] // 0x00000001899CD750-0x00000001899CD770
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EndureTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001820AC3C0-0x00000001820AC6F0
	// [XID] // 0x00000001899D4BF0-0x00000001899D4C10
	private static bool ParseConfigFromLine(string line, out EndureTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001820AB880-0x00000001820AB9C0
	// [IDTag] // 0x00000001899DC290-0x00000001899DC2D0
	// [XID] // 0x00000001899DC290-0x00000001899DC2D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EndureTemplateExcelConfig> configList) => default; // 0x00000001820AB9C0-0x00000001820ABC70
	// [IDTag] // 0x00000001899E6CD0-0x00000001899E6D10
	// [XID] // 0x00000001899E6CD0-0x00000001899E6D10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F61 */, bool useObjectPool = false /* Metadata: 0x00AF1F65 */) => default; // 0x00000001820AC0C0-0x00000001820AC310
	// [IDTag] // 0x00000001899F10F0-0x00000001899F1130
	// [XID] // 0x00000001899F10F0-0x00000001899F1130
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F66 */, bool useObjectPool = false /* Metadata: 0x00AF1F6A */) => default; // 0x00000001820ABD70-0x00000001820AC0C0
}

