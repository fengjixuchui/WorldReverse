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

public static class DocumentExcelConfigLoader // TypeDefIndex: 15825
{
	// Fields
	private static Dictionary<uint, DocumentExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DocumentExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DocumentExcelConfig, DocumentExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DocumentExcelConfig>, Dictionary<uint, DocumentExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DocumentExcelConfig> dataDict { /* [XID] */ /* 0x000000018978E070-0x000000018978E090 */ get; } // 0x00000001853B39F0-0x00000001853B3AA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018979DBB0-0x000000018979DBD0 */ get; } // 0x00000001853B2800-0x00000001853B28A0 

	// Methods
	// [XID] // 0x00000001897869C0-0x00000001897869E0
	public static void Register() {} // 0x00000001853B3DD0-0x00000001853B3E70
	// [XID] // 0x0000000189795760-0x0000000189795780
	public static DocumentExcelConfig GetData(uint id) => default; // 0x00000001853B26D0-0x00000001853B2800
	// [XID] // 0x00000001897A4EF0-0x00000001897A4F10
	public static void LoadData() {} // 0x00000001853B2E30-0x00000001853B2F20
	// [XID] // 0x00000001897AC4C0-0x00000001897AC4E0
	private static void RegisterHotfixGenerated() {} // 0x00000001853B2C60-0x00000001853B2E30
	// [XID] // 0x00000001897B4410-0x00000001897B4430
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001853B28A0-0x00000001853B2C60
	// [IDTag] // 0x00000001897BC130-0x00000001897BC170
	// [XID] // 0x00000001897BC130-0x00000001897BC170
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001853B3350-0x00000001853B3450
	// [XID] // 0x00000001897C69E0-0x00000001897C6A00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DocumentExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001853B3AA0-0x00000001853B3DD0
	// [XID] // 0x00000001897CE1C0-0x00000001897CE1E0
	private static bool ParseConfigFromLine(string line, out DocumentExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001853B2F20-0x00000001853B30A0
	// [IDTag] // 0x00000001897D56F0-0x00000001897D5730
	// [XID] // 0x00000001897D56F0-0x00000001897D5730
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DocumentExcelConfig> configList) => default; // 0x00000001853B30A0-0x00000001853B3350
	// [IDTag] // 0x00000001897E0030-0x00000001897E0070
	// [XID] // 0x00000001897E0030-0x00000001897E0070
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2781 */, bool useObjectPool = false /* Metadata: 0x00AF2785 */) => default; // 0x00000001853B37A0-0x00000001853B39F0
	// [IDTag] // 0x00000001897EA840-0x00000001897EA880
	// [XID] // 0x00000001897EA840-0x00000001897EA880
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2786 */, bool useObjectPool = false /* Metadata: 0x00AF278A */) => default; // 0x00000001853B3450-0x00000001853B37A0
}

