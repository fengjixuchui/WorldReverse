/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RqTalkExcelConfigLoader // TypeDefIndex: 15971
{
	// Fields
	private static Dictionary<uint, RqTalkExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RqTalkExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RqTalkExcelConfig, RqTalkExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RqTalkExcelConfig>, Dictionary<uint, RqTalkExcelConfig>, string, bool> customValidateFunc; // 0x20
	private static Dictionary<uint, List<RqTalkExcelConfig>> _mainQuestId2DataDic; // 0x28

	// Properties
	public static Dictionary<uint, RqTalkExcelConfig> dataDict { /* [XID] */ /* 0x0000000189718130-0x0000000189718150 */ get; } // 0x0000000181474C50-0x0000000181474D20 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897272A0-0x00000001897272C0 */ get; } // 0x0000000181473610-0x00000001814736B0 

	// Constructors
	static RqTalkExcelConfigLoader() {} // 0x0000000181475330-0x00000001814753C0

	// Methods
	// [XID] // 0x0000000189710DF0-0x0000000189710E10
	public static void Register() {} // 0x0000000181475270-0x0000000181475330
	// [XID] // 0x000000018971FB10-0x000000018971FB30
	public static RqTalkExcelConfig GetData(uint id) => default; // 0x0000000181473480-0x0000000181473610
	// [XID] // 0x000000018972E7B0-0x000000018972E7D0
	public static void LoadData() {} // 0x0000000181473E00-0x0000000181473F30
	// [XID] // 0x0000000189735F40-0x0000000189735F60
	private static void RegisterHotfixGenerated() {} // 0x0000000181473B90-0x0000000181473E00
	// [XID] // 0x000000018973DBB0-0x000000018973DBD0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001814736B0-0x0000000181473B90
	// [IDTag] // 0x0000000189744F50-0x0000000189744F90
	// [XID] // 0x0000000189744F50-0x0000000189744F90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001814744B0-0x0000000181474610
	// [XID] // 0x000000018974F950-0x000000018974F970
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RqTalkExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181474F20-0x0000000181475270
	// [XID] // 0x0000000189756F40-0x0000000189756F60
	private static bool ParseConfigFromLine(string line, out RqTalkExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181473F30-0x0000000181474070
	// [IDTag] // 0x000000018975E4F0-0x000000018975E530
	// [XID] // 0x000000018975E4F0-0x000000018975E530
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RqTalkExcelConfig> configList) => default; // 0x0000000181474170-0x00000001814744B0
	// [IDTag] // 0x0000000189768B00-0x0000000189768B40
	// [XID] // 0x0000000189768B00-0x0000000189768B40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C98 */, bool useObjectPool = false /* Metadata: 0x00AF2C9C */) => default; // 0x00000001814749A0-0x0000000181474C50
	// [IDTag] // 0x0000000189773240-0x0000000189773280
	// [XID] // 0x0000000189773240-0x0000000189773280
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C9D */, bool useObjectPool = false /* Metadata: 0x00AF2CA1 */) => default; // 0x0000000181474610-0x00000001814749A0
	// [XID] // 0x000000018977DB20-0x000000018977DB40
	public static void BuildIndex() {} // 0x0000000181474D20-0x0000000181474F20
	// [XID] // 0x0000000189785320-0x0000000189785340
	private static void AddMainQuestIndex(RqTalkExcelConfig config) {} // 0x00000001814732B0-0x0000000181473480
	// [XID] // 0x000000018978C830-0x000000018978C850
	public static List<RqTalkExcelConfig> GetListByMainQuestId(uint mainQuestId) => default; // 0x0000000181474070-0x0000000181474170
}

