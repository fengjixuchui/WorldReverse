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

public static class MiracleRingDropExcelConfigLoader // TypeDefIndex: 15836
{
	// Fields
	private static Dictionary<int, MiracleRingDropExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MiracleRingDropExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MiracleRingDropExcelConfig, MiracleRingDropExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MiracleRingDropExcelConfig>, Dictionary<int, MiracleRingDropExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, MiracleRingDropExcelConfig> dataDict { /* [XID] */ /* 0x000000018962E310-0x000000018962E330 */ get; } // 0x0000000182A7CFE0-0x0000000182A7D090 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018963D5F0-0x000000018963D610 */ get; } // 0x0000000182A7BE30-0x0000000182A7BED0 

	// Methods
	// [XID] // 0x00000001896269E0-0x0000000189626A00
	public static void Register() {} // 0x0000000182A7D3C0-0x0000000182A7D460
	// [XID] // 0x0000000189635ED0-0x0000000189635EF0
	public static MiracleRingDropExcelConfig GetData(MiracleTag miracleTag) => default; // 0x0000000182A7BD00-0x0000000182A7BE30
	// [XID] // 0x0000000189644BB0-0x0000000189644BD0
	public static void LoadData() {} // 0x0000000182A7C460-0x0000000182A7C550
	// [XID] // 0x000000018964C550-0x000000018964C570
	private static void RegisterHotfixGenerated() {} // 0x0000000182A7C290-0x0000000182A7C460
	// [XID] // 0x0000000189653B20-0x0000000189653B40
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182A7BED0-0x0000000182A7C290
	// [IDTag] // 0x000000018965B390-0x000000018965B3D0
	// [XID] // 0x000000018965B390-0x000000018965B3D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182A7C690-0x0000000182A7C790
	// [XID] // 0x00000001896658F0-0x0000000189665910
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MiracleRingDropExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182A7D090-0x0000000182A7D3C0
	// [XID] // 0x000000018966CFE0-0x000000018966D000
	private static bool ParseConfigFromLine(string line, out MiracleRingDropExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182A7C550-0x0000000182A7C690
	// [IDTag] // 0x0000000189674ED0-0x0000000189674F10
	// [XID] // 0x0000000189674ED0-0x0000000189674F10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MiracleRingDropExcelConfig> configList) => default; // 0x0000000182A7C790-0x0000000182A7CA40
	// [IDTag] // 0x000000018967F540-0x000000018967F580
	// [XID] // 0x000000018967F540-0x000000018967F580
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF27EA */, bool useObjectPool = false /* Metadata: 0x00AF27EE */) => default; // 0x0000000182A7CA40-0x0000000182A7CC90
	// [IDTag] // 0x000000018968A010-0x000000018968A050
	// [XID] // 0x000000018968A010-0x000000018968A050
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF27EF */, bool useObjectPool = false /* Metadata: 0x00AF27F3 */) => default; // 0x0000000182A7CC90-0x0000000182A7CFE0
}

