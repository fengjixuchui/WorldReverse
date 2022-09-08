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

public static class ReliquaryAffixExcelConfigLoader // TypeDefIndex: 16020
{
	// Fields
	private static Dictionary<uint, ReliquaryAffixExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryAffixExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryAffixExcelConfig, ReliquaryAffixExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryAffixExcelConfig>, Dictionary<uint, ReliquaryAffixExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReliquaryAffixExcelConfig> dataDict { /* [XID] */ /* 0x0000000189783AF0-0x0000000189783B10 */ get; } // 0x0000000182CDF320-0x0000000182CDF3D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189792800-0x0000000189792820 */ get; } // 0x0000000182CDE170-0x0000000182CDE210 

	// Methods
	// [XID] // 0x000000018977C140-0x000000018977C160
	public static void Register() {} // 0x0000000182CDF700-0x0000000182CDF7A0
	// [XID] // 0x000000018978B2E0-0x000000018978B300
	public static ReliquaryAffixExcelConfig GetData(uint id) => default; // 0x0000000182CDE040-0x0000000182CDE170
	// [XID] // 0x0000000189799D90-0x0000000189799DB0
	public static void LoadData() {} // 0x0000000182CDE7A0-0x0000000182CDE890
	// [XID] // 0x00000001897A1C80-0x00000001897A1CA0
	private static void RegisterHotfixGenerated() {} // 0x0000000182CDE5D0-0x0000000182CDE7A0
	// [XID] // 0x00000001897A94A0-0x00000001897A94C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182CDE210-0x0000000182CDE5D0
	// [IDTag] // 0x00000001897B0BE0-0x00000001897B0C20
	// [XID] // 0x00000001897B0BE0-0x00000001897B0C20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182CDE9D0-0x0000000182CDEAD0
	// [XID] // 0x00000001897BBFF0-0x00000001897BC010
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryAffixExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182CDF3D0-0x0000000182CDF700
	// [XID] // 0x00000001897C3810-0x00000001897C3830
	private static bool ParseConfigFromLine(string line, out ReliquaryAffixExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182CDE890-0x0000000182CDE9D0
	// [IDTag] // 0x00000001897CAFB0-0x00000001897CAFF0
	// [XID] // 0x00000001897CAFB0-0x00000001897CAFF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryAffixExcelConfig> configList) => default; // 0x0000000182CDEAD0-0x0000000182CDED80
	// [IDTag] // 0x00000001897D5650-0x00000001897D5690
	// [XID] // 0x00000001897D5650-0x00000001897D5690
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E13 */, bool useObjectPool = false /* Metadata: 0x00AF2E17 */) => default; // 0x0000000182CDED80-0x0000000182CDEFD0
	// [IDTag] // 0x00000001897DFF10-0x00000001897DFF50
	// [XID] // 0x00000001897DFF10-0x00000001897DFF50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E18 */, bool useObjectPool = false /* Metadata: 0x00AF2E1C */) => default; // 0x0000000182CDEFD0-0x0000000182CDF320
}

