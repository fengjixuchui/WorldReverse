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

public static class ChannellerSlabLoopDungeonConditionExcelConfigLoader // TypeDefIndex: 15051
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLoopDungeonConditionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonConditionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLoopDungeonConditionExcelConfig, ChannellerSlabLoopDungeonConditionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonConditionExcelConfig>, Dictionary<uint, ChannellerSlabLoopDungeonConditionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLoopDungeonConditionExcelConfig> dataDict { /* [XID] */ /* 0x000000018970DD90-0x000000018970DDB0 */ get; } // 0x00000001856873B0-0x0000000185687460 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018971CD60-0x000000018971CD80 */ get; } // 0x0000000185686200-0x00000001856862A0 

	// Methods
	// [XID] // 0x0000000189706460-0x0000000189706480
	public static void Register() {} // 0x0000000185687790-0x0000000185687830
	// [XID] // 0x0000000189715270-0x0000000189715290
	public static ChannellerSlabLoopDungeonConditionExcelConfig GetData(uint id) => default; // 0x00000001856860D0-0x0000000185686200
	// [XID] // 0x0000000189724150-0x0000000189724170
	public static void LoadData() {} // 0x0000000185686830-0x0000000185686920
	// [XID] // 0x000000018972B8B0-0x000000018972B8D0
	private static void RegisterHotfixGenerated() {} // 0x0000000185686660-0x0000000185686830
	// [XID] // 0x0000000189733080-0x00000001897330A0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001856862A0-0x0000000185686660
	// [IDTag] // 0x000000018973A750-0x000000018973A790
	// [XID] // 0x000000018973A750-0x000000018973A790
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185686D10-0x0000000185686E10
	// [XID] // 0x00000001897451B0-0x00000001897451D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLoopDungeonConditionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185687460-0x0000000185687790
	// [XID] // 0x000000018974CC60-0x000000018974CC80
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLoopDungeonConditionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185686920-0x0000000185686A60
	// [IDTag] // 0x0000000189754040-0x0000000189754080
	// [XID] // 0x0000000189754040-0x0000000189754080
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLoopDungeonConditionExcelConfig> configList) => default; // 0x0000000185686A60-0x0000000185686D10
	// [IDTag] // 0x000000018975E6D0-0x000000018975E710
	// [XID] // 0x000000018975E6D0-0x000000018975E710
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFF6E */, bool useObjectPool = false /* Metadata: 0x00AEFF72 */) => default; // 0x0000000185686E10-0x0000000185687060
	// [IDTag] // 0x0000000189768CC0-0x0000000189768D00
	// [XID] // 0x0000000189768CC0-0x0000000189768D00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF73 */, bool useObjectPool = false /* Metadata: 0x00AEFF77 */) => default; // 0x0000000185687060-0x00000001856873B0
}

