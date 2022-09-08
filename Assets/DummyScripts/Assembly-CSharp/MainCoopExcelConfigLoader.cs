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

public static class MainCoopExcelConfigLoader // TypeDefIndex: 15457
{
	// Fields
	private static Dictionary<uint, MainCoopExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MainCoopExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MainCoopExcelConfig, MainCoopExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MainCoopExcelConfig>, Dictionary<uint, MainCoopExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MainCoopExcelConfig> dataDict { /* [XID] */ /* 0x00000001895F0E40-0x00000001895F0E60 */ get; } // 0x0000000181C284A0-0x0000000181C28550 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895FFD10-0x00000001895FFD30 */ get; } // 0x0000000181C272F0-0x0000000181C27390 

	// Methods
	// [XID] // 0x00000001895E96B0-0x00000001895E96D0
	public static void Register() {} // 0x0000000181C28880-0x0000000181C28920
	// [XID] // 0x00000001895F8870-0x00000001895F8890
	public static MainCoopExcelConfig GetData(uint id) => default; // 0x0000000181C271C0-0x0000000181C272F0
	// [XID] // 0x0000000189607420-0x0000000189607440
	public static void LoadData() {} // 0x0000000181C27920-0x0000000181C27A10
	// [XID] // 0x000000018960EE60-0x000000018960EE80
	private static void RegisterHotfixGenerated() {} // 0x0000000181C27750-0x0000000181C27920
	// [XID] // 0x00000001896164E0-0x0000000189616500
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181C27390-0x0000000181C27750
	// [IDTag] // 0x000000018961DD30-0x000000018961DD70
	// [XID] // 0x000000018961DD30-0x000000018961DD70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181C27B50-0x0000000181C27C50
	// [XID] // 0x00000001896282D0-0x00000001896282F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MainCoopExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181C28550-0x0000000181C28880
	// [XID] // 0x000000018962FB80-0x000000018962FBA0
	private static bool ParseConfigFromLine(string line, out MainCoopExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181C27A10-0x0000000181C27B50
	// [IDTag] // 0x0000000189637740-0x0000000189637780
	// [XID] // 0x0000000189637740-0x0000000189637780
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MainCoopExcelConfig> configList) => default; // 0x0000000181C27C50-0x0000000181C27F00
	// [IDTag] // 0x0000000189641C80-0x0000000189641CC0
	// [XID] // 0x0000000189641C80-0x0000000189641CC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1B09 */, bool useObjectPool = false /* Metadata: 0x00AF1B0D */) => default; // 0x0000000181C28250-0x0000000181C284A0
	// [IDTag] // 0x000000018964C610-0x000000018964C650
	// [XID] // 0x000000018964C610-0x000000018964C650
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B0E */, bool useObjectPool = false /* Metadata: 0x00AF1B12 */) => default; // 0x0000000181C27F00-0x0000000181C28250
}

