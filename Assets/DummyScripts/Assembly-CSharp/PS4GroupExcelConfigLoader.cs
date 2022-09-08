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

public static class PS4GroupExcelConfigLoader // TypeDefIndex: 14998
{
	// Fields
	private static Dictionary<uint, PS4GroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PS4GroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PS4GroupExcelConfig, PS4GroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PS4GroupExcelConfig>, Dictionary<uint, PS4GroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PS4GroupExcelConfig> dataDict { /* [XID] */ /* 0x0000000189737AE0-0x0000000189737B00 */ get; } // 0x0000000183518F50-0x0000000183519000 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189746A20-0x0000000189746A40 */ get; } // 0x0000000183517DA0-0x0000000183517E40 

	// Methods
	// [XID] // 0x0000000189730160-0x0000000189730180
	public static void Register() {} // 0x0000000183519330-0x00000001835193D0
	// [XID] // 0x000000018973F6A0-0x000000018973F6C0
	public static PS4GroupExcelConfig GetData(uint id) => default; // 0x0000000183517C70-0x0000000183517DA0
	// [XID] // 0x000000018974E3D0-0x000000018974E3F0
	public static void LoadData() {} // 0x00000001835183D0-0x00000001835184C0
	// [XID] // 0x0000000189755A30-0x0000000189755A50
	private static void RegisterHotfixGenerated() {} // 0x0000000183518200-0x00000001835183D0
	// [XID] // 0x000000018975CD50-0x000000018975CD70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183517E40-0x0000000183518200
	// [IDTag] // 0x0000000189764500-0x0000000189764540
	// [XID] // 0x0000000189764500-0x0000000189764540
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183518600-0x0000000183518700
	// [XID] // 0x000000018976EAE0-0x000000018976EB00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PS4GroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183519000-0x0000000183519330
	// [XID] // 0x00000001897765C0-0x00000001897765E0
	private static bool ParseConfigFromLine(string line, out PS4GroupExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001835184C0-0x0000000183518600
	// [IDTag] // 0x000000018977DC00-0x000000018977DC40
	// [XID] // 0x000000018977DC00-0x000000018977DC40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PS4GroupExcelConfig> configList) => default; // 0x0000000183518700-0x00000001835189B0
	// [IDTag] // 0x00000001897882A0-0x00000001897882E0
	// [XID] // 0x00000001897882A0-0x00000001897882E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE02 */, bool useObjectPool = false /* Metadata: 0x00AEFE06 */) => default; // 0x0000000183518D00-0x0000000183518F50
	// [IDTag] // 0x00000001897929C0-0x0000000189792A00
	// [XID] // 0x00000001897929C0-0x0000000189792A00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE07 */, bool useObjectPool = false /* Metadata: 0x00AEFE0B */) => default; // 0x00000001835189B0-0x0000000183518D00
}

