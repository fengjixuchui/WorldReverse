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

public static class TowerFloorExcelConfigLoader // TypeDefIndex: 14921
{
	// Fields
	private static Dictionary<uint, List<TowerLevelExcelConfig>> _towerLevelListDic; // 0x00
	private static Dictionary<uint, TowerFloorExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<TowerFloorExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<TowerFloorExcelConfig, TowerFloorExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<TowerFloorExcelConfig>, Dictionary<uint, TowerFloorExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, TowerFloorExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BD25E0-0x0000000189BD2600 */ get; } // 0x000000018517E7D0-0x000000018517E8A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895E65B0-0x00000001895E65D0 */ get; } // 0x000000018517CFB0-0x000000018517D050 

	// Constructors
	static TowerFloorExcelConfigLoader() {} // 0x000000018517F0C0-0x000000018517F120

	// Methods
	// [XID] // 0x0000000189BBB8F0-0x0000000189BBB910
	public static List<TowerLevelExcelConfig> GetTowerLevelListByFloorId(uint floorId) => default; // 0x000000018517ECB0-0x000000018517F0C0
	// [XID] // 0x0000000189BC3790-0x0000000189BC37B0
	public static TowerFloorExcelConfig GetDataByIndex(uint floorIndex) => default; // 0x000000018517DAC0-0x000000018517DCE0
	// [XID] // 0x0000000189BCAF50-0x0000000189BCAF70
	public static void Register() {} // 0x000000018517EBF0-0x000000018517ECB0
	// [XID] // 0x0000000189BD9B60-0x0000000189BD9B80
	public static TowerFloorExcelConfig GetData(uint floorId) => default; // 0x000000018517CE10-0x000000018517CFB0
	// [XID] // 0x00000001895EE0B0-0x00000001895EE0D0
	public static void LoadData() {} // 0x000000018517D7A0-0x000000018517D8D0
	// [XID] // 0x00000001895F5810-0x00000001895F5830
	private static void RegisterHotfixGenerated() {} // 0x000000018517D530-0x000000018517D7A0
	// [XID] // 0x00000001895FCDD0-0x00000001895FCDF0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018517D050-0x000000018517D530
	// [IDTag] // 0x0000000189604830-0x0000000189604870
	// [XID] // 0x0000000189604830-0x0000000189604870
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018517DCE0-0x000000018517DE40
	// [XID] // 0x000000018960F000-0x000000018960F020
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TowerFloorExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018517E8A0-0x000000018517EBF0
	// [XID] // 0x0000000189616680-0x00000001896166A0
	private static bool ParseConfigFromLine(string line, out TowerFloorExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018517D980-0x000000018517DAC0
	// [IDTag] // 0x000000018961DEB0-0x000000018961DEF0
	// [XID] // 0x000000018961DEB0-0x000000018961DEF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TowerFloorExcelConfig> configList) => default; // 0x000000018517DE40-0x000000018517E190
	// [IDTag] // 0x0000000189628390-0x00000001896283D0
	// [XID] // 0x0000000189628390-0x00000001896283D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA05 */, bool useObjectPool = false /* Metadata: 0x00AEFA09 */) => default; // 0x000000018517E190-0x000000018517E440
	// [IDTag] // 0x0000000189632BE0-0x0000000189632C20
	// [XID] // 0x0000000189632BE0-0x0000000189632C20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA0A */, bool useObjectPool = false /* Metadata: 0x00AEFA0E */) => default; // 0x000000018517E440-0x000000018517E7D0
}

