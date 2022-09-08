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

public static class WorldAreaExploreEventConfigLoader // TypeDefIndex: 16298
{
	// Fields
	private static Dictionary<uint, WorldAreaExploreEventConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WorldAreaExploreEventConfig>> customApplyHotfixAction; // 0x08
	public static Action<WorldAreaExploreEventConfig, WorldAreaExploreEventConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WorldAreaExploreEventConfig>, Dictionary<uint, WorldAreaExploreEventConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WorldAreaExploreEventConfig> dataDict { /* [XID] */ /* 0x0000000189703430-0x0000000189703450 */ get; } // 0x00000001831FB6E0-0x00000001831FB790 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897124F0-0x0000000189712510 */ get; } // 0x00000001831FA530-0x00000001831FA5D0 

	// Methods
	// [XID] // 0x00000001896FBEF0-0x00000001896FBF10
	public static void Register() {} // 0x00000001831FBAC0-0x00000001831FBB60
	// [XID] // 0x000000018970AB00-0x000000018970AB20
	public static WorldAreaExploreEventConfig GetData(uint EventID) => default; // 0x00000001831FA400-0x00000001831FA530
	// [XID] // 0x0000000189719C70-0x0000000189719C90
	public static void LoadData() {} // 0x00000001831FAB60-0x00000001831FAC50
	// [XID] // 0x0000000189721250-0x0000000189721270
	private static void RegisterHotfixGenerated() {} // 0x00000001831FA990-0x00000001831FAB60
	// [XID] // 0x0000000189728890-0x00000001897288B0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001831FA5D0-0x00000001831FA990
	// [IDTag] // 0x0000000189730000-0x0000000189730040
	// [XID] // 0x0000000189730000-0x0000000189730040
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001831FB040-0x00000001831FB140
	// [XID] // 0x000000018973A550-0x000000018973A570
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WorldAreaExploreEventConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001831FB790-0x00000001831FBAC0
	// [XID] // 0x0000000189741EC0-0x0000000189741EE0
	private static bool ParseConfigFromLine(string line, out WorldAreaExploreEventConfig data) {
		data = default;
		return default;
	} // 0x00000001831FAC50-0x00000001831FAD90
	// [IDTag] // 0x00000001897498E0-0x0000000189749920
	// [XID] // 0x00000001897498E0-0x0000000189749920
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WorldAreaExploreEventConfig> configList) => default; // 0x00000001831FAD90-0x00000001831FB040
	// [IDTag] // 0x0000000189753D20-0x0000000189753D60
	// [XID] // 0x0000000189753D20-0x0000000189753D60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF36ED */, bool useObjectPool = false /* Metadata: 0x00AF36F1 */) => default; // 0x00000001831FB140-0x00000001831FB390
	// [IDTag] // 0x000000018975E3D0-0x000000018975E410
	// [XID] // 0x000000018975E3D0-0x000000018975E410
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF36F2 */, bool useObjectPool = false /* Metadata: 0x00AF36F6 */) => default; // 0x00000001831FB390-0x00000001831FB6E0
}

