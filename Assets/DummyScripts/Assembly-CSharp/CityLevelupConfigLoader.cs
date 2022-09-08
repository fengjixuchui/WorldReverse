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

public static class CityLevelupConfigLoader // TypeDefIndex: 14926
{
	// Fields
	private static List<CityLevelupConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<CityLevelupConfig>> customApplyHotfixAction; // 0x08
	public static Action<CityLevelupConfig, CityLevelupConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CityLevelupConfig>, List<CityLevelupConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<CityLevelupConfig> dataList { /* [XID] */ /* 0x00000001898BD4E0-0x00000001898BD500 */ get; } // 0x00000001817BB230-0x00000001817BB2E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898C4C80-0x00000001898C4CA0 */ get; } // 0x00000001817B9B60-0x00000001817B9C00 

	// Methods
	// [XID] // 0x000000018989F200-0x000000018989F220
	public static void BuildIndex() {} // 0x00000001817BB1A0-0x00000001817BB230
	// [XID] // 0x00000001898A6DA0-0x00000001898A6DC0
	public static CityLevelupConfig GetConfigByAreaID(uint sceneID, uint areaID, uint level) => default; // 0x00000001817BA650-0x00000001817BA880
	// [XID] // 0x00000001898AE5B0-0x00000001898AE5D0
	public static uint GetCityMaxLevelByAreaID(uint sceneID, uint areaID) => default; // 0x00000001817BA430-0x00000001817BA650
	// [XID] // 0x00000001898B5A90-0x00000001898B5AB0
	public static void Register() {} // 0x00000001817BB610-0x00000001817BB6B0
	// [XID] // 0x00000001898CC0B0-0x00000001898CC0D0
	public static void LoadData() {} // 0x00000001817BA200-0x00000001817BA2F0
	// [XID] // 0x00000001898D3930-0x00000001898D3950
	private static void RegisterHotfixGenerated() {} // 0x00000001817BA030-0x00000001817BA200
	// [XID] // 0x00000001898DB140-0x00000001898DB160
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001817B9C00-0x00000001817BA030
	// [IDTag] // 0x00000001898E2EC0-0x00000001898E2F00
	// [XID] // 0x00000001898E2EC0-0x00000001898E2F00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001817BA880-0x00000001817BA980
	// [XID] // 0x00000001898ED9A0-0x00000001898ED9C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CityLevelupConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001817BB2E0-0x00000001817BB610
	// [XID] // 0x00000001898F52E0-0x00000001898F5300
	private static bool ParseConfigFromLine(string line, out CityLevelupConfig data) {
		data = default;
		return default;
	} // 0x00000001817BA2F0-0x00000001817BA430
	// [IDTag] // 0x00000001898FC950-0x00000001898FC990
	// [XID] // 0x00000001898FC950-0x00000001898FC990
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CityLevelupConfig> configList) => default; // 0x00000001817BA980-0x00000001817BAC20
	// [IDTag] // 0x0000000189907310-0x0000000189907350
	// [XID] // 0x0000000189907310-0x0000000189907350
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA37 */, bool useObjectPool = false /* Metadata: 0x00AEFA3B */) => default; // 0x00000001817BAC20-0x00000001817BAE70
	// [IDTag] // 0x0000000189911B40-0x0000000189911B80
	// [XID] // 0x0000000189911B40-0x0000000189911B80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA3C */, bool useObjectPool = false /* Metadata: 0x00AEFA40 */) => default; // 0x00000001817BAE70-0x00000001817BB1A0
}

