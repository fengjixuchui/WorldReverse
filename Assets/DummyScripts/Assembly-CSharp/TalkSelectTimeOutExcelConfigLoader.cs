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

public static class TalkSelectTimeOutExcelConfigLoader // TypeDefIndex: 15973
{
	// Fields
	private static Dictionary<uint, TalkSelectTimeOutExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TalkSelectTimeOutExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TalkSelectTimeOutExcelConfig, TalkSelectTimeOutExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TalkSelectTimeOutExcelConfig>, Dictionary<uint, TalkSelectTimeOutExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TalkSelectTimeOutExcelConfig> dataDict { /* [XID] */ /* 0x0000000189833CE0-0x0000000189833D00 */ get; } // 0x0000000183D043E0-0x0000000183D04490 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189842B20-0x0000000189842B40 */ get; } // 0x0000000183D03230-0x0000000183D032D0 

	// Methods
	// [XID] // 0x000000018982C7D0-0x000000018982C7F0
	public static void Register() {} // 0x0000000183D047C0-0x0000000183D04860
	// [XID] // 0x000000018983B2A0-0x000000018983B2C0
	public static TalkSelectTimeOutExcelConfig GetData(uint id) => default; // 0x0000000183D03100-0x0000000183D03230
	// [XID] // 0x0000000189849ED0-0x0000000189849EF0
	public static void LoadData() {} // 0x0000000183D03860-0x0000000183D03950
	// [XID] // 0x0000000189851550-0x0000000189851570
	private static void RegisterHotfixGenerated() {} // 0x0000000183D03690-0x0000000183D03860
	// [XID] // 0x0000000189858AC0-0x0000000189858AE0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183D032D0-0x0000000183D03690
	// [IDTag] // 0x000000018985FC50-0x000000018985FC90
	// [XID] // 0x000000018985FC50-0x000000018985FC90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183D03A90-0x0000000183D03B90
	// [XID] // 0x000000018986A3A0-0x000000018986A3C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TalkSelectTimeOutExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183D04490-0x0000000183D047C0
	// [XID] // 0x00000001898717D0-0x00000001898717F0
	private static bool ParseConfigFromLine(string line, out TalkSelectTimeOutExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183D03950-0x0000000183D03A90
	// [IDTag] // 0x0000000189879050-0x0000000189879090
	// [XID] // 0x0000000189879050-0x0000000189879090
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TalkSelectTimeOutExcelConfig> configList) => default; // 0x0000000183D03B90-0x0000000183D03E40
	// [IDTag] // 0x0000000189883190-0x00000001898831D0
	// [XID] // 0x0000000189883190-0x00000001898831D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2CA7 */, bool useObjectPool = false /* Metadata: 0x00AF2CAB */) => default; // 0x0000000183D04190-0x0000000183D043E0
	// [IDTag] // 0x000000018988D6A0-0x000000018988D6E0
	// [XID] // 0x000000018988D6A0-0x000000018988D6E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CAC */, bool useObjectPool = false /* Metadata: 0x00AF2CB0 */) => default; // 0x0000000183D03E40-0x0000000183D04190
}

