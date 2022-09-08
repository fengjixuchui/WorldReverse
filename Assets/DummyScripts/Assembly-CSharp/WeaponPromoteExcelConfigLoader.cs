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

public static class WeaponPromoteExcelConfigLoader // TypeDefIndex: 14924
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, WeaponPromoteExcelConfig>> _weaponPromoteDic; // 0x00
	private static List<WeaponPromoteExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<WeaponPromoteExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<WeaponPromoteExcelConfig, WeaponPromoteExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<WeaponPromoteExcelConfig>, List<WeaponPromoteExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<WeaponPromoteExcelConfig> dataList { /* [XID] */ /* 0x0000000189798980-0x00000001897989A0 */ get; } // 0x000000018179CEB0-0x000000018179CF80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897A0750-0x00000001897A0770 */ get; } // 0x000000018179B250-0x000000018179B2F0 

	// Constructors
	static WeaponPromoteExcelConfigLoader() {} // 0x000000018179D390-0x000000018179D3F0

	// Methods
	// [XID] // 0x000000018977AAC0-0x000000018977AAE0
	public static void BuildWeaponPromoteDic() {} // 0x000000018179B840-0x000000018179BC70
	// [XID] // 0x0000000189782660-0x0000000189782680
	public static Dictionary<uint, WeaponPromoteExcelConfig> GetWeaponPromoteDicByPromoteId(uint promoteId) => default; // 0x000000018179CD80-0x000000018179CEB0
	// [XID] // 0x0000000189789980-0x00000001897899A0
	public static WeaponPromoteExcelConfig GetWeaponPromoteConfig(uint promoteId, uint promoteLevel) => default; // 0x000000018179C010-0x000000018179C180
	// [XID] // 0x0000000189791170-0x0000000189791190
	public static void Register() {} // 0x000000018179D2D0-0x000000018179D390
	// [XID] // 0x00000001897A7D40-0x00000001897A7D60
	public static void LoadData() {} // 0x000000018179BEE0-0x000000018179C010
	// [XID] // 0x00000001897AF7F0-0x00000001897AF810
	private static void RegisterHotfixGenerated() {} // 0x000000018179BC70-0x000000018179BEE0
	// [XID] // 0x00000001897B7670-0x00000001897B7690
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018179B2F0-0x000000018179B840
	// [IDTag] // 0x00000001897BF550-0x00000001897BF590
	// [XID] // 0x00000001897BF550-0x00000001897BF590
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018179C2C0-0x000000018179C420
	// [XID] // 0x00000001897C9960-0x00000001897C9980
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeaponPromoteExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018179CF80-0x000000018179D2D0
	// [XID] // 0x00000001897D0FD0-0x00000001897D0FF0
	private static bool ParseConfigFromLine(string line, out WeaponPromoteExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018179C180-0x000000018179C2C0
	// [IDTag] // 0x00000001897D8F90-0x00000001897D8FD0
	// [XID] // 0x00000001897D8F90-0x00000001897D8FD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeaponPromoteExcelConfig> configList) => default; // 0x000000018179C420-0x000000018179C750
	// [IDTag] // 0x00000001897E32C0-0x00000001897E3300
	// [XID] // 0x00000001897E32C0-0x00000001897E3300
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA23 */, bool useObjectPool = false /* Metadata: 0x00AEFA27 */) => default; // 0x000000018179CAD0-0x000000018179CD80
	// [IDTag] // 0x00000001897EDD70-0x00000001897EDDB0
	// [XID] // 0x00000001897EDD70-0x00000001897EDDB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA28 */, bool useObjectPool = false /* Metadata: 0x00AEFA2C */) => default; // 0x000000018179C750-0x000000018179CAD0
}

