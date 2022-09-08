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

public static class CookRecipeExcelConfigLoader // TypeDefIndex: 15447
{
	// Fields
	private static Dictionary<uint, CookRecipeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CookRecipeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CookRecipeExcelConfig, CookRecipeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CookRecipeExcelConfig>, Dictionary<uint, CookRecipeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CookRecipeExcelConfig> dataDict { /* [XID] */ /* 0x00000001899B2AF0-0x00000001899B2B10 */ get; } // 0x0000000183771D20-0x0000000183771DD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899C17B0-0x00000001899C17D0 */ get; } // 0x0000000183770B70-0x0000000183770C10 

	// Methods
	// [XID] // 0x00000001899AB0A0-0x00000001899AB0C0
	public static void Register() {} // 0x0000000183772100-0x00000001837721A0
	// [XID] // 0x00000001899B9C90-0x00000001899B9CB0
	public static CookRecipeExcelConfig GetData(uint id) => default; // 0x0000000183770A40-0x0000000183770B70
	// [XID] // 0x00000001899C8D40-0x00000001899C8D60
	public static void LoadData() {} // 0x00000001837711A0-0x0000000183771290
	// [XID] // 0x00000001899D06F0-0x00000001899D0710
	private static void RegisterHotfixGenerated() {} // 0x0000000183770FD0-0x00000001837711A0
	// [XID] // 0x00000001899D7BD0-0x00000001899D7BF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183770C10-0x0000000183770FD0
	// [IDTag] // 0x00000001899DF110-0x00000001899DF150
	// [XID] // 0x00000001899DF110-0x00000001899DF150
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837713D0-0x00000001837714D0
	// [XID] // 0x00000001899E9940-0x00000001899E9960
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CookRecipeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183771DD0-0x0000000183772100
	// [XID] // 0x00000001899F1150-0x00000001899F1170
	private static bool ParseConfigFromLine(string line, out CookRecipeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183771290-0x00000001837713D0
	// [IDTag] // 0x00000001899F8A10-0x00000001899F8A50
	// [XID] // 0x00000001899F8A10-0x00000001899F8A50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CookRecipeExcelConfig> configList) => default; // 0x00000001837714D0-0x0000000183771780
	// [IDTag] // 0x0000000189A030B0-0x0000000189A030F0
	// [XID] // 0x0000000189A030B0-0x0000000189A030F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1AB8 */, bool useObjectPool = false /* Metadata: 0x00AF1ABC */) => default; // 0x0000000183771780-0x00000001837719D0
	// [IDTag] // 0x0000000189A0D6C0-0x0000000189A0D700
	// [XID] // 0x0000000189A0D6C0-0x0000000189A0D700
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1ABD */, bool useObjectPool = false /* Metadata: 0x00AF1AC1 */) => default; // 0x00000001837719D0-0x0000000183771D20
}

