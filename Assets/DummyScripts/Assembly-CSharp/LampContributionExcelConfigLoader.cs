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

public static class LampContributionExcelConfigLoader // TypeDefIndex: 15175
{
	// Fields
	private static Dictionary<uint, LampContributionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LampContributionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LampContributionExcelConfig, LampContributionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LampContributionExcelConfig>, Dictionary<uint, LampContributionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, LampContributionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189652380-0x00000001896523A0 */ get; } // 0x0000000183A90220-0x0000000183A902D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189661210-0x0000000189661230 */ get; } // 0x0000000183A8F070-0x0000000183A8F110 

	// Methods
	// [XID] // 0x000000018964ABC0-0x000000018964ABE0
	public static void Register() {} // 0x0000000183A90600-0x0000000183A906A0
	// [XID] // 0x0000000189659AB0-0x0000000189659AD0
	public static LampContributionExcelConfig GetData(uint id) => default; // 0x0000000183A8EF40-0x0000000183A8F070
	// [XID] // 0x0000000189668CE0-0x0000000189668D00
	public static void LoadData() {} // 0x0000000183A8F6A0-0x0000000183A8F790
	// [XID] // 0x0000000189670810-0x0000000189670830
	private static void RegisterHotfixGenerated() {} // 0x0000000183A8F4D0-0x0000000183A8F6A0
	// [XID] // 0x0000000189678010-0x0000000189678030
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183A8F110-0x0000000183A8F4D0
	// [IDTag] // 0x000000018967F6E0-0x000000018967F720
	// [XID] // 0x000000018967F6E0-0x000000018967F720
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183A8FB80-0x0000000183A8FC80
	// [XID] // 0x000000018968A150-0x000000018968A170
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LampContributionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183A902D0-0x0000000183A90600
	// [XID] // 0x0000000189691F50-0x0000000189691F70
	private static bool ParseConfigFromLine(string line, out LampContributionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183A8F790-0x0000000183A8F8D0
	// [IDTag] // 0x0000000189699440-0x0000000189699480
	// [XID] // 0x0000000189699440-0x0000000189699480
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LampContributionExcelConfig> configList) => default; // 0x0000000183A8F8D0-0x0000000183A8FB80
	// [IDTag] // 0x00000001896A3800-0x00000001896A3840
	// [XID] // 0x00000001896A3800-0x00000001896A3840
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF02EA */, bool useObjectPool = false /* Metadata: 0x00AF02EE */) => default; // 0x0000000183A8FFD0-0x0000000183A90220
	// [IDTag] // 0x00000001896ADAB0-0x00000001896ADAF0
	// [XID] // 0x00000001896ADAB0-0x00000001896ADAF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02EF */, bool useObjectPool = false /* Metadata: 0x00AF02F3 */) => default; // 0x0000000183A8FC80-0x0000000183A8FFD0
}

