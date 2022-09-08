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

public static class FlightActivityDayExcelConfigLoader // TypeDefIndex: 15118
{
	// Fields
	private static Dictionary<uint, FlightActivityDayExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FlightActivityDayExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FlightActivityDayExcelConfig, FlightActivityDayExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FlightActivityDayExcelConfig>, Dictionary<uint, FlightActivityDayExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FlightActivityDayExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B2CDF0-0x0000000189B2CE10 */ get; } // 0x000000018266F0D0-0x000000018266F180 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B3BC50-0x0000000189B3BC70 */ get; } // 0x000000018266DF20-0x000000018266DFC0 

	// Methods
	// [XID] // 0x0000000189B259C0-0x0000000189B259E0
	public static void Register() {} // 0x000000018266F4B0-0x000000018266F550
	// [XID] // 0x0000000189B34280-0x0000000189B342A0
	public static FlightActivityDayExcelConfig GetData(uint id) => default; // 0x000000018266DDF0-0x000000018266DF20
	// [XID] // 0x0000000189B435F0-0x0000000189B43610
	public static void LoadData() {} // 0x000000018266E550-0x000000018266E640
	// [XID] // 0x0000000189B4AE30-0x0000000189B4AE50
	private static void RegisterHotfixGenerated() {} // 0x000000018266E380-0x000000018266E550
	// [XID] // 0x0000000189B52440-0x0000000189B52460
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018266DFC0-0x000000018266E380
	// [IDTag] // 0x0000000189B59E00-0x0000000189B59E40
	// [XID] // 0x0000000189B59E00-0x0000000189B59E40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018266E780-0x000000018266E880
	// [XID] // 0x0000000189B645F0-0x0000000189B64610
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FlightActivityDayExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018266F180-0x000000018266F4B0
	// [XID] // 0x0000000189B6BAB0-0x0000000189B6BAD0
	private static bool ParseConfigFromLine(string line, out FlightActivityDayExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018266E640-0x000000018266E780
	// [IDTag] // 0x0000000189B73390-0x0000000189B733D0
	// [XID] // 0x0000000189B73390-0x0000000189B733D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FlightActivityDayExcelConfig> configList) => default; // 0x000000018266E880-0x000000018266EB30
	// [IDTag] // 0x0000000189B7D7C0-0x0000000189B7D800
	// [XID] // 0x0000000189B7D7C0-0x0000000189B7D800
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF014D */, bool useObjectPool = false /* Metadata: 0x00AF0151 */) => default; // 0x000000018266EB30-0x000000018266ED80
	// [IDTag] // 0x0000000189B88160-0x0000000189B881A0
	// [XID] // 0x0000000189B88160-0x0000000189B881A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0152 */, bool useObjectPool = false /* Metadata: 0x00AF0156 */) => default; // 0x000000018266ED80-0x000000018266F0D0
}

