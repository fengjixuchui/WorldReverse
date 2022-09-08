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

public static class MonsterTitleExcelConfigLoader // TypeDefIndex: 15851
{
	// Fields
	private static Dictionary<uint, MonsterTitleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterTitleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterTitleExcelConfig, MonsterTitleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterTitleExcelConfig>, Dictionary<uint, MonsterTitleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterTitleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189820B70-0x0000000189820B90 */ get; } // 0x00000001832ACB60-0x00000001832ACC10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018982F3C0-0x000000018982F3E0 */ get; } // 0x00000001832AB9B0-0x00000001832ABA50 

	// Methods
	// [XID] // 0x0000000189819390-0x00000001898193B0
	public static void Register() {} // 0x00000001832ACF40-0x00000001832ACFE0
	// [XID] // 0x0000000189828120-0x0000000189828140
	public static MonsterTitleExcelConfig GetData(uint titleID) => default; // 0x00000001832AB880-0x00000001832AB9B0
	// [XID] // 0x0000000189836CB0-0x0000000189836CD0
	public static void LoadData() {} // 0x00000001832ABFE0-0x00000001832AC0D0
	// [XID] // 0x000000018983E0E0-0x000000018983E100
	private static void RegisterHotfixGenerated() {} // 0x00000001832ABE10-0x00000001832ABFE0
	// [XID] // 0x00000001898458B0-0x00000001898458D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001832ABA50-0x00000001832ABE10
	// [IDTag] // 0x000000018984CE40-0x000000018984CE80
	// [XID] // 0x000000018984CE40-0x000000018984CE80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001832AC4C0-0x00000001832AC5C0
	// [XID] // 0x0000000189856FA0-0x0000000189856FC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterTitleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001832ACC10-0x00000001832ACF40
	// [XID] // 0x000000018985E130-0x000000018985E150
	private static bool ParseConfigFromLine(string line, out MonsterTitleExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001832AC0D0-0x00000001832AC210
	// [IDTag] // 0x0000000189865B30-0x0000000189865B70
	// [XID] // 0x0000000189865B30-0x0000000189865B70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterTitleExcelConfig> configList) => default; // 0x00000001832AC210-0x00000001832AC4C0
	// [IDTag] // 0x000000018986FFE0-0x0000000189870020
	// [XID] // 0x000000018986FFE0-0x0000000189870020
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2859 */, bool useObjectPool = false /* Metadata: 0x00AF285D */) => default; // 0x00000001832AC910-0x00000001832ACB60
	// [IDTag] // 0x000000018987ABD0-0x000000018987AC10
	// [XID] // 0x000000018987ABD0-0x000000018987AC10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF285E */, bool useObjectPool = false /* Metadata: 0x00AF2862 */) => default; // 0x00000001832AC5C0-0x00000001832AC910
}

