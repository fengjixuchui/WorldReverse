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

public static class BlessingScanPicExcelConfigLoader // TypeDefIndex: 15033
{
	// Fields
	private static Dictionary<uint, BlessingScanPicExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlessingScanPicExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlessingScanPicExcelConfig, BlessingScanPicExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlessingScanPicExcelConfig>, Dictionary<uint, BlessingScanPicExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlessingScanPicExcelConfig> dataDict { /* [XID] */ /* 0x000000018998B100-0x000000018998B120 */ get; } // 0x00000001818444E0-0x0000000181844590 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018999A7F0-0x000000018999A810 */ get; } // 0x0000000181843330-0x00000001818433D0 

	// Methods
	// [XID] // 0x0000000189983890-0x00000001899838B0
	public static void Register() {} // 0x00000001818448C0-0x0000000181844960
	// [XID] // 0x0000000189992C50-0x0000000189992C70
	public static BlessingScanPicExcelConfig GetData(uint id) => default; // 0x0000000181843200-0x0000000181843330
	// [XID] // 0x00000001899A1F50-0x00000001899A1F70
	public static void LoadData() {} // 0x0000000181843960-0x0000000181843A50
	// [XID] // 0x00000001899A9820-0x00000001899A9840
	private static void RegisterHotfixGenerated() {} // 0x0000000181843790-0x0000000181843960
	// [XID] // 0x00000001899B1250-0x00000001899B1270
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001818433D0-0x0000000181843790
	// [IDTag] // 0x00000001899B84B0-0x00000001899B84F0
	// [XID] // 0x00000001899B84B0-0x00000001899B84F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181843B90-0x0000000181843C90
	// [XID] // 0x00000001899C32A0-0x00000001899C32C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlessingScanPicExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181844590-0x00000001818448C0
	// [XID] // 0x00000001899CA6E0-0x00000001899CA700
	private static bool ParseConfigFromLine(string line, out BlessingScanPicExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181843A50-0x0000000181843B90
	// [IDTag] // 0x00000001899D1E80-0x00000001899D1EC0
	// [XID] // 0x00000001899D1E80-0x00000001899D1EC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlessingScanPicExcelConfig> configList) => default; // 0x0000000181843C90-0x0000000181843F40
	// [IDTag] // 0x00000001899DC370-0x00000001899DC3B0
	// [XID] // 0x00000001899DC370-0x00000001899DC3B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFEF5 */, bool useObjectPool = false /* Metadata: 0x00AEFEF9 */) => default; // 0x0000000181844290-0x00000001818444E0
	// [IDTag] // 0x00000001899E6DF0-0x00000001899E6E30
	// [XID] // 0x00000001899E6DF0-0x00000001899E6E30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEFA */, bool useObjectPool = false /* Metadata: 0x00AEFEFE */) => default; // 0x0000000181843F40-0x0000000181844290
}

