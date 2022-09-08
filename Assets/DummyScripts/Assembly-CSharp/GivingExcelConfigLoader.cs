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

public static class GivingExcelConfigLoader // TypeDefIndex: 15672
{
	// Fields
	private static Dictionary<uint, GivingExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GivingExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GivingExcelConfig, GivingExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GivingExcelConfig>, Dictionary<uint, GivingExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GivingExcelConfig> dataDict { /* [XID] */ /* 0x000000018993A490-0x000000018993A4B0 */ get; } // 0x0000000183DA6B60-0x0000000183DA6C10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189949020-0x0000000189949040 */ get; } // 0x0000000183DA59B0-0x0000000183DA5A50 

	// Methods
	// [XID] // 0x0000000189932A20-0x0000000189932A40
	public static void Register() {} // 0x0000000183DA6F40-0x0000000183DA6FE0
	// [XID] // 0x00000001899414C0-0x00000001899414E0
	public static GivingExcelConfig GetData(uint Id) => default; // 0x0000000183DA5880-0x0000000183DA59B0
	// [XID] // 0x0000000189950810-0x0000000189950830
	public static void LoadData() {} // 0x0000000183DA5FE0-0x0000000183DA60D0
	// [XID] // 0x0000000189957E00-0x0000000189957E20
	private static void RegisterHotfixGenerated() {} // 0x0000000183DA5E10-0x0000000183DA5FE0
	// [XID] // 0x000000018995F6D0-0x000000018995F6F0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183DA5A50-0x0000000183DA5E10
	// [IDTag] // 0x0000000189966F10-0x0000000189966F50
	// [XID] // 0x0000000189966F10-0x0000000189966F50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183DA6210-0x0000000183DA6310
	// [XID] // 0x00000001899719E0-0x0000000189971A00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GivingExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183DA6C10-0x0000000183DA6F40
	// [XID] // 0x00000001899792F0-0x0000000189979310
	private static bool ParseConfigFromLine(string line, out GivingExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183DA60D0-0x0000000183DA6210
	// [IDTag] // 0x0000000189980440-0x0000000189980480
	// [XID] // 0x0000000189980440-0x0000000189980480
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GivingExcelConfig> configList) => default; // 0x0000000183DA6310-0x0000000183DA65C0
	// [IDTag] // 0x000000018998B040-0x000000018998B080
	// [XID] // 0x000000018998B040-0x000000018998B080
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2292 */, bool useObjectPool = false /* Metadata: 0x00AF2296 */) => default; // 0x0000000183DA6910-0x0000000183DA6B60
	// [IDTag] // 0x0000000189995AF0-0x0000000189995B30
	// [XID] // 0x0000000189995AF0-0x0000000189995B30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2297 */, bool useObjectPool = false /* Metadata: 0x00AF229B */) => default; // 0x0000000183DA65C0-0x0000000183DA6910
}

