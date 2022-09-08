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

public static class FindHilichurlExcelConfigLoader // TypeDefIndex: 14825
{
	// Fields
	private static Dictionary<uint, FindHilichurlExcelConfig> _activitysInfo; // 0x00
	private static Dictionary<uint, FindHilichurlExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<FindHilichurlExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<FindHilichurlExcelConfig, FindHilichurlExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<FindHilichurlExcelConfig>, Dictionary<uint, FindHilichurlExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, FindHilichurlExcelConfig> dataDict { /* [XID] */ /* 0x000000018994C040-0x000000018994C060 */ get; } // 0x0000000183595770-0x0000000183595840 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018995AE70-0x000000018995AE90 */ get; } // 0x0000000183593EF0-0x0000000183593F90 

	// Constructors
	static FindHilichurlExcelConfigLoader() {} // 0x0000000183595D80-0x0000000183595DE0

	// Methods
	// [XID] // 0x0000000189935830-0x0000000189935850
	public static void BuildActivitysInfotDic() {} // 0x0000000183594810-0x0000000183594B40
	// [XID] // 0x000000018993D410-0x000000018993D430
	public static FindHilichurlExcelConfig GetDataByActivityID(uint activityId) => default; // 0x0000000183595C50-0x0000000183595D80
	// [XID] // 0x0000000189944AA0-0x0000000189944AC0
	public static void Register() {} // 0x0000000183595B90-0x0000000183595C50
	// [XID] // 0x00000001899536F0-0x0000000189953710
	public static FindHilichurlExcelConfig GetData(uint id) => default; // 0x0000000183593D50-0x0000000183593EF0
	// [XID] // 0x0000000189962B10-0x0000000189962B30
	public static void LoadData() {} // 0x00000001835946E0-0x0000000183594810
	// [XID] // 0x0000000189969E40-0x0000000189969E60
	private static void RegisterHotfixGenerated() {} // 0x0000000183594470-0x00000001835946E0
	// [XID] // 0x0000000189971C40-0x0000000189971C60
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183593F90-0x0000000183594470
	// [IDTag] // 0x00000001899794D0-0x0000000189979510
	// [XID] // 0x00000001899794D0-0x0000000189979510
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183594C80-0x0000000183594DE0
	// [XID] // 0x0000000189983970-0x0000000189983990
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FindHilichurlExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183595840-0x0000000183595B90
	// [XID] // 0x000000018998B1C0-0x000000018998B1E0
	private static bool ParseConfigFromLine(string line, out FindHilichurlExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183594B40-0x0000000183594C80
	// [IDTag] // 0x0000000189992D50-0x0000000189992D90
	// [XID] // 0x0000000189992D50-0x0000000189992D90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FindHilichurlExcelConfig> configList) => default; // 0x0000000183594DE0-0x0000000183595130
	// [IDTag] // 0x000000018999D6D0-0x000000018999D710
	// [XID] // 0x000000018999D6D0-0x000000018999D710
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6B6 */, bool useObjectPool = false /* Metadata: 0x00AEF6BA */) => default; // 0x0000000183595130-0x00000001835953E0
	// [IDTag] // 0x00000001899A8220-0x00000001899A8260
	// [XID] // 0x00000001899A8220-0x00000001899A8260
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6BB */, bool useObjectPool = false /* Metadata: 0x00AEF6BF */) => default; // 0x00000001835953E0-0x0000000183595770
}

