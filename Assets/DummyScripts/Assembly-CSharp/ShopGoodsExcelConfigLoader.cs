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

public static class ShopGoodsExcelConfigLoader // TypeDefIndex: 16112
{
	// Fields
	private static Dictionary<uint, ShopGoodsExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopGoodsExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopGoodsExcelConfig, ShopGoodsExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopGoodsExcelConfig>, Dictionary<uint, ShopGoodsExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ShopGoodsExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A83640-0x0000000189A83660 */ get; } // 0x0000000182B2C090-0x0000000182B2C140 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A92630-0x0000000189A92650 */ get; } // 0x0000000182B2AEE0-0x0000000182B2AF80 

	// Methods
	// [XID] // 0x0000000189A7BCA0-0x0000000189A7BCC0
	public static void Register() {} // 0x0000000182B2C470-0x0000000182B2C510
	// [XID] // 0x0000000189A8AF00-0x0000000189A8AF20
	public static ShopGoodsExcelConfig GetData(uint goodsId) => default; // 0x0000000182B2ADB0-0x0000000182B2AEE0
	// [XID] // 0x0000000189A9A140-0x0000000189A9A160
	public static void LoadData() {} // 0x0000000182B2B510-0x0000000182B2B600
	// [XID] // 0x0000000189AA10E0-0x0000000189AA1100
	private static void RegisterHotfixGenerated() {} // 0x0000000182B2B340-0x0000000182B2B510
	// [XID] // 0x0000000189AA8860-0x0000000189AA8880
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B2AF80-0x0000000182B2B340
	// [IDTag] // 0x0000000189AB0400-0x0000000189AB0440
	// [XID] // 0x0000000189AB0400-0x0000000189AB0440
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B2B9F0-0x0000000182B2BAF0
	// [XID] // 0x0000000189ABB150-0x0000000189ABB170
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopGoodsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B2C140-0x0000000182B2C470
	// [XID] // 0x0000000189AC2960-0x0000000189AC2980
	private static bool ParseConfigFromLine(string line, out ShopGoodsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B2B600-0x0000000182B2B740
	// [IDTag] // 0x0000000189AC9F60-0x0000000189AC9FA0
	// [XID] // 0x0000000189AC9F60-0x0000000189AC9FA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopGoodsExcelConfig> configList) => default; // 0x0000000182B2B740-0x0000000182B2B9F0
	// [IDTag] // 0x0000000189AD4CA0-0x0000000189AD4CE0
	// [XID] // 0x0000000189AD4CA0-0x0000000189AD4CE0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3181 */, bool useObjectPool = false /* Metadata: 0x00AF3185 */) => default; // 0x0000000182B2BE40-0x0000000182B2C090
	// [IDTag] // 0x0000000189ADF7F0-0x0000000189ADF830
	// [XID] // 0x0000000189ADF7F0-0x0000000189ADF830
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3186 */, bool useObjectPool = false /* Metadata: 0x00AF318A */) => default; // 0x0000000182B2BAF0-0x0000000182B2BE40
}

