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

public static class MpPlayGroupExcelConfigLoader // TypeDefIndex: 15866
{
	// Fields
	private static Dictionary<uint, MpPlayGroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayGroupExcelConfig, MpPlayGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayGroupExcelConfig>, Dictionary<uint, MpPlayGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayGroupExcelConfig> dataDict { /* [XID] */ /* 0x000000018982AF50-0x000000018982AF70 */ get; } // 0x00000001831B6A90-0x00000001831B6B40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189839A40-0x0000000189839A60 */ get; } // 0x00000001831B58E0-0x00000001831B5980 

	// Methods
	// [XID] // 0x0000000189823550-0x0000000189823570
	public static void Register() {} // 0x00000001831B6E70-0x00000001831B6F10
	// [XID] // 0x0000000189832490-0x00000001898324B0
	public static MpPlayGroupExcelConfig GetData(uint EntryId) => default; // 0x00000001831B57B0-0x00000001831B58E0
	// [XID] // 0x0000000189840F80-0x0000000189840FA0
	public static void LoadData() {} // 0x00000001831B5F10-0x00000001831B6000
	// [XID] // 0x0000000189848400-0x0000000189848420
	private static void RegisterHotfixGenerated() {} // 0x00000001831B5D40-0x00000001831B5F10
	// [XID] // 0x000000018984FB80-0x000000018984FBA0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001831B5980-0x00000001831B5D40
	// [IDTag] // 0x0000000189856F60-0x0000000189856FA0
	// [XID] // 0x0000000189856F60-0x0000000189856FA0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001831B6140-0x00000001831B6240
	// [XID] // 0x00000001898613F0-0x0000000189861410
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001831B6B40-0x00000001831B6E70
	// [XID] // 0x0000000189868B90-0x0000000189868BB0
	private static bool ParseConfigFromLine(string line, out MpPlayGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001831B6000-0x00000001831B6140
	// [IDTag] // 0x000000018986FFA0-0x000000018986FFE0
	// [XID] // 0x000000018986FFA0-0x000000018986FFE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayGroupExcelConfig> configList) => default; // 0x00000001831B6240-0x00000001831B64F0
	// [IDTag] // 0x000000018987AB90-0x000000018987ABD0
	// [XID] // 0x000000018987AB90-0x000000018987ABD0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF28D3 */, bool useObjectPool = false /* Metadata: 0x00AF28D7 */) => default; // 0x00000001831B64F0-0x00000001831B6740
	// [IDTag] // 0x0000000189884AB0-0x0000000189884AF0
	// [XID] // 0x0000000189884AB0-0x0000000189884AF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28D8 */, bool useObjectPool = false /* Metadata: 0x00AF28DC */) => default; // 0x00000001831B6740-0x00000001831B6A90
}

