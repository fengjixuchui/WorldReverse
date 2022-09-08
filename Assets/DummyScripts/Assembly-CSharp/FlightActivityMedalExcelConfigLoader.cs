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

public static class FlightActivityMedalExcelConfigLoader // TypeDefIndex: 15116
{
	// Fields
	private static Dictionary<uint, FlightActivityMedalExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FlightActivityMedalExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FlightActivityMedalExcelConfig, FlightActivityMedalExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FlightActivityMedalExcelConfig>, Dictionary<uint, FlightActivityMedalExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FlightActivityMedalExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A39CD0-0x0000000189A39CF0 */ get; } // 0x0000000182B49530-0x0000000182B495E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A48BD0-0x0000000189A48BF0 */ get; } // 0x0000000182B48380-0x0000000182B48420 

	// Methods
	// [XID] // 0x0000000189A32280-0x0000000189A322A0
	public static void Register() {} // 0x0000000182B49910-0x0000000182B499B0
	// [XID] // 0x0000000189A41510-0x0000000189A41530
	public static FlightActivityMedalExcelConfig GetData(uint id) => default; // 0x0000000182B48250-0x0000000182B48380
	// [XID] // 0x0000000189A50320-0x0000000189A50340
	public static void LoadData() {} // 0x0000000182B489B0-0x0000000182B48AA0
	// [XID] // 0x0000000189A578F0-0x0000000189A57910
	private static void RegisterHotfixGenerated() {} // 0x0000000182B487E0-0x0000000182B489B0
	// [XID] // 0x0000000189A5F4F0-0x0000000189A5F510
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B48420-0x0000000182B487E0
	// [IDTag] // 0x0000000189A66E20-0x0000000189A66E60
	// [XID] // 0x0000000189A66E20-0x0000000189A66E60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B48E90-0x0000000182B48F90
	// [XID] // 0x0000000189A71360-0x0000000189A71380
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FlightActivityMedalExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B495E0-0x0000000182B49910
	// [XID] // 0x0000000189A78F80-0x0000000189A78FA0
	private static bool ParseConfigFromLine(string line, out FlightActivityMedalExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B48AA0-0x0000000182B48BE0
	// [IDTag] // 0x0000000189A803C0-0x0000000189A80400
	// [XID] // 0x0000000189A803C0-0x0000000189A80400
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FlightActivityMedalExcelConfig> configList) => default; // 0x0000000182B48BE0-0x0000000182B48E90
	// [IDTag] // 0x0000000189A8B0A0-0x0000000189A8B0E0
	// [XID] // 0x0000000189A8B0A0-0x0000000189A8B0E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF013E */, bool useObjectPool = false /* Metadata: 0x00AF0142 */) => default; // 0x0000000182B492E0-0x0000000182B49530
	// [IDTag] // 0x0000000189A95610-0x0000000189A95650
	// [XID] // 0x0000000189A95610-0x0000000189A95650
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0143 */, bool useObjectPool = false /* Metadata: 0x00AF0147 */) => default; // 0x0000000182B48F90-0x0000000182B492E0
}

