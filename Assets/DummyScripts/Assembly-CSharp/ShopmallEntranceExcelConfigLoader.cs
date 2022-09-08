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

public static class ShopmallEntranceExcelConfigLoader // TypeDefIndex: 14914
{
	// Fields
	private static List<ShopmallEntranceExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopmallEntranceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopmallEntranceExcelConfig, ShopmallEntranceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopmallEntranceExcelConfig>, List<ShopmallEntranceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ShopmallEntranceExcelConfig> dataList { /* [XID] */ /* 0x000000018980CFF0-0x000000018980D010 */ get; } // 0x00000001823BBA30-0x00000001823BBAE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898147B0-0x00000001898147D0 */ get; } // 0x00000001823BA660-0x00000001823BA700 

	// Methods
	// [XID] // 0x00000001897FE180-0x00000001897FE1A0
	public static ShopmallEntranceExcelConfig GetEntranceConfig(ShopType type) => default; // 0x00000001823BAF30-0x00000001823BB110
	// [XID] // 0x00000001898058D0-0x00000001898058F0
	public static void Register() {} // 0x00000001823BBE10-0x00000001823BBEB0
	// [XID] // 0x000000018981C200-0x000000018981C220
	public static void LoadData() {} // 0x00000001823BAD00-0x00000001823BADF0
	// [XID] // 0x0000000189823770-0x0000000189823790
	private static void RegisterHotfixGenerated() {} // 0x00000001823BAB30-0x00000001823BAD00
	// [XID] // 0x000000018982B050-0x000000018982B070
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823BA700-0x00000001823BAB30
	// [IDTag] // 0x00000001898325F0-0x0000000189832630
	// [XID] // 0x00000001898325F0-0x0000000189832630
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823BB3B0-0x00000001823BB4B0
	// [XID] // 0x000000018983CDF0-0x000000018983CE10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopmallEntranceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823BBAE0-0x00000001823BBE10
	// [XID] // 0x0000000189844460-0x0000000189844480
	private static bool ParseConfigFromLine(string line, out ShopmallEntranceExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001823BADF0-0x00000001823BAF30
	// [IDTag] // 0x000000018984B8D0-0x000000018984B910
	// [XID] // 0x000000018984B8D0-0x000000018984B910
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopmallEntranceExcelConfig> configList) => default; // 0x00000001823BB110-0x00000001823BB3B0
	// [IDTag] // 0x00000001898559B0-0x00000001898559F0
	// [XID] // 0x00000001898559B0-0x00000001898559F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9BF */, bool useObjectPool = false /* Metadata: 0x00AEF9C3 */) => default; // 0x00000001823BB7E0-0x00000001823BBA30
	// [IDTag] // 0x000000018985FE90-0x000000018985FED0
	// [XID] // 0x000000018985FE90-0x000000018985FED0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9C4 */, bool useObjectPool = false /* Metadata: 0x00AEF9C8 */) => default; // 0x00000001823BB4B0-0x00000001823BB7E0
}

