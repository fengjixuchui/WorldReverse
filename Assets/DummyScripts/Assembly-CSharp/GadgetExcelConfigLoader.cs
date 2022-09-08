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

public static class GadgetExcelConfigLoader // TypeDefIndex: 15638
{
	// Fields
	private static Dictionary<uint, GadgetExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetExcelConfig, GadgetExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetExcelConfig>, Dictionary<uint, GadgetExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A927D0-0x0000000189A927F0 */ get; } // 0x0000000182BEEEC0-0x0000000182BEEF70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AA12A0-0x0000000189AA12C0 */ get; } // 0x0000000182BEDD10-0x0000000182BEDDB0 

	// Methods
	// [XID] // 0x0000000189A8AFE0-0x0000000189A8B000
	public static void Register() {} // 0x0000000182BEF2A0-0x0000000182BEF340
	// [XID] // 0x0000000189A9A200-0x0000000189A9A220
	public static GadgetExcelConfig GetData(uint id) => default; // 0x0000000182BEDBE0-0x0000000182BEDD10
	// [XID] // 0x0000000189AA8940-0x0000000189AA8960
	public static void LoadData() {} // 0x0000000182BEE340-0x0000000182BEE430
	// [XID] // 0x0000000189AB0500-0x0000000189AB0520
	private static void RegisterHotfixGenerated() {} // 0x0000000182BEE170-0x0000000182BEE340
	// [XID] // 0x0000000189AB7BA0-0x0000000189AB7BC0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182BEDDB0-0x0000000182BEE170
	// [IDTag] // 0x0000000189ABF690-0x0000000189ABF6D0
	// [XID] // 0x0000000189ABF690-0x0000000189ABF6D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182BEE570-0x0000000182BEE670
	// [XID] // 0x0000000189ACA040-0x0000000189ACA060
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182BEEF70-0x0000000182BEF2A0
	// [XID] // 0x0000000189AD18D0-0x0000000189AD18F0
	private static bool ParseConfigFromLine(string line, out GadgetExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182BEE430-0x0000000182BEE570
	// [IDTag] // 0x0000000189AD95D0-0x0000000189AD9610
	// [XID] // 0x0000000189AD95D0-0x0000000189AD9610
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetExcelConfig> configList) => default; // 0x0000000182BEE670-0x0000000182BEE920
	// [IDTag] // 0x0000000189AE4050-0x0000000189AE4090
	// [XID] // 0x0000000189AE4050-0x0000000189AE4090
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2157 */, bool useObjectPool = false /* Metadata: 0x00AF215B */) => default; // 0x0000000182BEE920-0x0000000182BEEB70
	// [IDTag] // 0x0000000189AEEBA0-0x0000000189AEEBE0
	// [XID] // 0x0000000189AEEBA0-0x0000000189AEEBE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF215C */, bool useObjectPool = false /* Metadata: 0x00AF2160 */) => default; // 0x0000000182BEEB70-0x0000000182BEEEC0
}

