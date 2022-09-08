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

public static class HomeWorldAreaComfortExcelConfigLoader // TypeDefIndex: 15729
{
	// Fields
	private static Dictionary<uint, HomeWorldAreaComfortExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldAreaComfortExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldAreaComfortExcelConfig, HomeWorldAreaComfortExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldAreaComfortExcelConfig>, Dictionary<uint, HomeWorldAreaComfortExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldAreaComfortExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B357C0-0x0000000189B357E0 */ get; } // 0x0000000183393E30-0x0000000183393EE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B44DF0-0x0000000189B44E10 */ get; } // 0x0000000183392C80-0x0000000183392D20 

	// Methods
	// [XID] // 0x0000000189B2E330-0x0000000189B2E350
	public static void Register() {} // 0x0000000183394210-0x00000001833942B0
	// [XID] // 0x0000000189B3CFC0-0x0000000189B3CFE0
	public static HomeWorldAreaComfortExcelConfig GetData(uint configID) => default; // 0x0000000183392B50-0x0000000183392C80
	// [XID] // 0x0000000189B4C5E0-0x0000000189B4C600
	public static void LoadData() {} // 0x00000001833932B0-0x00000001833933A0
	// [XID] // 0x0000000189B53C60-0x0000000189B53C80
	private static void RegisterHotfixGenerated() {} // 0x00000001833930E0-0x00000001833932B0
	// [XID] // 0x0000000189B5B510-0x0000000189B5B530
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183392D20-0x00000001833930E0
	// [IDTag] // 0x0000000189B629A0-0x0000000189B629E0
	// [XID] // 0x0000000189B629A0-0x0000000189B629E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833934E0-0x00000001833935E0
	// [XID] // 0x0000000189B6D260-0x0000000189B6D280
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldAreaComfortExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183393EE0-0x0000000183394210
	// [XID] // 0x0000000189B748F0-0x0000000189B74910
	private static bool ParseConfigFromLine(string line, out HomeWorldAreaComfortExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001833933A0-0x00000001833934E0
	// [IDTag] // 0x0000000189B7BED0-0x0000000189B7BF10
	// [XID] // 0x0000000189B7BED0-0x0000000189B7BF10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldAreaComfortExcelConfig> configList) => default; // 0x00000001833935E0-0x0000000183393890
	// [IDTag] // 0x0000000189B86900-0x0000000189B86940
	// [XID] // 0x0000000189B86900-0x0000000189B86940
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF246D */, bool useObjectPool = false /* Metadata: 0x00AF2471 */) => default; // 0x0000000183393890-0x0000000183393AE0
	// [IDTag] // 0x0000000189B90D10-0x0000000189B90D50
	// [XID] // 0x0000000189B90D10-0x0000000189B90D50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2472 */, bool useObjectPool = false /* Metadata: 0x00AF2476 */) => default; // 0x0000000183393AE0-0x0000000183393E30
}

