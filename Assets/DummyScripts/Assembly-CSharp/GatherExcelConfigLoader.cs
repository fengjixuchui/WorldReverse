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

public static class GatherExcelConfigLoader // TypeDefIndex: 15662
{
	// Fields
	private static Dictionary<uint, GatherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GatherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GatherExcelConfig, GatherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GatherExcelConfig>, Dictionary<uint, GatherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GatherExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B3BB70-0x0000000189B3BB90 */ get; } // 0x0000000182E28B10-0x0000000182E28BC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B4AD50-0x0000000189B4AD70 */ get; } // 0x0000000182E27960-0x0000000182E27A00 

	// Methods
	// [XID] // 0x0000000189B34160-0x0000000189B34180
	public static void Register() {} // 0x0000000182E28EF0-0x0000000182E28F90
	// [XID] // 0x0000000189B43550-0x0000000189B43570
	public static GatherExcelConfig GetData(uint pointType) => default; // 0x0000000182E27830-0x0000000182E27960
	// [XID] // 0x0000000189B52360-0x0000000189B52380
	public static void LoadData() {} // 0x0000000182E27F90-0x0000000182E28080
	// [XID] // 0x0000000189B59D40-0x0000000189B59D60
	private static void RegisterHotfixGenerated() {} // 0x0000000182E27DC0-0x0000000182E27F90
	// [XID] // 0x0000000189B61450-0x0000000189B61470
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E27A00-0x0000000182E27DC0
	// [IDTag] // 0x0000000189B68EE0-0x0000000189B68F20
	// [XID] // 0x0000000189B68EE0-0x0000000189B68F20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E281C0-0x0000000182E282C0
	// [XID] // 0x0000000189B73290-0x0000000189B732B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GatherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E28BC0-0x0000000182E28EF0
	// [XID] // 0x0000000189B7A7D0-0x0000000189B7A7F0
	private static bool ParseConfigFromLine(string line, out GatherExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E28080-0x0000000182E281C0
	// [IDTag] // 0x0000000189B81FB0-0x0000000189B81FF0
	// [XID] // 0x0000000189B81FB0-0x0000000189B81FF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GatherExcelConfig> configList) => default; // 0x0000000182E282C0-0x0000000182E28570
	// [IDTag] // 0x0000000189B8C240-0x0000000189B8C280
	// [XID] // 0x0000000189B8C240-0x0000000189B8C280
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2229 */, bool useObjectPool = false /* Metadata: 0x00AF222D */) => default; // 0x0000000182E288C0-0x0000000182E28B10
	// [IDTag] // 0x0000000189B96790-0x0000000189B967D0
	// [XID] // 0x0000000189B96790-0x0000000189B967D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF222E */, bool useObjectPool = false /* Metadata: 0x00AF2232 */) => default; // 0x0000000182E28570-0x0000000182E288C0
}

