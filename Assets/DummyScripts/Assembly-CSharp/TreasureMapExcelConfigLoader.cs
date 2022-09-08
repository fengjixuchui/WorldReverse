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

public static class TreasureMapExcelConfigLoader // TypeDefIndex: 15195
{
	// Fields
	private static Dictionary<uint, TreasureMapExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TreasureMapExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TreasureMapExcelConfig, TreasureMapExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TreasureMapExcelConfig>, Dictionary<uint, TreasureMapExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TreasureMapExcelConfig> dataDict { /* [XID] */ /* 0x0000000189646440-0x0000000189646460 */ get; } // 0x0000000181C93E30-0x0000000181C93EE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896554C0-0x00000001896554E0 */ get; } // 0x0000000181C92C80-0x0000000181C92D20 

	// Methods
	// [XID] // 0x000000018963EC40-0x000000018963EC60
	public static void Register() {} // 0x0000000181C94210-0x0000000181C942B0
	// [XID] // 0x000000018964DB80-0x000000018964DBA0
	public static TreasureMapExcelConfig GetData(uint activity_id) => default; // 0x0000000181C92B50-0x0000000181C92C80
	// [XID] // 0x000000018965CC60-0x000000018965CC80
	public static void LoadData() {} // 0x0000000181C932B0-0x0000000181C933A0
	// [XID] // 0x00000001896641A0-0x00000001896641C0
	private static void RegisterHotfixGenerated() {} // 0x0000000181C930E0-0x0000000181C932B0
	// [XID] // 0x000000018966B820-0x000000018966B840
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181C92D20-0x0000000181C930E0
	// [IDTag] // 0x00000001896735A0-0x00000001896735E0
	// [XID] // 0x00000001896735A0-0x00000001896735E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181C934E0-0x0000000181C935E0
	// [XID] // 0x000000018967DE60-0x000000018967DE80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TreasureMapExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181C93EE0-0x0000000181C94210
	// [XID] // 0x00000001896855E0-0x0000000189685600
	private static bool ParseConfigFromLine(string line, out TreasureMapExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181C933A0-0x0000000181C934E0
	// [IDTag] // 0x000000018968D020-0x000000018968D060
	// [XID] // 0x000000018968D020-0x000000018968D060
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TreasureMapExcelConfig> configList) => default; // 0x0000000181C935E0-0x0000000181C93890
	// [IDTag] // 0x0000000189697E20-0x0000000189697E60
	// [XID] // 0x0000000189697E20-0x0000000189697E60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF037C */, bool useObjectPool = false /* Metadata: 0x00AF0380 */) => default; // 0x0000000181C93890-0x0000000181C93AE0
	// [IDTag] // 0x00000001896A2460-0x00000001896A24A0
	// [XID] // 0x00000001896A2460-0x00000001896A24A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0381 */, bool useObjectPool = false /* Metadata: 0x00AF0385 */) => default; // 0x0000000181C93AE0-0x0000000181C93E30
}

