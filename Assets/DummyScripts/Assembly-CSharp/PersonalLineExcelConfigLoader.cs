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

public static class PersonalLineExcelConfigLoader // TypeDefIndex: 15941
{
	// Fields
	private static Dictionary<uint, PersonalLineExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PersonalLineExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PersonalLineExcelConfig, PersonalLineExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PersonalLineExcelConfig>, Dictionary<uint, PersonalLineExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PersonalLineExcelConfig> dataDict { /* [XID] */ /* 0x0000000189638E70-0x0000000189638E90 */ get; } // 0x000000018430E1E0-0x000000018430E290 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189647AF0-0x0000000189647B10 */ get; } // 0x000000018430D030-0x000000018430D0D0 

	// Methods
	// [XID] // 0x00000001896313C0-0x00000001896313E0
	public static void Register() {} // 0x000000018430E5C0-0x000000018430E660
	// [XID] // 0x0000000189640270-0x0000000189640290
	public static PersonalLineExcelConfig GetData(uint id) => default; // 0x000000018430CF00-0x000000018430D030
	// [XID] // 0x000000018964F1A0-0x000000018964F1C0
	public static void LoadData() {} // 0x000000018430D660-0x000000018430D750
	// [XID] // 0x0000000189656B10-0x0000000189656B30
	private static void RegisterHotfixGenerated() {} // 0x000000018430D490-0x000000018430D660
	// [XID] // 0x000000018965E1D0-0x000000018965E1F0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018430D0D0-0x000000018430D490
	// [IDTag] // 0x0000000189665890-0x00000001896658D0
	// [XID] // 0x0000000189665890-0x00000001896658D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018430D890-0x000000018430D990
	// [XID] // 0x0000000189670710-0x0000000189670730
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PersonalLineExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018430E290-0x000000018430E5C0
	// [XID] // 0x0000000189677EF0-0x0000000189677F10
	private static bool ParseConfigFromLine(string line, out PersonalLineExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018430D750-0x000000018430D890
	// [IDTag] // 0x000000018967F500-0x000000018967F540
	// [XID] // 0x000000018967F500-0x000000018967F540
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PersonalLineExcelConfig> configList) => default; // 0x000000018430D990-0x000000018430DC40
	// [IDTag] // 0x0000000189689FB0-0x0000000189689FF0
	// [XID] // 0x0000000189689FB0-0x0000000189689FF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BC0 */, bool useObjectPool = false /* Metadata: 0x00AF2BC4 */) => default; // 0x000000018430DF90-0x000000018430E1E0
	// [IDTag] // 0x0000000189694A40-0x0000000189694A80
	// [XID] // 0x0000000189694A40-0x0000000189694A80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BC5 */, bool useObjectPool = false /* Metadata: 0x00AF2BC9 */) => default; // 0x000000018430DC40-0x000000018430DF90
}

