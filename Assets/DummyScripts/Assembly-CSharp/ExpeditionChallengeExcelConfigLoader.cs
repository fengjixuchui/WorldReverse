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

public static class ExpeditionChallengeExcelConfigLoader // TypeDefIndex: 15092
{
	// Fields
	private static Dictionary<uint, ExpeditionChallengeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionChallengeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionChallengeExcelConfig, ExpeditionChallengeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionChallengeExcelConfig>, Dictionary<uint, ExpeditionChallengeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionChallengeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189962A50-0x0000000189962A70 */ get; } // 0x000000018336AC00-0x000000018336ACB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189971AE0-0x0000000189971B00 */ get; } // 0x0000000183369A50-0x0000000183369AF0 

	// Methods
	// [XID] // 0x000000018995ADD0-0x000000018995ADF0
	public static void Register() {} // 0x000000018336AFE0-0x000000018336B080
	// [XID] // 0x0000000189969D80-0x0000000189969DA0
	public static ExpeditionChallengeExcelConfig GetData(uint id) => default; // 0x0000000183369920-0x0000000183369A50
	// [XID] // 0x00000001899793D0-0x00000001899793F0
	public static void LoadData() {} // 0x000000018336A080-0x000000018336A170
	// [XID] // 0x0000000189980500-0x0000000189980520
	private static void RegisterHotfixGenerated() {} // 0x0000000183369EB0-0x000000018336A080
	// [XID] // 0x0000000189987E50-0x0000000189987E70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183369AF0-0x0000000183369EB0
	// [IDTag] // 0x000000018998F820-0x000000018998F860
	// [XID] // 0x000000018998F820-0x000000018998F860
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018336A560-0x000000018336A660
	// [XID] // 0x000000018999A7B0-0x000000018999A7D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionChallengeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018336ACB0-0x000000018336AFE0
	// [XID] // 0x00000001899A1EF0-0x00000001899A1F10
	private static bool ParseConfigFromLine(string line, out ExpeditionChallengeExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018336A170-0x000000018336A2B0
	// [IDTag] // 0x00000001899A97A0-0x00000001899A97E0
	// [XID] // 0x00000001899A97A0-0x00000001899A97E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionChallengeExcelConfig> configList) => default; // 0x000000018336A2B0-0x000000018336A560
	// [IDTag] // 0x00000001899B41E0-0x00000001899B4220
	// [XID] // 0x00000001899B41E0-0x00000001899B4220
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0099 */, bool useObjectPool = false /* Metadata: 0x00AF009D */) => default; // 0x000000018336A660-0x000000018336A8B0
	// [IDTag] // 0x00000001899BE810-0x00000001899BE850
	// [XID] // 0x00000001899BE810-0x00000001899BE850
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF009E */, bool useObjectPool = false /* Metadata: 0x00AF00A2 */) => default; // 0x000000018336A8B0-0x000000018336AC00
}

