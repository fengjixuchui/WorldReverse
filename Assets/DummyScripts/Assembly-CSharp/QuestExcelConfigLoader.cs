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

public static class QuestExcelConfigLoader // TypeDefIndex: 14890
{
	// Fields
	private static Dictionary<uint, QuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<QuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<QuestExcelConfig, QuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<QuestExcelConfig>, Dictionary<uint, QuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, QuestExcelConfig> dataDict { /* [XID] */ /* 0x00000001897E4990-0x00000001897E49B0 */ get; } // 0x00000001810FDB20-0x00000001810FDBD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897F3F10-0x00000001897F3F30 */ get; } // 0x00000001810FC970-0x00000001810FCA10 

	// Methods
	// [XID] // 0x00000001897D5970-0x00000001897D5990
	public static void LoadAll() {} // 0x00000001810FDFA0-0x00000001810FE0D0
	// [XID] // 0x00000001897DD050-0x00000001897DD070
	public static void Register() {} // 0x00000001810FDF00-0x00000001810FDFA0
	// [XID] // 0x00000001897EC5E0-0x00000001897EC600
	public static QuestExcelConfig GetData(uint subId) => default; // 0x00000001810FC840-0x00000001810FC970
	// [XID] // 0x00000001897FB890-0x00000001897FB8B0
	public static void LoadData() {} // 0x00000001810FCFA0-0x00000001810FD090
	// [XID] // 0x0000000189802D20-0x0000000189802D40
	private static void RegisterHotfixGenerated() {} // 0x00000001810FCDD0-0x00000001810FCFA0
	// [XID] // 0x000000018980A2B0-0x000000018980A2D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001810FCA10-0x00000001810FCDD0
	// [IDTag] // 0x00000001898119E0-0x0000000189811A20
	// [XID] // 0x00000001898119E0-0x0000000189811A20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001810FD480-0x00000001810FD580
	// [XID] // 0x000000018981C240-0x000000018981C260
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<QuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001810FDBD0-0x00000001810FDF00
	// [XID] // 0x00000001898237B0-0x00000001898237D0
	private static bool ParseConfigFromLine(string line, out QuestExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001810FD090-0x00000001810FD1D0
	// [IDTag] // 0x000000018982B0B0-0x000000018982B0F0
	// [XID] // 0x000000018982B0B0-0x000000018982B0F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<QuestExcelConfig> configList) => default; // 0x00000001810FD1D0-0x00000001810FD480
	// [IDTag] // 0x0000000189835630-0x0000000189835670
	// [XID] // 0x0000000189835630-0x0000000189835670
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF919 */, bool useObjectPool = false /* Metadata: 0x00AEF91D */) => default; // 0x00000001810FD8D0-0x00000001810FDB20
	// [IDTag] // 0x000000018983FC30-0x000000018983FC70
	// [XID] // 0x000000018983FC30-0x000000018983FC70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF91E */, bool useObjectPool = false /* Metadata: 0x00AEF922 */) => default; // 0x00000001810FD580-0x00000001810FD8D0
}

