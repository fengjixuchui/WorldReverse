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

public static class BonusActivityClientExcelConfigLoader // TypeDefIndex: 16168
{
	// Fields
	private static Dictionary<uint, BonusActivityClientExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BonusActivityClientExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BonusActivityClientExcelConfig, BonusActivityClientExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BonusActivityClientExcelConfig>, Dictionary<uint, BonusActivityClientExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BonusActivityClientExcelConfig> dataDict { /* [XID] */ /* 0x00000001897F6840-0x00000001897F6860 */ get; } // 0x00000001828AF0B0-0x00000001828AF160 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189805730-0x0000000189805750 */ get; } // 0x00000001828ADF00-0x00000001828ADFA0 

	// Methods
	// [XID] // 0x00000001897EF1F0-0x00000001897EF210
	public static void Register() {} // 0x00000001828AF490-0x00000001828AF530
	// [XID] // 0x00000001897FDEE0-0x00000001897FDF00
	public static BonusActivityClientExcelConfig GetData(uint id) => default; // 0x00000001828ADDD0-0x00000001828ADF00
	// [XID] // 0x000000018980CD30-0x000000018980CD50
	public static void LoadData() {} // 0x00000001828AE530-0x00000001828AE620
	// [XID] // 0x0000000189814590-0x00000001898145B0
	private static void RegisterHotfixGenerated() {} // 0x00000001828AE360-0x00000001828AE530
	// [XID] // 0x000000018981C020-0x000000018981C040
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001828ADFA0-0x00000001828AE360
	// [IDTag] // 0x0000000189823450-0x0000000189823490
	// [XID] // 0x0000000189823450-0x0000000189823490
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001828AEA10-0x00000001828AEB10
	// [XID] // 0x000000018982DCE0-0x000000018982DD00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BonusActivityClientExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001828AF160-0x00000001828AF490
	// [XID] // 0x00000001898353B0-0x00000001898353D0
	private static bool ParseConfigFromLine(string line, out BonusActivityClientExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001828AE620-0x00000001828AE760
	// [IDTag] // 0x000000018983CAD0-0x000000018983CB10
	// [XID] // 0x000000018983CAD0-0x000000018983CB10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BonusActivityClientExcelConfig> configList) => default; // 0x00000001828AE760-0x00000001828AEA10
	// [IDTag] // 0x0000000189847090-0x00000001898470D0
	// [XID] // 0x0000000189847090-0x00000001898470D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF331C */, bool useObjectPool = false /* Metadata: 0x00AF3320 */) => default; // 0x00000001828AEB10-0x00000001828AED60
	// [IDTag] // 0x00000001898514F0-0x0000000189851530
	// [XID] // 0x00000001898514F0-0x0000000189851530
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3321 */, bool useObjectPool = false /* Metadata: 0x00AF3325 */) => default; // 0x00000001828AED60-0x00000001828AF0B0
}

