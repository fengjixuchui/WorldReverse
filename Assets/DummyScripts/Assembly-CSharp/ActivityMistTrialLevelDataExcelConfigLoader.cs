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

public static class ActivityMistTrialLevelDataExcelConfigLoader // TypeDefIndex: 15138
{
	// Fields
	private static Dictionary<uint, ActivityMistTrialLevelDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityMistTrialLevelDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityMistTrialLevelDataExcelConfig, ActivityMistTrialLevelDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityMistTrialLevelDataExcelConfig>, Dictionary<uint, ActivityMistTrialLevelDataExcelConfig>, string, bool> customValidateFunc; // 0x20
	private static List<ActivityMistTrialLevelDataExcelConfig> _activityMistTrialLevelConfigList; // 0x28

	// Properties
	public static Dictionary<uint, ActivityMistTrialLevelDataExcelConfig> dataDict { /* [XID] */ /* 0x00000001897F6A80-0x00000001897F6AA0 */ get; } // 0x0000000182B85B30-0x0000000182B85C00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189805850-0x0000000189805870 */ get; } // 0x0000000182B84050-0x0000000182B840F0 
	public static List<ActivityMistTrialLevelDataExcelConfig> activityMistTrialLevelConfigList { /* [XID] */ /* 0x000000018985BAF0-0x000000018985BB10 */ get; } // 0x0000000182B848C0-0x0000000182B84AD0 

	// Constructors
	static ActivityMistTrialLevelDataExcelConfigLoader() {} // 0x0000000182B86010-0x0000000182B86070

	// Methods
	// [XID] // 0x00000001897EF3F0-0x00000001897EF410
	public static void Register() {} // 0x0000000182B85F50-0x0000000182B86010
	// [XID] // 0x00000001897FE0E0-0x00000001897FE100
	public static ActivityMistTrialLevelDataExcelConfig GetData(uint Id) => default; // 0x0000000182B83AE0-0x0000000182B83C70
	// [XID] // 0x000000018980CEB0-0x000000018980CED0
	public static void LoadData() {} // 0x0000000182B84DE0-0x0000000182B84F10
	// [XID] // 0x00000001898146F0-0x0000000189814710
	private static void RegisterHotfixGenerated() {} // 0x0000000182B84B70-0x0000000182B84DE0
	// [XID] // 0x000000018981C120-0x000000018981C140
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B843E0-0x0000000182B848C0
	// [IDTag] // 0x0000000189823630-0x0000000189823670
	// [XID] // 0x0000000189823630-0x0000000189823670
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B85050-0x0000000182B851B0
	// [XID] // 0x000000018982DEC0-0x000000018982DEE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityMistTrialLevelDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B85C00-0x0000000182B85F50
	// [XID] // 0x00000001898354D0-0x00000001898354F0
	private static bool ParseConfigFromLine(string line, out ActivityMistTrialLevelDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B84F10-0x0000000182B85050
	// [IDTag] // 0x000000018983CCB0-0x000000018983CCF0
	// [XID] // 0x000000018983CCB0-0x000000018983CCF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityMistTrialLevelDataExcelConfig> configList) => default; // 0x0000000182B851B0-0x0000000182B854F0
	// [IDTag] // 0x00000001898471B0-0x00000001898471F0
	// [XID] // 0x00000001898471B0-0x00000001898471F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF01EA */, bool useObjectPool = false /* Metadata: 0x00AF01EE */) => default; // 0x0000000182B85880-0x0000000182B85B30
	// [IDTag] // 0x00000001898515D0-0x0000000189851610
	// [XID] // 0x00000001898515D0-0x0000000189851610
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF01EF */, bool useObjectPool = false /* Metadata: 0x00AF01F3 */) => default; // 0x0000000182B854F0-0x0000000182B85880
	// [XID] // 0x0000000189863090-0x00000001898630B0
	public static void LoadList(uint scheduleId) {} // 0x0000000182B83C70-0x0000000182B84050
	// [XID] // 0x000000018986A500-0x000000018986A520
	public static ActivityMistTrialLevelDataExcelConfig GetDataByLevelId(int levelId) => default; // 0x0000000182B840F0-0x0000000182B84260
	// [XID] // 0x00000001898719D0-0x00000001898719F0
	public static ActivityMistTrialLevelDataExcelConfig GetDataByDungeonId(uint dungeonId) => default; // 0x0000000182B84260-0x0000000182B843E0
}

