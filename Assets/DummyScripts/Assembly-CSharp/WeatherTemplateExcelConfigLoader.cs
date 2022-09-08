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

public static class WeatherTemplateExcelConfigLoader // TypeDefIndex: 16279
{
	// Fields
	private static List<WeatherTemplateExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeatherTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeatherTemplateExcelConfig, WeatherTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeatherTemplateExcelConfig>, List<WeatherTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<WeatherTemplateExcelConfig> dataList { /* [XID] */ /* 0x000000018969EF90-0x000000018969EFB0 */ get; } // 0x0000000182E6C3B0-0x0000000182E6C460 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896A6450-0x00000001896A6470 */ get; } // 0x0000000182E6B1C0-0x0000000182E6B260 

	// Methods
	// [XID] // 0x0000000189697D00-0x0000000189697D20
	public static void Register() {} // 0x0000000182E6C790-0x0000000182E6C830
	// [XID] // 0x00000001896AD9D0-0x00000001896AD9F0
	public static void LoadData() {} // 0x0000000182E6B860-0x0000000182E6B950
	// [XID] // 0x00000001896B5190-0x00000001896B51B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182E6B690-0x0000000182E6B860
	// [XID] // 0x00000001896BC3A0-0x00000001896BC3C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E6B260-0x0000000182E6B690
	// [IDTag] // 0x00000001896C38C0-0x00000001896C3900
	// [XID] // 0x00000001896C38C0-0x00000001896C3900
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E6BD30-0x0000000182E6BE30
	// [XID] // 0x00000001896CDFD0-0x00000001896CDFF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeatherTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E6C460-0x0000000182E6C790
	// [XID] // 0x00000001896D5500-0x00000001896D5520
	private static bool ParseConfigFromLine(string line, out WeatherTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E6B950-0x0000000182E6BA90
	// [IDTag] // 0x00000001896DCAA0-0x00000001896DCAE0
	// [XID] // 0x00000001896DCAA0-0x00000001896DCAE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeatherTemplateExcelConfig> configList) => default; // 0x0000000182E6BA90-0x0000000182E6BD30
	// [IDTag] // 0x00000001896E7040-0x00000001896E7080
	// [XID] // 0x00000001896E7040-0x00000001896E7080
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3644 */, bool useObjectPool = false /* Metadata: 0x00AF3648 */) => default; // 0x0000000182E6BE30-0x0000000182E6C080
	// [IDTag] // 0x00000001896F1160-0x00000001896F11A0
	// [XID] // 0x00000001896F1160-0x00000001896F11A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3649 */, bool useObjectPool = false /* Metadata: 0x00AF364D */) => default; // 0x0000000182E6C080-0x0000000182E6C3B0
}

