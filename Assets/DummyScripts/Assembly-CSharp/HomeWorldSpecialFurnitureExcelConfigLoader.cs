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

public static class HomeWorldSpecialFurnitureExcelConfigLoader // TypeDefIndex: 15709
{
	// Fields
	private static Dictionary<uint, HomeWorldSpecialFurnitureExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldSpecialFurnitureExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldSpecialFurnitureExcelConfig, HomeWorldSpecialFurnitureExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldSpecialFurnitureExcelConfig>, Dictionary<uint, HomeWorldSpecialFurnitureExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldSpecialFurnitureExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AA4580-0x0000000189AA45A0 */ get; } // 0x000000018402D3B0-0x000000018402D460 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AB3540-0x0000000189AB3560 */ get; } // 0x000000018402C200-0x000000018402C2A0 

	// Methods
	// [XID] // 0x0000000189A9CE30-0x0000000189A9CE50
	public static void Register() {} // 0x000000018402D790-0x000000018402D830
	// [XID] // 0x0000000189AABBB0-0x0000000189AABBD0
	public static HomeWorldSpecialFurnitureExcelConfig GetData(uint ID) => default; // 0x000000018402C0D0-0x000000018402C200
	// [XID] // 0x0000000189ABB250-0x0000000189ABB270
	public static void LoadData() {} // 0x000000018402C830-0x000000018402C920
	// [XID] // 0x0000000189AC2A00-0x0000000189AC2A20
	private static void RegisterHotfixGenerated() {} // 0x000000018402C660-0x000000018402C830
	// [XID] // 0x0000000189ACA020-0x0000000189ACA040
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018402C2A0-0x000000018402C660
	// [IDTag] // 0x0000000189AD1890-0x0000000189AD18D0
	// [XID] // 0x0000000189AD1890-0x0000000189AD18D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018402CA60-0x000000018402CB60
	// [XID] // 0x0000000189ADC700-0x0000000189ADC720
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldSpecialFurnitureExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018402D460-0x000000018402D790
	// [XID] // 0x0000000189AE4030-0x0000000189AE4050
	private static bool ParseConfigFromLine(string line, out HomeWorldSpecialFurnitureExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018402C920-0x000000018402CA60
	// [IDTag] // 0x0000000189AEB8D0-0x0000000189AEB910
	// [XID] // 0x0000000189AEB8D0-0x0000000189AEB910
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldSpecialFurnitureExcelConfig> configList) => default; // 0x000000018402CB60-0x000000018402CE10
	// [IDTag] // 0x0000000189AF6130-0x0000000189AF6170
	// [XID] // 0x0000000189AF6130-0x0000000189AF6170
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF23D7 */, bool useObjectPool = false /* Metadata: 0x00AF23DB */) => default; // 0x000000018402D160-0x000000018402D3B0
	// [IDTag] // 0x0000000189B00750-0x0000000189B00790
	// [XID] // 0x0000000189B00750-0x0000000189B00790
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23DC */, bool useObjectPool = false /* Metadata: 0x00AF23E0 */) => default; // 0x000000018402CE10-0x000000018402D160
}

