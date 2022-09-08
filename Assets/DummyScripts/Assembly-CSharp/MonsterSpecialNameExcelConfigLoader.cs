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

public static class MonsterSpecialNameExcelConfigLoader // TypeDefIndex: 15853
{
	// Fields
	private static Dictionary<uint, MonsterSpecialNameExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterSpecialNameExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterSpecialNameExcelConfig, MonsterSpecialNameExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterSpecialNameExcelConfig>, Dictionary<uint, MonsterSpecialNameExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterSpecialNameExcelConfig> dataDict { /* [XID] */ /* 0x000000018994D530-0x000000018994D550 */ get; } // 0x0000000183686C70-0x0000000183686D20 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018995C440-0x000000018995C460 */ get; } // 0x0000000183685AC0-0x0000000183685B60 

	// Methods
	// [XID] // 0x0000000189946020-0x0000000189946040
	public static void Register() {} // 0x0000000183687050-0x00000001836870F0
	// [XID] // 0x0000000189954BC0-0x0000000189954BE0
	public static MonsterSpecialNameExcelConfig GetData(uint specialNameID) => default; // 0x0000000183685990-0x0000000183685AC0
	// [XID] // 0x0000000189963E60-0x0000000189963E80
	public static void LoadData() {} // 0x00000001836860F0-0x00000001836861E0
	// [XID] // 0x000000018996B350-0x000000018996B370
	private static void RegisterHotfixGenerated() {} // 0x0000000183685F20-0x00000001836860F0
	// [XID] // 0x0000000189972E50-0x0000000189972E70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183685B60-0x0000000183685F20
	// [IDTag] // 0x000000018997A730-0x000000018997A770
	// [XID] // 0x000000018997A730-0x000000018997A770
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183686320-0x0000000183686420
	// [XID] // 0x0000000189984B50-0x0000000189984B70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterSpecialNameExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183686D20-0x0000000183687050
	// [XID] // 0x000000018998C710-0x000000018998C730
	private static bool ParseConfigFromLine(string line, out MonsterSpecialNameExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836861E0-0x0000000183686320
	// [IDTag] // 0x0000000189994450-0x0000000189994490
	// [XID] // 0x0000000189994450-0x0000000189994490
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterSpecialNameExcelConfig> configList) => default; // 0x0000000183686420-0x00000001836866D0
	// [IDTag] // 0x000000018999EE10-0x000000018999EE50
	// [XID] // 0x000000018999EE10-0x000000018999EE50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2868 */, bool useObjectPool = false /* Metadata: 0x00AF286C */) => default; // 0x0000000183686A20-0x0000000183686C70
	// [IDTag] // 0x00000001899A96C0-0x00000001899A9700
	// [XID] // 0x00000001899A96C0-0x00000001899A9700
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF286D */, bool useObjectPool = false /* Metadata: 0x00AF2871 */) => default; // 0x00000001836866D0-0x0000000183686A20
}

