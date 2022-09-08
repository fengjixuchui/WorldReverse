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

public static class AsterMidGroupsExcelConfigLoader // TypeDefIndex: 15018
{
	// Fields
	private static Dictionary<uint, AsterMidGroupsExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AsterMidGroupsExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AsterMidGroupsExcelConfig, AsterMidGroupsExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AsterMidGroupsExcelConfig>, Dictionary<uint, AsterMidGroupsExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AsterMidGroupsExcelConfig> dataDict { /* [XID] */ /* 0x000000018962E450-0x000000018962E470 */ get; } // 0x0000000184344AE0-0x0000000184344B90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018963D730-0x000000018963D750 */ get; } // 0x0000000184343930-0x00000001843439D0 

	// Methods
	// [XID] // 0x0000000189626B60-0x0000000189626B80
	public static void Register() {} // 0x0000000184344EC0-0x0000000184344F60
	// [XID] // 0x0000000189636050-0x0000000189636070
	public static AsterMidGroupsExcelConfig GetData(uint id) => default; // 0x0000000184343800-0x0000000184343930
	// [XID] // 0x0000000189644CB0-0x0000000189644CD0
	public static void LoadData() {} // 0x0000000184343F60-0x0000000184344050
	// [XID] // 0x000000018964C710-0x000000018964C730
	private static void RegisterHotfixGenerated() {} // 0x0000000184343D90-0x0000000184343F60
	// [XID] // 0x0000000189653C20-0x0000000189653C40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843439D0-0x0000000184343D90
	// [IDTag] // 0x000000018965B4D0-0x000000018965B510
	// [XID] // 0x000000018965B4D0-0x000000018965B510
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184344190-0x0000000184344290
	// [XID] // 0x0000000189665AB0-0x0000000189665AD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterMidGroupsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184344B90-0x0000000184344EC0
	// [XID] // 0x000000018966D1C0-0x000000018966D1E0
	private static bool ParseConfigFromLine(string line, out AsterMidGroupsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184344050-0x0000000184344190
	// [IDTag] // 0x0000000189675110-0x0000000189675150
	// [XID] // 0x0000000189675110-0x0000000189675150
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterMidGroupsExcelConfig> configList) => default; // 0x0000000184344290-0x0000000184344540
	// [IDTag] // 0x000000018967F7E0-0x000000018967F820
	// [XID] // 0x000000018967F7E0-0x000000018967F820
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE99 */, bool useObjectPool = false /* Metadata: 0x00AEFE9D */) => default; // 0x0000000184344540-0x0000000184344790
	// [IDTag] // 0x000000018968A210-0x000000018968A250
	// [XID] // 0x000000018968A210-0x000000018968A250
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE9E */, bool useObjectPool = false /* Metadata: 0x00AEFEA2 */) => default; // 0x0000000184344790-0x0000000184344AE0
}

