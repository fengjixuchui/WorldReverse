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

public static class AchievementGoalExcelConfigLoader // TypeDefIndex: 14996
{
	// Fields
	private static Dictionary<uint, AchievementGoalExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AchievementGoalExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AchievementGoalExcelConfig, AchievementGoalExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AchievementGoalExcelConfig>, Dictionary<uint, AchievementGoalExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AchievementGoalExcelConfig> dataDict { /* [XID] */ /* 0x000000018960A830-0x000000018960A850 */ get; } // 0x0000000182C72DA0-0x0000000182C72E50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189619780-0x00000001896197A0 */ get; } // 0x0000000182C71BF0-0x0000000182C71C90 

	// Methods
	// [XID] // 0x0000000189602E90-0x0000000189602EB0
	public static void Register() {} // 0x0000000182C73180-0x0000000182C73220
	// [XID] // 0x0000000189611EA0-0x0000000189611EC0
	public static AchievementGoalExcelConfig GetData(uint id) => default; // 0x0000000182C71AC0-0x0000000182C71BF0
	// [XID] // 0x0000000189620D00-0x0000000189620D20
	public static void LoadData() {} // 0x0000000182C72220-0x0000000182C72310
	// [XID] // 0x0000000189628330-0x0000000189628350
	private static void RegisterHotfixGenerated() {} // 0x0000000182C72050-0x0000000182C72220
	// [XID] // 0x000000018962FC40-0x000000018962FC60
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182C71C90-0x0000000182C72050
	// [IDTag] // 0x0000000189637800-0x0000000189637840
	// [XID] // 0x0000000189637800-0x0000000189637840
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182C72700-0x0000000182C72800
	// [XID] // 0x0000000189641D60-0x0000000189641D80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AchievementGoalExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182C72E50-0x0000000182C73180
	// [XID] // 0x00000001896495C0-0x00000001896495E0
	private static bool ParseConfigFromLine(string line, out AchievementGoalExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182C72310-0x0000000182C72450
	// [IDTag] // 0x0000000189650C30-0x0000000189650C70
	// [XID] // 0x0000000189650C30-0x0000000189650C70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AchievementGoalExcelConfig> configList) => default; // 0x0000000182C72450-0x0000000182C72700
	// [IDTag] // 0x000000018965B530-0x000000018965B570
	// [XID] // 0x000000018965B530-0x000000018965B570
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFDF3 */, bool useObjectPool = false /* Metadata: 0x00AEFDF7 */) => default; // 0x0000000182C72B50-0x0000000182C72DA0
	// [IDTag] // 0x0000000189665AD0-0x0000000189665B10
	// [XID] // 0x0000000189665AD0-0x0000000189665B10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDF8 */, bool useObjectPool = false /* Metadata: 0x00AEFDFC */) => default; // 0x0000000182C72800-0x0000000182C72B50
}

