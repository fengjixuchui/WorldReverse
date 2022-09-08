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

public static class DungeonMapAreaExcelConfigLoader // TypeDefIndex: 15604
{
	// Fields
	private static Dictionary<uint, DungeonMapAreaExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonMapAreaExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonMapAreaExcelConfig, DungeonMapAreaExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonMapAreaExcelConfig>, Dictionary<uint, DungeonMapAreaExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonMapAreaExcelConfig> dataDict { /* [XID] */ /* 0x00000001898CF1F0-0x00000001898CF210 */ get; } // 0x00000001823C0A10-0x00000001823C0AC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898DE720-0x00000001898DE740 */ get; } // 0x00000001823BF860-0x00000001823BF900 

	// Methods
	// [XID] // 0x00000001898C7B00-0x00000001898C7B20
	public static void Register() {} // 0x00000001823C0DF0-0x00000001823C0E90
	// [XID] // 0x00000001898D6AA0-0x00000001898D6AC0
	public static DungeonMapAreaExcelConfig GetData(uint dungeonID) => default; // 0x00000001823BF730-0x00000001823BF860
	// [XID] // 0x00000001898E5F00-0x00000001898E5F20
	public static void LoadData() {} // 0x00000001823BFE90-0x00000001823BFF80
	// [XID] // 0x00000001898ED7E0-0x00000001898ED800
	private static void RegisterHotfixGenerated() {} // 0x00000001823BFCC0-0x00000001823BFE90
	// [XID] // 0x00000001898F50A0-0x00000001898F50C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823BF900-0x00000001823BFCC0
	// [IDTag] // 0x00000001898FC830-0x00000001898FC870
	// [XID] // 0x00000001898FC830-0x00000001898FC870
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823C0370-0x00000001823C0470
	// [XID] // 0x00000001899071B0-0x00000001899071D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonMapAreaExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823C0AC0-0x00000001823C0DF0
	// [XID] // 0x000000018990EB10-0x000000018990EB30
	private static bool ParseConfigFromLine(string line, out DungeonMapAreaExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001823BFF80-0x00000001823C00C0
	// [IDTag] // 0x0000000189916260-0x00000001899162A0
	// [XID] // 0x0000000189916260-0x00000001899162A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonMapAreaExcelConfig> configList) => default; // 0x00000001823C00C0-0x00000001823C0370
	// [IDTag] // 0x0000000189920A10-0x0000000189920A50
	// [XID] // 0x0000000189920A10-0x0000000189920A50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2051 */, bool useObjectPool = false /* Metadata: 0x00AF2055 */) => default; // 0x00000001823C0470-0x00000001823C06C0
	// [IDTag] // 0x000000018992B3C0-0x000000018992B400
	// [XID] // 0x000000018992B3C0-0x000000018992B400
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2056 */, bool useObjectPool = false /* Metadata: 0x00AF205A */) => default; // 0x00000001823C06C0-0x00000001823C0A10
}

