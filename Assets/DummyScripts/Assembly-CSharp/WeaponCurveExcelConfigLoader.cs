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

public static class WeaponCurveExcelConfigLoader // TypeDefIndex: 15682
{
	// Fields
	private static Dictionary<uint, WeaponCurveExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeaponCurveExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeaponCurveExcelConfig, WeaponCurveExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeaponCurveExcelConfig>, Dictionary<uint, WeaponCurveExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WeaponCurveExcelConfig> dataDict { /* [XID] */ /* 0x0000000189819410-0x0000000189819430 */ get; } // 0x00000001834EE7E0-0x00000001834EE890 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189828220-0x0000000189828240 */ get; } // 0x00000001834ED630-0x00000001834ED6D0 

	// Methods
	// [XID] // 0x00000001898117E0-0x0000000189811800
	public static void Register() {} // 0x00000001834EEBC0-0x00000001834EEC60
	// [XID] // 0x0000000189820C10-0x0000000189820C30
	public static WeaponCurveExcelConfig GetData(uint level) => default; // 0x00000001834ED500-0x00000001834ED630
	// [XID] // 0x000000018982F4A0-0x000000018982F4C0
	public static void LoadData() {} // 0x00000001834EDC60-0x00000001834EDD50
	// [XID] // 0x0000000189836D50-0x0000000189836D70
	private static void RegisterHotfixGenerated() {} // 0x00000001834EDA90-0x00000001834EDC60
	// [XID] // 0x000000018983E1E0-0x000000018983E200
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001834ED6D0-0x00000001834EDA90
	// [IDTag] // 0x0000000189845970-0x00000001898459B0
	// [XID] // 0x0000000189845970-0x00000001898459B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001834EE140-0x00000001834EE240
	// [XID] // 0x000000018984FBA0-0x000000018984FBC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeaponCurveExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001834EE890-0x00000001834EEBC0
	// [XID] // 0x0000000189857040-0x0000000189857060
	private static bool ParseConfigFromLine(string line, out WeaponCurveExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001834EDD50-0x00000001834EDE90
	// [IDTag] // 0x000000018985E150-0x000000018985E190
	// [XID] // 0x000000018985E150-0x000000018985E190
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeaponCurveExcelConfig> configList) => default; // 0x00000001834EDE90-0x00000001834EE140
	// [IDTag] // 0x0000000189868BD0-0x0000000189868C10
	// [XID] // 0x0000000189868BD0-0x0000000189868C10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF22DD */, bool useObjectPool = false /* Metadata: 0x00AF22E1 */) => default; // 0x00000001834EE590-0x00000001834EE7E0
	// [IDTag] // 0x0000000189872F10-0x0000000189872F50
	// [XID] // 0x0000000189872F10-0x0000000189872F50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22E2 */, bool useObjectPool = false /* Metadata: 0x00AF22E6 */) => default; // 0x00000001834EE240-0x00000001834EE590
}

