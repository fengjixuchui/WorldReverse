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

public static class H5ActivityExcelConfigLoader // TypeDefIndex: 15694
{
	// Fields
	private static Dictionary<uint, H5ActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<H5ActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<H5ActivityExcelConfig, H5ActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<H5ActivityExcelConfig>, Dictionary<uint, H5ActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, H5ActivityExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BB40B0-0x0000000189BB40D0 */ get; } // 0x0000000182ABDDC0-0x0000000182ABDE70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BC35D0-0x0000000189BC35F0 */ get; } // 0x0000000182ABCC10-0x0000000182ABCCB0 

	// Methods
	// [XID] // 0x0000000189BAC830-0x0000000189BAC850
	public static void Register() {} // 0x0000000182ABE1A0-0x0000000182ABE240
	// [XID] // 0x0000000189BBB790-0x0000000189BBB7B0
	public static H5ActivityExcelConfig GetData(uint h5ActivityId) => default; // 0x0000000182ABCAE0-0x0000000182ABCC10
	// [XID] // 0x0000000189BCADF0-0x0000000189BCAE10
	public static void LoadData() {} // 0x0000000182ABD240-0x0000000182ABD330
	// [XID] // 0x0000000189BD2400-0x0000000189BD2420
	private static void RegisterHotfixGenerated() {} // 0x0000000182ABD070-0x0000000182ABD240
	// [XID] // 0x0000000189BD99E0-0x0000000189BD9A00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182ABCCB0-0x0000000182ABD070
	// [IDTag] // 0x00000001895E6450-0x00000001895E6490
	// [XID] // 0x00000001895E6450-0x00000001895E6490
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182ABD470-0x0000000182ABD570
	// [XID] // 0x00000001895F0DE0-0x00000001895F0E00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<H5ActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182ABDE70-0x0000000182ABE1A0
	// [XID] // 0x00000001895F87F0-0x00000001895F8810
	private static bool ParseConfigFromLine(string line, out H5ActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182ABD330-0x0000000182ABD470
	// [IDTag] // 0x00000001895FFCB0-0x00000001895FFCF0
	// [XID] // 0x00000001895FFCB0-0x00000001895FFCF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<H5ActivityExcelConfig> configList) => default; // 0x0000000182ABD570-0x0000000182ABD820
	// [IDTag] // 0x000000018960A710-0x000000018960A750
	// [XID] // 0x000000018960A710-0x000000018960A750
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2345 */, bool useObjectPool = false /* Metadata: 0x00AF2349 */) => default; // 0x0000000182ABDB70-0x0000000182ABDDC0
	// [IDTag] // 0x0000000189614DE0-0x0000000189614E20
	// [XID] // 0x0000000189614DE0-0x0000000189614E20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF234A */, bool useObjectPool = false /* Metadata: 0x00AF234E */) => default; // 0x0000000182ABD820-0x0000000182ABDB70
}

