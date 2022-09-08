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

public static class OptionExcelConfigLoader // TypeDefIndex: 15666
{
	// Fields
	private static Dictionary<uint, OptionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<OptionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<OptionExcelConfig, OptionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OptionExcelConfig>, Dictionary<uint, OptionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, OptionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189785380-0x00000001897853A0 */ get; } // 0x000000018274A7D0-0x000000018274A880 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189793CE0-0x0000000189793D00 */ get; } // 0x0000000182749620-0x00000001827496C0 

	// Methods
	// [XID] // 0x000000018977DB60-0x000000018977DB80
	public static void Register() {} // 0x000000018274ABB0-0x000000018274AC50
	// [XID] // 0x000000018978C850-0x000000018978C870
	public static OptionExcelConfig GetData(uint id) => default; // 0x00000001827494F0-0x0000000182749620
	// [XID] // 0x000000018979C050-0x000000018979C070
	public static void LoadData() {} // 0x0000000182749C50-0x0000000182749D40
	// [XID] // 0x00000001897A3560-0x00000001897A3580
	private static void RegisterHotfixGenerated() {} // 0x0000000182749A80-0x0000000182749C50
	// [XID] // 0x00000001897AAB00-0x00000001897AAB20
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001827496C0-0x0000000182749A80
	// [IDTag] // 0x00000001897B2650-0x00000001897B2690
	// [XID] // 0x00000001897B2650-0x00000001897B2690
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018274A130-0x000000018274A230
	// [XID] // 0x00000001897BDB20-0x00000001897BDB40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OptionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018274A880-0x000000018274ABB0
	// [XID] // 0x00000001897C4EC0-0x00000001897C4EE0
	private static bool ParseConfigFromLine(string line, out OptionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182749D40-0x0000000182749E80
	// [IDTag] // 0x00000001897CC710-0x00000001897CC750
	// [XID] // 0x00000001897CC710-0x00000001897CC750
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OptionExcelConfig> configList) => default; // 0x0000000182749E80-0x000000018274A130
	// [IDTag] // 0x00000001897D7040-0x00000001897D7080
	// [XID] // 0x00000001897D7040-0x00000001897D7080
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2247 */, bool useObjectPool = false /* Metadata: 0x00AF224B */) => default; // 0x000000018274A580-0x000000018274A7D0
	// [IDTag] // 0x00000001897E1860-0x00000001897E18A0
	// [XID] // 0x00000001897E1860-0x00000001897E18A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF224C */, bool useObjectPool = false /* Metadata: 0x00AF2250 */) => default; // 0x000000018274A230-0x000000018274A580
}

