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

public static class NewActivityScoreLimitExcelConfigLoader // TypeDefIndex: 15900
{
	// Fields
	private static Dictionary<uint, NewActivityScoreLimitExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityScoreLimitExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityScoreLimitExcelConfig, NewActivityScoreLimitExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityScoreLimitExcelConfig>, Dictionary<uint, NewActivityScoreLimitExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityScoreLimitExcelConfig> dataDict { /* [XID] */ /* 0x00000001897B9ED0-0x00000001897B9EF0 */ get; } // 0x0000000183DD9760-0x0000000183DD9810 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897C98A0-0x00000001897C98C0 */ get; } // 0x0000000183DD85B0-0x0000000183DD8650 

	// Methods
	// [XID] // 0x00000001897B2610-0x00000001897B2630
	public static void Register() {} // 0x0000000183DD9B40-0x0000000183DD9BE0
	// [XID] // 0x00000001897C2010-0x00000001897C2030
	public static NewActivityScoreLimitExcelConfig GetData(uint id) => default; // 0x0000000183DD8480-0x0000000183DD85B0
	// [XID] // 0x00000001897D0ED0-0x00000001897D0EF0
	public static void LoadData() {} // 0x0000000183DD8BE0-0x0000000183DD8CD0
	// [XID] // 0x00000001897D8DB0-0x00000001897D8DD0
	private static void RegisterHotfixGenerated() {} // 0x0000000183DD8A10-0x0000000183DD8BE0
	// [XID] // 0x00000001897DFFD0-0x00000001897DFFF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183DD8650-0x0000000183DD8A10
	// [IDTag] // 0x00000001897E7710-0x00000001897E7750
	// [XID] // 0x00000001897E7710-0x00000001897E7750
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183DD8E10-0x0000000183DD8F10
	// [XID] // 0x00000001897F2610-0x00000001897F2630
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityScoreLimitExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183DD9810-0x0000000183DD9B40
	// [XID] // 0x00000001897F9D80-0x00000001897F9DA0
	private static bool ParseConfigFromLine(string line, out NewActivityScoreLimitExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183DD8CD0-0x0000000183DD8E10
	// [IDTag] // 0x0000000189801300-0x0000000189801340
	// [XID] // 0x0000000189801300-0x0000000189801340
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityScoreLimitExcelConfig> configList) => default; // 0x0000000183DD8F10-0x0000000183DD91C0
	// [IDTag] // 0x000000018980B6C0-0x000000018980B700
	// [XID] // 0x000000018980B6C0-0x000000018980B700
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2AA0 */, bool useObjectPool = false /* Metadata: 0x00AF2AA4 */) => default; // 0x0000000183DD9510-0x0000000183DD9760
	// [IDTag] // 0x0000000189815F90-0x0000000189815FD0
	// [XID] // 0x0000000189815F90-0x0000000189815FD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AA5 */, bool useObjectPool = false /* Metadata: 0x00AF2AA9 */) => default; // 0x0000000183DD91C0-0x0000000183DD9510
}

