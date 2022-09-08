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

public static class EnvAnimalGatherExcelConfigLoader // TypeDefIndex: 15572
{
	// Fields
	private static List<EnvAnimalGatherExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<EnvAnimalGatherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EnvAnimalGatherExcelConfig, EnvAnimalGatherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EnvAnimalGatherExcelConfig>, List<EnvAnimalGatherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<EnvAnimalGatherExcelConfig> dataList { /* [XID] */ /* 0x0000000189AD3260-0x0000000189AD3280 */ get; } // 0x000000018409AE40-0x000000018409AEF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ADACE0-0x0000000189ADAD00 */ get; } // 0x0000000184099C50-0x0000000184099CF0 

	// Methods
	// [XID] // 0x0000000189ACB7F0-0x0000000189ACB810
	public static void Register() {} // 0x000000018409B220-0x000000018409B2C0
	// [XID] // 0x0000000189AE2480-0x0000000189AE24A0
	public static void LoadData() {} // 0x000000018409A2F0-0x000000018409A3E0
	// [XID] // 0x0000000189AE9D90-0x0000000189AE9DB0
	private static void RegisterHotfixGenerated() {} // 0x000000018409A120-0x000000018409A2F0
	// [XID] // 0x0000000189AF1B90-0x0000000189AF1BB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184099CF0-0x000000018409A120
	// [IDTag] // 0x0000000189AF9330-0x0000000189AF9370
	// [XID] // 0x0000000189AF9330-0x0000000189AF9370
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018409A520-0x000000018409A620
	// [XID] // 0x0000000189B03670-0x0000000189B03690
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EnvAnimalGatherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018409AEF0-0x000000018409B220
	// [XID] // 0x0000000189B0ADE0-0x0000000189B0AE00
	private static bool ParseConfigFromLine(string line, out EnvAnimalGatherExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018409A3E0-0x000000018409A520
	// [IDTag] // 0x0000000189B12640-0x0000000189B12680
	// [XID] // 0x0000000189B12640-0x0000000189B12680
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EnvAnimalGatherExcelConfig> configList) => default; // 0x000000018409A620-0x000000018409A8C0
	// [IDTag] // 0x0000000189B1CC90-0x0000000189B1CCD0
	// [XID] // 0x0000000189B1CC90-0x0000000189B1CCD0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F70 */, bool useObjectPool = false /* Metadata: 0x00AF1F74 */) => default; // 0x000000018409ABF0-0x000000018409AE40
	// [IDTag] // 0x0000000189B271A0-0x0000000189B271E0
	// [XID] // 0x0000000189B271A0-0x0000000189B271E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F75 */, bool useObjectPool = false /* Metadata: 0x00AF1F79 */) => default; // 0x000000018409A8C0-0x000000018409ABF0
}

