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

public static class PhotographPosenameExcelConfigLoader // TypeDefIndex: 15947
{
	// Fields
	private static Dictionary<uint, PhotographPosenameExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PhotographPosenameExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PhotographPosenameExcelConfig, PhotographPosenameExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PhotographPosenameExcelConfig>, Dictionary<uint, PhotographPosenameExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PhotographPosenameExcelConfig> dataDict { /* [XID] */ /* 0x00000001899719C0-0x00000001899719E0 */ get; } // 0x0000000183082080-0x0000000183082130 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189980360-0x0000000189980380 */ get; } // 0x0000000183080ED0-0x0000000183080F70 

	// Methods
	// [XID] // 0x0000000189969C60-0x0000000189969C80
	public static void Register() {} // 0x0000000183082460-0x0000000183082500
	// [XID] // 0x0000000189979290-0x00000001899792B0
	public static PhotographPosenameExcelConfig GetData(uint fetter_id) => default; // 0x0000000183080DA0-0x0000000183080ED0
	// [XID] // 0x0000000189987C30-0x0000000189987C50
	public static void LoadData() {} // 0x0000000183081500-0x00000001830815F0
	// [XID] // 0x000000018998F7A0-0x000000018998F7C0
	private static void RegisterHotfixGenerated() {} // 0x0000000183081330-0x0000000183081500
	// [XID] // 0x0000000189997180-0x00000001899971A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183080F70-0x0000000183081330
	// [IDTag] // 0x000000018999EDB0-0x000000018999EDF0
	// [XID] // 0x000000018999EDB0-0x000000018999EDF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183081730-0x0000000183081830
	// [XID] // 0x00000001899A96A0-0x00000001899A96C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PhotographPosenameExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183082130-0x0000000183082460
	// [XID] // 0x00000001899B10F0-0x00000001899B1110
	private static bool ParseConfigFromLine(string line, out PhotographPosenameExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001830815F0-0x0000000183081730
	// [IDTag] // 0x00000001899B8350-0x00000001899B8390
	// [XID] // 0x00000001899B8350-0x00000001899B8390
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PhotographPosenameExcelConfig> configList) => default; // 0x0000000183081830-0x0000000183081AE0
	// [IDTag] // 0x00000001899C3100-0x00000001899C3140
	// [XID] // 0x00000001899C3100-0x00000001899C3140
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BED */, bool useObjectPool = false /* Metadata: 0x00AF2BF1 */) => default; // 0x0000000183081AE0-0x0000000183081D30
	// [IDTag] // 0x00000001899CD670-0x00000001899CD6B0
	// [XID] // 0x00000001899CD670-0x00000001899CD6B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BF2 */, bool useObjectPool = false /* Metadata: 0x00AF2BF6 */) => default; // 0x0000000183081D30-0x0000000183082080
}

