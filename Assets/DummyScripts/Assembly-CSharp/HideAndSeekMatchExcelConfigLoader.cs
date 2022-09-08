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

public static class HideAndSeekMatchExcelConfigLoader // TypeDefIndex: 15127
{
	// Fields
	private static Dictionary<uint, HideAndSeekMatchExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HideAndSeekMatchExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HideAndSeekMatchExcelConfig, HideAndSeekMatchExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HideAndSeekMatchExcelConfig>, Dictionary<uint, HideAndSeekMatchExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HideAndSeekMatchExcelConfig> dataDict { /* [XID] */ /* 0x00000001899AF810-0x00000001899AF830 */ get; } // 0x0000000182D28700-0x0000000182D287B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899BE7D0-0x00000001899BE7F0 */ get; } // 0x0000000182D27550-0x0000000182D275F0 

	// Methods
	// [XID] // 0x00000001899A8100-0x00000001899A8120
	public static void Register() {} // 0x0000000182D28AE0-0x0000000182D28B80
	// [XID] // 0x00000001899B6CF0-0x00000001899B6D10
	public static HideAndSeekMatchExcelConfig GetData(uint id) => default; // 0x0000000182D27420-0x0000000182D27550
	// [XID] // 0x00000001899C5FF0-0x00000001899C6010
	public static void LoadData() {} // 0x0000000182D27B80-0x0000000182D27C70
	// [XID] // 0x00000001899CD7F0-0x00000001899CD810
	private static void RegisterHotfixGenerated() {} // 0x0000000182D279B0-0x0000000182D27B80
	// [XID] // 0x00000001899D4C90-0x00000001899D4CB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D275F0-0x0000000182D279B0
	// [IDTag] // 0x00000001899DC310-0x00000001899DC350
	// [XID] // 0x00000001899DC310-0x00000001899DC350
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D28060-0x0000000182D28160
	// [XID] // 0x00000001899E6D90-0x00000001899E6DB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HideAndSeekMatchExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D287B0-0x0000000182D28AE0
	// [XID] // 0x00000001899EE220-0x00000001899EE240
	private static bool ParseConfigFromLine(string line, out HideAndSeekMatchExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D27C70-0x0000000182D27DB0
	// [IDTag] // 0x00000001899F5A50-0x00000001899F5A90
	// [XID] // 0x00000001899F5A50-0x00000001899F5A90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HideAndSeekMatchExcelConfig> configList) => default; // 0x0000000182D27DB0-0x0000000182D28060
	// [IDTag] // 0x00000001899FFFA0-0x00000001899FFFE0
	// [XID] // 0x00000001899FFFA0-0x00000001899FFFE0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF018C */, bool useObjectPool = false /* Metadata: 0x00AF0190 */) => default; // 0x0000000182D28160-0x0000000182D283B0
	// [IDTag] // 0x0000000189A0A660-0x0000000189A0A6A0
	// [XID] // 0x0000000189A0A660-0x0000000189A0A6A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0191 */, bool useObjectPool = false /* Metadata: 0x00AF0195 */) => default; // 0x0000000182D283B0-0x0000000182D28700
}

