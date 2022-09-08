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

public static class OfferingLevelUpExcelConfigLoader // TypeDefIndex: 15919
{
	// Fields
	private static List<OfferingLevelUpExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<OfferingLevelUpExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<OfferingLevelUpExcelConfig, OfferingLevelUpExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OfferingLevelUpExcelConfig>, List<OfferingLevelUpExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<OfferingLevelUpExcelConfig> dataList { /* [XID] */ /* 0x0000000189ADDE40-0x0000000189ADDE60 */ get; } // 0x0000000183B97950-0x0000000183B97A00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE5920-0x0000000189AE5940 */ get; } // 0x0000000183B96760-0x0000000183B96800 

	// Methods
	// [XID] // 0x0000000189AD6600-0x0000000189AD6620
	public static void Register() {} // 0x0000000183B97D30-0x0000000183B97DD0
	// [XID] // 0x0000000189AECD40-0x0000000189AECD60
	public static void LoadData() {} // 0x0000000183B96E00-0x0000000183B96EF0
	// [XID] // 0x0000000189AF4710-0x0000000189AF4730
	private static void RegisterHotfixGenerated() {} // 0x0000000183B96C30-0x0000000183B96E00
	// [XID] // 0x0000000189AFBD00-0x0000000189AFBD20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183B96800-0x0000000183B96C30
	// [IDTag] // 0x0000000189B03570-0x0000000189B035B0
	// [XID] // 0x0000000189B03570-0x0000000189B035B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183B972D0-0x0000000183B973D0
	// [XID] // 0x0000000189B0DE10-0x0000000189B0DE30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OfferingLevelUpExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183B97A00-0x0000000183B97D30
	// [XID] // 0x0000000189B15170-0x0000000189B15190
	private static bool ParseConfigFromLine(string line, out OfferingLevelUpExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183B96EF0-0x0000000183B97030
	// [IDTag] // 0x0000000189B1CBD0-0x0000000189B1CC10
	// [XID] // 0x0000000189B1CBD0-0x0000000189B1CC10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OfferingLevelUpExcelConfig> configList) => default; // 0x0000000183B97030-0x0000000183B972D0
	// [IDTag] // 0x0000000189B27140-0x0000000189B27180
	// [XID] // 0x0000000189B27140-0x0000000189B27180
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B2A */, bool useObjectPool = false /* Metadata: 0x00AF2B2E */) => default; // 0x0000000183B973D0-0x0000000183B97620
	// [IDTag] // 0x0000000189B31530-0x0000000189B31570
	// [XID] // 0x0000000189B31530-0x0000000189B31570
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B2F */, bool useObjectPool = false /* Metadata: 0x00AF2B33 */) => default; // 0x0000000183B97620-0x0000000183B97950
}

