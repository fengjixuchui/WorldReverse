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

public static class HomeWorldFurnitureExcelConfigLoader // TypeDefIndex: 15707
{
	// Fields
	private static Dictionary<uint, HomeWorldFurnitureExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldFurnitureExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldFurnitureExcelConfig, HomeWorldFurnitureExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldFurnitureExcelConfig>, Dictionary<uint, HomeWorldFurnitureExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldFurnitureExcelConfig> dataDict { /* [XID] */ /* 0x00000001899944B0-0x00000001899944D0 */ get; } // 0x0000000182B72EA0-0x0000000182B72F50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A34F0-0x00000001899A3510 */ get; } // 0x0000000182B71CF0-0x0000000182B71D90 

	// Methods
	// [XID] // 0x000000018998C750-0x000000018998C770
	public static void Register() {} // 0x0000000182B73280-0x0000000182B733D0
	// [XID] // 0x0000000189B08400-0x0000000189B08420
	public static HomeWorldFurnitureExcelConfig GetData(uint id) => default; // 0x0000000182B71BC0-0x0000000182B71CF0
	// [XID] // 0x00000001899AAFE0-0x00000001899AB000
	public static void LoadData() {} // 0x0000000182B72320-0x0000000182B72410
	// [XID] // 0x00000001899B2A50-0x00000001899B2A70
	private static void RegisterHotfixGenerated() {} // 0x0000000182B72150-0x0000000182B72320
	// [XID] // 0x00000001899B9BB0-0x00000001899B9BD0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B71D90-0x0000000182B72150
	// [IDTag] // 0x00000001899C16F0-0x00000001899C1730
	// [XID] // 0x00000001899C16F0-0x00000001899C1730
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B72800-0x0000000182B72900
	// [XID] // 0x00000001899CBFA0-0x00000001899CBFC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldFurnitureExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B72F50-0x0000000182B73280
	// [XID] // 0x00000001899D34D0-0x00000001899D34F0
	private static bool ParseConfigFromLine(string line, out HomeWorldFurnitureExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B72410-0x0000000182B72550
	// [IDTag] // 0x00000001899DAB20-0x00000001899DAB60
	// [XID] // 0x00000001899DAB20-0x00000001899DAB60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldFurnitureExcelConfig> configList) => default; // 0x0000000182B72550-0x0000000182B72800
	// [IDTag] // 0x00000001899E5740-0x00000001899E5780
	// [XID] // 0x00000001899E5740-0x00000001899E5780
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF23C8 */, bool useObjectPool = false /* Metadata: 0x00AF23CC */) => default; // 0x0000000182B72C50-0x0000000182B72EA0
	// [IDTag] // 0x00000001899EFAB0-0x00000001899EFAF0
	// [XID] // 0x00000001899EFAB0-0x00000001899EFAF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23CD */, bool useObjectPool = false /* Metadata: 0x00AF23D1 */) => default; // 0x0000000182B72900-0x0000000182B72C50
}

