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

public static class ActivityMistTrialAvatarDataExcelConfigLoader // TypeDefIndex: 15140
{
	// Fields
	private static Dictionary<uint, ActivityMistTrialAvatarDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityMistTrialAvatarDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityMistTrialAvatarDataExcelConfig, ActivityMistTrialAvatarDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityMistTrialAvatarDataExcelConfig>, Dictionary<uint, ActivityMistTrialAvatarDataExcelConfig>, string, bool> customValidateFunc; // 0x20
	private static List<ActivityMistTrialAvatarDataExcelConfig> _activityMistTrialAvatarConfigList; // 0x28
	private static List<ulong> _activityMistTrialAvatarIdList; // 0x30

	// Properties
	public static Dictionary<uint, ActivityMistTrialAvatarDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189926D40-0x0000000189926D60 */ get; } // 0x0000000182B82E50-0x0000000182B82F20 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189935750-0x0000000189935770 */ get; } // 0x0000000182B81700-0x0000000182B817A0 
	public static List<ActivityMistTrialAvatarDataExcelConfig> activityMistTrialAvatarConfigList { /* [XID] */ /* 0x000000018998C870-0x000000018998C890 */ get; } // 0x0000000182B837A0-0x0000000182B839B0 
	public static List<ulong> activityMistTrialAvatarIdList { /* [XID] */ /* 0x00000001899AB140-0x00000001899AB160 */ get; } // 0x0000000182B830B0-0x0000000182B83450 

	// Constructors
	static ActivityMistTrialAvatarDataExcelConfigLoader() {} // 0x0000000182B83A70-0x0000000182B83AE0

	// Methods
	// [XID] // 0x000000018991F200-0x000000018991F220
	public static void Register() {} // 0x0000000182B839B0-0x0000000182B83A70
	// [XID] // 0x000000018992E450-0x000000018992E470
	public static ActivityMistTrialAvatarDataExcelConfig GetData(uint Id) => default; // 0x0000000182B81190-0x0000000182B81320
	// [XID] // 0x000000018993D2B0-0x000000018993D2D0
	public static void LoadData() {} // 0x0000000182B82100-0x0000000182B82230
	// [XID] // 0x0000000189944980-0x00000001899449A0
	private static void RegisterHotfixGenerated() {} // 0x0000000182B81D20-0x0000000182B81F90
	// [XID] // 0x000000018994BF60-0x000000018994BF80
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B817A0-0x0000000182B81C80
	// [IDTag] // 0x00000001899535D0-0x0000000189953610
	// [XID] // 0x00000001899535D0-0x0000000189953610
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B826B0-0x0000000182B82810
	// [XID] // 0x000000018995DEB0-0x000000018995DED0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityMistTrialAvatarDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B83450-0x0000000182B837A0
	// [XID] // 0x00000001899656F0-0x0000000189965710
	private static bool ParseConfigFromLine(string line, out ActivityMistTrialAvatarDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B82230-0x0000000182B82370
	// [IDTag] // 0x000000018996CE10-0x000000018996CE50
	// [XID] // 0x000000018996CE10-0x000000018996CE50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityMistTrialAvatarDataExcelConfig> configList) => default; // 0x0000000182B82370-0x0000000182B826B0
	// [IDTag] // 0x0000000189977940-0x0000000189977980
	// [XID] // 0x0000000189977940-0x0000000189977980
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF01F9 */, bool useObjectPool = false /* Metadata: 0x00AF01FD */) => default; // 0x0000000182B82BA0-0x0000000182B82E50
	// [IDTag] // 0x0000000189982200-0x0000000189982240
	// [XID] // 0x0000000189982200-0x0000000189982240
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF01FE */, bool useObjectPool = false /* Metadata: 0x00AF0202 */) => default; // 0x0000000182B82810-0x0000000182B82BA0
	// [XID] // 0x00000001899945D0-0x00000001899945F0
	public static void LoadList(uint scheduleId) {} // 0x0000000182B81320-0x0000000182B81700
	// [XID] // 0x000000018999BDA0-0x000000018999BDC0
	public static ActivityMistTrialAvatarDataExcelConfig GetDataByIndexId(int levelId) => default; // 0x0000000182B81F90-0x0000000182B82100
	// [XID] // 0x00000001899A35D0-0x00000001899A35F0
	public static ActivityMistTrialAvatarDataExcelConfig GetDataByAvatarTrialId(int trialId) => default; // 0x0000000182B82F20-0x0000000182B830B0
}

