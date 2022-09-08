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

public static class EmotionTemplateExcelConfigLoader // TypeDefIndex: 15568
{
	// Fields
	private static Dictionary<uint, EmotionTemplateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EmotionTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EmotionTemplateExcelConfig, EmotionTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EmotionTemplateExcelConfig>, Dictionary<uint, EmotionTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EmotionTemplateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189876000-0x0000000189876020 */ get; } // 0x00000001841CEA30-0x00000001841CEAE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189884B70-0x0000000189884B90 */ get; } // 0x00000001841CD880-0x00000001841CD920 

	// Methods
	// [XID] // 0x000000018986EB50-0x000000018986EB70
	public static void Register() {} // 0x00000001841CEE10-0x00000001841CEEB0
	// [XID] // 0x000000018987DC20-0x000000018987DC40
	public static EmotionTemplateExcelConfig GetData(uint ID) => default; // 0x00000001841CD750-0x00000001841CD880
	// [XID] // 0x000000018988C1C0-0x000000018988C1E0
	public static void LoadData() {} // 0x00000001841CDEB0-0x00000001841CDFA0
	// [XID] // 0x0000000189893730-0x0000000189893750
	private static void RegisterHotfixGenerated() {} // 0x00000001841CDCE0-0x00000001841CDEB0
	// [XID] // 0x000000018989AE50-0x000000018989AE70
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001841CD920-0x00000001841CDCE0
	// [IDTag] // 0x00000001898A2240-0x00000001898A2280
	// [XID] // 0x00000001898A2240-0x00000001898A2280
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001841CE0E0-0x00000001841CE1E0
	// [XID] // 0x00000001898ACA60-0x00000001898ACA80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EmotionTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001841CEAE0-0x00000001841CEE10
	// [XID] // 0x00000001898B3EE0-0x00000001898B3F00
	private static bool ParseConfigFromLine(string line, out EmotionTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001841CDFA0-0x00000001841CE0E0
	// [IDTag] // 0x00000001898BBB90-0x00000001898BBBD0
	// [XID] // 0x00000001898BBB90-0x00000001898BBBD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EmotionTemplateExcelConfig> configList) => default; // 0x00000001841CE1E0-0x00000001841CE490
	// [IDTag] // 0x00000001898C5F70-0x00000001898C5FB0
	// [XID] // 0x00000001898C5F70-0x00000001898C5FB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F52 */, bool useObjectPool = false /* Metadata: 0x00AF1F56 */) => default; // 0x00000001841CE7E0-0x00000001841CEA30
	// [IDTag] // 0x00000001898D0A20-0x00000001898D0A60
	// [XID] // 0x00000001898D0A20-0x00000001898D0A60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F57 */, bool useObjectPool = false /* Metadata: 0x00AF1F5B */) => default; // 0x00000001841CE490-0x00000001841CE7E0
}

