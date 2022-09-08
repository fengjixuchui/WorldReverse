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

public static class ChannellerSlabDungeonExcelConfigLoader // TypeDefIndex: 14816
{
	// Fields
	private static Dictionary<uint, ChannellerSlabDungeonExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabDungeonExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabDungeonExcelConfig, ChannellerSlabDungeonExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabDungeonExcelConfig>, Dictionary<uint, ChannellerSlabDungeonExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabDungeonExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A89A10-0x0000000189A89A30 */ get; } // 0x00000001835493D0-0x0000000183549480 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A98B60-0x0000000189A98B80 */ get; } // 0x0000000183547FD0-0x0000000183548070 

	// Methods
	// [XID] // 0x0000000189A7AAF0-0x0000000189A7AB10
	public static ChannellerSlabDungeonExcelConfig GetDataByPointID(uint pointID) => default; // 0x0000000183548BE0-0x0000000183548E30
	// [XID] // 0x0000000189A81FB0-0x0000000189A81FD0
	public static void Register() {} // 0x00000001835497B0-0x0000000183549850
	// [XID] // 0x0000000189A91150-0x0000000189A91170
	public static ChannellerSlabDungeonExcelConfig GetData(uint stageID) => default; // 0x0000000183547EA0-0x0000000183547FD0
	// [XID] // 0x0000000189A9FE70-0x0000000189A9FE90
	public static void LoadData() {} // 0x0000000183548600-0x00000001835486F0
	// [XID] // 0x0000000189AA7620-0x0000000189AA7640
	private static void RegisterHotfixGenerated() {} // 0x0000000183548430-0x0000000183548600
	// [XID] // 0x0000000189AAECE0-0x0000000189AAED00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183548070-0x0000000183548430
	// [IDTag] // 0x0000000189AB66E0-0x0000000189AB6720
	// [XID] // 0x0000000189AB66E0-0x0000000189AB6720
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183548AE0-0x0000000183548BE0
	// [XID] // 0x0000000189AC0FF0-0x0000000189AC1010
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabDungeonExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183549480-0x00000001835497B0
	// [XID] // 0x0000000189AC8990-0x0000000189AC89B0
	private static bool ParseConfigFromLine(string line, out ChannellerSlabDungeonExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001835486F0-0x0000000183548830
	// [IDTag] // 0x0000000189AD0150-0x0000000189AD0190
	// [XID] // 0x0000000189AD0150-0x0000000189AD0190
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabDungeonExcelConfig> configList) => default; // 0x0000000183548830-0x0000000183548AE0
	// [IDTag] // 0x0000000189ADAEC0-0x0000000189ADAF00
	// [XID] // 0x0000000189ADAEC0-0x0000000189ADAF00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF65C */, bool useObjectPool = false /* Metadata: 0x00AEF660 */) => default; // 0x0000000183548E30-0x0000000183549080
	// [IDTag] // 0x0000000189AE5BA0-0x0000000189AE5BE0
	// [XID] // 0x0000000189AE5BA0-0x0000000189AE5BE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF661 */, bool useObjectPool = false /* Metadata: 0x00AEF665 */) => default; // 0x0000000183549080-0x00000001835493D0
}

