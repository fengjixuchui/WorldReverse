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

public static class AvatarFettersLevelExcelConfigLoader // TypeDefIndex: 15213
{
	// Fields
	private static List<AvatarFettersLevelExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarFettersLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarFettersLevelExcelConfig, AvatarFettersLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarFettersLevelExcelConfig>, List<AvatarFettersLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<AvatarFettersLevelExcelConfig> dataList { /* [XID] */ /* 0x00000001898CF270-0x00000001898CF290 */ get; } // 0x0000000184343380-0x0000000184343430 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898D6AE0-0x00000001898D6B00 */ get; } // 0x0000000184342190-0x0000000184342230 

	// Methods
	// [XID] // 0x00000001898C7B60-0x00000001898C7B80
	public static void Register() {} // 0x0000000184343760-0x0000000184343800
	// [XID] // 0x00000001898DE740-0x00000001898DE760
	public static void LoadData() {} // 0x0000000184342830-0x0000000184342920
	// [XID] // 0x00000001898E5FA0-0x00000001898E5FC0
	private static void RegisterHotfixGenerated() {} // 0x0000000184342660-0x0000000184342830
	// [XID] // 0x00000001898ED8C0-0x00000001898ED8E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184342230-0x0000000184342660
	// [IDTag] // 0x00000001898F5140-0x00000001898F5180
	// [XID] // 0x00000001898F5140-0x00000001898F5180
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184342D00-0x0000000184342E00
	// [XID] // 0x00000001898FF9D0-0x00000001898FF9F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarFettersLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184343430-0x0000000184343760
	// [XID] // 0x0000000189907230-0x0000000189907250
	private static bool ParseConfigFromLine(string line, out AvatarFettersLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184342920-0x0000000184342A60
	// [IDTag] // 0x000000018990EC10-0x000000018990EC50
	// [XID] // 0x000000018990EC10-0x000000018990EC50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarFettersLevelExcelConfig> configList) => default; // 0x0000000184342A60-0x0000000184342D00
	// [IDTag] // 0x0000000189919520-0x0000000189919560
	// [XID] // 0x0000000189919520-0x0000000189919560
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF03FD */, bool useObjectPool = false /* Metadata: 0x00AF0401 */) => default; // 0x0000000184342E00-0x0000000184343050
	// [IDTag] // 0x0000000189923E20-0x0000000189923E60
	// [XID] // 0x0000000189923E20-0x0000000189923E60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0402 */, bool useObjectPool = false /* Metadata: 0x00AF0406 */) => default; // 0x0000000184343050-0x0000000184343380
}

