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

public static class SeaLampSectionMiniQuestExcelConfigLoader // TypeDefIndex: 15186
{
	// Fields
	private static Dictionary<uint, SeaLampSectionMiniQuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SeaLampSectionMiniQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SeaLampSectionMiniQuestExcelConfig, SeaLampSectionMiniQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SeaLampSectionMiniQuestExcelConfig>, Dictionary<uint, SeaLampSectionMiniQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SeaLampSectionMiniQuestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189783D10-0x0000000189783D30 */ get; } // 0x00000001839B8A20-0x00000001839B8AD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189792980-0x00000001897929A0 */ get; } // 0x00000001839B7870-0x00000001839B7910 

	// Methods
	// [XID] // 0x000000018977C2E0-0x000000018977C300
	public static void Register() {} // 0x00000001839B8E00-0x00000001839B8EA0
	// [XID] // 0x000000018978B4C0-0x000000018978B4E0
	public static SeaLampSectionMiniQuestExcelConfig GetData(uint id) => default; // 0x00000001839B7740-0x00000001839B7870
	// [XID] // 0x0000000189799E90-0x0000000189799EB0
	public static void LoadData() {} // 0x00000001839B7EA0-0x00000001839B7F90
	// [XID] // 0x00000001897A1DC0-0x00000001897A1DE0
	private static void RegisterHotfixGenerated() {} // 0x00000001839B7CD0-0x00000001839B7EA0
	// [XID] // 0x00000001897A95E0-0x00000001897A9600
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001839B7910-0x00000001839B7CD0
	// [IDTag] // 0x00000001897B0D80-0x00000001897B0DC0
	// [XID] // 0x00000001897B0D80-0x00000001897B0DC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001839B8380-0x00000001839B8480
	// [XID] // 0x00000001897BC2B0-0x00000001897BC2D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SeaLampSectionMiniQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001839B8AD0-0x00000001839B8E00
	// [XID] // 0x00000001897C39B0-0x00000001897C39D0
	private static bool ParseConfigFromLine(string line, out SeaLampSectionMiniQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001839B7F90-0x00000001839B80D0
	// [IDTag] // 0x00000001897CB110-0x00000001897CB150
	// [XID] // 0x00000001897CB110-0x00000001897CB150
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SeaLampSectionMiniQuestExcelConfig> configList) => default; // 0x00000001839B80D0-0x00000001839B8380
	// [IDTag] // 0x00000001897D5870-0x00000001897D58B0
	// [XID] // 0x00000001897D5870-0x00000001897D58B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF033A */, bool useObjectPool = false /* Metadata: 0x00AF033E */) => default; // 0x00000001839B8480-0x00000001839B86D0
	// [IDTag] // 0x00000001897E0150-0x00000001897E0190
	// [XID] // 0x00000001897E0150-0x00000001897E0190
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF033F */, bool useObjectPool = false /* Metadata: 0x00AF0343 */) => default; // 0x00000001839B86D0-0x00000001839B8A20
}

