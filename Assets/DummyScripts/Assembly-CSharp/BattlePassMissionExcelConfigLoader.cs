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

public static class BattlePassMissionExcelConfigLoader // TypeDefIndex: 15254
{
	// Fields
	private static Dictionary<uint, BattlePassMissionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BattlePassMissionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BattlePassMissionExcelConfig, BattlePassMissionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BattlePassMissionExcelConfig>, Dictionary<uint, BattlePassMissionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BattlePassMissionExcelConfig> dataDict { /* [XID] */ /* 0x00000001897FFC90-0x00000001897FFCB0 */ get; } // 0x0000000183E1B810-0x0000000183E1B8C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018980E950-0x000000018980E970 */ get; } // 0x0000000183E1A660-0x0000000183E1A700 

	// Methods
	// [XID] // 0x00000001897F85E0-0x00000001897F8600
	public static void Register() {} // 0x0000000183E1BBF0-0x0000000183E1BC90
	// [XID] // 0x0000000189807350-0x0000000189807370
	public static BattlePassMissionExcelConfig GetData(uint id) => default; // 0x0000000183E1A530-0x0000000183E1A660
	// [XID] // 0x0000000189816030-0x0000000189816050
	public static void LoadData() {} // 0x0000000183E1AC90-0x0000000183E1AD80
	// [XID] // 0x000000018981DAD0-0x000000018981DAF0
	private static void RegisterHotfixGenerated() {} // 0x0000000183E1AAC0-0x0000000183E1AC90
	// [XID] // 0x0000000189824EC0-0x0000000189824EE0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183E1A700-0x0000000183E1AAC0
	// [IDTag] // 0x000000018982C8D0-0x000000018982C910
	// [XID] // 0x000000018982C8D0-0x000000018982C910
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183E1B170-0x0000000183E1B270
	// [XID] // 0x0000000189836DF0-0x0000000189836E10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BattlePassMissionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183E1B8C0-0x0000000183E1BBF0
	// [XID] // 0x000000018983E280-0x000000018983E2A0
	private static bool ParseConfigFromLine(string line, out BattlePassMissionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183E1AD80-0x0000000183E1AEC0
	// [IDTag] // 0x0000000189845A10-0x0000000189845A50
	// [XID] // 0x0000000189845A10-0x0000000189845A50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BattlePassMissionExcelConfig> configList) => default; // 0x0000000183E1AEC0-0x0000000183E1B170
	// [IDTag] // 0x000000018984FC60-0x000000018984FCA0
	// [XID] // 0x000000018984FC60-0x000000018984FCA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF054B */, bool useObjectPool = false /* Metadata: 0x00AF054F */) => default; // 0x0000000183E1B270-0x0000000183E1B4C0
	// [IDTag] // 0x000000018985A2F0-0x000000018985A330
	// [XID] // 0x000000018985A2F0-0x000000018985A330
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0550 */, bool useObjectPool = false /* Metadata: 0x00AF0554 */) => default; // 0x0000000183E1B4C0-0x0000000183E1B810
}

