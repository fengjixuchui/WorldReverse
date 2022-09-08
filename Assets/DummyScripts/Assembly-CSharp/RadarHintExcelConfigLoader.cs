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

public static class RadarHintExcelConfigLoader // TypeDefIndex: 15642
{
	// Fields
	private static Dictionary<uint, RadarHintExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RadarHintExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RadarHintExcelConfig, RadarHintExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RadarHintExcelConfig>, Dictionary<uint, RadarHintExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RadarHintExcelConfig> dataDict { /* [XID] */ /* 0x000000018971FBD0-0x000000018971FBF0 */ get; } // 0x00000001821528E0-0x0000000182152990 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018972E830-0x000000018972E850 */ get; } // 0x0000000182151730-0x00000001821517D0 

	// Methods
	// [XID] // 0x0000000189718210-0x0000000189718230
	public static void Register() {} // 0x0000000182152CC0-0x0000000182152D60
	// [XID] // 0x00000001897272E0-0x0000000189727300
	public static RadarHintExcelConfig GetData(uint id) => default; // 0x0000000182151600-0x0000000182151730
	// [XID] // 0x0000000189735FC0-0x0000000189735FE0
	public static void LoadData() {} // 0x0000000182151D60-0x0000000182151E50
	// [XID] // 0x000000018973DC90-0x000000018973DCB0
	private static void RegisterHotfixGenerated() {} // 0x0000000182151B90-0x0000000182151D60
	// [XID] // 0x0000000189745030-0x0000000189745050
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821517D0-0x0000000182151B90
	// [IDTag] // 0x000000018974CB40-0x000000018974CB80
	// [XID] // 0x000000018974CB40-0x000000018974CB80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182152240-0x0000000182152340
	// [XID] // 0x0000000189756FE0-0x0000000189757000
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RadarHintExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182152990-0x0000000182152CC0
	// [XID] // 0x000000018975E570-0x000000018975E590
	private static bool ParseConfigFromLine(string line, out RadarHintExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182151E50-0x0000000182151F90
	// [IDTag] // 0x0000000189765C10-0x0000000189765C50
	// [XID] // 0x0000000189765C10-0x0000000189765C50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RadarHintExcelConfig> configList) => default; // 0x0000000182151F90-0x0000000182152240
	// [IDTag] // 0x0000000189770290-0x00000001897702D0
	// [XID] // 0x0000000189770290-0x00000001897702D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2175 */, bool useObjectPool = false /* Metadata: 0x00AF2179 */) => default; // 0x0000000182152340-0x0000000182152590
	// [IDTag] // 0x000000018977A8C0-0x000000018977A900
	// [XID] // 0x000000018977A8C0-0x000000018977A900
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF217A */, bool useObjectPool = false /* Metadata: 0x00AF217E */) => default; // 0x0000000182152590-0x00000001821528E0
}

