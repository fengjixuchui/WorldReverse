/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RandomQuestTemplateExcelConfigLoader // TypeDefIndex: 15984
{
	// Fields
	private static Dictionary<uint, RandomQuestTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandomQuestTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandomQuestTemplateExcelConfig, RandomQuestTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandomQuestTemplateExcelConfig>, Dictionary<uint, RandomQuestTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandomQuestTemplateExcelConfig> dataDict { /* [XID] */ /* 0x00000001897AC400-0x00000001897AC420 */ get; } // 0x00000001837CC4E0-0x00000001837CC590 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897BC050-0x00000001897BC070 */ get; } // 0x00000001837CB330-0x00000001837CB3D0 

	// Methods
	// [XID] // 0x00000001897A4E70-0x00000001897A4E90
	public static void Register() {} // 0x00000001837CC8C0-0x00000001837CC960
	// [XID] // 0x00000001897B4370-0x00000001897B4390
	public static RandomQuestTemplateExcelConfig GetData(uint mainId) => default; // 0x00000001837CB200-0x00000001837CB330
	// [XID] // 0x00000001897C3830-0x00000001897C3850
	public static void LoadData() {} // 0x00000001837CB960-0x00000001837CBA50
	// [XID] // 0x00000001897CAFF0-0x00000001897CB010
	private static void RegisterHotfixGenerated() {} // 0x00000001837CB790-0x00000001837CB960
	// [XID] // 0x00000001897D26B0-0x00000001897D26D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001837CB3D0-0x00000001837CB790
	// [IDTag] // 0x00000001897DA410-0x00000001897DA450
	// [XID] // 0x00000001897DA410-0x00000001897DA450
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837CBE40-0x00000001837CBF40
	// [XID] // 0x00000001897E4730-0x00000001897E4750
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandomQuestTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001837CC590-0x00000001837CC8C0
	// [XID] // 0x00000001897EC2E0-0x00000001897EC300
	private static bool ParseConfigFromLine(string line, out RandomQuestTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001837CBA50-0x00000001837CBB90
	// [IDTag] // 0x00000001897F3C30-0x00000001897F3C70
	// [XID] // 0x00000001897F3C30-0x00000001897F3C70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandomQuestTemplateExcelConfig> configList) => default; // 0x00000001837CBB90-0x00000001837CBE40
	// [IDTag] // 0x00000001897FDF60-0x00000001897FDFA0
	// [XID] // 0x00000001897FDF60-0x00000001897FDFA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2CF2 */, bool useObjectPool = false /* Metadata: 0x00AF2CF6 */) => default; // 0x00000001837CBF40-0x00000001837CC190
	// [IDTag] // 0x0000000189808680-0x00000001898086C0
	// [XID] // 0x0000000189808680-0x00000001898086C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CF7 */, bool useObjectPool = false /* Metadata: 0x00AF2CFB */) => default; // 0x00000001837CC190-0x00000001837CC4E0
}

