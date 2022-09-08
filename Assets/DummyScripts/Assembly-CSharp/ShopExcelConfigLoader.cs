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

public static class ShopExcelConfigLoader // TypeDefIndex: 16110
{
	// Fields
	private static Dictionary<int, ShopExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopExcelConfig, ShopExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopExcelConfig>, Dictionary<int, ShopExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, ShopExcelConfig> dataDict { /* [XID] */ /* 0x00000001897D0E10-0x00000001897D0E30 */ get; } // 0x000000018209C550-0x000000018209C600 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897DFEF0-0x00000001897DFF10 */ get; } // 0x000000018209B3A0-0x000000018209B440 

	// Methods
	// [XID] // 0x00000001897C9800-0x00000001897C9820
	public static void Register() {} // 0x000000018209C930-0x000000018209C9D0
	// [XID] // 0x00000001897D8D30-0x00000001897D8D50
	public static ShopExcelConfig GetData(ShopType shopType) => default; // 0x000000018209B270-0x000000018209B3A0
	// [XID] // 0x00000001897E7690-0x00000001897E76B0
	public static void LoadData() {} // 0x000000018209B9D0-0x000000018209BAC0
	// [XID] // 0x00000001897EF230-0x00000001897EF250
	private static void RegisterHotfixGenerated() {} // 0x000000018209B800-0x000000018209B9D0
	// [XID] // 0x00000001897F6880-0x00000001897F68A0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018209B440-0x000000018209B800
	// [IDTag] // 0x00000001897FDF20-0x00000001897FDF60
	// [XID] // 0x00000001897FDF20-0x00000001897FDF60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018209BEB0-0x000000018209BFB0
	// [XID] // 0x0000000189808640-0x0000000189808660
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018209C600-0x000000018209C930
	// [XID] // 0x0000000189810190-0x00000001898101B0
	private static bool ParseConfigFromLine(string line, out ShopExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018209BAC0-0x000000018209BC00
	// [IDTag] // 0x00000001898177E0-0x0000000189817820
	// [XID] // 0x00000001898177E0-0x0000000189817820
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopExcelConfig> configList) => default; // 0x000000018209BC00-0x000000018209BEB0
	// [IDTag] // 0x0000000189822170-0x00000001898221B0
	// [XID] // 0x0000000189822170-0x00000001898221B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3172 */, bool useObjectPool = false /* Metadata: 0x00AF3176 */) => default; // 0x000000018209BFB0-0x000000018209C200
	// [IDTag] // 0x000000018982C770-0x000000018982C7B0
	// [XID] // 0x000000018982C770-0x000000018982C7B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3177 */, bool useObjectPool = false /* Metadata: 0x00AF317B */) => default; // 0x000000018209C200-0x000000018209C550
}

