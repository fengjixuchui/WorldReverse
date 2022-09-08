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

public static class FleurFairTipsExcelConfigLoader // TypeDefIndex: 15104
{
	// Fields
	private static Dictionary<uint, FleurFairTipsExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairTipsExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairTipsExcelConfig, FleurFairTipsExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairTipsExcelConfig>, Dictionary<uint, FleurFairTipsExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairTipsExcelConfig> dataDict { /* [XID] */ /* 0x000000018988D7C0-0x000000018988D7E0 */ get; } // 0x0000000184144DB0-0x0000000184144E60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018989C600-0x000000018989C620 */ get; } // 0x0000000184143C00-0x0000000184143CA0 

	// Methods
	// [XID] // 0x00000001898865E0-0x0000000189886600
	public static void Register() {} // 0x0000000184145190-0x0000000184145230
	// [XID] // 0x0000000189894ED0-0x0000000189894EF0
	public static FleurFairTipsExcelConfig GetData(uint id) => default; // 0x0000000184143AD0-0x0000000184143C00
	// [XID] // 0x00000001898A3D60-0x00000001898A3D80
	public static void LoadData() {} // 0x0000000184144230-0x0000000184144320
	// [XID] // 0x00000001898AAFE0-0x00000001898AB000
	private static void RegisterHotfixGenerated() {} // 0x0000000184144060-0x0000000184144230
	// [XID] // 0x00000001898B28B0-0x00000001898B28D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184143CA0-0x0000000184144060
	// [IDTag] // 0x00000001898BA700-0x00000001898BA740
	// [XID] // 0x00000001898BA700-0x00000001898BA740
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184144460-0x0000000184144560
	// [XID] // 0x00000001898C4BC0-0x00000001898C4BE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairTipsExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184144E60-0x0000000184145190
	// [XID] // 0x00000001898CBFF0-0x00000001898CC010
	private static bool ParseConfigFromLine(string line, out FleurFairTipsExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184144320-0x0000000184144460
	// [IDTag] // 0x00000001898D3870-0x00000001898D38B0
	// [XID] // 0x00000001898D3870-0x00000001898D38B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairTipsExcelConfig> configList) => default; // 0x0000000184144560-0x0000000184144810
	// [IDTag] // 0x00000001898DE7E0-0x00000001898DE820
	// [XID] // 0x00000001898DE7E0-0x00000001898DE820
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF00E9 */, bool useObjectPool = false /* Metadata: 0x00AF00ED */) => default; // 0x0000000184144810-0x0000000184144A60
	// [IDTag] // 0x00000001898E9280-0x00000001898E92C0
	// [XID] // 0x00000001898E9280-0x00000001898E92C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00EE */, bool useObjectPool = false /* Metadata: 0x00AF00F2 */) => default; // 0x0000000184144A60-0x0000000184144DB0
}

