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

public static class ChannellerSlabBuffExcelConfigLoader // TypeDefIndex: 14811
{
	// Fields
	private static Dictionary<uint, ChannellerSlabBuffExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabBuffExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabBuffExcelConfig, ChannellerSlabBuffExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabBuffExcelConfig>, Dictionary<uint, ChannellerSlabBuffExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabBuffExcelConfig> dataDict { /* [XID] */ /* 0x00000001897F0EA0-0x00000001897F0EC0 */ get; } // 0x0000000181CB7FF0-0x0000000181CB80A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897FFDB0-0x00000001897FFDD0 */ get; } // 0x0000000181CB6BE0-0x0000000181CB6C80 

	// Methods
	// [XID] // 0x00000001897D72E0-0x00000001897D7300
	public static void GetDataByQuality(QualityType quality, ref List<uint> idList) {} // 0x0000000181CB7040-0x0000000181CB72A0
	// [XID] // 0x00000001897E92D0-0x00000001897E92F0
	public static void Register() {} // 0x0000000181CB8530-0x0000000181CB85D0
	// [XID] // 0x00000001897F86E0-0x00000001897F8700
	public static ChannellerSlabBuffExcelConfig GetData(uint id) => default; // 0x0000000181CB6AB0-0x0000000181CB6BE0
	// [XID] // 0x0000000189807450-0x0000000189807470
	public static void LoadData() {} // 0x0000000181CB7470-0x0000000181CB7560
	// [XID] // 0x000000018980EA30-0x000000018980EA50
	private static void RegisterHotfixGenerated() {} // 0x0000000181CB72A0-0x0000000181CB7470
	// [XID] // 0x0000000189816130-0x0000000189816150
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181CB6C80-0x0000000181CB7040
	// [IDTag] // 0x000000018981DB90-0x000000018981DBD0
	// [XID] // 0x000000018981DB90-0x000000018981DBD0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181CB76A0-0x0000000181CB77A0
	// [XID] // 0x0000000189828360-0x0000000189828380
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabBuffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181CB8200-0x0000000181CB8530
	// [XID] // 0x000000018982F660-0x000000018982F680
	private static bool ParseConfigFromLine(string line, out ChannellerSlabBuffExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181CB7560-0x0000000181CB76A0
	// [IDTag] // 0x0000000189836F70-0x0000000189836FB0
	// [XID] // 0x0000000189836F70-0x0000000189836FB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabBuffExcelConfig> configList) => default; // 0x0000000181CB77A0-0x0000000181CB7A50
	// [IDTag] // 0x0000000189841160-0x00000001898411A0
	// [XID] // 0x0000000189841160-0x00000001898411A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF62A */, bool useObjectPool = false /* Metadata: 0x00AEF62E */) => default; // 0x0000000181CB7A50-0x0000000181CB7CA0
	// [IDTag] // 0x000000018984B930-0x000000018984B970
	// [XID] // 0x000000018984B930-0x000000018984B970
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF62F */, bool useObjectPool = false /* Metadata: 0x00AEF633 */) => default; // 0x0000000181CB7CA0-0x0000000181CB7FF0

	// Extension methods
	// [XID] // 0x00000001897DE830-0x00000001897DE870
	public static string GetBuffDesc(this ChannellerSlabBuffExcelConfig excel) => default; // 0x0000000181CB80A0-0x0000000181CB8200
}

