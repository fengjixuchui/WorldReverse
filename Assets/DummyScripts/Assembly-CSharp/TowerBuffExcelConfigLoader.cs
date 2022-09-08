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

public static class TowerBuffExcelConfigLoader // TypeDefIndex: 16201
{
	// Fields
	private static Dictionary<uint, TowerBuffExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TowerBuffExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TowerBuffExcelConfig, TowerBuffExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TowerBuffExcelConfig>, Dictionary<uint, TowerBuffExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TowerBuffExcelConfig> dataDict { /* [XID] */ /* 0x000000018981A980-0x000000018981A9A0 */ get; } // 0x00000001841B5DF0-0x00000001841B5EA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898296D0-0x00000001898296F0 */ get; } // 0x00000001841B4C40-0x00000001841B4CE0 

	// Methods
	// [XID] // 0x0000000189812D20-0x0000000189812D40
	public static void Register() {} // 0x00000001841B61D0-0x00000001841B6270
	// [XID] // 0x0000000189822110-0x0000000189822130
	public static TowerBuffExcelConfig GetData(uint towerBuffId) => default; // 0x00000001841B4B10-0x00000001841B4C40
	// [XID] // 0x0000000189830CA0-0x0000000189830CC0
	public static void LoadData() {} // 0x00000001841B5270-0x00000001841B5360
	// [XID] // 0x0000000189838380-0x00000001898383A0
	private static void RegisterHotfixGenerated() {} // 0x00000001841B50A0-0x00000001841B5270
	// [XID] // 0x000000018983FA50-0x000000018983FA70
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001841B4CE0-0x00000001841B50A0
	// [IDTag] // 0x0000000189847050-0x0000000189847090
	// [XID] // 0x0000000189847050-0x0000000189847090
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001841B5750-0x00000001841B5850
	// [XID] // 0x00000001898514D0-0x00000001898514F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TowerBuffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001841B5EA0-0x00000001841B61D0
	// [XID] // 0x0000000189858A40-0x0000000189858A60
	private static bool ParseConfigFromLine(string line, out TowerBuffExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001841B5360-0x00000001841B54A0
	// [IDTag] // 0x000000018985FB90-0x000000018985FBD0
	// [XID] // 0x000000018985FB90-0x000000018985FBD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TowerBuffExcelConfig> configList) => default; // 0x00000001841B54A0-0x00000001841B5750
	// [IDTag] // 0x000000018986A320-0x000000018986A360
	// [XID] // 0x000000018986A320-0x000000018986A360
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF33FC */, bool useObjectPool = false /* Metadata: 0x00AF3400 */) => default; // 0x00000001841B5850-0x00000001841B5AA0
	// [IDTag] // 0x00000001898744A0-0x00000001898744E0
	// [XID] // 0x00000001898744A0-0x00000001898744E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3401 */, bool useObjectPool = false /* Metadata: 0x00AF3405 */) => default; // 0x00000001841B5AA0-0x00000001841B5DF0
}

