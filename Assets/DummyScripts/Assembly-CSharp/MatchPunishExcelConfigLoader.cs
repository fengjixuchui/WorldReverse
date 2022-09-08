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

public static class MatchPunishExcelConfigLoader // TypeDefIndex: 15810
{
	// Fields
	private static Dictionary<uint, MatchPunishExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MatchPunishExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MatchPunishExcelConfig, MatchPunishExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MatchPunishExcelConfig>, Dictionary<uint, MatchPunishExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MatchPunishExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B7BEB0-0x0000000189B7BED0 */ get; } // 0x0000000185461DB0-0x0000000185461E60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B8AB50-0x0000000189B8AB70 */ get; } // 0x0000000185460C00-0x0000000185460CA0 

	// Methods
	// [XID] // 0x0000000189B74890-0x0000000189B748B0
	public static void Register() {} // 0x0000000185462190-0x0000000185462230
	// [XID] // 0x0000000189B83800-0x0000000189B83820
	public static MatchPunishExcelConfig GetData(uint times) => default; // 0x0000000185460AD0-0x0000000185460C00
	// [XID] // 0x0000000189B92200-0x0000000189B92220
	public static void LoadData() {} // 0x0000000185461230-0x0000000185461320
	// [XID] // 0x0000000189B99700-0x0000000189B99720
	private static void RegisterHotfixGenerated() {} // 0x0000000185461060-0x0000000185461230
	// [XID] // 0x0000000189BA0D30-0x0000000189BA0D50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185460CA0-0x0000000185461060
	// [IDTag] // 0x0000000189BA83B0-0x0000000189BA83F0
	// [XID] // 0x0000000189BA83B0-0x0000000189BA83F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185461710-0x0000000185461810
	// [XID] // 0x0000000189BB2930-0x0000000189BB2950
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MatchPunishExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185461E60-0x0000000185462190
	// [XID] // 0x0000000189BB9D60-0x0000000189BB9D80
	private static bool ParseConfigFromLine(string line, out MatchPunishExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185461320-0x0000000185461460
	// [IDTag] // 0x0000000189BC1D30-0x0000000189BC1D70
	// [XID] // 0x0000000189BC1D30-0x0000000189BC1D70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MatchPunishExcelConfig> configList) => default; // 0x0000000185461460-0x0000000185461710
	// [IDTag] // 0x0000000189BCC4C0-0x0000000189BCC500
	// [XID] // 0x0000000189BCC4C0-0x0000000189BCC500
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2699 */, bool useObjectPool = false /* Metadata: 0x00AF269D */) => default; // 0x0000000185461810-0x0000000185461A60
	// [IDTag] // 0x0000000189BD67A0-0x0000000189BD67E0
	// [XID] // 0x0000000189BD67A0-0x0000000189BD67E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF269E */, bool useObjectPool = false /* Metadata: 0x00AF26A2 */) => default; // 0x0000000185461A60-0x0000000185461DB0
}

