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

public static class QuestCodexExcelConfigLoader // TypeDefIndex: 15308
{
	// Fields
	private static Dictionary<uint, QuestCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<QuestCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<QuestCodexExcelConfig, QuestCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<QuestCodexExcelConfig>, Dictionary<uint, QuestCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, QuestCodexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189ACA100-0x0000000189ACA120 */ get; } // 0x00000001820C7640-0x00000001820C76F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AD9650-0x0000000189AD9670 */ get; } // 0x00000001820C6490-0x00000001820C6530 

	// Methods
	// [XID] // 0x0000000189AC2AA0-0x0000000189AC2AC0
	public static void Register() {} // 0x00000001820C7A20-0x00000001820C7AC0
	// [XID] // 0x0000000189AD1970-0x0000000189AD1990
	public static QuestCodexExcelConfig GetData(uint Id) => default; // 0x00000001820C6360-0x00000001820C6490
	// [XID] // 0x0000000189AE1100-0x0000000189AE1120
	public static void LoadData() {} // 0x00000001820C6AC0-0x00000001820C6BB0
	// [XID] // 0x0000000189AE8530-0x0000000189AE8550
	private static void RegisterHotfixGenerated() {} // 0x00000001820C68F0-0x00000001820C6AC0
	// [XID] // 0x0000000189AF04B0-0x0000000189AF04D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001820C6530-0x00000001820C68F0
	// [IDTag] // 0x0000000189AF79E0-0x0000000189AF7A20
	// [XID] // 0x0000000189AF79E0-0x0000000189AF7A20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820C6FA0-0x00000001820C70A0
	// [XID] // 0x0000000189B02110-0x0000000189B02130
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<QuestCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001820C76F0-0x00000001820C7A20
	// [XID] // 0x0000000189B09550-0x0000000189B09570
	private static bool ParseConfigFromLine(string line, out QuestCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001820C6BB0-0x00000001820C6CF0
	// [IDTag] // 0x0000000189B110D0-0x0000000189B11110
	// [XID] // 0x0000000189B110D0-0x0000000189B11110
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<QuestCodexExcelConfig> configList) => default; // 0x00000001820C6CF0-0x00000001820C6FA0
	// [IDTag] // 0x0000000189B1B2C0-0x0000000189B1B300
	// [XID] // 0x0000000189B1B2C0-0x0000000189B1B300
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0718 */, bool useObjectPool = false /* Metadata: 0x00AF071C */) => default; // 0x00000001820C73F0-0x00000001820C7640
	// [IDTag] // 0x0000000189B25960-0x0000000189B259A0
	// [XID] // 0x0000000189B25960-0x0000000189B259A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF071D */, bool useObjectPool = false /* Metadata: 0x00AF0721 */) => default; // 0x00000001820C70A0-0x00000001820C73F0
}

