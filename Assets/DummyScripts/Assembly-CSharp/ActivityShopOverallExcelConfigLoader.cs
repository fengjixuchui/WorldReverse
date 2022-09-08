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

public static class ActivityShopOverallExcelConfigLoader // TypeDefIndex: 15190
{
	// Fields
	private static Dictionary<uint, ActivityShopOverallExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityShopOverallExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityShopOverallExcelConfig, ActivityShopOverallExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityShopOverallExcelConfig>, Dictionary<uint, ActivityShopOverallExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityShopOverallExcelConfig> dataDict { /* [XID] */ /* 0x0000000189893830-0x0000000189893850 */ get; } // 0x000000018126CF30-0x000000018126CFE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898A22E0-0x00000001898A2300 */ get; } // 0x000000018126BD80-0x000000018126BE20 

	// Methods
	// [XID] // 0x000000018988C2A0-0x000000018988C2C0
	public static void Register() {} // 0x000000018126D310-0x000000018126D3B0
	// [XID] // 0x000000018989AF70-0x000000018989AF90
	public static ActivityShopOverallExcelConfig GetData(uint scheduleId) => default; // 0x000000018126BC50-0x000000018126BD80
	// [XID] // 0x00000001898A9970-0x00000001898A9990
	public static void LoadData() {} // 0x000000018126C3B0-0x000000018126C4A0
	// [XID] // 0x00000001898B1280-0x00000001898B12A0
	private static void RegisterHotfixGenerated() {} // 0x000000018126C1E0-0x000000018126C3B0
	// [XID] // 0x00000001898B8BE0-0x00000001898B8C00
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018126BE20-0x000000018126C1E0
	// [IDTag] // 0x00000001898C0200-0x00000001898C0240
	// [XID] // 0x00000001898C0200-0x00000001898C0240
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018126C890-0x000000018126C990
	// [XID] // 0x00000001898CABA0-0x00000001898CABC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityShopOverallExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018126CFE0-0x000000018126D310
	// [XID] // 0x00000001898D2270-0x00000001898D2290
	private static bool ParseConfigFromLine(string line, out ActivityShopOverallExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018126C4A0-0x000000018126C5E0
	// [IDTag] // 0x00000001898D9A70-0x00000001898D9AB0
	// [XID] // 0x00000001898D9A70-0x00000001898D9AB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityShopOverallExcelConfig> configList) => default; // 0x000000018126C5E0-0x000000018126C890
	// [IDTag] // 0x00000001898E4580-0x00000001898E45C0
	// [XID] // 0x00000001898E4580-0x00000001898E45C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0359 */, bool useObjectPool = false /* Metadata: 0x00AF035D */) => default; // 0x000000018126C990-0x000000018126CBE0
	// [IDTag] // 0x00000001898EF1A0-0x00000001898EF1E0
	// [XID] // 0x00000001898EF1A0-0x00000001898EF1E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF035E */, bool useObjectPool = false /* Metadata: 0x00AF0362 */) => default; // 0x000000018126CBE0-0x000000018126CF30
}

