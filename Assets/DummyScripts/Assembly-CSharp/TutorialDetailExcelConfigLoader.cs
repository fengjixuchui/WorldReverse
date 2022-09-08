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

public static class TutorialDetailExcelConfigLoader // TypeDefIndex: 16251
{
	// Fields
	private static Dictionary<uint, TutorialDetailExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TutorialDetailExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TutorialDetailExcelConfig, TutorialDetailExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TutorialDetailExcelConfig>, Dictionary<uint, TutorialDetailExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TutorialDetailExcelConfig> dataDict { /* [XID] */ /* 0x0000000189848360-0x0000000189848380 */ get; } // 0x0000000183A6C150-0x0000000183A6C200 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189856EA0-0x0000000189856EC0 */ get; } // 0x0000000183A6AFA0-0x0000000183A6B040 

	// Methods
	// [XID] // 0x0000000189840EC0-0x0000000189840EE0
	public static void Register() {} // 0x0000000183A6C530-0x0000000183A6C5D0
	// [XID] // 0x000000018984FB00-0x000000018984FB20
	public static TutorialDetailExcelConfig GetData(uint id) => default; // 0x0000000183A6AE70-0x0000000183A6AFA0
	// [XID] // 0x000000018985E070-0x000000018985E090
	public static void LoadData() {} // 0x0000000183A6B5D0-0x0000000183A6B6C0
	// [XID] // 0x0000000189865AD0-0x0000000189865AF0
	private static void RegisterHotfixGenerated() {} // 0x0000000183A6B400-0x0000000183A6B5D0
	// [XID] // 0x000000018986D050-0x000000018986D070
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183A6B040-0x0000000183A6B400
	// [IDTag] // 0x0000000189874460-0x00000001898744A0
	// [XID] // 0x0000000189874460-0x00000001898744A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183A6BAB0-0x0000000183A6BBB0
	// [XID] // 0x000000018987EEC0-0x000000018987EEE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TutorialDetailExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183A6C200-0x0000000183A6C530
	// [XID] // 0x00000001898864C0-0x00000001898864E0
	private static bool ParseConfigFromLine(string line, out TutorialDetailExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183A6B6C0-0x0000000183A6B800
	// [IDTag] // 0x000000018988D620-0x000000018988D660
	// [XID] // 0x000000018988D620-0x000000018988D660
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TutorialDetailExcelConfig> configList) => default; // 0x0000000183A6B800-0x0000000183A6BAB0
	// [IDTag] // 0x0000000189897C20-0x0000000189897C60
	// [XID] // 0x0000000189897C20-0x0000000189897C60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF358F */, bool useObjectPool = false /* Metadata: 0x00AF3593 */) => default; // 0x0000000183A6BBB0-0x0000000183A6BE00
	// [IDTag] // 0x00000001898A2080-0x00000001898A20C0
	// [XID] // 0x00000001898A2080-0x00000001898A20C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3594 */, bool useObjectPool = false /* Metadata: 0x00AF3598 */) => default; // 0x0000000183A6BE00-0x0000000183A6C150
}

