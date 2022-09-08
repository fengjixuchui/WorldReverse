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

public static class DungeonSerialConfigLoader // TypeDefIndex: 15557
{
	// Fields
	private static Dictionary<uint, DungeonSerialConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonSerialConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonSerialConfig, DungeonSerialConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonSerialConfig>, Dictionary<uint, DungeonSerialConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonSerialConfig> dataDict { /* [XID] */ /* 0x0000000189839B00-0x0000000189839B20 */ get; } // 0x0000000181A17BC0-0x0000000181A17C70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189848480-0x00000001898484A0 */ get; } // 0x0000000181A16A10-0x0000000181A16AB0 

	// Methods
	// [XID] // 0x0000000189832550-0x0000000189832570
	public static void Register() {} // 0x0000000181A17FA0-0x0000000181A18040
	// [XID] // 0x0000000189841000-0x0000000189841020
	public static DungeonSerialConfig GetData(uint id) => default; // 0x0000000181A168E0-0x0000000181A16A10
	// [XID] // 0x000000018984FBE0-0x000000018984FC00
	public static void LoadData() {} // 0x0000000181A17040-0x0000000181A17130
	// [XID] // 0x00000001898570A0-0x00000001898570C0
	private static void RegisterHotfixGenerated() {} // 0x0000000181A16E70-0x0000000181A17040
	// [XID] // 0x000000018985E1D0-0x000000018985E1F0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181A16AB0-0x0000000181A16E70
	// [IDTag] // 0x0000000189865BB0-0x0000000189865BF0
	// [XID] // 0x0000000189865BB0-0x0000000189865BF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181A17520-0x0000000181A17620
	// [XID] // 0x0000000189870040-0x0000000189870060
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonSerialConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181A17C70-0x0000000181A17FA0
	// [XID] // 0x00000001898776D0-0x00000001898776F0
	private static bool ParseConfigFromLine(string line, out DungeonSerialConfig data) {
		data = default;
		return default;
	} // 0x0000000181A17130-0x0000000181A17270
	// [IDTag] // 0x000000018987EF20-0x000000018987EF60
	// [XID] // 0x000000018987EF20-0x000000018987EF60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonSerialConfig> configList) => default; // 0x0000000181A17270-0x0000000181A17520
	// [IDTag] // 0x0000000189889340-0x0000000189889380
	// [XID] // 0x0000000189889340-0x0000000189889380
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F02 */, bool useObjectPool = false /* Metadata: 0x00AF1F06 */) => default; // 0x0000000181A17620-0x0000000181A17870
	// [IDTag] // 0x0000000189893750-0x0000000189893790
	// [XID] // 0x0000000189893750-0x0000000189893790
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F07 */, bool useObjectPool = false /* Metadata: 0x00AF1F0B */) => default; // 0x0000000181A17870-0x0000000181A17BC0
}

