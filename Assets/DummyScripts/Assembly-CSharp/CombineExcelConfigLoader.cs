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

public static class CombineExcelConfigLoader // TypeDefIndex: 15340
{
	// Fields
	private static Dictionary<uint, CombineExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CombineExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CombineExcelConfig, CombineExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CombineExcelConfig>, Dictionary<uint, CombineExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CombineExcelConfig> dataDict { /* [XID] */ /* 0x00000001899F7290-0x00000001899F72B0 */ get; } // 0x00000001818ADB00-0x00000001818ADBB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A061B0-0x0000000189A061D0 */ get; } // 0x00000001818AC950-0x00000001818AC9F0 

	// Methods
	// [XID] // 0x00000001899EFB70-0x00000001899EFB90
	public static void Register() {} // 0x00000001818ADEE0-0x00000001818ADF80
	// [XID] // 0x00000001899FE990-0x00000001899FE9B0
	public static CombineExcelConfig GetData(uint combineId) => default; // 0x00000001818AC820-0x00000001818AC950
	// [XID] // 0x0000000189A0D720-0x0000000189A0D740
	public static void LoadData() {} // 0x00000001818ACF80-0x00000001818AD070
	// [XID] // 0x0000000189A14EC0-0x0000000189A14EE0
	private static void RegisterHotfixGenerated() {} // 0x00000001818ACDB0-0x00000001818ACF80
	// [XID] // 0x0000000189A1C010-0x0000000189A1C030
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001818AC9F0-0x00000001818ACDB0
	// [IDTag] // 0x0000000189A238A0-0x0000000189A238E0
	// [XID] // 0x0000000189A238A0-0x0000000189A238E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001818AD1B0-0x00000001818AD2B0
	// [XID] // 0x0000000189A2DA50-0x0000000189A2DA70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CombineExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001818ADBB0-0x00000001818ADEE0
	// [XID] // 0x0000000189A35670-0x0000000189A35690
	private static bool ParseConfigFromLine(string line, out CombineExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001818AD070-0x00000001818AD1B0
	// [IDTag] // 0x0000000189A3CA80-0x0000000189A3CAC0
	// [XID] // 0x0000000189A3CA80-0x0000000189A3CAC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CombineExcelConfig> configList) => default; // 0x00000001818AD2B0-0x00000001818AD560
	// [IDTag] // 0x0000000189A47390-0x0000000189A473D0
	// [XID] // 0x0000000189A47390-0x0000000189A473D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0801 */, bool useObjectPool = false /* Metadata: 0x00AF0805 */) => default; // 0x00000001818AD8B0-0x00000001818ADB00
	// [IDTag] // 0x0000000189A51B70-0x0000000189A51BB0
	// [XID] // 0x0000000189A51B70-0x0000000189A51BB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0806 */, bool useObjectPool = false /* Metadata: 0x00AF080A */) => default; // 0x00000001818AD560-0x00000001818AD8B0
}

