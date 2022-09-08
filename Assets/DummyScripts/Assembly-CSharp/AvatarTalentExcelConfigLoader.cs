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

public static class AvatarTalentExcelConfigLoader // TypeDefIndex: 15242
{
	// Fields
	private static Dictionary<uint, AvatarTalentExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarTalentExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarTalentExcelConfig, AvatarTalentExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarTalentExcelConfig>, Dictionary<uint, AvatarTalentExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarTalentExcelConfig> dataDict { /* [XID] */ /* 0x000000018971CD00-0x000000018971CD20 */ get; } // 0x0000000182797230-0x00000001827972E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018972B850-0x000000018972B870 */ get; } // 0x0000000182796080-0x0000000182796120 

	// Methods
	// [XID] // 0x0000000189715190-0x00000001897151B0
	public static void Register() {} // 0x0000000182797610-0x00000001827976B0
	// [XID] // 0x00000001897240F0-0x0000000189724110
	public static AvatarTalentExcelConfig GetData(uint talentId) => default; // 0x0000000182795F50-0x0000000182796080
	// [XID] // 0x0000000189733020-0x0000000189733040
	public static void LoadData() {} // 0x00000001827966B0-0x00000001827967A0
	// [XID] // 0x000000018973A6D0-0x000000018973A6F0
	private static void RegisterHotfixGenerated() {} // 0x00000001827964E0-0x00000001827966B0
	// [XID] // 0x0000000189742080-0x00000001897420A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182796120-0x00000001827964E0
	// [IDTag] // 0x0000000189749AE0-0x0000000189749B20
	// [XID] // 0x0000000189749AE0-0x0000000189749B20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182796B90-0x0000000182796C90
	// [XID] // 0x0000000189753F40-0x0000000189753F60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarTalentExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001827972E0-0x0000000182797610
	// [XID] // 0x000000018975B480-0x000000018975B4A0
	private static bool ParseConfigFromLine(string line, out AvatarTalentExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001827967A0-0x00000001827968E0
	// [IDTag] // 0x0000000189762E90-0x0000000189762ED0
	// [XID] // 0x0000000189762E90-0x0000000189762ED0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarTalentExcelConfig> configList) => default; // 0x00000001827968E0-0x0000000182796B90
	// [IDTag] // 0x000000018976D480-0x000000018976D4C0
	// [XID] // 0x000000018976D480-0x000000018976D4C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0500 */, bool useObjectPool = false /* Metadata: 0x00AF0504 */) => default; // 0x0000000182796C90-0x0000000182796EE0
	// [IDTag] // 0x00000001897779F0-0x0000000189777A30
	// [XID] // 0x00000001897779F0-0x0000000189777A30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0505 */, bool useObjectPool = false /* Metadata: 0x00AF0509 */) => default; // 0x0000000182796EE0-0x0000000182797230
}

