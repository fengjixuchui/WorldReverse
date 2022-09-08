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

public static class ActivitySalesmanExcelConfigLoader // TypeDefIndex: 15170
{
	// Fields
	private static Dictionary<uint, ActivitySalesmanExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivitySalesmanExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivitySalesmanExcelConfig, ActivitySalesmanExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivitySalesmanExcelConfig>, Dictionary<uint, ActivitySalesmanExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivitySalesmanExcelConfig> dataDict { /* [XID] */ /* 0x00000001899BFF90-0x00000001899BFFB0 */ get; } // 0x0000000183818F50-0x0000000183819000 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899CEEA0-0x00000001899CEEC0 */ get; } // 0x0000000183817DA0-0x0000000183817E40 

	// Methods
	// [XID] // 0x00000001899B8430-0x00000001899B8450
	public static void Register() {} // 0x0000000183819330-0x00000001838193D0
	// [XID] // 0x00000001899C7790-0x00000001899C77B0
	public static ActivitySalesmanExcelConfig GetData(uint scheduleId) => default; // 0x0000000183817C70-0x0000000183817DA0
	// [XID] // 0x00000001899D64D0-0x00000001899D64F0
	public static void LoadData() {} // 0x00000001838183D0-0x00000001838184C0
	// [XID] // 0x00000001899DDA20-0x00000001899DDA40
	private static void RegisterHotfixGenerated() {} // 0x0000000183818200-0x00000001838183D0
	// [XID] // 0x00000001899E57E0-0x00000001899E5800
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183817E40-0x0000000183818200
	// [IDTag] // 0x00000001899EC910-0x00000001899EC950
	// [XID] // 0x00000001899EC910-0x00000001899EC950
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001838188B0-0x00000001838189B0
	// [XID] // 0x00000001899F72F0-0x00000001899F7310
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivitySalesmanExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183819000-0x0000000183819330
	// [XID] // 0x00000001899FEA70-0x00000001899FEA90
	private static bool ParseConfigFromLine(string line, out ActivitySalesmanExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001838184C0-0x0000000183818600
	// [IDTag] // 0x0000000189A06230-0x0000000189A06270
	// [XID] // 0x0000000189A06230-0x0000000189A06270
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivitySalesmanExcelConfig> configList) => default; // 0x0000000183818600-0x00000001838188B0
	// [IDTag] // 0x0000000189A104D0-0x0000000189A10510
	// [XID] // 0x0000000189A104D0-0x0000000189A10510
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF02C2 */, bool useObjectPool = false /* Metadata: 0x00AF02C6 */) => default; // 0x0000000183818D00-0x0000000183818F50
	// [IDTag] // 0x0000000189A1A930-0x0000000189A1A970
	// [XID] // 0x0000000189A1A930-0x0000000189A1A970
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02C7 */, bool useObjectPool = false /* Metadata: 0x00AF02CB */) => default; // 0x00000001838189B0-0x0000000183818D00
}

