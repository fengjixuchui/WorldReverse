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

public static class LevelSuppressExcelConfigLoader // TypeDefIndex: 15785
{
	// Fields
	private static Dictionary<int, LevelSuppressExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LevelSuppressExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LevelSuppressExcelConfig, LevelSuppressExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LevelSuppressExcelConfig>, Dictionary<int, LevelSuppressExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, LevelSuppressExcelConfig> dataDict { /* [XID] */ /* 0x00000001895F0D80-0x00000001895F0DA0 */ get; } // 0x0000000182DBA7A0-0x0000000182DBA850 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895FFC10-0x00000001895FFC30 */ get; } // 0x0000000182DB95F0-0x0000000182DB9690 

	// Methods
	// [XID] // 0x00000001895E95D0-0x00000001895E95F0
	public static void Register() {} // 0x0000000182DBAB80-0x0000000182DBAC20
	// [XID] // 0x00000001895F8770-0x00000001895F8790
	public static LevelSuppressExcelConfig GetData(int level) => default; // 0x0000000182DB94C0-0x0000000182DB95F0
	// [XID] // 0x00000001896073A0-0x00000001896073C0
	public static void LoadData() {} // 0x0000000182DB9C20-0x0000000182DB9D10
	// [XID] // 0x000000018960EE00-0x000000018960EE20
	private static void RegisterHotfixGenerated() {} // 0x0000000182DB9A50-0x0000000182DB9C20
	// [XID] // 0x0000000189616440-0x0000000189616460
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182DB9690-0x0000000182DB9A50
	// [IDTag] // 0x000000018961DC70-0x000000018961DCB0
	// [XID] // 0x000000018961DC70-0x000000018961DCB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182DB9E50-0x0000000182DB9F50
	// [XID] // 0x0000000189628290-0x00000001896282B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LevelSuppressExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182DBA850-0x0000000182DBAB80
	// [XID] // 0x000000018962FAA0-0x000000018962FAC0
	private static bool ParseConfigFromLine(string line, out LevelSuppressExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182DB9D10-0x0000000182DB9E50
	// [IDTag] // 0x0000000189637680-0x00000001896376C0
	// [XID] // 0x0000000189637680-0x00000001896376C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LevelSuppressExcelConfig> configList) => default; // 0x0000000182DB9F50-0x0000000182DBA200
	// [IDTag] // 0x0000000189641C00-0x0000000189641C40
	// [XID] // 0x0000000189641C00-0x0000000189641C40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF25ED */, bool useObjectPool = false /* Metadata: 0x00AF25F1 */) => default; // 0x0000000182DBA200-0x0000000182DBA450
	// [IDTag] // 0x000000018964C570-0x000000018964C5B0
	// [XID] // 0x000000018964C570-0x000000018964C5B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25F2 */, bool useObjectPool = false /* Metadata: 0x00AF25F6 */) => default; // 0x0000000182DBA450-0x0000000182DBA7A0
}

