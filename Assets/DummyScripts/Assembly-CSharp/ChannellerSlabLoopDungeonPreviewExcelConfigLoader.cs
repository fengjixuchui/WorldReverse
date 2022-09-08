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

public static class ChannellerSlabLoopDungeonPreviewExcelConfigLoader // TypeDefIndex: 14813
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLoopDungeonPreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonPreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLoopDungeonPreviewExcelConfig, ChannellerSlabLoopDungeonPreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonPreviewExcelConfig>, Dictionary<uint, ChannellerSlabLoopDungeonPreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLoopDungeonPreviewExcelConfig> dataDict { /* [XID] */ /* 0x00000001898F6B40-0x00000001898F6B60 */ get; } // 0x0000000183FAEC70-0x0000000183FAED20 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189905B20-0x0000000189905B40 */ get; } // 0x0000000183FADAC0-0x0000000183FADB60 

	// Methods
	// [XID] // 0x00000001898E7BB0-0x00000001898E7BD0
	public static ChannellerSlabLoopDungeonPreviewExcelConfig GetDataByActivity(uint activityId) => default; // 0x0000000183FAED20-0x0000000183FAEF70
	// [XID] // 0x00000001898EF2C0-0x00000001898EF2E0
	public static void Register() {} // 0x0000000183FAF2A0-0x0000000183FAF340
	// [XID] // 0x00000001898FE260-0x00000001898FE280
	public static ChannellerSlabLoopDungeonPreviewExcelConfig GetData(uint id) => default; // 0x0000000183FAD990-0x0000000183FADAC0
	// [XID] // 0x000000018990D3D0-0x000000018990D3F0
	public static void LoadData() {} // 0x0000000183FAE0F0-0x0000000183FAE1E0
	// [XID] // 0x0000000189914B40-0x0000000189914B60
	private static void RegisterHotfixGenerated() {} // 0x0000000183FADF20-0x0000000183FAE0F0
	// [XID] // 0x000000018991C8C0-0x000000018991C8E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183FADB60-0x0000000183FADF20
	// [IDTag] // 0x0000000189923FC0-0x0000000189924000
	// [XID] // 0x0000000189923FC0-0x0000000189924000
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183FAE320-0x0000000183FAE420
	// [XID] // 0x000000018992E550-0x000000018992E570
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLoopDungeonPreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183FAEF70-0x0000000183FAF2A0
	// [XID] // 0x0000000189935850-0x0000000189935870
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLoopDungeonPreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183FAE1E0-0x0000000183FAE320
	// [IDTag] // 0x000000018993D430-0x000000018993D470
	// [XID] // 0x000000018993D430-0x000000018993D470
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLoopDungeonPreviewExcelConfig> configList) => default; // 0x0000000183FAE420-0x0000000183FAE6D0
	// [IDTag] // 0x0000000189947740-0x0000000189947780
	// [XID] // 0x0000000189947740-0x0000000189947780
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF63E */, bool useObjectPool = false /* Metadata: 0x00AEF642 */) => default; // 0x0000000183FAEA20-0x0000000183FAEC70
	// [IDTag] // 0x0000000189952130-0x0000000189952170
	// [XID] // 0x0000000189952130-0x0000000189952170
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF643 */, bool useObjectPool = false /* Metadata: 0x00AEF647 */) => default; // 0x0000000183FAE6D0-0x0000000183FAEA20
}

