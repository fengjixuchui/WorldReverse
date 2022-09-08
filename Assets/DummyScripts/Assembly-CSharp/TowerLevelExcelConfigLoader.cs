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

public static class TowerLevelExcelConfigLoader // TypeDefIndex: 14922
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, TowerLevelExcelConfig>> _towerLevelDic; // 0x00
	private static Dictionary<uint, TowerLevelExcelConfig> _dungeon2TowerLevelConfigDic; // 0x08
	private static Dictionary<uint, TowerLevelExcelConfig> _dataDict; // 0x10
	public static Action<List<DataHotfixMeta>, List<TowerLevelExcelConfig>> customApplyHotfixAction; // 0x18
	public static Action<TowerLevelExcelConfig, TowerLevelExcelConfig> onUpdateConfig; // 0x20
	public static Action onApplyHotfixFinish; // 0x28
	public static Func<List<DataHotfixMeta>, List<TowerLevelExcelConfig>, Dictionary<uint, TowerLevelExcelConfig>, string, bool> customValidateFunc; // 0x30

	// Properties
	public static Dictionary<uint, TowerLevelExcelConfig> dataDict { /* [XID] */ /* 0x000000018967C8C0-0x000000018967C8E0 */ get; } // 0x00000001829BEF30-0x00000001829BF000 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018968BB10-0x000000018968BB30 */ get; } // 0x00000001829BD3A0-0x00000001829BD440 

	// Constructors
	static TowerLevelExcelConfigLoader() {} // 0x00000001829BF510-0x00000001829BF580

	// Methods
	// [XID] // 0x0000000189656D50-0x0000000189656D70
	public static void BuildTowerLevelDic() {} // 0x00000001829BD440-0x00000001829BD910
	// [XID] // 0x000000018965E430-0x000000018965E450
	public static TowerLevelExcelConfig GetTowerLevelConfig(uint groupId, uint levelIndex) => default; // 0x00000001829BD910-0x00000001829BDA80
	// [XID] // 0x0000000189665B30-0x0000000189665B50
	public static Dictionary<uint, TowerLevelExcelConfig> GetTowerLevelGroup(uint groupId) => default; // 0x00000001829BD270-0x00000001829BD3A0
	// [XID] // 0x00000001898DEF50-0x00000001898DEF70
	public static TowerLevelExcelConfig GetTowerLevelConfigByDungeonId(uint dungeonId) => default; // 0x00000001829BF000-0x00000001829BF100
	// [XID] // 0x00000001896751F0-0x0000000189675210
	public static void Register() {} // 0x00000001829BF450-0x00000001829BF510
	// [XID] // 0x0000000189683F50-0x0000000189683F70
	public static TowerLevelExcelConfig GetData(uint levelId) => default; // 0x00000001829BD0D0-0x00000001829BD270
	// [XID] // 0x0000000189693720-0x0000000189693740
	public static void LoadData() {} // 0x00000001829BE1D0-0x00000001829BE300
	// [XID] // 0x000000018969AA70-0x000000018969AA90
	private static void RegisterHotfixGenerated() {} // 0x00000001829BDF60-0x00000001829BE1D0
	// [XID] // 0x00000001896A2500-0x00000001896A2520
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001829BDA80-0x00000001829BDF60
	// [IDTag] // 0x00000001896A96C0-0x00000001896A9700
	// [XID] // 0x00000001896A96C0-0x00000001896A9700
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001829BE790-0x00000001829BE8F0
	// [XID] // 0x00000001896B39D0-0x00000001896B39F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TowerLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001829BF100-0x00000001829BF450
	// [XID] // 0x00000001896BB0D0-0x00000001896BB0F0
	private static bool ParseConfigFromLine(string line, out TowerLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001829BE300-0x00000001829BE440
	// [IDTag] // 0x00000001896C2220-0x00000001896C2260
	// [XID] // 0x00000001896C2220-0x00000001896C2260
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TowerLevelExcelConfig> configList) => default; // 0x00000001829BE440-0x00000001829BE790
	// [IDTag] // 0x00000001896CC930-0x00000001896CC970
	// [XID] // 0x00000001896CC930-0x00000001896CC970
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA0F */, bool useObjectPool = false /* Metadata: 0x00AEFA13 */) => default; // 0x00000001829BE8F0-0x00000001829BEBA0
	// [IDTag] // 0x00000001896D6E80-0x00000001896D6EC0
	// [XID] // 0x00000001896D6E80-0x00000001896D6EC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA14 */, bool useObjectPool = false /* Metadata: 0x00AEFA18 */) => default; // 0x00000001829BEBA0-0x00000001829BEF30
}

