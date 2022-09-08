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

public static class HomeWorldLimitShopExcelConfigLoader // TypeDefIndex: 15725
{
	// Fields
	private static Dictionary<uint, HomeWorldLimitShopExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldLimitShopExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldLimitShopExcelConfig, HomeWorldLimitShopExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldLimitShopExcelConfig>, Dictionary<uint, HomeWorldLimitShopExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldLimitShopExcelConfig> dataDict { /* [XID] */ /* 0x00000001898FE0E0-0x00000001898FE100 */ get; } // 0x00000001846E7800-0x00000001846E78B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018990D270-0x000000018990D290 */ get; } // 0x00000001846E6650-0x00000001846E66F0 

	// Methods
	// [XID] // 0x00000001898F6940-0x00000001898F6960
	public static void Register() {} // 0x00000001846E7BE0-0x00000001846E7C80
	// [XID] // 0x0000000189905960-0x0000000189905980
	public static HomeWorldLimitShopExcelConfig GetData(uint goodsId) => default; // 0x00000001846E6520-0x00000001846E6650
	// [XID] // 0x0000000189914980-0x00000001899149A0
	public static void LoadData() {} // 0x00000001846E6C80-0x00000001846E6D70
	// [XID] // 0x000000018991C580-0x000000018991C5A0
	private static void RegisterHotfixGenerated() {} // 0x00000001846E6AB0-0x00000001846E6C80
	// [XID] // 0x0000000189923D80-0x0000000189923DA0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001846E66F0-0x00000001846E6AB0
	// [IDTag] // 0x000000018992B300-0x000000018992B340
	// [XID] // 0x000000018992B300-0x000000018992B340
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001846E6EB0-0x00000001846E6FB0
	// [XID] // 0x0000000189935630-0x0000000189935650
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldLimitShopExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001846E78B0-0x00000001846E7BE0
	// [XID] // 0x000000018993D170-0x000000018993D190
	private static bool ParseConfigFromLine(string line, out HomeWorldLimitShopExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001846E6D70-0x00000001846E6EB0
	// [IDTag] // 0x0000000189944860-0x00000001899448A0
	// [XID] // 0x0000000189944860-0x00000001899448A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldLimitShopExcelConfig> configList) => default; // 0x00000001846E6FB0-0x00000001846E7260
	// [IDTag] // 0x000000018994EDE0-0x000000018994EE20
	// [XID] // 0x000000018994EDE0-0x000000018994EE20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF244F */, bool useObjectPool = false /* Metadata: 0x00AF2453 */) => default; // 0x00000001846E75B0-0x00000001846E7800
	// [IDTag] // 0x0000000189959530-0x0000000189959570
	// [XID] // 0x0000000189959530-0x0000000189959570
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2454 */, bool useObjectPool = false /* Metadata: 0x00AF2458 */) => default; // 0x00000001846E7260-0x00000001846E75B0
}

