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

public static class DungeonElementChallengeExcelConfigLoader // TypeDefIndex: 15514
{
	// Fields
	private static Dictionary<uint, DungeonElementChallengeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonElementChallengeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonElementChallengeExcelConfig, DungeonElementChallengeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonElementChallengeExcelConfig>, Dictionary<uint, DungeonElementChallengeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonElementChallengeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A9CED0-0x0000000189A9CEF0 */ get; } // 0x00000001847DD2A0-0x00000001847DD350 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AABBD0-0x0000000189AABBF0 */ get; } // 0x00000001847DC0F0-0x00000001847DC190 

	// Methods
	// [XID] // 0x0000000189A95590-0x0000000189A955B0
	public static void Register() {} // 0x00000001847DD680-0x00000001847DD720
	// [XID] // 0x0000000189AA45A0-0x0000000189AA45C0
	public static DungeonElementChallengeExcelConfig GetData(uint dungeonId) => default; // 0x00000001847DBFC0-0x00000001847DC0F0
	// [XID] // 0x0000000189AB35A0-0x0000000189AB35C0
	public static void LoadData() {} // 0x00000001847DC720-0x00000001847DC810
	// [XID] // 0x0000000189ABB2B0-0x0000000189ABB2D0
	private static void RegisterHotfixGenerated() {} // 0x00000001847DC550-0x00000001847DC720
	// [XID] // 0x0000000189AC2A20-0x0000000189AC2A40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847DC190-0x00000001847DC550
	// [IDTag] // 0x0000000189ACA0A0-0x0000000189ACA0E0
	// [XID] // 0x0000000189ACA0A0-0x0000000189ACA0E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001847DCC00-0x00000001847DCD00
	// [XID] // 0x0000000189AD4E80-0x0000000189AD4EA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonElementChallengeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001847DD350-0x00000001847DD680
	// [XID] // 0x0000000189ADC720-0x0000000189ADC740
	private static bool ParseConfigFromLine(string line, out DungeonElementChallengeExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001847DC810-0x00000001847DC950
	// [IDTag] // 0x0000000189AE4090-0x0000000189AE40D0
	// [XID] // 0x0000000189AE4090-0x0000000189AE40D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonElementChallengeExcelConfig> configList) => default; // 0x00000001847DC950-0x00000001847DCC00
	// [IDTag] // 0x0000000189AEEBE0-0x0000000189AEEC20
	// [XID] // 0x0000000189AEEBE0-0x0000000189AEEC20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1CC0 */, bool useObjectPool = false /* Metadata: 0x00AF1CC4 */) => default; // 0x00000001847DD050-0x00000001847DD2A0
	// [IDTag] // 0x0000000189AF9370-0x0000000189AF93B0
	// [XID] // 0x0000000189AF9370-0x0000000189AF93B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CC5 */, bool useObjectPool = false /* Metadata: 0x00AF1CC9 */) => default; // 0x00000001847DCD00-0x00000001847DD050
}

