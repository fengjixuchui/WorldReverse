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

public static class MatchingTextDataExcelConfigLoader // TypeDefIndex: 15808
{
	// Fields
	private static Dictionary<uint, MatchingTextDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MatchingTextDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MatchingTextDataExcelConfig, MatchingTextDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MatchingTextDataExcelConfig>, Dictionary<uint, MatchingTextDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MatchingTextDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A898D0-0x0000000189A898F0 */ get; } // 0x00000001836E21A0-0x00000001836E2250 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A98920-0x0000000189A98940 */ get; } // 0x00000001836E0FF0-0x00000001836E1090 

	// Methods
	// [XID] // 0x0000000189A81E50-0x0000000189A81E70
	public static void Register() {} // 0x00000001836E2580-0x00000001836E2620
	// [XID] // 0x0000000189A90FD0-0x0000000189A90FF0
	public static MatchingTextDataExcelConfig GetData(uint matchId) => default; // 0x00000001836E0EC0-0x00000001836E0FF0
	// [XID] // 0x0000000189A9FCD0-0x0000000189A9FCF0
	public static void LoadData() {} // 0x00000001836E1620-0x00000001836E1710
	// [XID] // 0x0000000189AA7440-0x0000000189AA7460
	private static void RegisterHotfixGenerated() {} // 0x00000001836E1450-0x00000001836E1620
	// [XID] // 0x0000000189AAEB60-0x0000000189AAEB80
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001836E1090-0x00000001836E1450
	// [IDTag] // 0x0000000189AB64C0-0x0000000189AB6500
	// [XID] // 0x0000000189AB64C0-0x0000000189AB6500
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836E1B00-0x00000001836E1C00
	// [XID] // 0x0000000189AC0DB0-0x0000000189AC0DD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MatchingTextDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001836E2250-0x00000001836E2580
	// [XID] // 0x0000000189AC87F0-0x0000000189AC8810
	private static bool ParseConfigFromLine(string line, out MatchingTextDataExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836E1710-0x00000001836E1850
	// [IDTag] // 0x0000000189ACFF50-0x0000000189ACFF90
	// [XID] // 0x0000000189ACFF50-0x0000000189ACFF90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MatchingTextDataExcelConfig> configList) => default; // 0x00000001836E1850-0x00000001836E1B00
	// [IDTag] // 0x0000000189ADAC80-0x0000000189ADACC0
	// [XID] // 0x0000000189ADAC80-0x0000000189ADACC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF268A */, bool useObjectPool = false /* Metadata: 0x00AF268E */) => default; // 0x00000001836E1F50-0x00000001836E21A0
	// [IDTag] // 0x0000000189AE59A0-0x0000000189AE59E0
	// [XID] // 0x0000000189AE59A0-0x0000000189AE59E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF268F */, bool useObjectPool = false /* Metadata: 0x00AF2693 */) => default; // 0x00000001836E1C00-0x00000001836E1F50
}

