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

public static class AvatarSkillExcelConfigLoader // TypeDefIndex: 15225
{
	// Fields
	private static Dictionary<uint, AvatarSkillExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarSkillExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarSkillExcelConfig, AvatarSkillExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarSkillExcelConfig>, Dictionary<uint, AvatarSkillExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarSkillExcelConfig> dataDict { /* [XID] */ /* 0x00000001897F3DD0-0x00000001897F3DF0 */ get; } // 0x0000000184765A10-0x0000000184765AC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189802BE0-0x0000000189802C00 */ get; } // 0x0000000184764860-0x0000000184764900 

	// Methods
	// [XID] // 0x00000001897EC4C0-0x00000001897EC4E0
	public static void Register() {} // 0x0000000184765DF0-0x0000000184765E90
	// [XID] // 0x00000001897366D0-0x00000001897366F0
	public static AvatarSkillExcelConfig GetData(uint id) => default; // 0x0000000184764730-0x0000000184764860
	// [XID] // 0x000000018980A1D0-0x000000018980A1F0
	public static void LoadData() {} // 0x0000000184764E90-0x0000000184764F80
	// [XID] // 0x00000001898118E0-0x0000000189811900
	private static void RegisterHotfixGenerated() {} // 0x0000000184764CC0-0x0000000184764E90
	// [XID] // 0x00000001898194D0-0x00000001898194F0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184764900-0x0000000184764CC0
	// [IDTag] // 0x0000000189820CB0-0x0000000189820CF0
	// [XID] // 0x0000000189820CB0-0x0000000189820CF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184765370-0x0000000184765470
	// [XID] // 0x000000018982AFF0-0x000000018982B010
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarSkillExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184765AC0-0x0000000184765DF0
	// [XID] // 0x0000000189832590-0x00000001898325B0
	private static bool ParseConfigFromLine(string line, out AvatarSkillExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184764F80-0x00000001847650C0
	// [IDTag] // 0x0000000189839B60-0x0000000189839BA0
	// [XID] // 0x0000000189839B60-0x0000000189839BA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarSkillExcelConfig> configList) => default; // 0x00000001847650C0-0x0000000184765370
	// [IDTag] // 0x0000000189844360-0x00000001898443A0
	// [XID] // 0x0000000189844360-0x00000001898443A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF044E */, bool useObjectPool = false /* Metadata: 0x00AF0452 */) => default; // 0x00000001847657C0-0x0000000184765A10
	// [IDTag] // 0x000000018984E820-0x000000018984E860
	// [XID] // 0x000000018984E820-0x000000018984E860
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0453 */, bool useObjectPool = false /* Metadata: 0x00AF0457 */) => default; // 0x0000000184765470-0x00000001847657C0
}

