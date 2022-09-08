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

public static class BlossomReviseExcelConfigLoader // TypeDefIndex: 15278
{
	// Fields
	private static Dictionary<uint, BlossomReviseExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomReviseExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomReviseExcelConfig, BlossomReviseExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomReviseExcelConfig>, Dictionary<uint, BlossomReviseExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomReviseExcelConfig> dataDict { /* [XID] */ /* 0x00000001896314E0-0x0000000189631500 */ get; } // 0x0000000184B9A9C0-0x0000000184B9AA70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189640350-0x0000000189640370 */ get; } // 0x0000000184B99810-0x0000000184B998B0 

	// Methods
	// [XID] // 0x0000000189629CD0-0x0000000189629CF0
	public static void Register() {} // 0x0000000184B9ADA0-0x0000000184B9AE40
	// [XID] // 0x0000000189638F90-0x0000000189638FB0
	public static BlossomReviseExcelConfig GetData(uint id) => default; // 0x0000000184B996E0-0x0000000184B99810
	// [XID] // 0x0000000189647B70-0x0000000189647B90
	public static void LoadData() {} // 0x0000000184B99E40-0x0000000184B99F30
	// [XID] // 0x000000018964F240-0x000000018964F260
	private static void RegisterHotfixGenerated() {} // 0x0000000184B99C70-0x0000000184B99E40
	// [XID] // 0x0000000189656C10-0x0000000189656C30
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184B998B0-0x0000000184B99C70
	// [IDTag] // 0x000000018965E2F0-0x000000018965E330
	// [XID] // 0x000000018965E2F0-0x000000018965E330
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184B9A320-0x0000000184B9A420
	// [XID] // 0x0000000189668C20-0x0000000189668C40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomReviseExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184B9AA70-0x0000000184B9ADA0
	// [XID] // 0x0000000189670790-0x00000001896707B0
	private static bool ParseConfigFromLine(string line, out BlossomReviseExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184B99F30-0x0000000184B9A070
	// [IDTag] // 0x0000000189677F90-0x0000000189677FD0
	// [XID] // 0x0000000189677F90-0x0000000189677FD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomReviseExcelConfig> configList) => default; // 0x0000000184B9A070-0x0000000184B9A320
	// [IDTag] // 0x0000000189682670-0x00000001896826B0
	// [XID] // 0x0000000189682670-0x00000001896826B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF060E */, bool useObjectPool = false /* Metadata: 0x00AF0612 */) => default; // 0x0000000184B9A770-0x0000000184B9A9C0
	// [IDTag] // 0x000000018968CFE0-0x000000018968D020
	// [XID] // 0x000000018968CFE0-0x000000018968D020
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0613 */, bool useObjectPool = false /* Metadata: 0x00AF0617 */) => default; // 0x0000000184B9A420-0x0000000184B9A770
}

