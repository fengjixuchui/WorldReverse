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

public static class ReputationFunctionExcelConfigLoader // TypeDefIndex: 16051
{
	// Fields
	private static Dictionary<uint, ReputationFunctionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationFunctionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationFunctionExcelConfig, ReputationFunctionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationFunctionExcelConfig>, Dictionary<uint, ReputationFunctionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReputationFunctionExcelConfig> dataDict { /* [XID] */ /* 0x00000001898BA500-0x00000001898BA520 */ get; } // 0x0000000182D06380-0x0000000182D06430 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898C90E0-0x00000001898C9100 */ get; } // 0x0000000182D051D0-0x0000000182D05270 

	// Methods
	// [XID] // 0x00000001898B2730-0x00000001898B2750
	public static void Register() {} // 0x0000000182D06760-0x0000000182D06800
	// [XID] // 0x00000001898C1800-0x00000001898C1820
	public static ReputationFunctionExcelConfig GetData(uint functionId) => default; // 0x0000000182D050A0-0x0000000182D051D0
	// [XID] // 0x00000001898D0920-0x00000001898D0940
	public static void LoadData() {} // 0x0000000182D05800-0x0000000182D058F0
	// [XID] // 0x00000001898D8000-0x00000001898D8020
	private static void RegisterHotfixGenerated() {} // 0x0000000182D05630-0x0000000182D05800
	// [XID] // 0x00000001898DFEA0-0x00000001898DFEC0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D05270-0x0000000182D05630
	// [IDTag] // 0x00000001898E78D0-0x00000001898E7910
	// [XID] // 0x00000001898E78D0-0x00000001898E7910
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D05CE0-0x0000000182D05DE0
	// [XID] // 0x00000001898F2010-0x00000001898F2030
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationFunctionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D06430-0x0000000182D06760
	// [XID] // 0x00000001898F97D0-0x00000001898F97F0
	private static bool ParseConfigFromLine(string line, out ReputationFunctionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D058F0-0x0000000182D05A30
	// [IDTag] // 0x00000001899010F0-0x0000000189901130
	// [XID] // 0x00000001899010F0-0x0000000189901130
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationFunctionExcelConfig> configList) => default; // 0x0000000182D05A30-0x0000000182D05CE0
	// [IDTag] // 0x000000018990B750-0x000000018990B790
	// [XID] // 0x000000018990B750-0x000000018990B790
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2EF1 */, bool useObjectPool = false /* Metadata: 0x00AF2EF5 */) => default; // 0x0000000182D06130-0x0000000182D06380
	// [IDTag] // 0x00000001899160A0-0x00000001899160E0
	// [XID] // 0x00000001899160A0-0x00000001899160E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EF6 */, bool useObjectPool = false /* Metadata: 0x00AF2EFA */) => default; // 0x0000000182D05DE0-0x0000000182D06130
}

