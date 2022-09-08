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

public static class ChannellerSlabBuffCostExcelConfigLoader // TypeDefIndex: 14814
{
	// Fields
	private static Dictionary<uint, ChannellerSlabBuffCostExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabBuffCostExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabBuffCostExcelConfig, ChannellerSlabBuffCostExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabBuffCostExcelConfig>, Dictionary<uint, ChannellerSlabBuffCostExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabBuffCostExcelConfig> dataDict { /* [XID] */ /* 0x0000000189982300-0x0000000189982320 */ get; } // 0x0000000184AAD9B0-0x0000000184AADA60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189991350-0x0000000189991370 */ get; } // 0x0000000184AAC5B0-0x0000000184AAC650 

	// Methods
	// [XID] // 0x000000018996B4F0-0x000000018996B510
	public static uint GetCostByQuality(QualityType quality) => default; // 0x0000000184AADE30-0x0000000184AADEE0
	// [XID] // 0x0000000189973050-0x0000000189973070
	public static ChannellerSlabBuffCostExcelConfig GetConfigByQuality(QualityType quality) => default; // 0x0000000184AACBE0-0x0000000184AACE30
	// [XID] // 0x000000018997A970-0x000000018997A990
	public static void Register() {} // 0x0000000184AADD90-0x0000000184AADE30
	// [XID] // 0x0000000189989B00-0x0000000189989B20
	public static ChannellerSlabBuffCostExcelConfig GetData(uint id) => default; // 0x0000000184AAC480-0x0000000184AAC5B0
	// [XID] // 0x0000000189998E90-0x0000000189998EB0
	public static void LoadData() {} // 0x0000000184AACE30-0x0000000184AACF20
	// [XID] // 0x00000001899A0690-0x00000001899A06B0
	private static void RegisterHotfixGenerated() {} // 0x0000000184AACA10-0x0000000184AACBE0
	// [XID] // 0x00000001899A8260-0x00000001899A8280
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184AAC650-0x0000000184AACA10
	// [IDTag] // 0x00000001899AF990-0x00000001899AF9D0
	// [XID] // 0x00000001899AF990-0x00000001899AF9D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184AAD310-0x0000000184AAD410
	// [XID] // 0x00000001899B9DF0-0x00000001899B9E10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabBuffCostExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184AADA60-0x0000000184AADD90
	// [XID] // 0x00000001899C18B0-0x00000001899C18D0
	private static bool ParseConfigFromLine(string line, out ChannellerSlabBuffCostExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184AACF20-0x0000000184AAD060
	// [IDTag] // 0x00000001899C8E20-0x00000001899C8E60
	// [XID] // 0x00000001899C8E20-0x00000001899C8E60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabBuffCostExcelConfig> configList) => default; // 0x0000000184AAD060-0x0000000184AAD310
	// [IDTag] // 0x00000001899D36D0-0x00000001899D3710
	// [XID] // 0x00000001899D36D0-0x00000001899D3710
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF648 */, bool useObjectPool = false /* Metadata: 0x00AEF64C */) => default; // 0x0000000184AAD410-0x0000000184AAD660
	// [IDTag] // 0x00000001899DDB20-0x00000001899DDB60
	// [XID] // 0x00000001899DDB20-0x00000001899DDB60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF64D */, bool useObjectPool = false /* Metadata: 0x00AEF651 */) => default; // 0x0000000184AAD660-0x0000000184AAD9B0
}

