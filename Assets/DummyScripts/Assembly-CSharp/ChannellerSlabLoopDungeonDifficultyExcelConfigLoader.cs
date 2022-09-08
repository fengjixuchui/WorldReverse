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

public static class ChannellerSlabLoopDungeonDifficultyExcelConfigLoader // TypeDefIndex: 14817
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLoopDungeonDifficultyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonDifficultyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLoopDungeonDifficultyExcelConfig, ChannellerSlabLoopDungeonDifficultyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonDifficultyExcelConfig>, Dictionary<uint, ChannellerSlabLoopDungeonDifficultyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLoopDungeonDifficultyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B152F0-0x0000000189B15310 */ get; } // 0x0000000183945BD0-0x0000000183945C80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B24360-0x0000000189B24380 */ get; } // 0x00000001839448D0-0x0000000183944970 

	// Methods
	// [XID] // 0x0000000189AFF0D0-0x0000000189AFF0F0
	public static string GetDifficultyName(uint difficultyType) => default; // 0x0000000183945A80-0x0000000183945BD0
	// [XID] // 0x0000000189B068A0-0x0000000189B068C0
	public static uint GetDungeonFactorGroupId(uint stageId) => default; // 0x0000000183945FB0-0x0000000183946320
	// [XID] // 0x0000000189B0E030-0x0000000189B0E050
	public static void Register() {} // 0x0000000183946320-0x0000000183946A30
	// [XID] // 0x0000000189B1CDF0-0x0000000189B1CE10
	public static ChannellerSlabLoopDungeonDifficultyExcelConfig GetData(uint id) => default; // 0x00000001839447A0-0x00000001839448D0
	// [XID] // 0x0000000189B2B710-0x0000000189B2B730
	public static void LoadData() {} // 0x0000000183944F00-0x0000000183944FF0
	// [XID] // 0x0000000189B32CC0-0x0000000189B32CE0
	private static void RegisterHotfixGenerated() {} // 0x0000000183944D30-0x0000000183944F00
	// [XID] // 0x0000000189B3A510-0x0000000189B3A530
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183944970-0x0000000183944D30
	// [IDTag] // 0x0000000189B41F50-0x0000000189B41F90
	// [XID] // 0x0000000189B41F50-0x0000000189B41F90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183945130-0x0000000183945230
	// [XID] // 0x0000000189B4C7E0-0x0000000189B4C800
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLoopDungeonDifficultyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183945C80-0x0000000183945FB0
	// [XID] // 0x0000000189B53F40-0x0000000189B53F60
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLoopDungeonDifficultyExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183944FF0-0x0000000183945130
	// [IDTag] // 0x0000000189B5B890-0x0000000189B5B8D0
	// [XID] // 0x0000000189B5B890-0x0000000189B5B8D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLoopDungeonDifficultyExcelConfig> configList) => default; // 0x0000000183945230-0x00000001839454E0
	// [IDTag] // 0x0000000189B65EE0-0x0000000189B65F20
	// [XID] // 0x0000000189B65EE0-0x0000000189B65F20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF666 */, bool useObjectPool = false /* Metadata: 0x00AEF66A */) => default; // 0x00000001839454E0-0x0000000183945730
	// [IDTag] // 0x0000000189B70500-0x0000000189B70540
	// [XID] // 0x0000000189B70500-0x0000000189B70540
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF66B */, bool useObjectPool = false /* Metadata: 0x00AEF66F */) => default; // 0x0000000183945730-0x0000000183945A80
}

