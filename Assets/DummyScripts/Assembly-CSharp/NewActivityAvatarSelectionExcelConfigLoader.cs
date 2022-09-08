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

public static class NewActivityAvatarSelectionExcelConfigLoader // TypeDefIndex: 15898
{
	// Fields
	private static Dictionary<uint, NewActivityAvatarSelectionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityAvatarSelectionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityAvatarSelectionExcelConfig, NewActivityAvatarSelectionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityAvatarSelectionExcelConfig>, Dictionary<uint, NewActivityAvatarSelectionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityAvatarSelectionExcelConfig> dataDict { /* [XID] */ /* 0x00000001896B95D0-0x00000001896B95F0 */ get; } // 0x000000018414C540-0x000000018414C5F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896C8110-0x00000001896C8130 */ get; } // 0x000000018414B390-0x000000018414B430 

	// Methods
	// [XID] // 0x00000001896B1B90-0x00000001896B1BB0
	public static void Register() {} // 0x000000018414C920-0x000000018414CB20
	// [XID] // 0x00000001896C0960-0x00000001896C0980
	public static NewActivityAvatarSelectionExcelConfig GetData(uint scheduleId) => default; // 0x000000018414B260-0x000000018414B390
	// [XID] // 0x00000001896CFA10-0x00000001896CFA30
	public static void LoadData() {} // 0x000000018414B9C0-0x000000018414BAB0
	// [XID] // 0x00000001896D6C80-0x00000001896D6CA0
	private static void RegisterHotfixGenerated() {} // 0x000000018414B7F0-0x000000018414B9C0
	// [XID] // 0x00000001896DE420-0x00000001896DE440
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018414B430-0x000000018414B7F0
	// [IDTag] // 0x00000001896E5830-0x00000001896E5870
	// [XID] // 0x00000001896E5830-0x00000001896E5870
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018414BBF0-0x000000018414BCF0
	// [XID] // 0x00000001896EFC40-0x00000001896EFC60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityAvatarSelectionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018414C5F0-0x000000018414C920
	// [XID] // 0x00000001896F7650-0x00000001896F7670
	private static bool ParseConfigFromLine(string line, out NewActivityAvatarSelectionExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018414BAB0-0x000000018414BBF0
	// [IDTag] // 0x00000001896FF070-0x00000001896FF0B0
	// [XID] // 0x00000001896FF070-0x00000001896FF0B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityAvatarSelectionExcelConfig> configList) => default; // 0x000000018414BCF0-0x000000018414BFA0
	// [IDTag] // 0x0000000189709560-0x00000001897095A0
	// [XID] // 0x0000000189709560-0x00000001897095A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2A91 */, bool useObjectPool = false /* Metadata: 0x00AF2A95 */) => default; // 0x000000018414BFA0-0x000000018414C1F0
	// [IDTag] // 0x0000000189713D40-0x0000000189713D80
	// [XID] // 0x0000000189713D40-0x0000000189713D80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A96 */, bool useObjectPool = false /* Metadata: 0x00AF2A9A */) => default; // 0x000000018414C1F0-0x000000018414C540
}

