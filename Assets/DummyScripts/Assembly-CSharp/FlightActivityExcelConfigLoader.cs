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

public static class FlightActivityExcelConfigLoader // TypeDefIndex: 15113
{
	// Fields
	private static Dictionary<uint, FlightActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FlightActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FlightActivityExcelConfig, FlightActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FlightActivityExcelConfig>, Dictionary<uint, FlightActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FlightActivityExcelConfig> dataDict { /* [XID] */ /* 0x00000001898D6B20-0x00000001898D6B40 */ get; } // 0x00000001847128B0-0x0000000184712960 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898E5FE0-0x00000001898E6000 */ get; } // 0x0000000184711700-0x00000001847117A0 

	// Methods
	// [XID] // 0x00000001898CF2F0-0x00000001898CF310
	public static void Register() {} // 0x0000000184712C90-0x0000000184712D30
	// [XID] // 0x00000001898DE7C0-0x00000001898DE7E0
	public static FlightActivityExcelConfig GetData(uint activity_id) => default; // 0x00000001847115D0-0x0000000184711700
	// [XID] // 0x00000001898ED900-0x00000001898ED920
	public static void LoadData() {} // 0x0000000184711D30-0x0000000184711E20
	// [XID] // 0x00000001898F51A0-0x00000001898F51C0
	private static void RegisterHotfixGenerated() {} // 0x0000000184711B60-0x0000000184711D30
	// [XID] // 0x00000001898FC8B0-0x00000001898FC8D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847117A0-0x0000000184711B60
	// [IDTag] // 0x00000001899042D0-0x0000000189904310
	// [XID] // 0x00000001899042D0-0x0000000189904310
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184712210-0x0000000184712310
	// [XID] // 0x000000018990EC50-0x000000018990EC70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FlightActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184712960-0x0000000184712C90
	// [XID] // 0x00000001899163A0-0x00000001899163C0
	private static bool ParseConfigFromLine(string line, out FlightActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184711E20-0x0000000184711F60
	// [IDTag] // 0x000000018991DCB0-0x000000018991DCF0
	// [XID] // 0x000000018991DCB0-0x000000018991DCF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FlightActivityExcelConfig> configList) => default; // 0x0000000184711F60-0x0000000184712210
	// [IDTag] // 0x00000001899284F0-0x0000000189928530
	// [XID] // 0x00000001899284F0-0x0000000189928530
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF012A */, bool useObjectPool = false /* Metadata: 0x00AF012E */) => default; // 0x0000000184712310-0x0000000184712560
	// [IDTag] // 0x0000000189932B00-0x0000000189932B40
	// [XID] // 0x0000000189932B00-0x0000000189932B40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF012F */, bool useObjectPool = false /* Metadata: 0x00AF0133 */) => default; // 0x0000000184712560-0x00000001847128B0
}

