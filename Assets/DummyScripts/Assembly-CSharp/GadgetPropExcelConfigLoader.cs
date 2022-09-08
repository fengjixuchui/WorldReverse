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

public static class GadgetPropExcelConfigLoader // TypeDefIndex: 15640
{
	// Fields
	private static Dictionary<uint, GadgetPropExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetPropExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetPropExcelConfig, GadgetPropExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetPropExcelConfig>, Dictionary<uint, GadgetPropExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetPropExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BCF430-0x0000000189BCF450 */ get; } // 0x00000001837B0010-0x00000001837B00C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BDE520-0x0000000189BDE540 */ get; } // 0x00000001837AEE60-0x00000001837AEF00 

	// Methods
	// [XID] // 0x0000000189BC78C0-0x0000000189BC78E0
	public static void Register() {} // 0x00000001837B03F0-0x00000001837B0490
	// [XID] // 0x0000000189BD6800-0x0000000189BD6820
	public static GadgetPropExcelConfig GetData(uint id) => default; // 0x00000001837AED30-0x00000001837AEE60
	// [XID] // 0x00000001895EB030-0x00000001895EB050
	public static void LoadData() {} // 0x00000001837AF490-0x00000001837AF580
	// [XID] // 0x00000001895F2470-0x00000001895F2490
	private static void RegisterHotfixGenerated() {} // 0x00000001837AF2C0-0x00000001837AF490
	// [XID] // 0x00000001895F9E60-0x00000001895F9E80
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001837AEF00-0x00000001837AF2C0
	// [IDTag] // 0x00000001896016A0-0x00000001896016E0
	// [XID] // 0x00000001896016A0-0x00000001896016E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837AF970-0x00000001837AFA70
	// [XID] // 0x000000018960BEE0-0x000000018960BF00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetPropExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001837B00C0-0x00000001837B03F0
	// [XID] // 0x00000001896134A0-0x00000001896134C0
	private static bool ParseConfigFromLine(string line, out GadgetPropExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001837AF580-0x00000001837AF6C0
	// [IDTag] // 0x000000018961AC80-0x000000018961ACC0
	// [XID] // 0x000000018961AC80-0x000000018961ACC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetPropExcelConfig> configList) => default; // 0x00000001837AF6C0-0x00000001837AF970
	// [IDTag] // 0x00000001896250D0-0x0000000189625110
	// [XID] // 0x00000001896250D0-0x0000000189625110
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2166 */, bool useObjectPool = false /* Metadata: 0x00AF216A */) => default; // 0x00000001837AFDC0-0x00000001837B0010
	// [IDTag] // 0x000000018962FAE0-0x000000018962FB20
	// [XID] // 0x000000018962FAE0-0x000000018962FB20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF216B */, bool useObjectPool = false /* Metadata: 0x00AF216F */) => default; // 0x00000001837AFA70-0x00000001837AFDC0
}

