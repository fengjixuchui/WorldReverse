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

public static class BoredEventExcelConfigLoader // TypeDefIndex: 15286
{
	// Fields
	private static List<BoredEventExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<BoredEventExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BoredEventExcelConfig, BoredEventExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BoredEventExcelConfig>, List<BoredEventExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<BoredEventExcelConfig> dataList { /* [XID] */ /* 0x000000018987DC40-0x000000018987DC60 */ get; } // 0x0000000183C60F80-0x0000000183C61030 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189884BD0-0x0000000189884BF0 */ get; } // 0x0000000183C5FD90-0x0000000183C5FE30 

	// Methods
	// [XID] // 0x0000000189876020-0x0000000189876040
	public static void Register() {} // 0x0000000183C61360-0x0000000183C61400
	// [XID] // 0x000000018988C1E0-0x000000018988C200
	public static void LoadData() {} // 0x0000000183C60430-0x0000000183C60520
	// [XID] // 0x00000001898937F0-0x0000000189893810
	private static void RegisterHotfixGenerated() {} // 0x0000000183C60260-0x0000000183C60430
	// [XID] // 0x000000018989AF30-0x000000018989AF50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183C5FE30-0x0000000183C60260
	// [IDTag] // 0x00000001898A2280-0x00000001898A22C0
	// [XID] // 0x00000001898A2280-0x00000001898A22C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183C60900-0x0000000183C60A00
	// [XID] // 0x00000001898ACB00-0x00000001898ACB20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BoredEventExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183C61030-0x0000000183C61360
	// [XID] // 0x00000001898B3F80-0x00000001898B3FA0
	private static bool ParseConfigFromLine(string line, out BoredEventExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183C60520-0x0000000183C60660
	// [IDTag] // 0x00000001898BBC50-0x00000001898BBC90
	// [XID] // 0x00000001898BBC50-0x00000001898BBC90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BoredEventExcelConfig> configList) => default; // 0x0000000183C60660-0x0000000183C60900
	// [IDTag] // 0x00000001898C5FF0-0x00000001898C6030
	// [XID] // 0x00000001898C5FF0-0x00000001898C6030
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0660 */, bool useObjectPool = false /* Metadata: 0x00AF0664 */) => default; // 0x0000000183C60A00-0x0000000183C60C50
	// [IDTag] // 0x00000001898D0AC0-0x00000001898D0B00
	// [XID] // 0x00000001898D0AC0-0x00000001898D0B00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0665 */, bool useObjectPool = false /* Metadata: 0x00AF0669 */) => default; // 0x0000000183C60C50-0x0000000183C60F80
}

