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

public static class ActivityArenaChallengePreviewExcelConfigLoader // TypeDefIndex: 15006
{
	// Fields
	private static Dictionary<uint, ActivityArenaChallengePreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityArenaChallengePreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityArenaChallengePreviewExcelConfig, ActivityArenaChallengePreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityArenaChallengePreviewExcelConfig>, Dictionary<uint, ActivityArenaChallengePreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityArenaChallengePreviewExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B9DE00-0x0000000189B9DE20 */ get; } // 0x0000000182BA4FC0-0x0000000182BA5070 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BAC9F0-0x0000000189BACA10 */ get; } // 0x0000000182BA3E10-0x0000000182BA3EB0 

	// Methods
	// [XID] // 0x0000000189B968B0-0x0000000189B968D0
	public static void Register() {} // 0x0000000182BA53A0-0x0000000182BA5440
	// [XID] // 0x0000000189BA5790-0x0000000189BA57B0
	public static ActivityArenaChallengePreviewExcelConfig GetData(uint scheduleId) => default; // 0x0000000182BA3CE0-0x0000000182BA3E10
	// [XID] // 0x0000000189BB4250-0x0000000189BB4270
	public static void LoadData() {} // 0x0000000182BA4440-0x0000000182BA4530
	// [XID] // 0x0000000189BBB8B0-0x0000000189BBB8D0
	private static void RegisterHotfixGenerated() {} // 0x0000000182BA4270-0x0000000182BA4440
	// [XID] // 0x0000000189BC3750-0x0000000189BC3770
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182BA3EB0-0x0000000182BA4270
	// [IDTag] // 0x0000000189BCAEF0-0x0000000189BCAF30
	// [XID] // 0x0000000189BCAEF0-0x0000000189BCAF30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182BA4670-0x0000000182BA4770
	// [XID] // 0x0000000189BD5350-0x0000000189BD5370
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityArenaChallengePreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182BA5070-0x0000000182BA53A0
	// [XID] // 0x0000000189BDCEE0-0x0000000189BDCF00
	private static bool ParseConfigFromLine(string line, out ActivityArenaChallengePreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182BA4530-0x0000000182BA4670
	// [IDTag] // 0x00000001895E97B0-0x00000001895E97F0
	// [XID] // 0x00000001895E97B0-0x00000001895E97F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityArenaChallengePreviewExcelConfig> configList) => default; // 0x0000000182BA4770-0x0000000182BA4A20
	// [IDTag] // 0x00000001895F3E30-0x00000001895F3E70
	// [XID] // 0x00000001895F3E30-0x00000001895F3E70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE3E */, bool useObjectPool = false /* Metadata: 0x00AEFE42 */) => default; // 0x0000000182BA4D70-0x0000000182BA4FC0
	// [IDTag] // 0x00000001895FE520-0x00000001895FE560
	// [XID] // 0x00000001895FE520-0x00000001895FE560
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE43 */, bool useObjectPool = false /* Metadata: 0x00AEFE47 */) => default; // 0x0000000182BA4A20-0x0000000182BA4D70
}

