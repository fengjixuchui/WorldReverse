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

public static class RandTaskExcelConfigLoader // TypeDefIndex: 15999
{
	// Fields
	private static Dictionary<uint, RandTaskExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandTaskExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandTaskExcelConfig, RandTaskExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandTaskExcelConfig>, Dictionary<uint, RandTaskExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandTaskExcelConfig> dataDict { /* [XID] */ /* 0x0000000189ADDE20-0x0000000189ADDE40 */ get; } // 0x0000000183FD17D0-0x0000000183FD1880 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AECD20-0x0000000189AECD40 */ get; } // 0x0000000183FD0620-0x0000000183FD06C0 

	// Methods
	// [XID] // 0x0000000189AD65E0-0x0000000189AD6600
	public static void Register() {} // 0x0000000183FD1BB0-0x0000000183FD1C50
	// [XID] // 0x0000000189AE58C0-0x0000000189AE58E0
	public static RandTaskExcelConfig GetData(uint ID) => default; // 0x0000000183FD04F0-0x0000000183FD0620
	// [XID] // 0x0000000189AF46F0-0x0000000189AF4710
	public static void LoadData() {} // 0x0000000183FD0C50-0x0000000183FD0D40
	// [XID] // 0x0000000189AFBCE0-0x0000000189AFBD00
	private static void RegisterHotfixGenerated() {} // 0x0000000183FD0A80-0x0000000183FD0C50
	// [XID] // 0x0000000189B03510-0x0000000189B03530
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183FD06C0-0x0000000183FD0A80
	// [IDTag] // 0x0000000189B0AD00-0x0000000189B0AD40
	// [XID] // 0x0000000189B0AD00-0x0000000189B0AD40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183FD1130-0x0000000183FD1230
	// [XID] // 0x0000000189B15150-0x0000000189B15170
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandTaskExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183FD1880-0x0000000183FD1BB0
	// [XID] // 0x0000000189B1CBB0-0x0000000189B1CBD0
	private static bool ParseConfigFromLine(string line, out RandTaskExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183FD0D40-0x0000000183FD0E80
	// [IDTag] // 0x0000000189B24120-0x0000000189B24160
	// [XID] // 0x0000000189B24120-0x0000000189B24160
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandTaskExcelConfig> configList) => default; // 0x0000000183FD0E80-0x0000000183FD1130
	// [IDTag] // 0x0000000189B2E270-0x0000000189B2E2B0
	// [XID] // 0x0000000189B2E270-0x0000000189B2E2B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D59 */, bool useObjectPool = false /* Metadata: 0x00AF2D5D */) => default; // 0x0000000183FD1230-0x0000000183FD1480
	// [IDTag] // 0x0000000189B389F0-0x0000000189B38A30
	// [XID] // 0x0000000189B389F0-0x0000000189B38A30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D5E */, bool useObjectPool = false /* Metadata: 0x00AF2D62 */) => default; // 0x0000000183FD1480-0x0000000183FD17D0
}

