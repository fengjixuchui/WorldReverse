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

public static class ViewCodexExcelConfigLoader // TypeDefIndex: 15322
{
	// Fields
	private static Dictionary<uint, ViewCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ViewCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ViewCodexExcelConfig, ViewCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ViewCodexExcelConfig>, Dictionary<uint, ViewCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ViewCodexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189841040-0x0000000189841060 */ get; } // 0x00000001856198E0-0x0000000185619990 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018984FC40-0x000000018984FC60 */ get; } // 0x0000000185618730-0x00000001856187D0 

	// Methods
	// [XID] // 0x0000000189839B40-0x0000000189839B60
	public static void Register() {} // 0x0000000185619CC0-0x0000000185619D60
	// [XID] // 0x00000001898484C0-0x00000001898484E0
	public static ViewCodexExcelConfig GetData(uint Id) => default; // 0x0000000185618600-0x0000000185618730
	// [XID] // 0x00000001898570C0-0x00000001898570E0
	public static void LoadData() {} // 0x0000000185618D60-0x0000000185618E50
	// [XID] // 0x000000018985E210-0x000000018985E230
	private static void RegisterHotfixGenerated() {} // 0x0000000185618B90-0x0000000185618D60
	// [XID] // 0x0000000189865C50-0x0000000189865C70
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001856187D0-0x0000000185618B90
	// [IDTag] // 0x000000018986D170-0x000000018986D1B0
	// [XID] // 0x000000018986D170-0x000000018986D1B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185619240-0x0000000185619340
	// [XID] // 0x0000000189877710-0x0000000189877730
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ViewCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185619990-0x0000000185619CC0
	// [XID] // 0x000000018987EF80-0x000000018987EFA0
	private static bool ParseConfigFromLine(string line, out ViewCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185618E50-0x0000000185618F90
	// [IDTag] // 0x0000000189886560-0x00000001898865A0
	// [XID] // 0x0000000189886560-0x00000001898865A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ViewCodexExcelConfig> configList) => default; // 0x0000000185618F90-0x0000000185619240
	// [IDTag] // 0x00000001898907C0-0x0000000189890800
	// [XID] // 0x00000001898907C0-0x0000000189890800
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0781 */, bool useObjectPool = false /* Metadata: 0x00AF0785 */) => default; // 0x0000000185619690-0x00000001856198E0
	// [IDTag] // 0x000000018989AEB0-0x000000018989AEF0
	// [XID] // 0x000000018989AEB0-0x000000018989AEF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0786 */, bool useObjectPool = false /* Metadata: 0x00AF078A */) => default; // 0x0000000185619340-0x0000000185619690
}

