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

public static class RoomExcelConfigLoader // TypeDefIndex: 16093
{
	// Fields
	private static Dictionary<uint, RoomExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RoomExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RoomExcelConfig, RoomExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RoomExcelConfig>, Dictionary<uint, RoomExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RoomExcelConfig> dataDict { /* [XID] */ /* 0x00000001897C8370-0x00000001897C8390 */ get; } // 0x0000000183EE33A0-0x0000000183EE3450 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897D6FA0-0x00000001897D6FC0 */ get; } // 0x0000000183EE21F0-0x0000000183EE2290 

	// Methods
	// [XID] // 0x00000001897C09E0-0x00000001897C0A00
	public static void Register() {} // 0x0000000183EE3780-0x0000000183EE3820
	// [XID] // 0x00000001897CF730-0x00000001897CF750
	public static RoomExcelConfig GetData(uint id) => default; // 0x0000000183EE20C0-0x0000000183EE21F0
	// [XID] // 0x00000001897DE630-0x00000001897DE650
	public static void LoadData() {} // 0x0000000183EE2820-0x0000000183EE2910
	// [XID] // 0x00000001897E6110-0x00000001897E6130
	private static void RegisterHotfixGenerated() {} // 0x0000000183EE2650-0x0000000183EE2820
	// [XID] // 0x00000001897EDAD0-0x00000001897EDAF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183EE2290-0x0000000183EE2650
	// [IDTag] // 0x00000001897F5230-0x00000001897F5270
	// [XID] // 0x00000001897F5230-0x00000001897F5270
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183EE2D00-0x0000000183EE2E00
	// [XID] // 0x00000001897FFB70-0x00000001897FFB90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RoomExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183EE3450-0x0000000183EE3780
	// [XID] // 0x00000001898071F0-0x0000000189807210
	private static bool ParseConfigFromLine(string line, out RoomExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183EE2910-0x0000000183EE2A50
	// [IDTag] // 0x000000018980E810-0x000000018980E850
	// [XID] // 0x000000018980E810-0x000000018980E850
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RoomExcelConfig> configList) => default; // 0x0000000183EE2A50-0x0000000183EE2D00
	// [IDTag] // 0x0000000189819310-0x0000000189819350
	// [XID] // 0x0000000189819310-0x0000000189819350
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF300E */, bool useObjectPool = false /* Metadata: 0x00AF3012 */) => default; // 0x0000000183EE3150-0x0000000183EE33A0
	// [IDTag] // 0x00000001898234F0-0x0000000189823530
	// [XID] // 0x00000001898234F0-0x0000000189823530
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3013 */, bool useObjectPool = false /* Metadata: 0x00AF3017 */) => default; // 0x0000000183EE2E00-0x0000000183EE3150
}

