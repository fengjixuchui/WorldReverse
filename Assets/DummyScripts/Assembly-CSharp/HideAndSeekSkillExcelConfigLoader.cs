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

public static class HideAndSeekSkillExcelConfigLoader // TypeDefIndex: 15125
{
	// Fields
	private static Dictionary<uint, HideAndSeekSkillExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HideAndSeekSkillExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HideAndSeekSkillExcelConfig, HideAndSeekSkillExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HideAndSeekSkillExcelConfig>, Dictionary<uint, HideAndSeekSkillExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HideAndSeekSkillExcelConfig> dataDict { /* [XID] */ /* 0x0000000189810330-0x0000000189810350 */ get; } // 0x0000000183A18B40-0x0000000183A18BF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018981F300-0x000000018981F320 */ get; } // 0x0000000183A17990-0x0000000183A17A30 

	// Methods
	// [XID] // 0x0000000189808900-0x0000000189808920
	public static void Register() {} // 0x0000000183A18F20-0x0000000183A18FC0
	// [XID] // 0x00000001898179C0-0x00000001898179E0
	public static HideAndSeekSkillExcelConfig GetData(uint id) => default; // 0x0000000183A17860-0x0000000183A17990
	// [XID] // 0x00000001898267B0-0x00000001898267D0
	public static void LoadData() {} // 0x0000000183A17FC0-0x0000000183A180B0
	// [XID] // 0x000000018982DEE0-0x000000018982DF00
	private static void RegisterHotfixGenerated() {} // 0x0000000183A17DF0-0x0000000183A17FC0
	// [XID] // 0x00000001898354F0-0x0000000189835510
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183A17A30-0x0000000183A17DF0
	// [IDTag] // 0x000000018983CCF0-0x000000018983CD30
	// [XID] // 0x000000018983CCF0-0x000000018983CD30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183A181F0-0x0000000183A182F0
	// [XID] // 0x00000001898471F0-0x0000000189847210
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HideAndSeekSkillExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183A18BF0-0x0000000183A18F20
	// [XID] // 0x000000018984E880-0x000000018984E8A0
	private static bool ParseConfigFromLine(string line, out HideAndSeekSkillExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183A180B0-0x0000000183A181F0
	// [IDTag] // 0x0000000189855890-0x00000001898558D0
	// [XID] // 0x0000000189855890-0x00000001898558D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HideAndSeekSkillExcelConfig> configList) => default; // 0x0000000183A182F0-0x0000000183A185A0
	// [IDTag] // 0x000000018985FD50-0x000000018985FD90
	// [XID] // 0x000000018985FD50-0x000000018985FD90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF017D */, bool useObjectPool = false /* Metadata: 0x00AF0181 */) => default; // 0x0000000183A185A0-0x0000000183A187F0
	// [IDTag] // 0x000000018986A520-0x000000018986A560
	// [XID] // 0x000000018986A520-0x000000018986A560
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0182 */, bool useObjectPool = false /* Metadata: 0x00AF0186 */) => default; // 0x0000000183A187F0-0x0000000183A18B40
}

