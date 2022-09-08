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

public static class InvestigationDungeonConfigLoader // TypeDefIndex: 14871
{
	// Fields
	private static Dictionary<uint, List<uint>> _cityDungeonDic; // 0x00
	private static Dictionary<uint, InvestigationDungeonConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<InvestigationDungeonConfig>> customApplyHotfixAction; // 0x10
	public static Action<InvestigationDungeonConfig, InvestigationDungeonConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<InvestigationDungeonConfig>, Dictionary<uint, InvestigationDungeonConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, InvestigationDungeonConfig> dataDict { /* [XID] */ /* 0x00000001896C9850-0x00000001896C9870 */ get; } // 0x000000018507F640-0x000000018507F710 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896D86F0-0x00000001896D8710 */ get; } // 0x000000018507DC20-0x000000018507DCC0 

	// Constructors
	static InvestigationDungeonConfigLoader() {} // 0x000000018507FB20-0x000000018507FBB0

	// Methods
	// [XID] // 0x00000001896B3A10-0x00000001896B3A30
	public static void BuildCityDungeonDic() {} // 0x000000018507E410-0x000000018507E7A0
	// [XID] // 0x00000001896BB110-0x00000001896BB130
	public static List<uint> GetDungeonEntryListByCityId(uint cityId) => default; // 0x000000018507EA10-0x000000018507EB50
	// [XID] // 0x00000001896C2280-0x00000001896C22A0
	public static void Register() {} // 0x000000018507FA60-0x000000018507FB20
	// [XID] // 0x00000001896D0FA0-0x00000001896D0FC0
	public static InvestigationDungeonConfig GetData(uint entranceId) => default; // 0x000000018507DA80-0x000000018507DC20
	// [XID] // 0x00000001896E0060-0x00000001896E0080
	public static void LoadData() {} // 0x000000018507E7A0-0x000000018507E8D0
	// [XID] // 0x00000001896E7340-0x00000001896E7360
	private static void RegisterHotfixGenerated() {} // 0x000000018507E1A0-0x000000018507E410
	// [XID] // 0x00000001896EE8F0-0x00000001896EE910
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018507DCC0-0x000000018507E1A0
	// [IDTag] // 0x00000001896F6180-0x00000001896F61C0
	// [XID] // 0x00000001896F6180-0x00000001896F61C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018507EB50-0x000000018507ECB0
	// [XID] // 0x0000000189700560-0x0000000189700580
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<InvestigationDungeonConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018507F710-0x000000018507FA60
	// [XID] // 0x0000000189707DD0-0x0000000189707DF0
	private static bool ParseConfigFromLine(string line, out InvestigationDungeonConfig data) {
		data = default;
		return default;
	} // 0x000000018507E8D0-0x000000018507EA10
	// [IDTag] // 0x000000018970F8A0-0x000000018970F8E0
	// [XID] // 0x000000018970F8A0-0x000000018970F8E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<InvestigationDungeonConfig> configList) => default; // 0x000000018507ECB0-0x000000018507F000
	// [IDTag] // 0x0000000189719EF0-0x0000000189719F30
	// [XID] // 0x0000000189719EF0-0x0000000189719F30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF88C */, bool useObjectPool = false /* Metadata: 0x00AEF890 */) => default; // 0x000000018507F000-0x000000018507F2B0
	// [IDTag] // 0x00000001897241B0-0x00000001897241F0
	// [XID] // 0x00000001897241B0-0x00000001897241F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF891 */, bool useObjectPool = false /* Metadata: 0x00AEF895 */) => default; // 0x000000018507F2B0-0x000000018507F640
}

