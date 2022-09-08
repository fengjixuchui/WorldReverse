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

public static class FleurFairBuffEnergyStatExcelConfigLoader // TypeDefIndex: 15110
{
	// Fields
	private static Dictionary<uint, FleurFairBuffEnergyStatExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairBuffEnergyStatExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairBuffEnergyStatExcelConfig, FleurFairBuffEnergyStatExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairBuffEnergyStatExcelConfig>, Dictionary<uint, FleurFairBuffEnergyStatExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairBuffEnergyStatExcelConfig> dataDict { /* [XID] */ /* 0x000000018972A0A0-0x000000018972A0C0 */ get; } // 0x00000001824ED200-0x00000001824ED2B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189738F70-0x0000000189738F90 */ get; } // 0x00000001824EC050-0x00000001824EC0F0 

	// Methods
	// [XID] // 0x0000000189722920-0x0000000189722940
	public static void Register() {} // 0x00000001824ED5E0-0x00000001824ED680
	// [XID] // 0x0000000189731700-0x0000000189731720
	public static FleurFairBuffEnergyStatExcelConfig GetData(uint id) => default; // 0x00000001824EBF20-0x00000001824EC050
	// [XID] // 0x0000000189740D20-0x0000000189740D40
	public static void LoadData() {} // 0x00000001824EC680-0x00000001824EC770
	// [XID] // 0x0000000189748220-0x0000000189748240
	private static void RegisterHotfixGenerated() {} // 0x00000001824EC4B0-0x00000001824EC680
	// [XID] // 0x000000018974FAB0-0x000000018974FAD0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001824EC0F0-0x00000001824EC4B0
	// [IDTag] // 0x0000000189757080-0x00000001897570C0
	// [XID] // 0x0000000189757080-0x00000001897570C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001824EC8B0-0x00000001824EC9B0
	// [XID] // 0x0000000189761870-0x0000000189761890
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairBuffEnergyStatExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001824ED2B0-0x00000001824ED5E0
	// [XID] // 0x0000000189768C80-0x0000000189768CA0
	private static bool ParseConfigFromLine(string line, out FleurFairBuffEnergyStatExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001824EC770-0x00000001824EC8B0
	// [IDTag] // 0x0000000189770330-0x0000000189770370
	// [XID] // 0x0000000189770330-0x0000000189770370
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairBuffEnergyStatExcelConfig> configList) => default; // 0x00000001824EC9B0-0x00000001824ECC60
	// [IDTag] // 0x000000018977A960-0x000000018977A9A0
	// [XID] // 0x000000018977A960-0x000000018977A9A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0116 */, bool useObjectPool = false /* Metadata: 0x00AF011A */) => default; // 0x00000001824ECFB0-0x00000001824ED200
	// [IDTag] // 0x00000001897853A0-0x00000001897853E0
	// [XID] // 0x00000001897853A0-0x00000001897853E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF011B */, bool useObjectPool = false /* Metadata: 0x00AF011F */) => default; // 0x00000001824ECC60-0x00000001824ECFB0
}

