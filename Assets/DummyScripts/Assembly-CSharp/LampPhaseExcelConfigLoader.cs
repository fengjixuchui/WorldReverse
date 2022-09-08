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

public static class LampPhaseExcelConfigLoader // TypeDefIndex: 15177
{
	// Fields
	private static List<LampPhaseExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<LampPhaseExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LampPhaseExcelConfig, LampPhaseExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LampPhaseExcelConfig>, List<LampPhaseExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<LampPhaseExcelConfig> dataList { /* [XID] */ /* 0x00000001897DA4D0-0x00000001897DA4F0 */ get; } // 0x00000001831F5CC0-0x00000001831F5D70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897E19A0-0x00000001897E19C0 */ get; } // 0x00000001831F4AD0-0x00000001831F4B70 

	// Methods
	// [XID] // 0x00000001897D27D0-0x00000001897D27F0
	public static void Register() {} // 0x00000001831F60A0-0x00000001831F6140
	// [XID] // 0x00000001897E9150-0x00000001897E9170
	public static void LoadData() {} // 0x00000001831F5170-0x00000001831F5260
	// [XID] // 0x00000001897F0D60-0x00000001897F0D80
	private static void RegisterHotfixGenerated() {} // 0x00000001831F4FA0-0x00000001831F5170
	// [XID] // 0x00000001897F8600-0x00000001897F8620
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001831F4B70-0x00000001831F4FA0
	// [IDTag] // 0x00000001897FFCB0-0x00000001897FFCF0
	// [XID] // 0x00000001897FFCB0-0x00000001897FFCF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001831F53A0-0x00000001831F54A0
	// [XID] // 0x000000018980A1F0-0x000000018980A210
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LampPhaseExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001831F5D70-0x00000001831F60A0
	// [XID] // 0x0000000189811900-0x0000000189811920
	private static bool ParseConfigFromLine(string line, out LampPhaseExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001831F5260-0x00000001831F53A0
	// [IDTag] // 0x00000001898194F0-0x0000000189819530
	// [XID] // 0x00000001898194F0-0x0000000189819530
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LampPhaseExcelConfig> configList) => default; // 0x00000001831F54A0-0x00000001831F5740
	// [IDTag] // 0x00000001898235B0-0x00000001898235F0
	// [XID] // 0x00000001898235B0-0x00000001898235F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF02F9 */, bool useObjectPool = false /* Metadata: 0x00AF02FD */) => default; // 0x00000001831F5740-0x00000001831F5990
	// [IDTag] // 0x000000018982DE60-0x000000018982DEA0
	// [XID] // 0x000000018982DE60-0x000000018982DEA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02FE */, bool useObjectPool = false /* Metadata: 0x00AF0302 */) => default; // 0x00000001831F5990-0x00000001831F5CC0
}

