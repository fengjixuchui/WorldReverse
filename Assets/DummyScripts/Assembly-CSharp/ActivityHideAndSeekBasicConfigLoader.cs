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

public static class ActivityHideAndSeekBasicConfigLoader // TypeDefIndex: 14824
{
	// Fields
	private static Dictionary<uint, ActivityHideAndSeekBasicConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityHideAndSeekBasicConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityHideAndSeekBasicConfig, ActivityHideAndSeekBasicConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityHideAndSeekBasicConfig>, Dictionary<uint, ActivityHideAndSeekBasicConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityHideAndSeekBasicConfig> dataDict { /* [XID] */ /* 0x00000001898C0360-0x00000001898C0380 */ get; } // 0x000000018195C0C0-0x000000018195C170 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898CF3F0-0x00000001898CF410 */ get; } // 0x000000018195AF10-0x000000018195AFB0 

	// Methods
	// [XID] // 0x00000001898B13C0-0x00000001898B13E0
	public static ActivityHideAndSeekBasicConfig GetConfig(uint activityID) => default; // 0x000000018195AB90-0x000000018195ADE0
	// [XID] // 0x00000001898B8D20-0x00000001898B8D40
	public static void Register() {} // 0x000000018195C4A0-0x000000018195C540
	// [XID] // 0x00000001898C7C60-0x00000001898C7C80
	public static ActivityHideAndSeekBasicConfig GetData(uint id) => default; // 0x000000018195ADE0-0x000000018195AF10
	// [XID] // 0x00000001898D6C20-0x00000001898D6C40
	public static void LoadData() {} // 0x000000018195B540-0x000000018195B630
	// [XID] // 0x00000001898DE8E0-0x00000001898DE900
	private static void RegisterHotfixGenerated() {} // 0x000000018195B370-0x000000018195B540
	// [XID] // 0x00000001898E60A0-0x00000001898E60C0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018195AFB0-0x000000018195B370
	// [IDTag] // 0x00000001898ED9E0-0x00000001898EDA20
	// [XID] // 0x00000001898ED9E0-0x00000001898EDA20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018195B770-0x000000018195B870
	// [XID] // 0x00000001898F8410-0x00000001898F8430
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityHideAndSeekBasicConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018195C170-0x000000018195C4A0
	// [XID] // 0x00000001898FFBD0-0x00000001898FFBF0
	private static bool ParseConfigFromLine(string line, out ActivityHideAndSeekBasicConfig data) {
		data = default;
		return default;
	} // 0x000000018195B630-0x000000018195B770
	// [IDTag] // 0x00000001899073B0-0x00000001899073F0
	// [XID] // 0x00000001899073B0-0x00000001899073F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityHideAndSeekBasicConfig> configList) => default; // 0x000000018195B870-0x000000018195BB20
	// [IDTag] // 0x0000000189911C00-0x0000000189911C40
	// [XID] // 0x0000000189911C00-0x0000000189911C40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6AC */, bool useObjectPool = false /* Metadata: 0x00AEF6B0 */) => default; // 0x000000018195BB20-0x000000018195BD70
	// [IDTag] // 0x000000018991C880-0x000000018991C8C0
	// [XID] // 0x000000018991C880-0x000000018991C8C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6B1 */, bool useObjectPool = false /* Metadata: 0x00AEF6B5 */) => default; // 0x000000018195BD70-0x000000018195C0C0
}

