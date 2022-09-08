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

public static class OpActivityBonusExcelConfigLoader // TypeDefIndex: 15930
{
	// Fields
	private static Dictionary<uint, OpActivityBonusExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<OpActivityBonusExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<OpActivityBonusExcelConfig, OpActivityBonusExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OpActivityBonusExcelConfig>, Dictionary<uint, OpActivityBonusExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, OpActivityBonusExcelConfig> dataDict { /* [XID] */ /* 0x00000001897C1FF0-0x00000001897C2010 */ get; } // 0x0000000181C87460-0x0000000181C87510 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897D0EB0-0x00000001897D0ED0 */ get; } // 0x0000000181C862B0-0x0000000181C86350 

	// Methods
	// [XID] // 0x00000001897B9EB0-0x00000001897B9ED0
	public static void Register() {} // 0x0000000181C87840-0x0000000181C879A0
	// [XID] // 0x00000001897C9840-0x00000001897C9860
	public static OpActivityBonusExcelConfig GetData(uint bonusId) => default; // 0x0000000181C86180-0x0000000181C862B0
	// [XID] // 0x00000001897D8D90-0x00000001897D8DB0
	public static void LoadData() {} // 0x0000000181C868E0-0x0000000181C869D0
	// [XID] // 0x00000001897DFFB0-0x00000001897DFFD0
	private static void RegisterHotfixGenerated() {} // 0x0000000181C86710-0x0000000181C868E0
	// [XID] // 0x00000001897E76F0-0x00000001897E7710
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181C86350-0x0000000181C86710
	// [IDTag] // 0x00000001897EF2D0-0x00000001897EF310
	// [XID] // 0x00000001897EF2D0-0x00000001897EF310
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181C86B10-0x0000000181C86C10
	// [XID] // 0x00000001897F9D60-0x00000001897F9D80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OpActivityBonusExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181C87510-0x0000000181C87840
	// [XID] // 0x00000001898012E0-0x0000000189801300
	private static bool ParseConfigFromLine(string line, out OpActivityBonusExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181C869D0-0x0000000181C86B10
	// [IDTag] // 0x0000000189808700-0x0000000189808740
	// [XID] // 0x0000000189808700-0x0000000189808740
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OpActivityBonusExcelConfig> configList) => default; // 0x0000000181C86C10-0x0000000181C86EC0
	// [IDTag] // 0x0000000189812E00-0x0000000189812E40
	// [XID] // 0x0000000189812E00-0x0000000189812E40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B72 */, bool useObjectPool = false /* Metadata: 0x00AF2B76 */) => default; // 0x0000000181C87210-0x0000000181C87460
	// [IDTag] // 0x000000018981D8D0-0x000000018981D910
	// [XID] // 0x000000018981D8D0-0x000000018981D910
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B77 */, bool useObjectPool = false /* Metadata: 0x00AF2B7B */) => default; // 0x0000000181C86EC0-0x0000000181C87210
}

