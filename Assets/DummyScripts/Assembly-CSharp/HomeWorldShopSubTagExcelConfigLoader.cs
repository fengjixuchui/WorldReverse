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

public static class HomeWorldShopSubTagExcelConfigLoader // TypeDefIndex: 15723
{
	// Fields
	private static Dictionary<uint, HomeWorldShopSubTagExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldShopSubTagExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldShopSubTagExcelConfig, HomeWorldShopSubTagExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldShopSubTagExcelConfig>, Dictionary<uint, HomeWorldShopSubTagExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldShopSubTagExcelConfig> dataDict { /* [XID] */ /* 0x00000001897B2630-0x00000001897B2650 */ get; } // 0x0000000184136640-0x00000001841366F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897C2090-0x00000001897C20B0 */ get; } // 0x0000000184135490-0x0000000184135530 

	// Methods
	// [XID] // 0x00000001897AAAE0-0x00000001897AAB00
	public static void Register() {} // 0x0000000184136A20-0x0000000184136AC0
	// [XID] // 0x00000001897B9EF0-0x00000001897B9F10
	public static HomeWorldShopSubTagExcelConfig GetData(uint subID) => default; // 0x0000000184135360-0x0000000184135490
	// [XID] // 0x00000001897C9900-0x00000001897C9920
	public static void LoadData() {} // 0x0000000184135AC0-0x0000000184135BB0
	// [XID] // 0x00000001897D0F90-0x00000001897D0FB0
	private static void RegisterHotfixGenerated() {} // 0x00000001841358F0-0x0000000184135AC0
	// [XID] // 0x00000001897D8E90-0x00000001897D8EB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184135530-0x00000001841358F0
	// [IDTag] // 0x00000001897E0090-0x00000001897E00D0
	// [XID] // 0x00000001897E0090-0x00000001897E00D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184135FA0-0x00000001841360A0
	// [XID] // 0x00000001897EA880-0x00000001897EA8A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldShopSubTagExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001841366F0-0x0000000184136A20
	// [XID] // 0x00000001897F2650-0x00000001897F2670
	private static bool ParseConfigFromLine(string line, out HomeWorldShopSubTagExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184135BB0-0x0000000184135CF0
	// [IDTag] // 0x00000001897F9DC0-0x00000001897F9E00
	// [XID] // 0x00000001897F9DC0-0x00000001897F9E00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldShopSubTagExcelConfig> configList) => default; // 0x0000000184135CF0-0x0000000184135FA0
	// [IDTag] // 0x00000001898042B0-0x00000001898042F0
	// [XID] // 0x00000001898042B0-0x00000001898042F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2440 */, bool useObjectPool = false /* Metadata: 0x00AF2444 */) => default; // 0x00000001841360A0-0x00000001841362F0
	// [IDTag] // 0x000000018980E870-0x000000018980E8B0
	// [XID] // 0x000000018980E870-0x000000018980E8B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2445 */, bool useObjectPool = false /* Metadata: 0x00AF2449 */) => default; // 0x00000001841362F0-0x0000000184136640
}

