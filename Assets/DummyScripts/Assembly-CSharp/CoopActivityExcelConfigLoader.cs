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

public static class CoopActivityExcelConfigLoader // TypeDefIndex: 15465
{
	// Fields
	private static Dictionary<uint, CoopActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CoopActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CoopActivityExcelConfig, CoopActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CoopActivityExcelConfig>, Dictionary<uint, CoopActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CoopActivityExcelConfig> dataDict { /* [XID] */ /* 0x00000001897240D0-0x00000001897240F0 */ get; } // 0x0000000185132A30-0x0000000185132AE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189733000-0x0000000189733020 */ get; } // 0x0000000185131880-0x0000000185131920 

	// Methods
	// [XID] // 0x000000018971CC60-0x000000018971CC80
	public static void Register() {} // 0x0000000185132E10-0x0000000185132EB0
	// [XID] // 0x000000018972B830-0x000000018972B850
	public static CoopActivityExcelConfig GetData(uint activityId) => default; // 0x0000000185131750-0x0000000185131880
	// [XID] // 0x000000018973A670-0x000000018973A690
	public static void LoadData() {} // 0x0000000185131EB0-0x0000000185131FA0
	// [XID] // 0x0000000189742060-0x0000000189742080
	private static void RegisterHotfixGenerated() {} // 0x0000000185131CE0-0x0000000185131EB0
	// [XID] // 0x0000000189749AC0-0x0000000189749AE0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185131920-0x0000000185131CE0
	// [IDTag] // 0x0000000189750F80-0x0000000189750FC0
	// [XID] // 0x0000000189750F80-0x0000000189750FC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001851320E0-0x00000001851321E0
	// [XID] // 0x000000018975B420-0x000000018975B440
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185132AE0-0x0000000185132E10
	// [XID] // 0x0000000189762E30-0x0000000189762E50
	private static bool ParseConfigFromLine(string line, out CoopActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185131FA0-0x00000001851320E0
	// [IDTag] // 0x000000018976A410-0x000000018976A450
	// [XID] // 0x000000018976A410-0x000000018976A450
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopActivityExcelConfig> configList) => default; // 0x00000001851321E0-0x0000000185132490
	// [IDTag] // 0x0000000189774810-0x0000000189774850
	// [XID] // 0x0000000189774810-0x0000000189774850
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1B3B */, bool useObjectPool = false /* Metadata: 0x00AF1B3F */) => default; // 0x00000001851327E0-0x0000000185132A30
	// [IDTag] // 0x000000018977F040-0x000000018977F080
	// [XID] // 0x000000018977F040-0x000000018977F080
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B40 */, bool useObjectPool = false /* Metadata: 0x00AF1B44 */) => default; // 0x0000000185132490-0x00000001851327E0
}

