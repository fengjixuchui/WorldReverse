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

public static class MaterialSourceDataExcelConfigLoader // TypeDefIndex: 15828
{
	// Fields
	private static Dictionary<uint, MaterialSourceDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MaterialSourceDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MaterialSourceDataExcelConfig, MaterialSourceDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MaterialSourceDataExcelConfig>, Dictionary<uint, MaterialSourceDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MaterialSourceDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189925380-0x00000001899253A0 */ get; } // 0x0000000185427EE0-0x0000000185427F90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189933F40-0x0000000189933F60 */ get; } // 0x0000000185426D30-0x0000000185426DD0 

	// Methods
	// [XID] // 0x000000018991DBD0-0x000000018991DBF0
	public static void Register() {} // 0x00000001854282C0-0x0000000185428360
	// [XID] // 0x000000018992C920-0x000000018992C940
	public static MaterialSourceDataExcelConfig GetData(uint id) => default; // 0x0000000185426C00-0x0000000185426D30
	// [XID] // 0x000000018993BB50-0x000000018993BB70
	public static void LoadData() {} // 0x0000000185427360-0x0000000185427450
	// [XID] // 0x0000000189942CD0-0x0000000189942CF0
	private static void RegisterHotfixGenerated() {} // 0x0000000185427190-0x0000000185427360
	// [XID] // 0x000000018994A4C0-0x000000018994A4E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185426DD0-0x0000000185427190
	// [IDTag] // 0x0000000189951F90-0x0000000189951FD0
	// [XID] // 0x0000000189951F90-0x0000000189951FD0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185427590-0x0000000185427690
	// [XID] // 0x000000018995C460-0x000000018995C480
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MaterialSourceDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185427F90-0x00000001854282C0
	// [XID] // 0x0000000189963E80-0x0000000189963EA0
	private static bool ParseConfigFromLine(string line, out MaterialSourceDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185427450-0x0000000185427590
	// [IDTag] // 0x000000018996B370-0x000000018996B3B0
	// [XID] // 0x000000018996B370-0x000000018996B3B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MaterialSourceDataExcelConfig> configList) => default; // 0x0000000185427690-0x0000000185427940
	// [IDTag] // 0x0000000189975DB0-0x0000000189975DF0
	// [XID] // 0x0000000189975DB0-0x0000000189975DF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2795 */, bool useObjectPool = false /* Metadata: 0x00AF2799 */) => default; // 0x0000000185427940-0x0000000185427B90
	// [IDTag] // 0x00000001899803C0-0x0000000189980400
	// [XID] // 0x00000001899803C0-0x0000000189980400
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF279A */, bool useObjectPool = false /* Metadata: 0x00AF279E */) => default; // 0x0000000185427B90-0x0000000185427EE0
}

