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

public static class MpPlayBuffExcelConfigLoader // TypeDefIndex: 15872
{
	// Fields
	private static Dictionary<uint, MpPlayBuffExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayBuffExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayBuffExcelConfig, MpPlayBuffExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayBuffExcelConfig>, Dictionary<uint, MpPlayBuffExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayBuffExcelConfig> dataDict { /* [XID] */ /* 0x000000018962B2A0-0x000000018962B2C0 */ get; } // 0x00000001841F2DD0-0x00000001841F2E80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018963A550-0x000000018963A570 */ get; } // 0x00000001841F1C20-0x00000001841F1CC0 

	// Methods
	// [XID] // 0x0000000189623AC0-0x0000000189623AE0
	public static void Register() {} // 0x00000001841F31B0-0x00000001841F3250
	// [XID] // 0x0000000189632A80-0x0000000189632AA0
	public static MpPlayBuffExcelConfig GetData(uint id) => default; // 0x00000001841F1AF0-0x00000001841F1C20
	// [XID] // 0x0000000189641BE0-0x0000000189641C00
	public static void LoadData() {} // 0x00000001841F2250-0x00000001841F2340
	// [XID] // 0x00000001896494E0-0x0000000189649500
	private static void RegisterHotfixGenerated() {} // 0x00000001841F2080-0x00000001841F2250
	// [XID] // 0x0000000189650AB0-0x0000000189650AD0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001841F1CC0-0x00000001841F2080
	// [IDTag] // 0x00000001896582F0-0x0000000189658330
	// [XID] // 0x00000001896582F0-0x0000000189658330
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001841F2730-0x00000001841F2830
	// [XID] // 0x0000000189662840-0x0000000189662860
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayBuffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001841F2E80-0x00000001841F31B0
	// [XID] // 0x000000018966A3E0-0x000000018966A400
	private static bool ParseConfigFromLine(string line, out MpPlayBuffExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001841F2340-0x00000001841F2480
	// [IDTag] // 0x0000000189672000-0x0000000189672040
	// [XID] // 0x0000000189672000-0x0000000189672040
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayBuffExcelConfig> configList) => default; // 0x00000001841F2480-0x00000001841F2730
	// [IDTag] // 0x000000018967C6E0-0x000000018967C720
	// [XID] // 0x000000018967C6E0-0x000000018967C720
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2900 */, bool useObjectPool = false /* Metadata: 0x00AF2904 */) => default; // 0x00000001841F2830-0x00000001841F2A80
	// [IDTag] // 0x0000000189686DB0-0x0000000189686DF0
	// [XID] // 0x0000000189686DB0-0x0000000189686DF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2905 */, bool useObjectPool = false /* Metadata: 0x00AF2909 */) => default; // 0x00000001841F2A80-0x00000001841F2DD0
}

