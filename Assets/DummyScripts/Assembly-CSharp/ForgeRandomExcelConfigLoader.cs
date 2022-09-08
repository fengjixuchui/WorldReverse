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

public static class ForgeRandomExcelConfigLoader // TypeDefIndex: 15624
{
	// Fields
	private static Dictionary<uint, ForgeRandomExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ForgeRandomExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ForgeRandomExcelConfig, ForgeRandomExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ForgeRandomExcelConfig>, Dictionary<uint, ForgeRandomExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ForgeRandomExcelConfig> dataDict { /* [XID] */ /* 0x000000018976A3D0-0x000000018976A3F0 */ get; } // 0x0000000181D0A9E0-0x0000000181D0AA90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897793A0-0x00000001897793C0 */ get; } // 0x0000000181D09830-0x0000000181D098D0 

	// Methods
	// [XID] // 0x0000000189762D70-0x0000000189762D90
	public static void Register() {} // 0x0000000181D0ADC0-0x0000000181D0AE60
	// [XID] // 0x0000000189771BF0-0x0000000189771C10
	public static ForgeRandomExcelConfig GetData(uint forgeRandomId) => default; // 0x0000000181D09700-0x0000000181D09830
	// [XID] // 0x0000000189780BE0-0x0000000189780C00
	public static void LoadData() {} // 0x0000000181D09E60-0x0000000181D09F50
	// [XID] // 0x00000001897881A0-0x00000001897881C0
	private static void RegisterHotfixGenerated() {} // 0x0000000181D09C90-0x0000000181D09E60
	// [XID] // 0x000000018978F7A0-0x000000018978F7C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181D098D0-0x0000000181D09C90
	// [IDTag] // 0x0000000189796FB0-0x0000000189796FF0
	// [XID] // 0x0000000189796FB0-0x0000000189796FF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181D0A090-0x0000000181D0A190
	// [XID] // 0x00000001897A1D60-0x00000001897A1D80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ForgeRandomExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181D0AA90-0x0000000181D0ADC0
	// [XID] // 0x00000001897A9580-0x00000001897A95A0
	private static bool ParseConfigFromLine(string line, out ForgeRandomExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181D09F50-0x0000000181D0A090
	// [IDTag] // 0x00000001897B0D00-0x00000001897B0D40
	// [XID] // 0x00000001897B0D00-0x00000001897B0D40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ForgeRandomExcelConfig> configList) => default; // 0x0000000181D0A190-0x0000000181D0A440
	// [IDTag] // 0x00000001897BC1F0-0x00000001897BC230
	// [XID] // 0x00000001897BC1F0-0x00000001897BC230
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF20E9 */, bool useObjectPool = false /* Metadata: 0x00AF20ED */) => default; // 0x0000000181D0A790-0x0000000181D0A9E0
	// [IDTag] // 0x00000001897C6AC0-0x00000001897C6B00
	// [XID] // 0x00000001897C6AC0-0x00000001897C6B00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20EE */, bool useObjectPool = false /* Metadata: 0x00AF20F2 */) => default; // 0x0000000181D0A440-0x0000000181D0A790
}

