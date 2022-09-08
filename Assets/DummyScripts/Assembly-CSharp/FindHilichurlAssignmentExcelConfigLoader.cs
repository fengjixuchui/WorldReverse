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

public static class FindHilichurlAssignmentExcelConfigLoader // TypeDefIndex: 14826
{
	// Fields
	private static Dictionary<uint, FindHilichurlAssignmentExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FindHilichurlAssignmentExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FindHilichurlAssignmentExcelConfig, FindHilichurlAssignmentExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FindHilichurlAssignmentExcelConfig>, Dictionary<uint, FindHilichurlAssignmentExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FindHilichurlAssignmentExcelConfig> dataDict { /* [XID] */ /* 0x00000001899F5AF0-0x00000001899F5B10 */ get; } // 0x0000000185899D40-0x0000000185899DF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A04830-0x0000000189A04850 */ get; } // 0x0000000185898690-0x0000000185898730 

	// Methods
	// [XID] // 0x00000001899C1890-0x00000001899C18B0
	public static uint GetIndex(uint assignmentId) => default; // 0x0000000185899DF0-0x0000000185899F20
	// [XID] // 0x00000001899C8E00-0x00000001899C8E20
	public static uint GetQuestId(uint assignmentId) => default; // 0x0000000185898730-0x0000000185898860
	// [XID] // 0x00000001899D0790-0x00000001899D07B0
	public static uint GetHintSubQuestId(uint assignmentId) => default; // 0x0000000185899010-0x0000000185899140
	// [XID] // 0x00000001899D7CB0-0x00000001899D7CD0
	public static uint GetDayIndex(uint assignmentId) => default; // 0x000000018589A2F0-0x000000018589A420
	// [XID] // 0x00000001899DF210-0x00000001899DF230
	public static FindHilichurlAssignmentType GetAssignmentType(uint assignmentId) => default; // 0x0000000185898C20-0x0000000185898D50
	// [XID] // 0x00000001899E6E70-0x00000001899E6E90
	public static string GetkeyWord(uint assignmentId) => default; // 0x0000000185899280-0x00000001858993F0
	// [XID] // 0x00000001899EE2C0-0x00000001899EE2E0
	public static void Register() {} // 0x000000018589A250-0x000000018589A2F0
	// [XID] // 0x00000001899FD270-0x00000001899FD290
	public static FindHilichurlAssignmentExcelConfig GetData(uint id) => default; // 0x0000000185898560-0x0000000185898690
	// [XID] // 0x0000000189A0BFB0-0x0000000189A0BFD0
	public static void LoadData() {} // 0x0000000185898F20-0x0000000185899010
	// [XID] // 0x0000000189A13940-0x0000000189A13960
	private static void RegisterHotfixGenerated() {} // 0x0000000185898D50-0x0000000185898F20
	// [XID] // 0x0000000189A1AA50-0x0000000189A1AA70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185898860-0x0000000185898C20
	// [IDTag] // 0x0000000189A223B0-0x0000000189A223F0
	// [XID] // 0x0000000189A223B0-0x0000000189A223F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001858996A0-0x00000001858997A0
	// [XID] // 0x0000000189A2C590-0x0000000189A2C5B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FindHilichurlAssignmentExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185899F20-0x000000018589A250
	// [XID] // 0x0000000189A33C80-0x0000000189A33CA0
	private static bool ParseConfigFromLine(string line, out FindHilichurlAssignmentExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185899140-0x0000000185899280
	// [IDTag] // 0x0000000189A3B420-0x0000000189A3B460
	// [XID] // 0x0000000189A3B420-0x0000000189A3B460
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FindHilichurlAssignmentExcelConfig> configList) => default; // 0x00000001858993F0-0x00000001858996A0
	// [IDTag] // 0x0000000189A45CA0-0x0000000189A45CE0
	// [XID] // 0x0000000189A45CA0-0x0000000189A45CE0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6C0 */, bool useObjectPool = false /* Metadata: 0x00AEF6C4 */) => default; // 0x00000001858997A0-0x00000001858999F0
	// [IDTag] // 0x0000000189A504E0-0x0000000189A50520
	// [XID] // 0x0000000189A504E0-0x0000000189A50520
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6C5 */, bool useObjectPool = false /* Metadata: 0x00AEF6C9 */) => default; // 0x00000001858999F0-0x0000000185899D40
}

