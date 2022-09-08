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

public static class DieTypeTipsExcelConfigLoader // TypeDefIndex: 14862
{
	// Fields
	private const uint GENERAL_MONSTER_ID = 1; // Metadata: 0x00AEF821
	private static Dictionary<int, DieTypeTipsExcelConfig> _dieType2config; // 0x00
	private static Dictionary<uint, DieTypeTipsExcelConfig> _monsterID2config; // 0x08
	private static Dictionary<uint, DieTypeTipsExcelConfig> _dataDict; // 0x10
	public static Action<List<DataHotfixMeta>, List<DieTypeTipsExcelConfig>> customApplyHotfixAction; // 0x18
	public static Action<DieTypeTipsExcelConfig, DieTypeTipsExcelConfig> onUpdateConfig; // 0x20
	public static Action onApplyHotfixFinish; // 0x28
	public static Func<List<DataHotfixMeta>, List<DieTypeTipsExcelConfig>, Dictionary<uint, DieTypeTipsExcelConfig>, string, bool> customValidateFunc; // 0x30

	// Properties
	public static Dictionary<uint, DieTypeTipsExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B779D0-0x0000000189B779F0 */ get; } // 0x0000000184CABCB0-0x0000000184CABD80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B86B80-0x0000000189B86BA0 */ get; } // 0x0000000184CAA760-0x0000000184CAA800 

	// Constructors
	static DieTypeTipsExcelConfigLoader() {} // 0x0000000184CAC850-0x0000000184CAC910

	// Methods
	// [XID] // 0x0000000189B53EA0-0x0000000189B53EC0
	public static void BuildIndex() {} // 0x0000000184CAC180-0x0000000184CAC440
	// [IDTag] // 0x0000000189B5B810-0x0000000189B5B850
	// [XID] // 0x0000000189B5B810-0x0000000189B5B850
	public static string GetDieTip(PlayerDieType dieType) => default; // 0x0000000184CABF80-0x0000000184CAC180
	// [IDTag] // 0x0000000189B65E80-0x0000000189B65EC0
	// [XID] // 0x0000000189B65E80-0x0000000189B65EC0
	public static string GetDieTip(uint monsterID) => default; // 0x0000000184CABD80-0x0000000184CABF80
	// [XID] // 0x0000000189B704E0-0x0000000189B70500
	public static void Register() {} // 0x0000000184CAC790-0x0000000184CAC850
	// [XID] // 0x0000000189B7EFA0-0x0000000189B7EFC0
	public static DieTypeTipsExcelConfig GetData(uint id) => default; // 0x0000000184CAA5C0-0x0000000184CAA760
	// [XID] // 0x0000000189B8DCF0-0x0000000189B8DD10
	public static void LoadData() {} // 0x0000000184CAAF50-0x0000000184CAB080
	// [XID] // 0x0000000189B951F0-0x0000000189B95210
	private static void RegisterHotfixGenerated() {} // 0x0000000184CAACE0-0x0000000184CAAF50
	// [XID] // 0x0000000189B9C860-0x0000000189B9C880
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184CAA800-0x0000000184CAACE0
	// [IDTag] // 0x0000000189BA3F70-0x0000000189BA3FB0
	// [XID] // 0x0000000189BA3F70-0x0000000189BA3FB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184CAB1C0-0x0000000184CAB320
	// [XID] // 0x0000000189BAE060-0x0000000189BAE080
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DieTypeTipsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184CAC440-0x0000000184CAC790
	// [XID] // 0x0000000189BB5910-0x0000000189BB5930
	private static bool ParseConfigFromLine(string line, out DieTypeTipsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184CAB080-0x0000000184CAB1C0
	// [IDTag] // 0x0000000189BBD0A0-0x0000000189BBD0E0
	// [XID] // 0x0000000189BBD0A0-0x0000000189BBD0E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DieTypeTipsExcelConfig> configList) => default; // 0x0000000184CAB320-0x0000000184CAB670
	// [IDTag] // 0x0000000189BC7B00-0x0000000189BC7B40
	// [XID] // 0x0000000189BC7B00-0x0000000189BC7B40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF817 */, bool useObjectPool = false /* Metadata: 0x00AEF81B */) => default; // 0x0000000184CABA00-0x0000000184CABCB0
	// [IDTag] // 0x0000000189BD2600-0x0000000189BD2640
	// [XID] // 0x0000000189BD2600-0x0000000189BD2640
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF81C */, bool useObjectPool = false /* Metadata: 0x00AEF820 */) => default; // 0x0000000184CAB670-0x0000000184CABA00
}

