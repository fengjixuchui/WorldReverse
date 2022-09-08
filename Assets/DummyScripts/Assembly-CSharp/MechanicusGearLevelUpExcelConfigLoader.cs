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

public static class MechanicusGearLevelUpExcelConfigLoader // TypeDefIndex: 14917
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, MechanicusGearLevelUpExcelConfig>> _configListDict; // 0x00
	private static Dictionary<uint, MechanicusGearLevelUpExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MechanicusGearLevelUpExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<MechanicusGearLevelUpExcelConfig, MechanicusGearLevelUpExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MechanicusGearLevelUpExcelConfig>, Dictionary<uint, MechanicusGearLevelUpExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, MechanicusGearLevelUpExcelConfig> dataDict { /* [XID] */ /* 0x0000000189997320-0x0000000189997340 */ get; } // 0x0000000182BCEA70-0x0000000182BCEB20 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A67D0-0x00000001899A67F0 */ get; } // 0x0000000182BCD440-0x0000000182BCD4E0 

	// Methods
	// [XID] // 0x00000001899805C0-0x00000001899805E0
	public static void BuildData() {} // 0x0000000182BCD4E0-0x0000000182BCD820
	// [XID] // 0x0000000189987EF0-0x0000000189987F10
	public static MechanicusGearLevelUpExcelConfig GetGearLevelUpExcelConfig(uint gearID, uint level) => default; // 0x0000000182BCD820-0x0000000182BCD960
	// [XID] // 0x000000018998F940-0x000000018998F960
	public static void Register() {} // 0x0000000182BCEE50-0x0000000182BCEEF0
	// [XID] // 0x000000018999EEF0-0x000000018999EF10
	public static MechanicusGearLevelUpExcelConfig GetData(uint ID) => default; // 0x0000000182BCD300-0x0000000182BCD440
	// [XID] // 0x00000001899AE060-0x00000001899AE080
	public static void LoadData() {} // 0x0000000182BCDEF0-0x0000000182BCDFE0
	// [XID] // 0x00000001899B5800-0x00000001899B5820
	private static void RegisterHotfixGenerated() {} // 0x0000000182BCDD20-0x0000000182BCDEF0
	// [XID] // 0x00000001899BCFD0-0x00000001899BCFF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182BCD960-0x0000000182BCDD20
	// [IDTag] // 0x00000001899C4A80-0x00000001899C4AC0
	// [XID] // 0x00000001899C4A80-0x00000001899C4AC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182BCE120-0x0000000182BCE220
	// [XID] // 0x00000001899CEFC0-0x00000001899CEFE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusGearLevelUpExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182BCEB20-0x0000000182BCEE50
	// [XID] // 0x00000001899D6590-0x00000001899D65B0
	private static bool ParseConfigFromLine(string line, out MechanicusGearLevelUpExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182BCDFE0-0x0000000182BCE120
	// [IDTag] // 0x00000001899DDAA0-0x00000001899DDAE0
	// [XID] // 0x00000001899DDAA0-0x00000001899DDAE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusGearLevelUpExcelConfig> configList) => default; // 0x0000000182BCE220-0x0000000182BCE4D0
	// [IDTag] // 0x00000001899E86C0-0x00000001899E8700
	// [XID] // 0x00000001899E86C0-0x00000001899E8700
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9DD */, bool useObjectPool = false /* Metadata: 0x00AEF9E1 */) => default; // 0x0000000182BCE820-0x0000000182BCEA70
	// [IDTag] // 0x00000001899F2CA0-0x00000001899F2CE0
	// [XID] // 0x00000001899F2CA0-0x00000001899F2CE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9E2 */, bool useObjectPool = false /* Metadata: 0x00AEF9E6 */) => default; // 0x0000000182BCE4D0-0x0000000182BCE820
}

