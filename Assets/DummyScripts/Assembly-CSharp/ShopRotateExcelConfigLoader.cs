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

public static class ShopRotateExcelConfigLoader // TypeDefIndex: 16114
{
	// Fields
	private static Dictionary<uint, ShopRotateExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopRotateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopRotateExcelConfig, ShopRotateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopRotateExcelConfig>, Dictionary<uint, ShopRotateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ShopRotateExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B93A10-0x0000000189B93A30 */ get; } // 0x0000000182984200-0x00000001829842B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BA27F0-0x0000000189BA2810 */ get; } // 0x0000000182983050-0x00000001829830F0 

	// Methods
	// [XID] // 0x0000000189B8C180-0x0000000189B8C1A0
	public static void Register() {} // 0x00000001829845E0-0x0000000182984680
	// [XID] // 0x0000000189B9AFE0-0x0000000189B9B000
	public static ShopRotateExcelConfig GetData(uint id) => default; // 0x0000000182982F20-0x0000000182983050
	// [XID] // 0x0000000189BA9C00-0x0000000189BA9C20
	public static void LoadData() {} // 0x0000000182983680-0x0000000182983770
	// [XID] // 0x0000000189BB1510-0x0000000189BB1530
	private static void RegisterHotfixGenerated() {} // 0x00000001829834B0-0x0000000182983680
	// [XID] // 0x0000000189BB84E0-0x0000000189BB8500
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001829830F0-0x00000001829834B0
	// [IDTag] // 0x0000000189BBFD50-0x0000000189BBFD90
	// [XID] // 0x0000000189BBFD50-0x0000000189BBFD90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182983B60-0x0000000182983C60
	// [XID] // 0x0000000189BCAC90-0x0000000189BCACB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopRotateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001829842B0-0x00000001829845E0
	// [XID] // 0x0000000189BD2340-0x0000000189BD2360
	private static bool ParseConfigFromLine(string line, out ShopRotateExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182983770-0x00000001829838B0
	// [IDTag] // 0x0000000189BD98C0-0x0000000189BD9900
	// [XID] // 0x0000000189BD98C0-0x0000000189BD9900
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopRotateExcelConfig> configList) => default; // 0x00000001829838B0-0x0000000182983B60
	// [IDTag] // 0x00000001895E94B0-0x00000001895E94F0
	// [XID] // 0x00000001895E94B0-0x00000001895E94F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3190 */, bool useObjectPool = false /* Metadata: 0x00AF3194 */) => default; // 0x0000000182983C60-0x0000000182983EB0
	// [IDTag] // 0x00000001895F3C30-0x00000001895F3C70
	// [XID] // 0x00000001895F3C30-0x00000001895F3C70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3195 */, bool useObjectPool = false /* Metadata: 0x00AF3199 */) => default; // 0x0000000182983EB0-0x0000000182984200
}

