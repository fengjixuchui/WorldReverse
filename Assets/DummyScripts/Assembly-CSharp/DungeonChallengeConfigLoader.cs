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

public static class DungeonChallengeConfigLoader // TypeDefIndex: 15552
{
	// Fields
	private static Dictionary<uint, DungeonChallengeConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonChallengeConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonChallengeConfig, DungeonChallengeConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonChallengeConfig>, Dictionary<uint, DungeonChallengeConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonChallengeConfig> dataDict { /* [XID] */ /* 0x0000000189B35840-0x0000000189B35860 */ get; } // 0x00000001812BA480-0x00000001812BA530 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B44E30-0x0000000189B44E50 */ get; } // 0x00000001812B92D0-0x00000001812B9370 

	// Methods
	// [XID] // 0x0000000189B2E350-0x0000000189B2E370
	public static void Register() {} // 0x00000001812BA860-0x00000001812BA900
	// [XID] // 0x0000000189B3D000-0x0000000189B3D020
	public static DungeonChallengeConfig GetData(uint id) => default; // 0x00000001812B91A0-0x00000001812B92D0
	// [XID] // 0x0000000189B4C620-0x0000000189B4C640
	public static void LoadData() {} // 0x00000001812B9900-0x00000001812B99F0
	// [XID] // 0x0000000189B53CC0-0x0000000189B53CE0
	private static void RegisterHotfixGenerated() {} // 0x00000001812B9730-0x00000001812B9900
	// [XID] // 0x0000000189B5B5D0-0x0000000189B5B5F0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812B9370-0x00000001812B9730
	// [IDTag] // 0x0000000189B62A20-0x0000000189B62A60
	// [XID] // 0x0000000189B62A20-0x0000000189B62A60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001812B9DE0-0x00000001812B9EE0
	// [XID] // 0x0000000189B6D2C0-0x0000000189B6D2E0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonChallengeConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001812BA530-0x00000001812BA860
	// [XID] // 0x0000000189B749B0-0x0000000189B749D0
	private static bool ParseConfigFromLine(string line, out DungeonChallengeConfig data) {
		data = default;
		return default;
	} // 0x00000001812B99F0-0x00000001812B9B30
	// [IDTag] // 0x0000000189B7BF90-0x0000000189B7BFD0
	// [XID] // 0x0000000189B7BF90-0x0000000189B7BFD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonChallengeConfig> configList) => default; // 0x00000001812B9B30-0x00000001812B9DE0
	// [IDTag] // 0x0000000189B869C0-0x0000000189B86A00
	// [XID] // 0x0000000189B869C0-0x0000000189B86A00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1EDF */, bool useObjectPool = false /* Metadata: 0x00AF1EE3 */) => default; // 0x00000001812BA230-0x00000001812BA480
	// [IDTag] // 0x0000000189B90D70-0x0000000189B90DB0
	// [XID] // 0x0000000189B90D70-0x0000000189B90DB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EE4 */, bool useObjectPool = false /* Metadata: 0x00AF1EE8 */) => default; // 0x00000001812B9EE0-0x00000001812BA230
}

