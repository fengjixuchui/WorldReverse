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

public static class GadgetGuestExcelConfigLoader // TypeDefIndex: 15648
{
	// Fields
	private static Dictionary<uint, GadgetGuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetGuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetGuestExcelConfig, GadgetGuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetGuestExcelConfig>, Dictionary<uint, GadgetGuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetGuestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A8C8D0-0x0000000189A8C8F0 */ get; } // 0x0000000184C47530-0x0000000184C475E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A9B760-0x0000000189A9B780 */ get; } // 0x0000000184C46380-0x0000000184C46420 

	// Methods
	// [XID] // 0x0000000189A84FC0-0x0000000189A84FE0
	public static void Register() {} // 0x0000000184C47910-0x0000000184C479B0
	// [XID] // 0x0000000189A93C70-0x0000000189A93C90
	public static GadgetGuestExcelConfig GetData(uint id) => default; // 0x0000000184C46250-0x0000000184C46380
	// [XID] // 0x0000000189AA2AC0-0x0000000189AA2AE0
	public static void LoadData() {} // 0x0000000184C469B0-0x0000000184C46AA0
	// [XID] // 0x0000000189AAA180-0x0000000189AAA1A0
	private static void RegisterHotfixGenerated() {} // 0x0000000184C467E0-0x0000000184C469B0
	// [XID] // 0x0000000189AB1F60-0x0000000189AB1F80
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184C46420-0x0000000184C467E0
	// [IDTag] // 0x0000000189AB91D0-0x0000000189AB9210
	// [XID] // 0x0000000189AB91D0-0x0000000189AB9210
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184C46E90-0x0000000184C46F90
	// [XID] // 0x0000000189AC4280-0x0000000189AC42A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetGuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184C475E0-0x0000000184C47910
	// [XID] // 0x0000000189ACB7B0-0x0000000189ACB7D0
	private static bool ParseConfigFromLine(string line, out GadgetGuestExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184C46AA0-0x0000000184C46BE0
	// [IDTag] // 0x0000000189AD3200-0x0000000189AD3240
	// [XID] // 0x0000000189AD3200-0x0000000189AD3240
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetGuestExcelConfig> configList) => default; // 0x0000000184C46BE0-0x0000000184C46E90
	// [IDTag] // 0x0000000189ADDEE0-0x0000000189ADDF20
	// [XID] // 0x0000000189ADDEE0-0x0000000189ADDF20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF21A2 */, bool useObjectPool = false /* Metadata: 0x00AF21A6 */) => default; // 0x0000000184C472E0-0x0000000184C47530
	// [IDTag] // 0x0000000189AE8450-0x0000000189AE8490
	// [XID] // 0x0000000189AE8450-0x0000000189AE8490
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF21A7 */, bool useObjectPool = false /* Metadata: 0x00AF21AB */) => default; // 0x0000000184C46F90-0x0000000184C472E0
}

