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

public static class AsterActivityPerviewExcelConfigLoader // TypeDefIndex: 15024
{
	// Fields
	private static Dictionary<uint, AsterActivityPerviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AsterActivityPerviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AsterActivityPerviewExcelConfig, AsterActivityPerviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AsterActivityPerviewExcelConfig>, Dictionary<uint, AsterActivityPerviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AsterActivityPerviewExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AD6760-0x0000000189AD6780 */ get; } // 0x00000001838E29D0-0x00000001838E2A80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE5AE0-0x0000000189AE5B00 */ get; } // 0x00000001838E1820-0x00000001838E18C0 

	// Methods
	// [XID] // 0x0000000189ACE890-0x0000000189ACE8B0
	public static void Register() {} // 0x00000001838E2DB0-0x00000001838E2E50
	// [XID] // 0x0000000189ADE080-0x0000000189ADE0A0
	public static AsterActivityPerviewExcelConfig GetData(uint activityId) => default; // 0x00000001838E16F0-0x00000001838E1820
	// [XID] // 0x0000000189AECF80-0x0000000189AECFA0
	public static void LoadData() {} // 0x00000001838E1E50-0x00000001838E1F40
	// [XID] // 0x0000000189AF4870-0x0000000189AF4890
	private static void RegisterHotfixGenerated() {} // 0x00000001838E1C80-0x00000001838E1E50
	// [XID] // 0x0000000189AFBEE0-0x0000000189AFBF00
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001838E18C0-0x00000001838E1C80
	// [IDTag] // 0x0000000189B037F0-0x0000000189B03830
	// [XID] // 0x0000000189B037F0-0x0000000189B03830
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001838E2080-0x00000001838E2180
	// [XID] // 0x0000000189B0DFB0-0x0000000189B0DFD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterActivityPerviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001838E2A80-0x00000001838E2DB0
	// [XID] // 0x0000000189B15270-0x0000000189B15290
	private static bool ParseConfigFromLine(string line, out AsterActivityPerviewExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001838E1F40-0x00000001838E2080
	// [IDTag] // 0x0000000189B1CD10-0x0000000189B1CD50
	// [XID] // 0x0000000189B1CD10-0x0000000189B1CD50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterActivityPerviewExcelConfig> configList) => default; // 0x00000001838E2180-0x00000001838E2430
	// [IDTag] // 0x0000000189B272E0-0x0000000189B27320
	// [XID] // 0x0000000189B272E0-0x0000000189B27320
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFEC1 */, bool useObjectPool = false /* Metadata: 0x00AEFEC5 */) => default; // 0x00000001838E2780-0x00000001838E29D0
	// [IDTag] // 0x0000000189B316F0-0x0000000189B31730
	// [XID] // 0x0000000189B316F0-0x0000000189B31730
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEC6 */, bool useObjectPool = false /* Metadata: 0x00AEFECA */) => default; // 0x00000001838E2430-0x00000001838E2780
}

