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

public static class AvatarSkillDepotExcelConfigLoader // TypeDefIndex: 14836
{
	// Fields
	private static Dictionary<uint, List<uint>> _talentSkillDeportDic; // 0x00
	private static Dictionary<uint, List<uint>> _mainCostItemSkillDeportDic; // 0x08
	private static Dictionary<uint, List<uint>> _viceCostItemSkillDeportDic; // 0x10
	private static Dictionary<uint, AvatarSkillDepotExcelConfig> _dataDict; // 0x18
	public static Action<List<DataHotfixMeta>, List<AvatarSkillDepotExcelConfig>> customApplyHotfixAction; // 0x20
	public static Action<AvatarSkillDepotExcelConfig, AvatarSkillDepotExcelConfig> onUpdateConfig; // 0x28
	public static Action onApplyHotfixFinish; // 0x30
	public static Func<List<DataHotfixMeta>, List<AvatarSkillDepotExcelConfig>, Dictionary<uint, AvatarSkillDepotExcelConfig>, string, bool> customValidateFunc; // 0x38

	// Properties
	public static Dictionary<uint, AvatarSkillDepotExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BA0EB0-0x0000000189BA0ED0 */ get; } // 0x00000001829A9320-0x00000001829A93F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BAF9E0-0x0000000189BAFA00 */ get; } // 0x00000001829A75C0-0x00000001829A7660 

	// Constructors
	static AvatarSkillDepotExcelConfigLoader() {} // 0x00000001829AA5E0-0x00000001829AA660

	// Methods
	// [XID] // 0x0000000189B6D4A0-0x0000000189B6D4C0
	public static List<uint> GetMainCostItemSkillDepotList(uint id) => default; // 0x00000001829A74B0-0x00000001829A75C0
	// [XID] // 0x0000000189B74AD0-0x0000000189B74AF0
	public static List<uint> GetViceCostItemSkillDepotList(uint id) => default; // 0x00000001829A7200-0x00000001829A7310
	// [XID] // 0x0000000189B7C110-0x0000000189B7C130
	public static void BuildTalentSkillDepotDic() {} // 0x00000001829A9CC0-0x00000001829AA1D0
	// [XID] // 0x0000000189B83B40-0x0000000189B83B60
	public static void BuildTalentUpgradeCostItemSkillDepotDic() {} // 0x00000001829A9C00-0x00000001829A9CC0
	// [XID] // 0x0000000189B8ACD0-0x0000000189B8ACF0
	private static void BuildMainCostItemSkillDepotDic() {} // 0x00000001829A7B40-0x00000001829A8350
	// [XID] // 0x0000000189B92360-0x0000000189B92380
	private static void BuildViceCostItemSkillDepotDic() {} // 0x00000001829A93F0-0x00000001829A9C00
	// [XID] // 0x0000000189B99940-0x0000000189B99960
	public static void Register() {} // 0x00000001829AA520-0x00000001829AA5E0
	// [XID] // 0x0000000189BA8590-0x0000000189BA85B0
	public static AvatarSkillDepotExcelConfig GetData(uint id) => default; // 0x00000001829A7310-0x00000001829A74B0
	// [XID] // 0x0000000189BB7050-0x0000000189BB7070
	public static void LoadData() {} // 0x00000001829A85C0-0x00000001829A86F0
	// [XID] // 0x0000000189BBE5F0-0x0000000189BBE610
	private static void RegisterHotfixGenerated() {} // 0x00000001829A8350-0x00000001829A85C0
	// [XID] // 0x0000000189BC6300-0x0000000189BC6320
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001829A7660-0x00000001829A7B40
	// [IDTag] // 0x0000000189BCDF40-0x0000000189BCDF80
	// [XID] // 0x0000000189BCDF40-0x0000000189BCDF80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001829A8830-0x00000001829A8990
	// [XID] // 0x0000000189BD81F0-0x0000000189BD8210
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarSkillDepotExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001829AA1D0-0x00000001829AA520
	// [XID] // 0x0000000189BDFD20-0x0000000189BDFD40
	private static bool ParseConfigFromLine(string line, out AvatarSkillDepotExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001829A86F0-0x00000001829A8830
	// [IDTag] // 0x00000001895EC8F0-0x00000001895EC930
	// [XID] // 0x00000001895EC8F0-0x00000001895EC930
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarSkillDepotExcelConfig> configList) => default; // 0x00000001829A8990-0x00000001829A8CE0
	// [IDTag] // 0x00000001895F7220-0x00000001895F7260
	// [XID] // 0x00000001895F7220-0x00000001895F7260
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF710 */, bool useObjectPool = false /* Metadata: 0x00AEF714 */) => default; // 0x00000001829A9070-0x00000001829A9320
	// [IDTag] // 0x00000001896017E0-0x0000000189601820
	// [XID] // 0x00000001896017E0-0x0000000189601820
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF715 */, bool useObjectPool = false /* Metadata: 0x00AEF719 */) => default; // 0x00000001829A8CE0-0x00000001829A9070
}

