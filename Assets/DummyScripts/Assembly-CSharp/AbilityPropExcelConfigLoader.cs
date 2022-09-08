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

public static class AbilityPropExcelConfigLoader // TypeDefIndex: 14987
{
	// Fields
	private static Dictionary<string, AbilityPropExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AbilityPropExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AbilityPropExcelConfig, AbilityPropExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AbilityPropExcelConfig>, Dictionary<string, AbilityPropExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, AbilityPropExcelConfig> dataDict { /* [XID] */ /* 0x0000000189952090-0x00000001899520B0 */ get; } // 0x00000001842E2210-0x00000001842E22C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189960F40-0x0000000189960F60 */ get; } // 0x00000001842E1070-0x00000001842E1110 

	// Methods
	// [XID] // 0x000000018994A660-0x000000018994A680
	public static void Register() {} // 0x00000001842E25F0-0x00000001842E2690
	// [XID] // 0x00000001899595D0-0x00000001899595F0
	public static AbilityPropExcelConfig GetData(string propName) => default; // 0x00000001842E0F30-0x00000001842E1070
	// [XID] // 0x0000000189968620-0x0000000189968640
	public static void LoadData() {} // 0x00000001842E16A0-0x00000001842E1790
	// [XID] // 0x000000018996FB60-0x000000018996FB80
	private static void RegisterHotfixGenerated() {} // 0x00000001842E14D0-0x00000001842E16A0
	// [XID] // 0x0000000189977A20-0x0000000189977A40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001842E1110-0x00000001842E14D0
	// [IDTag] // 0x000000018997EB80-0x000000018997EBC0
	// [XID] // 0x000000018997EB80-0x000000018997EBC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001842E1B70-0x00000001842E1C70
	// [XID] // 0x0000000189989A80-0x0000000189989AA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AbilityPropExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001842E22C0-0x00000001842E25F0
	// [XID] // 0x00000001899912B0-0x00000001899912D0
	private static bool ParseConfigFromLine(string line, out AbilityPropExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001842E1790-0x00000001842E18D0
	// [IDTag] // 0x0000000189998DD0-0x0000000189998E10
	// [XID] // 0x0000000189998DD0-0x0000000189998E10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AbilityPropExcelConfig> configList) => default; // 0x00000001842E18D0-0x00000001842E1B70
	// [IDTag] // 0x00000001899A3670-0x00000001899A36B0
	// [XID] // 0x00000001899A3670-0x00000001899A36B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFDC1 */, bool useObjectPool = false /* Metadata: 0x00AEFDC5 */) => default; // 0x00000001842E1C70-0x00000001842E1EC0
	// [IDTag] // 0x00000001899AE000-0x00000001899AE040
	// [XID] // 0x00000001899AE000-0x00000001899AE040
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDC6 */, bool useObjectPool = false /* Metadata: 0x00AEFDCA */) => default; // 0x00000001842E1EC0-0x00000001842E2210
}

