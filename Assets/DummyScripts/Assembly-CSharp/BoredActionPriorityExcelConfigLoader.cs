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

public static class BoredActionPriorityExcelConfigLoader // TypeDefIndex: 15288
{
	// Fields
	private static List<BoredActionPriorityExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<BoredActionPriorityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BoredActionPriorityExcelConfig, BoredActionPriorityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BoredActionPriorityExcelConfig>, List<BoredActionPriorityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<BoredActionPriorityExcelConfig> dataList { /* [XID] */ /* 0x00000001899685C0-0x00000001899685E0 */ get; } // 0x0000000183478160-0x0000000183478210 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018996FAC0-0x000000018996FAE0 */ get; } // 0x0000000183476F70-0x0000000183477010 

	// Methods
	// [XID] // 0x0000000189960E80-0x0000000189960EA0
	public static void Register() {} // 0x0000000183478540-0x00000001834785E0
	// [XID] // 0x0000000189977900-0x0000000189977920
	public static void LoadData() {} // 0x0000000183477610-0x0000000183477700
	// [XID] // 0x000000018997EAC0-0x000000018997EAE0
	private static void RegisterHotfixGenerated() {} // 0x0000000183477440-0x0000000183477610
	// [XID] // 0x00000001899863F0-0x0000000189986410
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183477010-0x0000000183477440
	// [IDTag] // 0x000000018998E080-0x000000018998E0C0
	// [XID] // 0x000000018998E080-0x000000018998E0C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183477AE0-0x0000000183477BE0
	// [XID] // 0x0000000189998D10-0x0000000189998D30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BoredActionPriorityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183478210-0x0000000183478540
	// [XID] // 0x00000001899A0590-0x00000001899A05B0
	private static bool ParseConfigFromLine(string line, out BoredActionPriorityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183477700-0x0000000183477840
	// [IDTag] // 0x00000001899A80A0-0x00000001899A80E0
	// [XID] // 0x00000001899A80A0-0x00000001899A80E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BoredActionPriorityExcelConfig> configList) => default; // 0x0000000183477840-0x0000000183477AE0
	// [IDTag] // 0x00000001899B2B10-0x00000001899B2B50
	// [XID] // 0x00000001899B2B10-0x00000001899B2B50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF066F */, bool useObjectPool = false /* Metadata: 0x00AF0673 */) => default; // 0x0000000183477F10-0x0000000183478160
	// [IDTag] // 0x00000001899BCEF0-0x00000001899BCF30
	// [XID] // 0x00000001899BCEF0-0x00000001899BCF30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0674 */, bool useObjectPool = false /* Metadata: 0x00AF0678 */) => default; // 0x0000000183477BE0-0x0000000183477F10
}

