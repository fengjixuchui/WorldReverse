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

public static class ChannellerSlabLevelExcelConfigLoader // TypeDefIndex: 14810
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLevelExcelConfig, ChannellerSlabLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLevelExcelConfig>, Dictionary<uint, ChannellerSlabLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLevelExcelConfig> dataDict { /* [XID] */ /* 0x0000000189759D80-0x0000000189759DA0 */ get; } // 0x0000000183417E20-0x0000000183417ED0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189768DA0-0x0000000189768DC0 */ get; } // 0x0000000183416720-0x00000001834167C0 

	// Methods
	// [XID] // 0x0000000189743A10-0x0000000189743A30
	public static bool GetIDList(uint stageId, uint waveId, ref List<uint> idList) => default; // 0x00000001834171D0-0x00000001834174D0
	// [XID] // 0x000000018974B560-0x000000018974B580
	public static ChannellerSlabLevelExcelConfig GetByGroupID(uint groupId) => default; // 0x0000000183416E40-0x0000000183417090
	// [XID] // 0x0000000189752750-0x0000000189752770
	public static void Register() {} // 0x0000000183418200-0x00000001834182A0
	// [XID] // 0x00000001897619B0-0x00000001897619D0
	public static ChannellerSlabLevelExcelConfig GetData(uint id) => default; // 0x00000001834165F0-0x0000000183416720
	// [XID] // 0x0000000189770490-0x00000001897704B0
	public static void LoadData() {} // 0x0000000183416D50-0x0000000183416E40
	// [XID] // 0x0000000189777BB0-0x0000000189777BD0
	private static void RegisterHotfixGenerated() {} // 0x0000000183416B80-0x0000000183416D50
	// [XID] // 0x000000018977F240-0x000000018977F260
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001834167C0-0x0000000183416B80
	// [IDTag] // 0x0000000189786C20-0x0000000189786C60
	// [XID] // 0x0000000189786C20-0x0000000189786C60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001834174D0-0x00000001834175D0
	// [XID] // 0x00000001897911F0-0x0000000189791210
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183417ED0-0x0000000183418200
	// [XID] // 0x00000001897989C0-0x00000001897989E0
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183417090-0x00000001834171D0
	// [IDTag] // 0x00000001897A0790-0x00000001897A07D0
	// [XID] // 0x00000001897A0790-0x00000001897A07D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLevelExcelConfig> configList) => default; // 0x00000001834175D0-0x0000000183417880
	// [IDTag] // 0x00000001897AABE0-0x00000001897AAC20
	// [XID] // 0x00000001897AABE0-0x00000001897AAC20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF620 */, bool useObjectPool = false /* Metadata: 0x00AEF624 */) => default; // 0x0000000183417BD0-0x0000000183417E20
	// [IDTag] // 0x00000001897B5F90-0x00000001897B5FD0
	// [XID] // 0x00000001897B5F90-0x00000001897B5FD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF625 */, bool useObjectPool = false /* Metadata: 0x00AEF629 */) => default; // 0x0000000183417880-0x0000000183417BD0
}

