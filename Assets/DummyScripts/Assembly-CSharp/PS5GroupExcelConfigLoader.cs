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

public static class PS5GroupExcelConfigLoader // TypeDefIndex: 15000
{
	// Fields
	private static Dictionary<uint, PS5GroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PS5GroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PS5GroupExcelConfig, PS5GroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PS5GroupExcelConfig>, Dictionary<uint, PS5GroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PS5GroupExcelConfig> dataDict { /* [XID] */ /* 0x0000000189848580-0x00000001898485A0 */ get; } // 0x0000000181987B80-0x0000000181987C30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189857140-0x0000000189857160 */ get; } // 0x00000001819869D0-0x0000000181986A70 

	// Methods
	// [XID] // 0x00000001898410C0-0x00000001898410E0
	public static void Register() {} // 0x0000000181987F60-0x0000000181988000
	// [XID] // 0x000000018984FCE0-0x000000018984FD00
	public static PS5GroupExcelConfig GetData(uint id) => default; // 0x00000001819868A0-0x00000001819869D0
	// [XID] // 0x000000018985E2D0-0x000000018985E2F0
	public static void LoadData() {} // 0x0000000181987000-0x00000001819870F0
	// [XID] // 0x0000000189865C90-0x0000000189865CB0
	private static void RegisterHotfixGenerated() {} // 0x0000000181986E30-0x0000000181987000
	// [XID] // 0x000000018986D210-0x000000018986D230
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181986A70-0x0000000181986E30
	// [IDTag] // 0x00000001898745C0-0x0000000189874600
	// [XID] // 0x00000001898745C0-0x0000000189874600
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001819874E0-0x00000001819875E0
	// [XID] // 0x000000018987F040-0x000000018987F060
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PS5GroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181987C30-0x0000000181987F60
	// [XID] // 0x0000000189886640-0x0000000189886660
	private static bool ParseConfigFromLine(string line, out PS5GroupExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001819870F0-0x0000000181987230
	// [IDTag] // 0x000000018988D880-0x000000018988D8C0
	// [XID] // 0x000000018988D880-0x000000018988D8C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PS5GroupExcelConfig> configList) => default; // 0x0000000181987230-0x00000001819874E0
	// [IDTag] // 0x0000000189897DE0-0x0000000189897E20
	// [XID] // 0x0000000189897DE0-0x0000000189897E20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE11 */, bool useObjectPool = false /* Metadata: 0x00AEFE15 */) => default; // 0x00000001819875E0-0x0000000181987830
	// [IDTag] // 0x00000001898A2340-0x00000001898A2380
	// [XID] // 0x00000001898A2340-0x00000001898A2380
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE16 */, bool useObjectPool = false /* Metadata: 0x00AEFE1A */) => default; // 0x0000000181987830-0x0000000181987B80
}

