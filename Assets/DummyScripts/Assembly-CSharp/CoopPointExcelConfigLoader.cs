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

public static class CoopPointExcelConfigLoader // TypeDefIndex: 14859
{
	// Fields
	private static Dictionary<uint, CoopPointExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CoopPointExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CoopPointExcelConfig, CoopPointExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CoopPointExcelConfig>, Dictionary<uint, CoopPointExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CoopPointExcelConfig> dataDict { /* [XID] */ /* 0x000000018987C2C0-0x000000018987C2E0 */ get; } // 0x0000000182D66510-0x0000000182D665C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018988AB30-0x000000018988AB50 */ get; } // 0x0000000182D65360-0x0000000182D65400 

	// Methods
	// [XID] // 0x000000018985E310-0x000000018985E330
	public static uint GetChapterId(uint configId) => default; // 0x0000000182D66A20-0x0000000182D66B50
	// [XID] // 0x0000000189865CD0-0x0000000189865CF0
	public static uint GetPosId(uint configId) => default; // 0x0000000182D665C0-0x0000000182D666F0
	// [XID] // 0x000000018986D250-0x000000018986D270
	public static CoopPointType GetCoopPointType(uint configId) => default; // 0x0000000182D65230-0x0000000182D65360
	// [XID] // 0x0000000189874700-0x0000000189874720
	public static void Register() {} // 0x0000000182D66B50-0x0000000182D66BF0
	// [XID] // 0x00000001898833D0-0x00000001898833F0
	public static CoopPointExcelConfig GetData(uint id) => default; // 0x0000000182D65100-0x0000000182D65230
	// [XID] // 0x0000000189891FC0-0x0000000189891FE0
	public static void LoadData() {} // 0x0000000182D65990-0x0000000182D65A80
	// [XID] // 0x0000000189899990-0x00000001898999B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182D657C0-0x0000000182D65990
	// [XID] // 0x00000001898A0A90-0x00000001898A0AB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D65400-0x0000000182D657C0
	// [IDTag] // 0x00000001898A8190-0x00000001898A81D0
	// [XID] // 0x00000001898A8190-0x00000001898A81D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D65BC0-0x0000000182D65CC0
	// [XID] // 0x00000001898B2970-0x00000001898B2990
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopPointExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D666F0-0x0000000182D66A20
	// [XID] // 0x00000001898BA800-0x00000001898BA820
	private static bool ParseConfigFromLine(string line, out CoopPointExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D65A80-0x0000000182D65BC0
	// [IDTag] // 0x00000001898C1980-0x00000001898C19C0
	// [XID] // 0x00000001898C1980-0x00000001898C19C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopPointExcelConfig> configList) => default; // 0x0000000182D65CC0-0x0000000182D65F70
	// [IDTag] // 0x00000001898CC0D0-0x00000001898CC110
	// [XID] // 0x00000001898CC0D0-0x00000001898CC110
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF803 */, bool useObjectPool = false /* Metadata: 0x00AEF807 */) => default; // 0x0000000182D662C0-0x0000000182D66510
	// [IDTag] // 0x00000001898D6BE0-0x00000001898D6C20
	// [XID] // 0x00000001898D6BE0-0x00000001898D6C20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF808 */, bool useObjectPool = false /* Metadata: 0x00AEF80C */) => default; // 0x0000000182D65F70-0x0000000182D662C0
}

