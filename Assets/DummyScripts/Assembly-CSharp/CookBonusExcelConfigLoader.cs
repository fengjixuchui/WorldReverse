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

public static class CookBonusExcelConfigLoader // TypeDefIndex: 14853
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, CookBonusExcelConfig>> _cookBonusDic; // 0x00
	private static List<CookBonusExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<CookBonusExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<CookBonusExcelConfig, CookBonusExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<CookBonusExcelConfig>, List<CookBonusExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<CookBonusExcelConfig> dataList { /* [XID] */ /* 0x000000018998F9A0-0x000000018998F9C0 */ get; } // 0x000000018301BA30-0x000000018301BB00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189997340-0x0000000189997360 */ get; } // 0x0000000183019FA0-0x000000018301A040 

	// Constructors
	static CookBonusExcelConfigLoader() {} // 0x000000018301BF10-0x000000018301BF70

	// Methods
	// [XID] // 0x00000001899794B0-0x00000001899794D0
	public static void BuildCookBonusDic() {} // 0x000000018301A970-0x000000018301AD00
	// [XID] // 0x00000001899805E0-0x0000000189980600
	public static Dictionary<uint, CookBonusExcelConfig> GetBonusDicByRecipeId(uint recipeId) => default; // 0x000000018301A800-0x000000018301A970
	// [XID] // 0x0000000189987F10-0x0000000189987F30
	public static void Register() {} // 0x000000018301BE50-0x000000018301BF10
	// [XID] // 0x000000018999EF10-0x000000018999EF30
	public static void LoadData() {} // 0x000000018301AD00-0x000000018301AE30
	// [XID] // 0x00000001899A67F0-0x00000001899A6810
	private static void RegisterHotfixGenerated() {} // 0x000000018301A590-0x000000018301A800
	// [XID] // 0x00000001899AE080-0x00000001899AE0A0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018301A040-0x000000018301A590
	// [IDTag] // 0x00000001899B5820-0x00000001899B5860
	// [XID] // 0x00000001899B5820-0x00000001899B5860
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018301B2A0-0x000000018301B400
	// [XID] // 0x00000001899C0090-0x00000001899C00B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CookBonusExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018301BB00-0x000000018301BE50
	// [XID] // 0x00000001899C7830-0x00000001899C7850
	private static bool ParseConfigFromLine(string line, out CookBonusExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018301AE30-0x000000018301AF70
	// [IDTag] // 0x00000001899CF000-0x00000001899CF040
	// [XID] // 0x00000001899CF000-0x00000001899CF040
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CookBonusExcelConfig> configList) => default; // 0x000000018301AF70-0x000000018301B2A0
	// [IDTag] // 0x00000001899D9450-0x00000001899D9490
	// [XID] // 0x00000001899D9450-0x00000001899D9490
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF7D1 */, bool useObjectPool = false /* Metadata: 0x00AEF7D5 */) => default; // 0x000000018301B780-0x000000018301BA30
	// [IDTag] // 0x00000001899E3CB0-0x00000001899E3CF0
	// [XID] // 0x00000001899E3CB0-0x00000001899E3CF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7D6 */, bool useObjectPool = false /* Metadata: 0x00AEF7DA */) => default; // 0x000000018301B400-0x000000018301B780
}

