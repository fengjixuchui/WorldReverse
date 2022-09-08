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

public static class GatherBundleExcelConfigLoader // TypeDefIndex: 15664
{
	// Fields
	private static Dictionary<uint, GatherBundleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GatherBundleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GatherBundleExcelConfig, GatherBundleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GatherBundleExcelConfig>, Dictionary<uint, GatherBundleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GatherBundleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189658330-0x0000000189658350 */ get; } // 0x000000018542BA10-0x000000018542BAC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896673B0-0x00000001896673D0 */ get; } // 0x000000018542A860-0x000000018542A900 

	// Methods
	// [XID] // 0x0000000189650B10-0x0000000189650B30
	public static void Register() {} // 0x000000018542BDF0-0x000000018542BE90
	// [XID] // 0x000000018965F920-0x000000018965F940
	public static GatherBundleExcelConfig GetData(uint id) => default; // 0x000000018542A730-0x000000018542A860
	// [XID] // 0x000000018966EBC0-0x000000018966EBE0
	public static void LoadData() {} // 0x000000018542AE90-0x000000018542AF80
	// [XID] // 0x00000001896765E0-0x0000000189676600
	private static void RegisterHotfixGenerated() {} // 0x000000018542ACC0-0x000000018542AE90
	// [XID] // 0x000000018967DDA0-0x000000018967DDC0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018542A900-0x000000018542ACC0
	// [IDTag] // 0x00000001896854A0-0x00000001896854E0
	// [XID] // 0x00000001896854A0-0x00000001896854E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018542B370-0x000000018542B470
	// [XID] // 0x00000001896904C0-0x00000001896904E0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GatherBundleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018542BAC0-0x000000018542BDF0
	// [XID] // 0x0000000189697D40-0x0000000189697D60
	private static bool ParseConfigFromLine(string line, out GatherBundleExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018542AF80-0x000000018542B0C0
	// [IDTag] // 0x000000018969F050-0x000000018969F090
	// [XID] // 0x000000018969F050-0x000000018969F090
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GatherBundleExcelConfig> configList) => default; // 0x000000018542B0C0-0x000000018542B370
	// [IDTag] // 0x00000001896A9560-0x00000001896A95A0
	// [XID] // 0x00000001896A9560-0x00000001896A95A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2238 */, bool useObjectPool = false /* Metadata: 0x00AF223C */) => default; // 0x000000018542B470-0x000000018542B6C0
	// [IDTag] // 0x00000001896B3730-0x00000001896B3770
	// [XID] // 0x00000001896B3730-0x00000001896B3770
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF223D */, bool useObjectPool = false /* Metadata: 0x00AF2241 */) => default; // 0x000000018542B6C0-0x000000018542BA10
}

