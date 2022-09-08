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

public static class EnvAnimalWeightExcelConfigLoader // TypeDefIndex: 15575
{
	// Fields
	private static Dictionary<int, EnvAnimalWeightExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EnvAnimalWeightExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EnvAnimalWeightExcelConfig, EnvAnimalWeightExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EnvAnimalWeightExcelConfig>, Dictionary<int, EnvAnimalWeightExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, EnvAnimalWeightExcelConfig> dataDict { /* [XID] */ /* 0x0000000189650B90-0x0000000189650BB0 */ get; } // 0x000000018168AF70-0x000000018168B020 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018965F960-0x000000018965F980 */ get; } // 0x0000000181689DC0-0x0000000181689E60 

	// Methods
	// [XID] // 0x0000000189649520-0x0000000189649540
	public static void Register() {} // 0x000000018168B350-0x000000018168B3F0
	// [XID] // 0x0000000189658370-0x0000000189658390
	public static EnvAnimalWeightExcelConfig GetData(EnvironmentType envType) => default; // 0x0000000181689C90-0x0000000181689DC0
	// [XID] // 0x0000000189667410-0x0000000189667430
	public static void LoadData() {} // 0x000000018168A3F0-0x000000018168A4E0
	// [XID] // 0x000000018966EC20-0x000000018966EC40
	private static void RegisterHotfixGenerated() {} // 0x000000018168A220-0x000000018168A3F0
	// [XID] // 0x0000000189676640-0x0000000189676660
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181689E60-0x000000018168A220
	// [IDTag] // 0x000000018967DE00-0x000000018967DE40
	// [XID] // 0x000000018967DE00-0x000000018967DE40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018168A8D0-0x000000018168A9D0
	// [XID] // 0x0000000189688B20-0x0000000189688B40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EnvAnimalWeightExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018168B020-0x000000018168B350
	// [XID] // 0x0000000189690540-0x0000000189690560
	private static bool ParseConfigFromLine(string line, out EnvAnimalWeightExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018168A4E0-0x000000018168A620
	// [IDTag] // 0x0000000189697D80-0x0000000189697DC0
	// [XID] // 0x0000000189697D80-0x0000000189697DC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EnvAnimalWeightExcelConfig> configList) => default; // 0x000000018168A620-0x000000018168A8D0
	// [IDTag] // 0x00000001896A2340-0x00000001896A2380
	// [XID] // 0x00000001896A2340-0x00000001896A2380
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F84 */, bool useObjectPool = false /* Metadata: 0x00AF1F88 */) => default; // 0x000000018168AD20-0x000000018168AF70
	// [IDTag] // 0x00000001896AC4F0-0x00000001896AC530
	// [XID] // 0x00000001896AC4F0-0x00000001896AC530
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F89 */, bool useObjectPool = false /* Metadata: 0x00AF1F8D */) => default; // 0x000000018168A9D0-0x000000018168AD20
}

