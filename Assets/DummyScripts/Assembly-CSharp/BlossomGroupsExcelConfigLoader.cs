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

public static class BlossomGroupsExcelConfigLoader // TypeDefIndex: 15272
{
	// Fields
	private static Dictionary<uint, BlossomGroupsExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomGroupsExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomGroupsExcelConfig, BlossomGroupsExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomGroupsExcelConfig>, Dictionary<uint, BlossomGroupsExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomGroupsExcelConfig> dataDict { /* [XID] */ /* 0x00000001898FAFA0-0x00000001898FAFC0 */ get; } // 0x0000000183132D90-0x0000000183132E40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018990A000-0x000000018990A020 */ get; } // 0x0000000183131BE0-0x0000000183131C80 

	// Methods
	// [XID] // 0x00000001898F3840-0x00000001898F3860
	public static void Register() {} // 0x0000000183133170-0x0000000183133210
	// [XID] // 0x0000000189902A80-0x0000000189902AA0
	public static BlossomGroupsExcelConfig GetData(uint id) => default; // 0x0000000183131AB0-0x0000000183131BE0
	// [XID] // 0x0000000189911920-0x0000000189911940
	public static void LoadData() {} // 0x0000000183132210-0x0000000183132300
	// [XID] // 0x0000000189919500-0x0000000189919520
	private static void RegisterHotfixGenerated() {} // 0x0000000183132040-0x0000000183132210
	// [XID] // 0x0000000189920A70-0x0000000189920A90
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183131C80-0x0000000183132040
	// [IDTag] // 0x0000000189928430-0x0000000189928470
	// [XID] // 0x0000000189928430-0x0000000189928470
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183132440-0x0000000183132540
	// [XID] // 0x0000000189932A80-0x0000000189932AA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomGroupsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183132E40-0x0000000183133170
	// [XID] // 0x000000018993A4F0-0x000000018993A510
	private static bool ParseConfigFromLine(string line, out BlossomGroupsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183132300-0x0000000183132440
	// [IDTag] // 0x0000000189941520-0x0000000189941560
	// [XID] // 0x0000000189941520-0x0000000189941560
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomGroupsExcelConfig> configList) => default; // 0x0000000183132540-0x00000001831327F0
	// [IDTag] // 0x000000018994BEC0-0x000000018994BF00
	// [XID] // 0x000000018994BEC0-0x000000018994BF00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF05E1 */, bool useObjectPool = false /* Metadata: 0x00AF05E5 */) => default; // 0x00000001831327F0-0x0000000183132A40
	// [IDTag] // 0x0000000189956420-0x0000000189956460
	// [XID] // 0x0000000189956420-0x0000000189956460
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05E6 */, bool useObjectPool = false /* Metadata: 0x00AF05EA */) => default; // 0x0000000183132A40-0x0000000183132D90
}

