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

public static class AnimalCodexExcelConfigLoader // TypeDefIndex: 15314
{
	// Fields
	private static Dictionary<uint, AnimalCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AnimalCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AnimalCodexExcelConfig, AnimalCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AnimalCodexExcelConfig>, Dictionary<uint, AnimalCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AnimalCodexExcelConfig> dataDict { /* [XID] */ /* 0x00000001898ED880-0x00000001898ED8A0 */ get; } // 0x0000000184489740-0x00000001844897F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898FC870-0x00000001898FC890 */ get; } // 0x0000000184488590-0x0000000184488630 

	// Methods
	// [XID] // 0x00000001898E5F60-0x00000001898E5F80
	public static void Register() {} // 0x0000000184489B20-0x0000000184489BC0
	// [XID] // 0x00000001898F50C0-0x00000001898F50E0
	public static AnimalCodexExcelConfig GetData(uint Id) => default; // 0x0000000184488460-0x0000000184488590
	// [XID] // 0x0000000189904270-0x0000000189904290
	public static void LoadData() {} // 0x0000000184488BC0-0x0000000184488CB0
	// [XID] // 0x000000018990B930-0x000000018990B950
	private static void RegisterHotfixGenerated() {} // 0x00000001844889F0-0x0000000184488BC0
	// [XID] // 0x0000000189913460-0x0000000189913480
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184488630-0x00000001844889F0
	// [IDTag] // 0x000000018991ACB0-0x000000018991ACF0
	// [XID] // 0x000000018991ACB0-0x000000018991ACF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184488DF0-0x0000000184488EF0
	// [XID] // 0x0000000189925400-0x0000000189925420
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AnimalCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001844897F0-0x0000000184489B20
	// [XID] // 0x000000018992C9A0-0x000000018992C9C0
	private static bool ParseConfigFromLine(string line, out AnimalCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184488CB0-0x0000000184488DF0
	// [IDTag] // 0x0000000189933FC0-0x0000000189934000
	// [XID] // 0x0000000189933FC0-0x0000000189934000
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AnimalCodexExcelConfig> configList) => default; // 0x0000000184488EF0-0x00000001844891A0
	// [IDTag] // 0x000000018993EA50-0x000000018993EA90
	// [XID] // 0x000000018993EA50-0x000000018993EA90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0745 */, bool useObjectPool = false /* Metadata: 0x00AF0749 */) => default; // 0x00000001844891A0-0x00000001844893F0
	// [IDTag] // 0x00000001899490A0-0x00000001899490E0
	// [XID] // 0x00000001899490A0-0x00000001899490E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF074A */, bool useObjectPool = false /* Metadata: 0x00AF074E */) => default; // 0x00000001844893F0-0x0000000184489740
}

