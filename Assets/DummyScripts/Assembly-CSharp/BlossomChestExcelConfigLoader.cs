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

public static class BlossomChestExcelConfigLoader // TypeDefIndex: 15276
{
	// Fields
	private static Dictionary<uint, BlossomChestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomChestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomChestExcelConfig, BlossomChestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomChestExcelConfig>, Dictionary<uint, BlossomChestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomChestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B3A470-0x0000000189B3A490 */ get; } // 0x0000000182506CF0-0x0000000182506DA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B49860-0x0000000189B49880 */ get; } // 0x0000000182505B40-0x0000000182505BE0 

	// Methods
	// [XID] // 0x0000000189B32B00-0x0000000189B32B20
	public static void Register() {} // 0x00000001825070D0-0x0000000182507190
	// [XID] // 0x0000000189B41EB0-0x0000000189B41ED0
	public static BlossomChestExcelConfig GetData(uint id) => default; // 0x0000000182505A10-0x0000000182505B40
	// [XID] // 0x0000000189B50EE0-0x0000000189B50F00
	public static void LoadData() {} // 0x0000000182506170-0x0000000182506260
	// [XID] // 0x0000000189B58710-0x0000000189B58730
	private static void RegisterHotfixGenerated() {} // 0x0000000182505FA0-0x0000000182506170
	// [XID] // 0x0000000189B600A0-0x0000000189B600C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182505BE0-0x0000000182505FA0
	// [IDTag] // 0x0000000189B67760-0x0000000189B677A0
	// [XID] // 0x0000000189B67760-0x0000000189B677A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182506650-0x0000000182506750
	// [XID] // 0x0000000189B71CD0-0x0000000189B71CF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomChestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182506DA0-0x00000001825070D0
	// [XID] // 0x0000000189B79040-0x0000000189B79060
	private static bool ParseConfigFromLine(string line, out BlossomChestExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182506260-0x00000001825063A0
	// [IDTag] // 0x0000000189B80570-0x0000000189B805B0
	// [XID] // 0x0000000189B80570-0x0000000189B805B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomChestExcelConfig> configList) => default; // 0x00000001825063A0-0x0000000182506650
	// [IDTag] // 0x0000000189B8ABF0-0x0000000189B8AC30
	// [XID] // 0x0000000189B8ABF0-0x0000000189B8AC30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF05FF */, bool useObjectPool = false /* Metadata: 0x00AF0603 */) => default; // 0x0000000182506750-0x00000001825069A0
	// [IDTag] // 0x0000000189B95130-0x0000000189B95170
	// [XID] // 0x0000000189B95130-0x0000000189B95170
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0604 */, bool useObjectPool = false /* Metadata: 0x00AF0608 */) => default; // 0x00000001825069A0-0x0000000182506CF0
}

