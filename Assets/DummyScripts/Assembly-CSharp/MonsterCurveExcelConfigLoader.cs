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

public static class MonsterCurveExcelConfigLoader // TypeDefIndex: 15678
{
	// Fields
	private static Dictionary<uint, MonsterCurveExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterCurveExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterCurveExcelConfig, MonsterCurveExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterCurveExcelConfig>, Dictionary<uint, MonsterCurveExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterCurveExcelConfig> dataDict { /* [XID] */ /* 0x0000000189634670-0x0000000189634690 */ get; } // 0x00000001837BF500-0x00000001837BF5B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896434A0-0x00000001896434C0 */ get; } // 0x00000001837BE350-0x00000001837BE3F0 

	// Methods
	// [XID] // 0x000000018962C930-0x000000018962C950
	public static void Register() {} // 0x00000001837BF8E0-0x00000001837BF980
	// [XID] // 0x00000001896F9250-0x00000001896F9270
	public static MonsterCurveExcelConfig GetData(uint level) => default; // 0x00000001837BE220-0x00000001837BE350
	// [XID] // 0x000000018964AAA0-0x000000018964AAC0
	public static void LoadData() {} // 0x00000001837BE980-0x00000001837BEA70
	// [XID] // 0x00000001896522C0-0x00000001896522E0
	private static void RegisterHotfixGenerated() {} // 0x00000001837BE7B0-0x00000001837BE980
	// [XID] // 0x00000001896599B0-0x00000001896599D0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001837BE3F0-0x00000001837BE7B0
	// [IDTag] // 0x00000001896610D0-0x0000000189661110
	// [XID] // 0x00000001896610D0-0x0000000189661110
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837BEBB0-0x00000001837BECB0
	// [XID] // 0x000000018966B740-0x000000018966B760
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterCurveExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001837BF5B0-0x00000001837BF8E0
	// [XID] // 0x0000000189673500-0x0000000189673520
	private static bool ParseConfigFromLine(string line, out MonsterCurveExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001837BEA70-0x00000001837BEBB0
	// [IDTag] // 0x000000018967AD00-0x000000018967AD40
	// [XID] // 0x000000018967AD00-0x000000018967AD40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterCurveExcelConfig> configList) => default; // 0x00000001837BECB0-0x00000001837BEF60
	// [IDTag] // 0x0000000189685460-0x00000001896854A0
	// [XID] // 0x0000000189685460-0x00000001896854A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF22BF */, bool useObjectPool = false /* Metadata: 0x00AF22C3 */) => default; // 0x00000001837BEF60-0x00000001837BF1B0
	// [IDTag] // 0x0000000189690480-0x00000001896904C0
	// [XID] // 0x0000000189690480-0x00000001896904C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22C4 */, bool useObjectPool = false /* Metadata: 0x00AF22C8 */) => default; // 0x00000001837BF1B0-0x00000001837BF500
}

