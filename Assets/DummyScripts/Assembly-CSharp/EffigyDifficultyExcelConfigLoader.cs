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

public static class EffigyDifficultyExcelConfigLoader // TypeDefIndex: 15078
{
	// Fields
	private static Dictionary<uint, EffigyDifficultyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EffigyDifficultyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EffigyDifficultyExcelConfig, EffigyDifficultyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EffigyDifficultyExcelConfig>, Dictionary<uint, EffigyDifficultyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EffigyDifficultyExcelConfig> dataDict { /* [XID] */ /* 0x00000001896BAFF0-0x00000001896BB010 */ get; } // 0x00000001820FDD20-0x00000001820FDDD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896C9770-0x00000001896C9790 */ get; } // 0x00000001820FCB70-0x00000001820FCC10 

	// Methods
	// [XID] // 0x00000001896B3910-0x00000001896B3930
	public static void Register() {} // 0x00000001820FE100-0x00000001820FE1A0
	// [XID] // 0x00000001896C2160-0x00000001896C2180
	public static EffigyDifficultyExcelConfig GetData(uint id) => default; // 0x00000001820FCA40-0x00000001820FCB70
	// [XID] // 0x00000001896D0EE0-0x00000001896D0F00
	public static void LoadData() {} // 0x00000001820FD1A0-0x00000001820FD290
	// [XID] // 0x00000001896D8650-0x00000001896D8670
	private static void RegisterHotfixGenerated() {} // 0x00000001820FCFD0-0x00000001820FD1A0
	// [XID] // 0x00000001896E0000-0x00000001896E0020
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001820FCC10-0x00000001820FCFD0
	// [IDTag] // 0x00000001896E7220-0x00000001896E7260
	// [XID] // 0x00000001896E7220-0x00000001896E7260
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820FD680-0x00000001820FD780
	// [XID] // 0x00000001896F1300-0x00000001896F1320
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EffigyDifficultyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001820FDDD0-0x00000001820FE100
	// [XID] // 0x00000001896F8CC0-0x00000001896F8CE0
	private static bool ParseConfigFromLine(string line, out EffigyDifficultyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001820FD290-0x00000001820FD3D0
	// [IDTag] // 0x0000000189700500-0x0000000189700540
	// [XID] // 0x0000000189700500-0x0000000189700540
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EffigyDifficultyExcelConfig> configList) => default; // 0x00000001820FD3D0-0x00000001820FD680
	// [IDTag] // 0x000000018970AC80-0x000000018970ACC0
	// [XID] // 0x000000018970AC80-0x000000018970ACC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0030 */, bool useObjectPool = false /* Metadata: 0x00AF0034 */) => default; // 0x00000001820FDAD0-0x00000001820FDD20
	// [IDTag] // 0x00000001897151F0-0x0000000189715230
	// [XID] // 0x00000001897151F0-0x0000000189715230
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0035 */, bool useObjectPool = false /* Metadata: 0x00AF0039 */) => default; // 0x00000001820FD780-0x00000001820FDAD0
}

