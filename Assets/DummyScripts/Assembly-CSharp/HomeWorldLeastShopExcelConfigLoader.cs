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

public static class HomeWorldLeastShopExcelConfigLoader // TypeDefIndex: 15727
{
	// Fields
	private static List<HomeWorldLeastShopExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldLeastShopExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldLeastShopExcelConfig, HomeWorldLeastShopExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldLeastShopExcelConfig>, List<HomeWorldLeastShopExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<HomeWorldLeastShopExcelConfig> dataList { /* [XID] */ /* 0x00000001899FFEE0-0x00000001899FFF00 */ get; } // 0x00000001845B8DF0-0x00000001845B8EA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A077B0-0x0000000189A077D0 */ get; } // 0x00000001845B7C00-0x00000001845B7CA0 

	// Methods
	// [XID] // 0x00000001899F8970-0x00000001899F8990
	public static void Register() {} // 0x00000001845B91D0-0x00000001845B9270
	// [XID] // 0x0000000189A0EC30-0x0000000189A0EC50
	public static void LoadData() {} // 0x00000001845B82A0-0x00000001845B8390
	// [XID] // 0x0000000189A16440-0x0000000189A16460
	private static void RegisterHotfixGenerated() {} // 0x00000001845B80D0-0x00000001845B82A0
	// [XID] // 0x0000000189A1D9E0-0x0000000189A1DA00
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001845B7CA0-0x00000001845B80D0
	// [IDTag] // 0x0000000189A24DD0-0x0000000189A24E10
	// [XID] // 0x0000000189A24DD0-0x0000000189A24E10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001845B84D0-0x00000001845B85D0
	// [XID] // 0x0000000189A2F3B0-0x0000000189A2F3D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldLeastShopExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001845B8EA0-0x00000001845B91D0
	// [XID] // 0x0000000189A36E30-0x0000000189A36E50
	private static bool ParseConfigFromLine(string line, out HomeWorldLeastShopExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001845B8390-0x00000001845B84D0
	// [IDTag] // 0x0000000189A3E470-0x0000000189A3E4B0
	// [XID] // 0x0000000189A3E470-0x0000000189A3E4B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldLeastShopExcelConfig> configList) => default; // 0x00000001845B85D0-0x00000001845B8870
	// [IDTag] // 0x0000000189A48AB0-0x0000000189A48AF0
	// [XID] // 0x0000000189A48AB0-0x0000000189A48AF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF245E */, bool useObjectPool = false /* Metadata: 0x00AF2462 */) => default; // 0x00000001845B8870-0x00000001845B8AC0
	// [IDTag] // 0x0000000189A53100-0x0000000189A53140
	// [XID] // 0x0000000189A53100-0x0000000189A53140
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2463 */, bool useObjectPool = false /* Metadata: 0x00AF2467 */) => default; // 0x00000001845B8AC0-0x00000001845B8DF0
}

