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

public static class FurnitureSuiteExcelConfigLoader // TypeDefIndex: 15717
{
	// Fields
	private static Dictionary<uint, FurnitureSuiteExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FurnitureSuiteExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FurnitureSuiteExcelConfig, FurnitureSuiteExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FurnitureSuiteExcelConfig>, Dictionary<uint, FurnitureSuiteExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FurnitureSuiteExcelConfig> dataDict { /* [XID] */ /* 0x00000001899BB5B0-0x00000001899BB5D0 */ get; } // 0x00000001843E4020-0x00000001843E40D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899CA5E0-0x00000001899CA600 */ get; } // 0x00000001843E2E70-0x00000001843E2F10 

	// Methods
	// [XID] // 0x00000001899B4140-0x00000001899B4160
	public static void Register() {} // 0x00000001843E4400-0x00000001843E44A0
	// [XID] // 0x00000001899C31C0-0x00000001899C31E0
	public static FurnitureSuiteExcelConfig GetData(uint suiteID) => default; // 0x00000001843E2D40-0x00000001843E2E70
	// [XID] // 0x00000001899D1DA0-0x00000001899D1DC0
	public static void LoadData() {} // 0x00000001843E34A0-0x00000001843E3590
	// [XID] // 0x00000001899D91B0-0x00000001899D91D0
	private static void RegisterHotfixGenerated() {} // 0x00000001843E32D0-0x00000001843E34A0
	// [XID] // 0x00000001899E0960-0x00000001899E0980
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843E2F10-0x00000001843E32D0
	// [IDTag] // 0x00000001899E8440-0x00000001899E8480
	// [XID] // 0x00000001899E8440-0x00000001899E8480
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001843E3980-0x00000001843E3A80
	// [XID] // 0x00000001899F2B20-0x00000001899F2B40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FurnitureSuiteExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001843E40D0-0x00000001843E4400
	// [XID] // 0x00000001899FA0F0-0x00000001899FA110
	private static bool ParseConfigFromLine(string line, out FurnitureSuiteExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001843E3590-0x00000001843E36D0
	// [IDTag] // 0x0000000189A014B0-0x0000000189A014F0
	// [XID] // 0x0000000189A014B0-0x0000000189A014F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FurnitureSuiteExcelConfig> configList) => default; // 0x00000001843E36D0-0x00000001843E3980
	// [IDTag] // 0x0000000189A0BDF0-0x0000000189A0BE30
	// [XID] // 0x0000000189A0BDF0-0x0000000189A0BE30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2413 */, bool useObjectPool = false /* Metadata: 0x00AF2417 */) => default; // 0x00000001843E3DD0-0x00000001843E4020
	// [IDTag] // 0x0000000189A16460-0x0000000189A164A0
	// [XID] // 0x0000000189A16460-0x0000000189A164A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2418 */, bool useObjectPool = false /* Metadata: 0x00AF241C */) => default; // 0x00000001843E3A80-0x00000001843E3DD0
}

