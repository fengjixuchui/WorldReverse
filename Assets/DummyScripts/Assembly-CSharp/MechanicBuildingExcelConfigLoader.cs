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

public static class MechanicBuildingExcelConfigLoader // TypeDefIndex: 16211
{
	// Fields
	private static Dictionary<uint, MechanicBuildingExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicBuildingExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicBuildingExcelConfig, MechanicBuildingExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicBuildingExcelConfig>, Dictionary<uint, MechanicBuildingExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicBuildingExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B04D20-0x0000000189B04D40 */ get; } // 0x000000018262A860-0x000000018262A910 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B13A70-0x0000000189B13A90 */ get; } // 0x00000001826296B0-0x0000000182629750 

	// Methods
	// [XID] // 0x0000000189AFD5D0-0x0000000189AFD5F0
	public static void Register() {} // 0x000000018262AC40-0x000000018262ACE0
	// [XID] // 0x0000000189B0C4F0-0x0000000189B0C510
	public static MechanicBuildingExcelConfig GetData(uint id) => default; // 0x0000000182629580-0x00000001826296B0
	// [XID] // 0x0000000189B1B120-0x0000000189B1B140
	public static void LoadData() {} // 0x0000000182629CE0-0x0000000182629DD0
	// [XID] // 0x0000000189B22890-0x0000000189B228B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182629B10-0x0000000182629CE0
	// [XID] // 0x0000000189B29E00-0x0000000189B29E20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182629750-0x0000000182629B10
	// [IDTag] // 0x0000000189B31430-0x0000000189B31470
	// [XID] // 0x0000000189B31430-0x0000000189B31470
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018262A1C0-0x000000018262A2C0
	// [XID] // 0x0000000189B3BA10-0x0000000189B3BA30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicBuildingExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018262A910-0x000000018262AC40
	// [XID] // 0x0000000189B43450-0x0000000189B43470
	private static bool ParseConfigFromLine(string line, out MechanicBuildingExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182629DD0-0x0000000182629F10
	// [IDTag] // 0x0000000189B4ABD0-0x0000000189B4AC10
	// [XID] // 0x0000000189B4ABD0-0x0000000189B4AC10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicBuildingExcelConfig> configList) => default; // 0x0000000182629F10-0x000000018262A1C0
	// [IDTag] // 0x0000000189B55350-0x0000000189B55390
	// [XID] // 0x0000000189B55350-0x0000000189B55390
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF346E */, bool useObjectPool = false /* Metadata: 0x00AF3472 */) => default; // 0x000000018262A610-0x000000018262A860
	// [IDTag] // 0x0000000189B5FEE0-0x0000000189B5FF20
	// [XID] // 0x0000000189B5FEE0-0x0000000189B5FF20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3473 */, bool useObjectPool = false /* Metadata: 0x00AF3477 */) => default; // 0x000000018262A2C0-0x000000018262A610
}

