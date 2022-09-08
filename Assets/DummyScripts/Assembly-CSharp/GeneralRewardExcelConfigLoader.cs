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

public static class GeneralRewardExcelConfigLoader // TypeDefIndex: 16071
{
	// Fields
	private static Dictionary<uint, GeneralRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GeneralRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GeneralRewardExcelConfig, GeneralRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GeneralRewardExcelConfig>, Dictionary<uint, GeneralRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GeneralRewardExcelConfig> dataDict { /* [XID] */ /* 0x0000000189693560-0x0000000189693580 */ get; } // 0x0000000181D41AA0-0x0000000181D41B50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896A2240-0x00000001896A2260 */ get; } // 0x0000000181D408F0-0x0000000181D40990 

	// Methods
	// [XID] // 0x000000018968B950-0x000000018968B970
	public static void Register() {} // 0x0000000181D41E80-0x0000000181D41F20
	// [XID] // 0x000000018969A850-0x000000018969A870
	public static GeneralRewardExcelConfig GetData(uint id) => default; // 0x0000000181D407C0-0x0000000181D408F0
	// [XID] // 0x00000001896A9480-0x00000001896A94A0
	public static void LoadData() {} // 0x0000000181D40F20-0x0000000181D41010
	// [XID] // 0x00000001896B05B0-0x00000001896B05D0
	private static void RegisterHotfixGenerated() {} // 0x0000000181D40D50-0x0000000181D40F20
	// [XID] // 0x00000001896B7FF0-0x00000001896B8010
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181D40990-0x0000000181D40D50
	// [IDTag] // 0x00000001896BF050-0x00000001896BF090
	// [XID] // 0x00000001896BF050-0x00000001896BF090
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181D41150-0x0000000181D41250
	// [XID] // 0x00000001896C95B0-0x00000001896C95D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GeneralRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181D41B50-0x0000000181D41E80
	// [XID] // 0x00000001896D0DC0-0x00000001896D0DE0
	private static bool ParseConfigFromLine(string line, out GeneralRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181D41010-0x0000000181D41150
	// [IDTag] // 0x00000001896D8430-0x00000001896D8470
	// [XID] // 0x00000001896D8430-0x00000001896D8470
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GeneralRewardExcelConfig> configList) => default; // 0x0000000181D41250-0x0000000181D41500
	// [IDTag] // 0x00000001896E2BA0-0x00000001896E2BE0
	// [XID] // 0x00000001896E2BA0-0x00000001896E2BE0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F7D */, bool useObjectPool = false /* Metadata: 0x00AF2F81 */) => default; // 0x0000000181D41500-0x0000000181D41750
	// [IDTag] // 0x00000001896ECE80-0x00000001896ECEC0
	// [XID] // 0x00000001896ECE80-0x00000001896ECEC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F82 */, bool useObjectPool = false /* Metadata: 0x00AF2F86 */) => default; // 0x0000000181D41750-0x0000000181D41AA0
}

