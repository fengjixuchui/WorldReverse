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

public static class CoopInteractionExcelConfigLoader // TypeDefIndex: 15459
{
	// Fields
	private static Dictionary<uint, CoopInteractionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CoopInteractionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CoopInteractionExcelConfig, CoopInteractionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CoopInteractionExcelConfig>, Dictionary<uint, CoopInteractionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CoopInteractionExcelConfig> dataDict { /* [XID] */ /* 0x000000018970F7C0-0x000000018970F7E0 */ get; } // 0x000000018263B320-0x000000018263B3D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018971E460-0x000000018971E480 */ get; } // 0x000000018263A170-0x000000018263A210 

	// Methods
	// [XID] // 0x0000000189707C10-0x0000000189707C30
	public static void Register() {} // 0x000000018263B700-0x000000018263B7A0
	// [XID] // 0x00000001896F6780-0x00000001896F67A0
	public static CoopInteractionExcelConfig GetData(uint id) => default; // 0x000000018263A040-0x000000018263A170
	// [XID] // 0x0000000189725A20-0x0000000189725A40
	public static void LoadData() {} // 0x000000018263A7A0-0x000000018263A890
	// [XID] // 0x000000018972CFE0-0x000000018972D000
	private static void RegisterHotfixGenerated() {} // 0x000000018263A5D0-0x000000018263A7A0
	// [XID] // 0x0000000189734770-0x0000000189734790
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018263A210-0x000000018263A5D0
	// [IDTag] // 0x000000018973C120-0x000000018973C160
	// [XID] // 0x000000018973C120-0x000000018973C160
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018263AC80-0x000000018263AD80
	// [XID] // 0x0000000189746960-0x0000000189746980
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopInteractionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018263B3D0-0x000000018263B700
	// [XID] // 0x000000018974E310-0x000000018974E330
	private static bool ParseConfigFromLine(string line, out CoopInteractionExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018263A890-0x000000018263A9D0
	// [IDTag] // 0x0000000189755910-0x0000000189755950
	// [XID] // 0x0000000189755910-0x0000000189755950
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopInteractionExcelConfig> configList) => default; // 0x000000018263A9D0-0x000000018263AC80
	// [IDTag] // 0x000000018975FEB0-0x000000018975FEF0
	// [XID] // 0x000000018975FEB0-0x000000018975FEF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1B18 */, bool useObjectPool = false /* Metadata: 0x00AF1B1C */) => default; // 0x000000018263AD80-0x000000018263AFD0
	// [IDTag] // 0x000000018976A450-0x000000018976A490
	// [XID] // 0x000000018976A450-0x000000018976A490
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B1D */, bool useObjectPool = false /* Metadata: 0x00AF1B21 */) => default; // 0x000000018263AFD0-0x000000018263B320
}

