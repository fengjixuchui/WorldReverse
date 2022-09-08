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

public static class SeaLampSectionMainQuestExcelConfigLoader // TypeDefIndex: 15184
{
	// Fields
	private static Dictionary<uint, SeaLampSectionMainQuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SeaLampSectionMainQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SeaLampSectionMainQuestExcelConfig, SeaLampSectionMainQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SeaLampSectionMainQuestExcelConfig>, Dictionary<uint, SeaLampSectionMainQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SeaLampSectionMainQuestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189629CF0-0x0000000189629D10 */ get; } // 0x00000001819A44F0-0x00000001819A45A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189638FB0-0x0000000189638FD0 */ get; } // 0x00000001819A3340-0x00000001819A33E0 

	// Methods
	// [XID] // 0x0000000189622340-0x0000000189622360
	public static void Register() {} // 0x00000001819A48D0-0x00000001819A4970
	// [XID] // 0x0000000189631500-0x0000000189631520
	public static SeaLampSectionMainQuestExcelConfig GetData(uint id) => default; // 0x00000001819A3210-0x00000001819A3340
	// [XID] // 0x0000000189640370-0x0000000189640390
	public static void LoadData() {} // 0x00000001819A3970-0x00000001819A3A60
	// [XID] // 0x0000000189647BB0-0x0000000189647BD0
	private static void RegisterHotfixGenerated() {} // 0x00000001819A37A0-0x00000001819A3970
	// [XID] // 0x000000018964F2C0-0x000000018964F2E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001819A33E0-0x00000001819A37A0
	// [IDTag] // 0x0000000189656C50-0x0000000189656C90
	// [XID] // 0x0000000189656C50-0x0000000189656C90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001819A3E50-0x00000001819A3F50
	// [XID] // 0x00000001896611F0-0x0000000189661210
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SeaLampSectionMainQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001819A45A0-0x00000001819A48D0
	// [XID] // 0x0000000189668CC0-0x0000000189668CE0
	private static bool ParseConfigFromLine(string line, out SeaLampSectionMainQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001819A3A60-0x00000001819A3BA0
	// [IDTag] // 0x00000001896707D0-0x0000000189670810
	// [XID] // 0x00000001896707D0-0x0000000189670810
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SeaLampSectionMainQuestExcelConfig> configList) => default; // 0x00000001819A3BA0-0x00000001819A3E50
	// [IDTag] // 0x000000018967AE00-0x000000018967AE40
	// [XID] // 0x000000018967AE00-0x000000018967AE40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF032B */, bool useObjectPool = false /* Metadata: 0x00AF032F */) => default; // 0x00000001819A3F50-0x00000001819A41A0
	// [IDTag] // 0x0000000189685600-0x0000000189685640
	// [XID] // 0x0000000189685600-0x0000000189685640
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0330 */, bool useObjectPool = false /* Metadata: 0x00AF0334 */) => default; // 0x00000001819A41A0-0x00000001819A44F0
}

