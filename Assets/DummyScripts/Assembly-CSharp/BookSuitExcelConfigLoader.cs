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

public static class BookSuitExcelConfigLoader // TypeDefIndex: 15830
{
	// Fields
	private static Dictionary<uint, BookSuitExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BookSuitExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BookSuitExcelConfig, BookSuitExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BookSuitExcelConfig>, Dictionary<uint, BookSuitExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BookSuitExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A26620-0x0000000189A26640 */ get; } // 0x0000000181F27D50-0x0000000181F27E00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A35510-0x0000000189A35530 */ get; } // 0x0000000181F26BA0-0x0000000181F26C40 

	// Methods
	// [XID] // 0x0000000189A1EFF0-0x0000000189A1F010
	public static void Register() {} // 0x0000000181F28130-0x0000000181F281D0
	// [XID] // 0x0000000189A2D970-0x0000000189A2D990
	public static BookSuitExcelConfig GetData(uint id) => default; // 0x0000000181F26A70-0x0000000181F26BA0
	// [XID] // 0x0000000189A3C9C0-0x0000000189A3C9E0
	public static void LoadData() {} // 0x0000000181F271D0-0x0000000181F272C0
	// [XID] // 0x0000000189A44430-0x0000000189A44450
	private static void RegisterHotfixGenerated() {} // 0x0000000181F27000-0x0000000181F271D0
	// [XID] // 0x0000000189A4B9E0-0x0000000189A4BA00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F26C40-0x0000000181F27000
	// [IDTag] // 0x0000000189A530A0-0x0000000189A530E0
	// [XID] // 0x0000000189A530A0-0x0000000189A530E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F276B0-0x0000000181F277B0
	// [XID] // 0x0000000189A5DD00-0x0000000189A5DD20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BookSuitExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F27E00-0x0000000181F28130
	// [XID] // 0x0000000189A65500-0x0000000189A65520
	private static bool ParseConfigFromLine(string line, out BookSuitExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F272C0-0x0000000181F27400
	// [IDTag] // 0x0000000189A6CBE0-0x0000000189A6CC20
	// [XID] // 0x0000000189A6CBE0-0x0000000189A6CC20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BookSuitExcelConfig> configList) => default; // 0x0000000181F27400-0x0000000181F276B0
	// [IDTag] // 0x0000000189A77450-0x0000000189A77490
	// [XID] // 0x0000000189A77450-0x0000000189A77490
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF27A4 */, bool useObjectPool = false /* Metadata: 0x00AF27A8 */) => default; // 0x0000000181F27B00-0x0000000181F27D50
	// [IDTag] // 0x0000000189A81E10-0x0000000189A81E50
	// [XID] // 0x0000000189A81E10-0x0000000189A81E50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF27A9 */, bool useObjectPool = false /* Metadata: 0x00AF27AD */) => default; // 0x0000000181F277B0-0x0000000181F27B00
}

