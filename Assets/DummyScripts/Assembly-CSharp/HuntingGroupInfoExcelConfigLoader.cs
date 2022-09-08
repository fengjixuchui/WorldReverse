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

public static class HuntingGroupInfoExcelConfigLoader // TypeDefIndex: 15749
{
	// Fields
	private static Dictionary<uint, HuntingGroupInfoExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingGroupInfoExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingGroupInfoExcelConfig, HuntingGroupInfoExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingGroupInfoExcelConfig>, Dictionary<uint, HuntingGroupInfoExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingGroupInfoExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A802E0-0x0000000189A80300 */ get; } // 0x00000001831F9F80-0x00000001831FA030 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A8F910-0x0000000189A8F930 */ get; } // 0x00000001831F8DD0-0x00000001831F8E70 

	// Methods
	// [XID] // 0x0000000189A78DA0-0x0000000189A78DC0
	public static void Register() {} // 0x00000001831FA360-0x00000001831FA400
	// [XID] // 0x0000000189A88040-0x0000000189A88060
	public static HuntingGroupInfoExcelConfig GetData(uint groupId) => default; // 0x00000001831F8CA0-0x00000001831F8DD0
	// [XID] // 0x0000000189A96F20-0x0000000189A96F40
	public static void LoadData() {} // 0x00000001831F9400-0x00000001831F94F0
	// [XID] // 0x0000000189A9E2B0-0x0000000189A9E2D0
	private static void RegisterHotfixGenerated() {} // 0x00000001831F9230-0x00000001831F9400
	// [XID] // 0x0000000189AA5C60-0x0000000189AA5C80
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001831F8E70-0x00000001831F9230
	// [IDTag] // 0x0000000189AAD2C0-0x0000000189AAD300
	// [XID] // 0x0000000189AAD2C0-0x0000000189AAD300
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001831F9630-0x00000001831F9730
	// [XID] // 0x0000000189AB7B40-0x0000000189AB7B60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingGroupInfoExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001831FA030-0x00000001831FA360
	// [XID] // 0x0000000189ABF630-0x0000000189ABF650
	private static bool ParseConfigFromLine(string line, out HuntingGroupInfoExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001831F94F0-0x00000001831F9630
	// [IDTag] // 0x0000000189AC7020-0x0000000189AC7060
	// [XID] // 0x0000000189AC7020-0x0000000189AC7060
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingGroupInfoExcelConfig> configList) => default; // 0x00000001831F9730-0x00000001831F99E0
	// [IDTag] // 0x0000000189AD1810-0x0000000189AD1850
	// [XID] // 0x0000000189AD1810-0x0000000189AD1850
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF24F9 */, bool useObjectPool = false /* Metadata: 0x00AF24FD */) => default; // 0x00000001831F9D30-0x00000001831F9F80
	// [IDTag] // 0x0000000189ADC680-0x0000000189ADC6C0
	// [XID] // 0x0000000189ADC680-0x0000000189ADC6C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24FE */, bool useObjectPool = false /* Metadata: 0x00AF2502 */) => default; // 0x00000001831F99E0-0x00000001831F9D30
}

