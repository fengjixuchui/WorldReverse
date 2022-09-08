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

public static class ChapterExcelConfigLoader // TypeDefIndex: 15967
{
	// Fields
	private static Dictionary<uint, ChapterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChapterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChapterExcelConfig, ChapterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChapterExcelConfig>, Dictionary<uint, ChapterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChapterExcelConfig> dataDict { /* [XID] */ /* 0x000000018986D0B0-0x000000018986D0D0 */ get; } // 0x0000000183558810-0x00000001835588C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018987C060-0x000000018987C080 */ get; } // 0x0000000183557660-0x0000000183557700 

	// Methods
	// [XID] // 0x0000000189865AF0-0x0000000189865B10
	public static void Register() {} // 0x0000000183558BF0-0x0000000183558C90
	// [XID] // 0x00000001898744E0-0x0000000189874500
	public static ChapterExcelConfig GetData(uint id) => default; // 0x0000000183557530-0x0000000183557660
	// [XID] // 0x00000001898831D0-0x00000001898831F0
	public static void LoadData() {} // 0x0000000183557C90-0x0000000183557D80
	// [XID] // 0x000000018988A910-0x000000018988A930
	private static void RegisterHotfixGenerated() {} // 0x0000000183557AC0-0x0000000183557C90
	// [XID] // 0x0000000189891E00-0x0000000189891E20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183557700-0x0000000183557AC0
	// [IDTag] // 0x0000000189899670-0x00000001898996B0
	// [XID] // 0x0000000189899670-0x00000001898996B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183558170-0x0000000183558270
	// [XID] // 0x00000001898A3B20-0x00000001898A3B40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChapterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001835588C0-0x0000000183558BF0
	// [XID] // 0x00000001898AAE40-0x00000001898AAE60
	private static bool ParseConfigFromLine(string line, out ChapterExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183557D80-0x0000000183557EC0
	// [IDTag] // 0x00000001898B2750-0x00000001898B2790
	// [XID] // 0x00000001898B2750-0x00000001898B2790
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChapterExcelConfig> configList) => default; // 0x0000000183557EC0-0x0000000183558170
	// [IDTag] // 0x00000001898BD2E0-0x00000001898BD320
	// [XID] // 0x00000001898BD2E0-0x00000001898BD320
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C7A */, bool useObjectPool = false /* Metadata: 0x00AF2C7E */) => default; // 0x0000000183558270-0x00000001835584C0
	// [IDTag] // 0x00000001898C79A0-0x00000001898C79E0
	// [XID] // 0x00000001898C79A0-0x00000001898C79E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C7F */, bool useObjectPool = false /* Metadata: 0x00AF2C83 */) => default; // 0x00000001835584C0-0x0000000183558810
}

