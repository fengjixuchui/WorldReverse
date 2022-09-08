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

public static class UidOpNotifyExcelConfigLoader // TypeDefIndex: 16038
{
	// Fields
	private static Dictionary<uint, UidOpNotifyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<UidOpNotifyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<UidOpNotifyExcelConfig, UidOpNotifyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<UidOpNotifyExcelConfig>, Dictionary<uint, UidOpNotifyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, UidOpNotifyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189835410-0x0000000189835430 */ get; } // 0x0000000184912B80-0x0000000184912C30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189844260-0x0000000189844280 */ get; } // 0x00000001849119D0-0x0000000184911A70 

	// Methods
	// [XID] // 0x000000018982DD60-0x000000018982DD80
	public static void Register() {} // 0x0000000184912F60-0x0000000184913000
	// [XID] // 0x000000018983CB90-0x000000018983CBB0
	public static UidOpNotifyExcelConfig GetData(uint id) => default; // 0x00000001849118A0-0x00000001849119D0
	// [XID] // 0x000000018984B6D0-0x000000018984B6F0
	public static void LoadData() {} // 0x0000000184912000-0x00000001849120F0
	// [XID] // 0x0000000189852760-0x0000000189852780
	private static void RegisterHotfixGenerated() {} // 0x0000000184911E30-0x0000000184912000
	// [XID] // 0x000000018985A210-0x000000018985A230
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184911A70-0x0000000184911E30
	// [IDTag] // 0x0000000189861370-0x00000001898613B0
	// [XID] // 0x0000000189861370-0x00000001898613B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001849124E0-0x00000001849125E0
	// [XID] // 0x000000018986BB60-0x000000018986BB80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<UidOpNotifyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184912C30-0x0000000184912F60
	// [XID] // 0x0000000189872E10-0x0000000189872E30
	private static bool ParseConfigFromLine(string line, out UidOpNotifyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001849120F0-0x0000000184912230
	// [IDTag] // 0x000000018987AB30-0x000000018987AB70
	// [XID] // 0x000000018987AB30-0x000000018987AB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<UidOpNotifyExcelConfig> configList) => default; // 0x0000000184912230-0x00000001849124E0
	// [IDTag] // 0x0000000189884A30-0x0000000189884A70
	// [XID] // 0x0000000189884A30-0x0000000189884A70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E91 */, bool useObjectPool = false /* Metadata: 0x00AF2E95 */) => default; // 0x00000001849125E0-0x0000000184912830
	// [IDTag] // 0x000000018988EEC0-0x000000018988EF00
	// [XID] // 0x000000018988EEC0-0x000000018988EF00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E96 */, bool useObjectPool = false /* Metadata: 0x00AF2E9A */) => default; // 0x0000000184912830-0x0000000184912B80
}

