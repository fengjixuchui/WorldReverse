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

public static class ChannellerSlabLoopDungeonRewardExcelConfigLoader // TypeDefIndex: 14812
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLoopDungeonRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLoopDungeonRewardExcelConfig, ChannellerSlabLoopDungeonRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonRewardExcelConfig>, Dictionary<uint, ChannellerSlabLoopDungeonRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLoopDungeonRewardExcelConfig> dataDict { /* [XID] */ /* 0x0000000189873130-0x0000000189873150 */ get; } // 0x00000001836D4270-0x00000001836D4320 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189881D60-0x0000000189881D80 */ get; } // 0x00000001836D2E30-0x00000001836D2ED0 

	// Methods
	// [XID] // 0x00000001898647D0-0x00000001898647F0
	public static int GetRewardConfig(ref List<ChannellerSlabLoopDungeonRewardExcelConfig> idList) => default; // 0x00000001836D2ED0-0x00000001836D3160
	// [XID] // 0x000000018986BD60-0x000000018986BD80
	public static void Register() {} // 0x00000001836D4650-0x00000001836D46F0
	// [XID] // 0x000000018987AE10-0x000000018987AE30
	public static ChannellerSlabLoopDungeonRewardExcelConfig GetData(uint id) => default; // 0x00000001836D2D00-0x00000001836D2E30
	// [XID] // 0x0000000189889500-0x0000000189889520
	public static void LoadData() {} // 0x00000001836D36F0-0x00000001836D37E0
	// [XID] // 0x0000000189890900-0x0000000189890920
	private static void RegisterHotfixGenerated() {} // 0x00000001836D3520-0x00000001836D36F0
	// [XID] // 0x0000000189897EA0-0x0000000189897EC0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001836D3160-0x00000001836D3520
	// [IDTag] // 0x000000018989F220-0x000000018989F260
	// [XID] // 0x000000018989F220-0x000000018989F260
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836D3BD0-0x00000001836D3CD0
	// [XID] // 0x00000001898A99F0-0x00000001898A9A10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLoopDungeonRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001836D4320-0x00000001836D4650
	// [XID] // 0x00000001898B13E0-0x00000001898B1400
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLoopDungeonRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836D37E0-0x00000001836D3920
	// [IDTag] // 0x00000001898B8D40-0x00000001898B8D80
	// [XID] // 0x00000001898B8D40-0x00000001898B8D80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLoopDungeonRewardExcelConfig> configList) => default; // 0x00000001836D3920-0x00000001836D3BD0
	// [IDTag] // 0x00000001898C3240-0x00000001898C3280
	// [XID] // 0x00000001898C3240-0x00000001898C3280
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF634 */, bool useObjectPool = false /* Metadata: 0x00AEF638 */) => default; // 0x00000001836D3CD0-0x00000001836D3F20
	// [IDTag] // 0x00000001898CD900-0x00000001898CD940
	// [XID] // 0x00000001898CD900-0x00000001898CD940
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF639 */, bool useObjectPool = false /* Metadata: 0x00AEF63D */) => default; // 0x00000001836D3F20-0x00000001836D4270
}

