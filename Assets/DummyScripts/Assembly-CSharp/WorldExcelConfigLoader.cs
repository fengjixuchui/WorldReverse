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

public static class WorldExcelConfigLoader // TypeDefIndex: 16095
{
	// Fields
	private static Dictionary<uint, WorldExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WorldExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WorldExcelConfig, WorldExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WorldExcelConfig>, Dictionary<uint, WorldExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WorldExcelConfig> dataDict { /* [XID] */ /* 0x00000001898D6A40-0x00000001898D6A60 */ get; } // 0x0000000183658A20-0x0000000183658AD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898E5EA0-0x00000001898E5EC0 */ get; } // 0x0000000183657870-0x0000000183657910 

	// Methods
	// [XID] // 0x00000001898CF0B0-0x00000001898CF0D0
	public static void Register() {} // 0x0000000183658E00-0x0000000183658EA0
	// [XID] // 0x00000001898DE640-0x00000001898DE660
	public static WorldExcelConfig GetData(uint id) => default; // 0x0000000183657740-0x0000000183657870
	// [XID] // 0x00000001898ED740-0x00000001898ED760
	public static void LoadData() {} // 0x0000000183657EA0-0x0000000183657F90
	// [XID] // 0x00000001898F4FA0-0x00000001898F4FC0
	private static void RegisterHotfixGenerated() {} // 0x0000000183657CD0-0x0000000183657EA0
	// [XID] // 0x00000001898FC690-0x00000001898FC6B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183657910-0x0000000183657CD0
	// [IDTag] // 0x0000000189904130-0x0000000189904170
	// [XID] // 0x0000000189904130-0x0000000189904170
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836580D0-0x00000001836581D0
	// [XID] // 0x000000018990EA10-0x000000018990EA30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WorldExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183658AD0-0x0000000183658E00
	// [XID] // 0x0000000189916080-0x00000001899160A0
	private static bool ParseConfigFromLine(string line, out WorldExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183657F90-0x00000001836580D0
	// [IDTag] // 0x000000018991DB30-0x000000018991DB70
	// [XID] // 0x000000018991DB30-0x000000018991DB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WorldExcelConfig> configList) => default; // 0x00000001836581D0-0x0000000183658480
	// [IDTag] // 0x00000001899282B0-0x00000001899282F0
	// [XID] // 0x00000001899282B0-0x00000001899282F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF301D */, bool useObjectPool = false /* Metadata: 0x00AF3021 */) => default; // 0x00000001836587D0-0x0000000183658A20
	// [IDTag] // 0x0000000189932900-0x0000000189932940
	// [XID] // 0x0000000189932900-0x0000000189932940
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3022 */, bool useObjectPool = false /* Metadata: 0x00AF3026 */) => default; // 0x0000000183658480-0x00000001836587D0
}

