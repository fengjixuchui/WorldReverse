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

public static class EffigyLimitingConditionExcelConfigLoader // TypeDefIndex: 15082
{
	// Fields
	private static Dictionary<uint, EffigyLimitingConditionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EffigyLimitingConditionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EffigyLimitingConditionExcelConfig, EffigyLimitingConditionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EffigyLimitingConditionExcelConfig>, Dictionary<uint, EffigyLimitingConditionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EffigyLimitingConditionExcelConfig> dataDict { /* [XID] */ /* 0x00000001899163C0-0x00000001899163E0 */ get; } // 0x00000001826C3840-0x00000001826C38F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189925440-0x0000000189925460 */ get; } // 0x00000001826C2690-0x00000001826C2730 

	// Methods
	// [XID] // 0x000000018990EC70-0x000000018990EC90
	public static void Register() {} // 0x00000001826C3C20-0x00000001826C3CC0
	// [XID] // 0x000000018991DD30-0x000000018991DD50
	public static EffigyLimitingConditionExcelConfig GetData(uint id) => default; // 0x00000001826C2560-0x00000001826C2690
	// [XID] // 0x000000018992CA20-0x000000018992CA40
	public static void LoadData() {} // 0x00000001826C2CC0-0x00000001826C2DB0
	// [XID] // 0x0000000189934020-0x0000000189934040
	private static void RegisterHotfixGenerated() {} // 0x00000001826C2AF0-0x00000001826C2CC0
	// [XID] // 0x000000018993BC70-0x000000018993BC90
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001826C2730-0x00000001826C2AF0
	// [IDTag] // 0x0000000189942DF0-0x0000000189942E30
	// [XID] // 0x0000000189942DF0-0x0000000189942E30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001826C31A0-0x00000001826C32A0
	// [XID] // 0x000000018994D650-0x000000018994D670
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EffigyLimitingConditionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001826C38F0-0x00000001826C3C20
	// [XID] // 0x0000000189954D60-0x0000000189954D80
	private static bool ParseConfigFromLine(string line, out EffigyLimitingConditionExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001826C2DB0-0x00000001826C2EF0
	// [IDTag] // 0x000000018995C560-0x000000018995C5A0
	// [XID] // 0x000000018995C560-0x000000018995C5A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EffigyLimitingConditionExcelConfig> configList) => default; // 0x00000001826C2EF0-0x00000001826C31A0
	// [IDTag] // 0x0000000189967050-0x0000000189967090
	// [XID] // 0x0000000189967050-0x0000000189967090
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF004E */, bool useObjectPool = false /* Metadata: 0x00AF0052 */) => default; // 0x00000001826C35F0-0x00000001826C3840
	// [IDTag] // 0x0000000189971B00-0x0000000189971B40
	// [XID] // 0x0000000189971B00-0x0000000189971B40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0053 */, bool useObjectPool = false /* Metadata: 0x00AF0057 */) => default; // 0x00000001826C32A0-0x00000001826C35F0
}

