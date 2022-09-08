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

public static class AsterMidExcelConfigLoader // TypeDefIndex: 15016
{
	// Fields
	private static Dictionary<uint, AsterMidExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AsterMidExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AsterMidExcelConfig, AsterMidExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AsterMidExcelConfig>, Dictionary<uint, AsterMidExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AsterMidExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B28710-0x0000000189B28730 */ get; } // 0x0000000183C5E1E0-0x0000000183C5E290 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B37510-0x0000000189B37530 */ get; } // 0x0000000183C5D030-0x0000000183C5D0D0 

	// Methods
	// [XID] // 0x0000000189B21010-0x0000000189B21030
	public static void Register() {} // 0x0000000183C5E5C0-0x0000000183C5E660
	// [XID] // 0x0000000189B2FB30-0x0000000189B2FB50
	public static AsterMidExcelConfig GetData(uint id) => default; // 0x0000000183C5CF00-0x0000000183C5D030
	// [XID] // 0x0000000189B3EDC0-0x0000000189B3EDE0
	public static void LoadData() {} // 0x0000000183C5D660-0x0000000183C5D750
	// [XID] // 0x0000000189B46840-0x0000000189B46860
	private static void RegisterHotfixGenerated() {} // 0x0000000183C5D490-0x0000000183C5D660
	// [XID] // 0x0000000189B4DD80-0x0000000189B4DDA0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183C5D0D0-0x0000000183C5D490
	// [IDTag] // 0x0000000189B55650-0x0000000189B55690
	// [XID] // 0x0000000189B55650-0x0000000189B55690
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183C5D890-0x0000000183C5D990
	// [XID] // 0x0000000189B60100-0x0000000189B60120
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterMidExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183C5E290-0x0000000183C5E5C0
	// [XID] // 0x0000000189B67820-0x0000000189B67840
	private static bool ParseConfigFromLine(string line, out AsterMidExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183C5D750-0x0000000183C5D890
	// [IDTag] // 0x0000000189B6EAC0-0x0000000189B6EB00
	// [XID] // 0x0000000189B6EAC0-0x0000000189B6EB00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterMidExcelConfig> configList) => default; // 0x0000000183C5D990-0x0000000183C5DC40
	// [IDTag] // 0x0000000189B791A0-0x0000000189B791E0
	// [XID] // 0x0000000189B791A0-0x0000000189B791E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE8A */, bool useObjectPool = false /* Metadata: 0x00AEFE8E */) => default; // 0x0000000183C5DC40-0x0000000183C5DE90
	// [IDTag] // 0x0000000189B83A80-0x0000000189B83AC0
	// [XID] // 0x0000000189B83A80-0x0000000189B83AC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE8F */, bool useObjectPool = false /* Metadata: 0x00AEFE93 */) => default; // 0x0000000183C5DE90-0x0000000183C5E1E0
}

