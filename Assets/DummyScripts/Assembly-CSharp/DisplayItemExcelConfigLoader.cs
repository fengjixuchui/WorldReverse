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

public static class DisplayItemExcelConfigLoader // TypeDefIndex: 15494
{
	// Fields
	private static Dictionary<uint, DisplayItemExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DisplayItemExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DisplayItemExcelConfig, DisplayItemExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DisplayItemExcelConfig>, Dictionary<uint, DisplayItemExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DisplayItemExcelConfig> dataDict { /* [XID] */ /* 0x0000000189920A50-0x0000000189920A70 */ get; } // 0x0000000185A6AC30-0x0000000185A6ACE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018992F940-0x000000018992F960 */ get; } // 0x0000000185A69A80-0x0000000185A69B20 

	// Methods
	// [XID] // 0x00000001899194A0-0x00000001899194C0
	public static void Register() {} // 0x0000000185A6B010-0x0000000185A6B0B0
	// [XID] // 0x00000001899283B0-0x00000001899283D0
	public static DisplayItemExcelConfig GetData(uint id) => default; // 0x0000000185A69950-0x0000000185A69A80
	// [XID] // 0x0000000189936E50-0x0000000189936E70
	public static void LoadData() {} // 0x0000000185A6A0B0-0x0000000185A6A1A0
	// [XID] // 0x000000018993EA10-0x000000018993EA30
	private static void RegisterHotfixGenerated() {} // 0x0000000185A69EE0-0x0000000185A6A0B0
	// [XID] // 0x00000001899460A0-0x00000001899460C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185A69B20-0x0000000185A69EE0
	// [IDTag] // 0x000000018994D570-0x000000018994D5B0
	// [XID] // 0x000000018994D570-0x000000018994D5B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185A6A2E0-0x0000000185A6A3E0
	// [XID] // 0x0000000189957EC0-0x0000000189957EE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DisplayItemExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185A6ACE0-0x0000000185A6B010
	// [XID] // 0x000000018995F770-0x000000018995F790
	private static bool ParseConfigFromLine(string line, out DisplayItemExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185A6A1A0-0x0000000185A6A2E0
	// [IDTag] // 0x0000000189966F90-0x0000000189966FD0
	// [XID] // 0x0000000189966F90-0x0000000189966FD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DisplayItemExcelConfig> configList) => default; // 0x0000000185A6A3E0-0x0000000185A6A690
	// [IDTag] // 0x0000000189971A00-0x0000000189971A40
	// [XID] // 0x0000000189971A00-0x0000000189971A40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1C48 */, bool useObjectPool = false /* Metadata: 0x00AF1C4C */) => default; // 0x0000000185A6A690-0x0000000185A6A8E0
	// [IDTag] // 0x000000018997BC40-0x000000018997BC80
	// [XID] // 0x000000018997BC40-0x000000018997BC80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C4D */, bool useObjectPool = false /* Metadata: 0x00AF1C51 */) => default; // 0x0000000185A6A8E0-0x0000000185A6AC30
}

