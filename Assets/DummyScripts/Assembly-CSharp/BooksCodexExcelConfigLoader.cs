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

public static class BooksCodexExcelConfigLoader // TypeDefIndex: 15318
{
	// Fields
	private static Dictionary<uint, BooksCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BooksCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BooksCodexExcelConfig, BooksCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BooksCodexExcelConfig>, Dictionary<uint, BooksCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BooksCodexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B77870-0x0000000189B77890 */ get; } // 0x0000000182053FB0-0x0000000182054060 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B86A40-0x0000000189B86A60 */ get; } // 0x0000000182052E00-0x0000000182052EA0 

	// Methods
	// [XID] // 0x0000000189B70380-0x0000000189B703A0
	public static void Register() {} // 0x0000000182054390-0x0000000182054430
	// [XID] // 0x0000000189B7EEA0-0x0000000189B7EEC0
	public static BooksCodexExcelConfig GetData(uint Id) => default; // 0x0000000182052CD0-0x0000000182052E00
	// [XID] // 0x0000000189B8DBD0-0x0000000189B8DBF0
	public static void LoadData() {} // 0x0000000182053430-0x0000000182053520
	// [XID] // 0x0000000189B95110-0x0000000189B95130
	private static void RegisterHotfixGenerated() {} // 0x0000000182053260-0x0000000182053430
	// [XID] // 0x0000000189B9C7A0-0x0000000189B9C7C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182052EA0-0x0000000182053260
	// [IDTag] // 0x0000000189BA3E70-0x0000000189BA3EB0
	// [XID] // 0x0000000189BA3E70-0x0000000189BA3EB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182053660-0x0000000182053760
	// [XID] // 0x0000000189BADF20-0x0000000189BADF40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BooksCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182054060-0x0000000182054390
	// [XID] // 0x0000000189BB57F0-0x0000000189BB5810
	private static bool ParseConfigFromLine(string line, out BooksCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182053520-0x0000000182053660
	// [IDTag] // 0x0000000189BBCE60-0x0000000189BBCEA0
	// [XID] // 0x0000000189BBCE60-0x0000000189BBCEA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BooksCodexExcelConfig> configList) => default; // 0x0000000182053760-0x0000000182053A10
	// [IDTag] // 0x0000000189BC7920-0x0000000189BC7960
	// [XID] // 0x0000000189BC7920-0x0000000189BC7960
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0763 */, bool useObjectPool = false /* Metadata: 0x00AF0767 */) => default; // 0x0000000182053D60-0x0000000182053FB0
	// [IDTag] // 0x0000000189BD24C0-0x0000000189BD2500
	// [XID] // 0x0000000189BD24C0-0x0000000189BD2500
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0768 */, bool useObjectPool = false /* Metadata: 0x00AF076C */) => default; // 0x0000000182053A10-0x0000000182053D60
}

