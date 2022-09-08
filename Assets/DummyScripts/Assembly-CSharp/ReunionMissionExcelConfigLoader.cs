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

public static class ReunionMissionExcelConfigLoader // TypeDefIndex: 16059
{
	// Fields
	private static Dictionary<uint, ReunionMissionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReunionMissionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReunionMissionExcelConfig, ReunionMissionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReunionMissionExcelConfig>, Dictionary<uint, ReunionMissionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReunionMissionExcelConfig> dataDict { /* [XID] */ /* 0x000000018960ED20-0x000000018960ED40 */ get; } // 0x0000000182D64C80-0x0000000182D64D30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018961DBD0-0x000000018961DBF0 */ get; } // 0x0000000182D63AD0-0x0000000182D63B70 

	// Methods
	// [XID] // 0x00000001896072E0-0x0000000189607300
	public static void Register() {} // 0x0000000182D65060-0x0000000182D65100
	// [XID] // 0x00000001896163A0-0x00000001896163C0
	public static ReunionMissionExcelConfig GetData(uint id) => default; // 0x0000000182D639A0-0x0000000182D63AD0
	// [XID] // 0x0000000189625030-0x0000000189625050
	public static void LoadData() {} // 0x0000000182D64100-0x0000000182D641F0
	// [XID] // 0x000000018962C870-0x000000018962C890
	private static void RegisterHotfixGenerated() {} // 0x0000000182D63F30-0x0000000182D64100
	// [XID] // 0x0000000189634590-0x00000001896345B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D63B70-0x0000000182D63F30
	// [IDTag] // 0x000000018963BCA0-0x000000018963BCE0
	// [XID] // 0x000000018963BCA0-0x000000018963BCE0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D64330-0x0000000182D64430
	// [XID] // 0x0000000189646280-0x00000001896462A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReunionMissionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D64D30-0x0000000182D65060
	// [XID] // 0x000000018964DAC0-0x000000018964DAE0
	private static bool ParseConfigFromLine(string line, out ReunionMissionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D641F0-0x0000000182D64330
	// [IDTag] // 0x00000001896552C0-0x0000000189655300
	// [XID] // 0x00000001896552C0-0x0000000189655300
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReunionMissionExcelConfig> configList) => default; // 0x0000000182D64430-0x0000000182D646E0
	// [IDTag] // 0x000000018965F860-0x000000018965F8A0
	// [XID] // 0x000000018965F860-0x000000018965F8A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F2A */, bool useObjectPool = false /* Metadata: 0x00AF2F2E */) => default; // 0x0000000182D646E0-0x0000000182D64930
	// [IDTag] // 0x000000018966A340-0x000000018966A380
	// [XID] // 0x000000018966A340-0x000000018966A380
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F2F */, bool useObjectPool = false /* Metadata: 0x00AF2F33 */) => default; // 0x0000000182D64930-0x0000000182D64C80
}

