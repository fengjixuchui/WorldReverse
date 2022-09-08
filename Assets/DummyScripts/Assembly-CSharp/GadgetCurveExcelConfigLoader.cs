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

public static class GadgetCurveExcelConfigLoader // TypeDefIndex: 15680
{
	// Fields
	private static Dictionary<uint, GadgetCurveExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetCurveExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetCurveExcelConfig, GadgetCurveExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetCurveExcelConfig>, Dictionary<uint, GadgetCurveExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetCurveExcelConfig> dataDict { /* [XID] */ /* 0x00000001897259E0-0x0000000189725A00 */ get; } // 0x0000000181DF3C50-0x0000000181DF3D00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897346F0-0x0000000189734710 */ get; } // 0x0000000181DF2AA0-0x0000000181DF2B40 

	// Methods
	// [XID] // 0x000000018971E420-0x000000018971E440
	public static void Register() {} // 0x0000000181DF4030-0x0000000181DF40D0
	// [XID] // 0x000000018972CFA0-0x000000018972CFC0
	public static GadgetCurveExcelConfig GetData(uint level) => default; // 0x0000000181DF2970-0x0000000181DF2AA0
	// [XID] // 0x000000018973C0A0-0x000000018973C0C0
	public static void LoadData() {} // 0x0000000181DF30D0-0x0000000181DF31C0
	// [XID] // 0x0000000189743870-0x0000000189743890
	private static void RegisterHotfixGenerated() {} // 0x0000000181DF2F00-0x0000000181DF30D0
	// [XID] // 0x000000018974B440-0x000000018974B460
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181DF2B40-0x0000000181DF2F00
	// [IDTag] // 0x00000001897525F0-0x0000000189752630
	// [XID] // 0x00000001897525F0-0x0000000189752630
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181DF3300-0x0000000181DF3400
	// [XID] // 0x000000018975CC10-0x000000018975CC30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetCurveExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181DF3D00-0x0000000181DF4030
	// [XID] // 0x0000000189764400-0x0000000189764420
	private static bool ParseConfigFromLine(string line, out GadgetCurveExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181DF31C0-0x0000000181DF3300
	// [IDTag] // 0x000000018976BD80-0x000000018976BDC0
	// [XID] // 0x000000018976BD80-0x000000018976BDC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetCurveExcelConfig> configList) => default; // 0x0000000181DF3400-0x0000000181DF36B0
	// [IDTag] // 0x00000001897764A0-0x00000001897764E0
	// [XID] // 0x00000001897764A0-0x00000001897764E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF22CE */, bool useObjectPool = false /* Metadata: 0x00AF22D2 */) => default; // 0x0000000181DF36B0-0x0000000181DF3900
	// [IDTag] // 0x0000000189780BA0-0x0000000189780BE0
	// [XID] // 0x0000000189780BA0-0x0000000189780BE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22D3 */, bool useObjectPool = false /* Metadata: 0x00AF22D7 */) => default; // 0x0000000181DF3900-0x0000000181DF3C50
}

