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

public static class DungeonLevelEntityConfigLoader // TypeDefIndex: 14865
{
	// Fields
	private static Dictionary<uint, List<DungeonLevelEntityConfig>> _levelConfigDic; // 0x00
	private static List<DungeonLevelEntityConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<DungeonLevelEntityConfig>> customApplyHotfixAction; // 0x10
	public static Action<DungeonLevelEntityConfig, DungeonLevelEntityConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<DungeonLevelEntityConfig>, List<DungeonLevelEntityConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<DungeonLevelEntityConfig> dataList { /* [XID] */ /* 0x00000001899C0070-0x00000001899C0090 */ get; } // 0x000000018283E160-0x000000018283E230 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899C7810-0x00000001899C7830 */ get; } // 0x000000018283CAD0-0x000000018283CB70 

	// Constructors
	static DungeonLevelEntityConfigLoader() {} // 0x000000018283E640-0x000000018283E6A0

	// Methods
	// [XID] // 0x00000001899A9860-0x00000001899A9880
	public static void BuildDungeonLevelConfigDic() {} // 0x000000018283C740-0x000000018283CAD0
	// [XID] // 0x00000001899B12B0-0x00000001899B12D0
	public static List<DungeonLevelEntityConfig> GetDungeonLevelConfigListById(uint id) => default; // 0x000000018283CB70-0x000000018283CC70
	// [XID] // 0x00000001899B85B0-0x00000001899B85D0
	public static void Register() {} // 0x000000018283E580-0x000000018283E640
	// [XID] // 0x00000001899CEFE0-0x00000001899CF000
	public static void LoadData() {} // 0x000000018283D430-0x000000018283D560
	// [XID] // 0x00000001899D65B0-0x00000001899D65D0
	private static void RegisterHotfixGenerated() {} // 0x000000018283D1C0-0x000000018283D430
	// [XID] // 0x00000001899DDAE0-0x00000001899DDB00
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018283CC70-0x000000018283D1C0
	// [IDTag] // 0x00000001899E5860-0x00000001899E58A0
	// [XID] // 0x00000001899E5860-0x00000001899E58A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018283D9D0-0x000000018283DB30
	// [XID] // 0x00000001899EFD70-0x00000001899EFD90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonLevelEntityConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018283E230-0x000000018283E580
	// [XID] // 0x00000001899F7410-0x00000001899F7430
	private static bool ParseConfigFromLine(string line, out DungeonLevelEntityConfig data) {
		data = default;
		return default;
	} // 0x000000018283D560-0x000000018283D6A0
	// [IDTag] // 0x00000001899FEB30-0x00000001899FEB70
	// [XID] // 0x00000001899FEB30-0x00000001899FEB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonLevelEntityConfig> configList) => default; // 0x000000018283D6A0-0x000000018283D9D0
	// [IDTag] // 0x0000000189A09150-0x0000000189A09190
	// [XID] // 0x0000000189A09150-0x0000000189A09190
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF834 */, bool useObjectPool = false /* Metadata: 0x00AEF838 */) => default; // 0x000000018283DB30-0x000000018283DDE0
	// [IDTag] // 0x0000000189A138E0-0x0000000189A13920
	// [XID] // 0x0000000189A138E0-0x0000000189A13920
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF839 */, bool useObjectPool = false /* Metadata: 0x00AEF83D */) => default; // 0x000000018283DDE0-0x000000018283E160
}

