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

public static class MiracleRingExcelConfigLoader // TypeDefIndex: 15834
{
	// Fields
	private static Dictionary<uint, MiracleRingExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MiracleRingExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MiracleRingExcelConfig, MiracleRingExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MiracleRingExcelConfig>, Dictionary<uint, MiracleRingExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MiracleRingExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B37350-0x0000000189B37370 */ get; } // 0x0000000184975A30-0x0000000184975AE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B46600-0x0000000189B46620 */ get; } // 0x0000000184974880-0x0000000184974920 

	// Methods
	// [XID] // 0x0000000189B2F9B0-0x0000000189B2F9D0
	public static void Register() {} // 0x0000000184975E10-0x0000000184975EB0
	// [XID] // 0x0000000189B3EBA0-0x0000000189B3EBC0
	public static MiracleRingExcelConfig GetData(uint itemId) => default; // 0x0000000184974750-0x0000000184974880
	// [XID] // 0x0000000189B4DBC0-0x0000000189B4DBE0
	public static void LoadData() {} // 0x0000000184974EB0-0x0000000184974FA0
	// [XID] // 0x0000000189B55490-0x0000000189B554B0
	private static void RegisterHotfixGenerated() {} // 0x0000000184974CE0-0x0000000184974EB0
	// [XID] // 0x0000000189B5CDD0-0x0000000189B5CDF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184974920-0x0000000184974CE0
	// [IDTag] // 0x0000000189B64490-0x0000000189B644D0
	// [XID] // 0x0000000189B64490-0x0000000189B644D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184975390-0x0000000184975490
	// [XID] // 0x0000000189B6E8E0-0x0000000189B6E900
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MiracleRingExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184975AE0-0x0000000184975E10
	// [XID] // 0x0000000189B76190-0x0000000189B761B0
	private static bool ParseConfigFromLine(string line, out MiracleRingExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184974FA0-0x00000001849750E0
	// [IDTag] // 0x0000000189B7D6C0-0x0000000189B7D700
	// [XID] // 0x0000000189B7D6C0-0x0000000189B7D700
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MiracleRingExcelConfig> configList) => default; // 0x00000001849750E0-0x0000000184975390
	// [IDTag] // 0x0000000189B88060-0x0000000189B880A0
	// [XID] // 0x0000000189B88060-0x0000000189B880A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF27DB */, bool useObjectPool = false /* Metadata: 0x00AF27DF */) => default; // 0x0000000184975490-0x00000001849756E0
	// [IDTag] // 0x0000000189B921C0-0x0000000189B92200
	// [XID] // 0x0000000189B921C0-0x0000000189B92200
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF27E0 */, bool useObjectPool = false /* Metadata: 0x00AF27E4 */) => default; // 0x00000001849756E0-0x0000000184975A30
}

