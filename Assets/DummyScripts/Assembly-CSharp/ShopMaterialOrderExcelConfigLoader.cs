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

public static class ShopMaterialOrderExcelConfigLoader // TypeDefIndex: 16116
{
	// Fields
	private static Dictionary<uint, ShopMaterialOrderExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopMaterialOrderExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopMaterialOrderExcelConfig, ShopMaterialOrderExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopMaterialOrderExcelConfig>, Dictionary<uint, ShopMaterialOrderExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ShopMaterialOrderExcelConfig> dataDict { /* [XID] */ /* 0x000000018969A7F0-0x000000018969A810 */ get; } // 0x00000001850810B0-0x0000000185081160 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896A9440-0x00000001896A9460 */ get; } // 0x000000018507FF00-0x000000018507FFA0 

	// Methods
	// [XID] // 0x0000000189693540-0x0000000189693560
	public static void Register() {} // 0x0000000185081490-0x0000000185081530
	// [XID] // 0x00000001896A2200-0x00000001896A2220
	public static ShopMaterialOrderExcelConfig GetData(uint Id) => default; // 0x000000018507FDD0-0x000000018507FF00
	// [XID] // 0x00000001896B0570-0x00000001896B0590
	public static void LoadData() {} // 0x0000000185080530-0x0000000185080620
	// [XID] // 0x00000001896B7FB0-0x00000001896B7FD0
	private static void RegisterHotfixGenerated() {} // 0x0000000185080360-0x0000000185080530
	// [XID] // 0x00000001896BF010-0x00000001896BF030
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018507FFA0-0x0000000185080360
	// [IDTag] // 0x00000001896C6950-0x00000001896C6990
	// [XID] // 0x00000001896C6950-0x00000001896C6990
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185080760-0x0000000185080860
	// [XID] // 0x00000001896D0DA0-0x00000001896D0DC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopMaterialOrderExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185081160-0x0000000185081490
	// [XID] // 0x00000001896D8410-0x00000001896D8430
	private static bool ParseConfigFromLine(string line, out ShopMaterialOrderExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185080620-0x0000000185080760
	// [IDTag] // 0x00000001896DFDC0-0x00000001896DFE00
	// [XID] // 0x00000001896DFDC0-0x00000001896DFE00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopMaterialOrderExcelConfig> configList) => default; // 0x0000000185080860-0x0000000185080B10
	// [IDTag] // 0x00000001896EA1A0-0x00000001896EA1E0
	// [XID] // 0x00000001896EA1A0-0x00000001896EA1E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF319F */, bool useObjectPool = false /* Metadata: 0x00AF31A3 */) => default; // 0x0000000185080E60-0x00000001850810B0
	// [IDTag] // 0x00000001896F46E0-0x00000001896F4720
	// [XID] // 0x00000001896F46E0-0x00000001896F4720
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF31A4 */, bool useObjectPool = false /* Metadata: 0x00AF31A8 */) => default; // 0x0000000185080B10-0x0000000185080E60
}

