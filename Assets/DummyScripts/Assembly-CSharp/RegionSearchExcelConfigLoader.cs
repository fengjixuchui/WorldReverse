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

public static class RegionSearchExcelConfigLoader // TypeDefIndex: 15157
{
	// Fields
	private static Dictionary<uint, RegionSearchExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RegionSearchExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RegionSearchExcelConfig, RegionSearchExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RegionSearchExcelConfig>, Dictionary<uint, RegionSearchExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RegionSearchExcelConfig> dataDict { /* [XID] */ /* 0x0000000189ABB330-0x0000000189ABB350 */ get; } // 0x000000018248CE80-0x000000018248CF30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ACA120-0x0000000189ACA140 */ get; } // 0x000000018248BCD0-0x000000018248BD70 

	// Methods
	// [XID] // 0x0000000189AB35C0-0x0000000189AB35E0
	public static void Register() {} // 0x000000018248D260-0x000000018248D300
	// [XID] // 0x0000000189AC2AC0-0x0000000189AC2AE0
	public static RegionSearchExcelConfig GetData(uint id) => default; // 0x000000018248BBA0-0x000000018248BCD0
	// [XID] // 0x0000000189AD1990-0x0000000189AD19B0
	public static void LoadData() {} // 0x000000018248C300-0x000000018248C3F0
	// [XID] // 0x0000000189AD9670-0x0000000189AD9690
	private static void RegisterHotfixGenerated() {} // 0x000000018248C130-0x000000018248C300
	// [XID] // 0x0000000189AE1120-0x0000000189AE1140
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018248BD70-0x000000018248C130
	// [IDTag] // 0x0000000189AE85B0-0x0000000189AE85F0
	// [XID] // 0x0000000189AE85B0-0x0000000189AE85F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018248C530-0x000000018248C630
	// [XID] // 0x0000000189AF3390-0x0000000189AF33B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RegionSearchExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018248CF30-0x000000018248D260
	// [XID] // 0x0000000189AFAC60-0x0000000189AFAC80
	private static bool ParseConfigFromLine(string line, out RegionSearchExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018248C3F0-0x000000018248C530
	// [IDTag] // 0x0000000189B02150-0x0000000189B02190
	// [XID] // 0x0000000189B02150-0x0000000189B02190
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RegionSearchExcelConfig> configList) => default; // 0x000000018248C630-0x000000018248C8E0
	// [IDTag] // 0x0000000189B0C690-0x0000000189B0C6D0
	// [XID] // 0x0000000189B0C690-0x0000000189B0C6D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0260 */, bool useObjectPool = false /* Metadata: 0x00AF0264 */) => default; // 0x000000018248CC30-0x000000018248CE80
	// [IDTag] // 0x0000000189B169B0-0x0000000189B169F0
	// [XID] // 0x0000000189B169B0-0x0000000189B169F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0265 */, bool useObjectPool = false /* Metadata: 0x00AF0269 */) => default; // 0x000000018248C8E0-0x000000018248CC30
}

