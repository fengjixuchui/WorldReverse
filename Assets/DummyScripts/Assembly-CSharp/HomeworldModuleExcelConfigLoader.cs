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

public static class HomeworldModuleExcelConfigLoader // TypeDefIndex: 15715
{
	// Fields
	private static Dictionary<uint, HomeworldModuleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeworldModuleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeworldModuleExcelConfig, HomeworldModuleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeworldModuleExcelConfig>, Dictionary<uint, HomeworldModuleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeworldModuleExcelConfig> dataDict { /* [XID] */ /* 0x000000018985FCB0-0x000000018985FCD0 */ get; } // 0x0000000181CFAC40-0x0000000181CFACF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018986EB30-0x000000018986EB50 */ get; } // 0x0000000181CF9A90-0x0000000181CF9B30 

	// Methods
	// [XID] // 0x0000000189858B40-0x0000000189858B60
	public static void Register() {} // 0x0000000181CFB020-0x0000000181CFB0C0
	// [XID] // 0x0000000189867370-0x0000000189867390
	public static HomeworldModuleExcelConfig GetData(uint Id) => default; // 0x0000000181CF9960-0x0000000181CF9A90
	// [XID] // 0x0000000189875FE0-0x0000000189876000
	public static void LoadData() {} // 0x0000000181CFA0C0-0x0000000181CFA1B0
	// [XID] // 0x000000018987DBC0-0x000000018987DBE0
	private static void RegisterHotfixGenerated() {} // 0x0000000181CF9EF0-0x0000000181CFA0C0
	// [XID] // 0x0000000189884AF0-0x0000000189884B10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181CF9B30-0x0000000181CF9EF0
	// [IDTag] // 0x000000018988C180-0x000000018988C1C0
	// [XID] // 0x000000018988C180-0x000000018988C1C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181CFA5A0-0x0000000181CFA6A0
	// [XID] // 0x0000000189896580-0x00000001898965A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeworldModuleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181CFACF0-0x0000000181CFB020
	// [XID] // 0x000000018989DB40-0x000000018989DB60
	private static bool ParseConfigFromLine(string line, out HomeworldModuleExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181CFA1B0-0x0000000181CFA2F0
	// [IDTag] // 0x00000001898A5440-0x00000001898A5480
	// [XID] // 0x00000001898A5440-0x00000001898A5480
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeworldModuleExcelConfig> configList) => default; // 0x0000000181CFA2F0-0x0000000181CFA5A0
	// [IDTag] // 0x00000001898AFA70-0x00000001898AFAB0
	// [XID] // 0x00000001898AFA70-0x00000001898AFAB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2404 */, bool useObjectPool = false /* Metadata: 0x00AF2408 */) => default; // 0x0000000181CFA9F0-0x0000000181CFAC40
	// [IDTag] // 0x00000001898BA560-0x00000001898BA5A0
	// [XID] // 0x00000001898BA560-0x00000001898BA5A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2409 */, bool useObjectPool = false /* Metadata: 0x00AF240D */) => default; // 0x0000000181CFA6A0-0x0000000181CFA9F0
}

