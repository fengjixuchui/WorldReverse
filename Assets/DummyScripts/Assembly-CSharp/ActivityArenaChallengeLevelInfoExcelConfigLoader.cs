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

public static class ActivityArenaChallengeLevelInfoExcelConfigLoader // TypeDefIndex: 15008
{
	// Fields
	private static Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityArenaChallengeLevelInfoExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityArenaChallengeLevelInfoExcelConfig, ActivityArenaChallengeLevelInfoExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityArenaChallengeLevelInfoExcelConfig>, Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig>, string, bool> customValidateFunc; // 0x20
	public static Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> arenaLevelInfoDic; // 0x28

	// Properties
	public static Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> dataDict { /* [XID] */ /* 0x000000018972A140-0x000000018972A160 */ get; } // 0x0000000180F7ECB0-0x0000000180F7ED80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189738FD0-0x0000000189738FF0 */ get; } // 0x0000000180F7D2F0-0x0000000180F7D390 

	// Constructors
	static ActivityArenaChallengeLevelInfoExcelConfigLoader() {} // 0x0000000180F7F190-0x0000000180F7F1F0

	// Methods
	// [XID] // 0x0000000189722960-0x0000000189722980
	public static void Register() {} // 0x0000000180F7F0D0-0x0000000180F7F190
	// [XID] // 0x00000001897317A0-0x00000001897317C0
	public static ActivityArenaChallengeLevelInfoExcelConfig GetData(uint ID) => default; // 0x0000000180F7D160-0x0000000180F7D2F0
	// [XID] // 0x0000000189740D80-0x0000000189740DA0
	public static void LoadData() {} // 0x0000000180F7DF60-0x0000000180F7E090
	// [XID] // 0x00000001897482C0-0x00000001897482E0
	private static void RegisterHotfixGenerated() {} // 0x0000000180F7D870-0x0000000180F7DAE0
	// [XID] // 0x000000018974FB30-0x000000018974FB50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000180F7D390-0x0000000180F7D870
	// [IDTag] // 0x00000001897570E0-0x0000000189757120
	// [XID] // 0x00000001897570E0-0x0000000189757120
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000180F7E510-0x0000000180F7E670
	// [XID] // 0x0000000189761890-0x00000001897618B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityArenaChallengeLevelInfoExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000180F7ED80-0x0000000180F7F0D0
	// [XID] // 0x0000000189768D00-0x0000000189768D20
	private static bool ParseConfigFromLine(string line, out ActivityArenaChallengeLevelInfoExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000180F7E090-0x0000000180F7E1D0
	// [IDTag] // 0x00000001897703B0-0x00000001897703F0
	// [XID] // 0x00000001897703B0-0x00000001897703F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityArenaChallengeLevelInfoExcelConfig> configList) => default; // 0x0000000180F7E1D0-0x0000000180F7E510
	// [IDTag] // 0x000000018977AA00-0x000000018977AA40
	// [XID] // 0x000000018977AA00-0x000000018977AA40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE4D */, bool useObjectPool = false /* Metadata: 0x00AEFE51 */) => default; // 0x0000000180F7E670-0x0000000180F7E920
	// [IDTag] // 0x0000000189785420-0x0000000189785460
	// [XID] // 0x0000000189785420-0x0000000189785460
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE52 */, bool useObjectPool = false /* Metadata: 0x00AEFE56 */) => default; // 0x0000000180F7E920-0x0000000180F7ECB0
	// [XID] // 0x000000018978F8C0-0x000000018978F8E0
	public static void LoadDic(uint scheduleId) {} // 0x0000000180F7DAE0-0x0000000180F7DF60
}

