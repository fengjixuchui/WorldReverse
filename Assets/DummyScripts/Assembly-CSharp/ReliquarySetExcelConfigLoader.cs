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

public static class ReliquarySetExcelConfigLoader // TypeDefIndex: 14901
{
	// Fields
	private static Dictionary<uint, ReliquarySetExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<ReliquarySetExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<ReliquarySetExcelConfig, ReliquarySetExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<ReliquarySetExcelConfig>, Dictionary<uint, ReliquarySetExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<uint> reliquarySetFilteredIdList { /* [XID] */ /* 0x00000001899DF1D0-0x00000001899DF210 */ get; /* [XID] */ /* 0x00000001899E9A80-0x00000001899E9AC0 */ private set; } // 0x0000000182020020-0x0000000182020080 0x0000000182020080-0x00000001820200E0
	public static Dictionary<uint, ReliquarySetExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A0A6C0-0x0000000189A0A6E0 */ get; } // 0x000000018201FBA0-0x000000018201FC50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A19350-0x0000000189A19370 */ get; } // 0x000000018201E5F0-0x000000018201E690 

	// Methods
	// [XID] // 0x00000001899F4790-0x00000001899F47B0
	public static void OnConfigLoadFinish() {} // 0x000000018201FC50-0x000000018201FCF0
	// [XID] // 0x00000001899FBD90-0x00000001899FBDB0
	private static void BuildReliquarySetFilterIdList() {} // 0x000000018201EA50-0x000000018201EE50
	// [XID] // 0x0000000189A03130-0x0000000189A03150
	public static void Register() {} // 0x00000001820200E0-0x0000000182020180
	// [XID] // 0x0000000189A11F20-0x0000000189A11F40
	public static ReliquarySetExcelConfig GetData(uint setId) => default; // 0x000000018201E4B0-0x000000018201E5F0
	// [XID] // 0x0000000189A209D0-0x0000000189A209F0
	public static void LoadData() {} // 0x000000018201F020-0x000000018201F110
	// [XID] // 0x0000000189A27DA0-0x0000000189A27DC0
	private static void RegisterHotfixGenerated() {} // 0x000000018201EE50-0x000000018201F020
	// [XID] // 0x0000000189A2F590-0x0000000189A2F5B0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018201E690-0x000000018201EA50
	// [IDTag] // 0x0000000189A36FB0-0x0000000189A36FF0
	// [XID] // 0x0000000189A36FB0-0x0000000189A36FF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018201F500-0x000000018201F600
	// [XID] // 0x0000000189A41670-0x0000000189A41690
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquarySetExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018201FCF0-0x0000000182020020
	// [XID] // 0x0000000189A48CB0-0x0000000189A48CD0
	private static bool ParseConfigFromLine(string line, out ReliquarySetExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018201F110-0x000000018201F250
	// [IDTag] // 0x0000000189A50400-0x0000000189A50440
	// [XID] // 0x0000000189A50400-0x0000000189A50440
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquarySetExcelConfig> configList) => default; // 0x000000018201F250-0x000000018201F500
	// [IDTag] // 0x0000000189A5AA30-0x0000000189A5AA70
	// [XID] // 0x0000000189A5AA30-0x0000000189A5AA70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF960 */, bool useObjectPool = false /* Metadata: 0x00AEF964 */) => default; // 0x000000018201F600-0x000000018201F850
	// [IDTag] // 0x0000000189A65660-0x0000000189A656A0
	// [XID] // 0x0000000189A65660-0x0000000189A656A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF965 */, bool useObjectPool = false /* Metadata: 0x00AEF969 */) => default; // 0x000000018201F850-0x000000018201FBA0
}

