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

public static class DragonSpineEnhanceExcelConfigLoader // TypeDefIndex: 14820
{
	// Fields
	private static Dictionary<uint, DragonSpineEnhanceExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DragonSpineEnhanceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DragonSpineEnhanceExcelConfig, DragonSpineEnhanceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DragonSpineEnhanceExcelConfig>, Dictionary<uint, DragonSpineEnhanceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DragonSpineEnhanceExcelConfig> dataDict { /* [XID] */ /* 0x00000001896A4E40-0x00000001896A4E60 */ get; } // 0x000000018150C090-0x000000018150C140 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896B3A30-0x00000001896B3A50 */ get; } // 0x000000018150AC90-0x000000018150AD30 

	// Methods
	// [XID] // 0x00000001896967B0-0x00000001896967D0
	public static uint GetMaxWeaponEnhance() => default; // 0x000000018150B2C0-0x000000018150B510
	// [XID] // 0x000000018969DE50-0x000000018969DE70
	public static void Register() {} // 0x000000018150C470-0x000000018150C510
	// [XID] // 0x00000001896AC710-0x00000001896AC730
	public static DragonSpineEnhanceExcelConfig GetData(uint id) => default; // 0x000000018150AB60-0x000000018150AC90
	// [XID] // 0x00000001896BB130-0x00000001896BB150
	public static void LoadData() {} // 0x000000018150B510-0x000000018150B600
	// [XID] // 0x00000001896C22A0-0x00000001896C22C0
	private static void RegisterHotfixGenerated() {} // 0x000000018150B0F0-0x000000018150B2C0
	// [XID] // 0x00000001896C9870-0x00000001896C9890
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018150AD30-0x000000018150B0F0
	// [IDTag] // 0x00000001896D0FC0-0x00000001896D1000
	// [XID] // 0x00000001896D0FC0-0x00000001896D1000
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018150B9F0-0x000000018150BAF0
	// [XID] // 0x00000001896DB600-0x00000001896DB620
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DragonSpineEnhanceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018150C140-0x000000018150C470
	// [XID] // 0x00000001896E2DA0-0x00000001896E2DC0
	private static bool ParseConfigFromLine(string line, out DragonSpineEnhanceExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018150B600-0x000000018150B740
	// [IDTag] // 0x00000001896EA3E0-0x00000001896EA420
	// [XID] // 0x00000001896EA3E0-0x00000001896EA420
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DragonSpineEnhanceExcelConfig> configList) => default; // 0x000000018150B740-0x000000018150B9F0
	// [IDTag] // 0x00000001896F4960-0x00000001896F49A0
	// [XID] // 0x00000001896F4960-0x00000001896F49A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF684 */, bool useObjectPool = false /* Metadata: 0x00AEF688 */) => default; // 0x000000018150BAF0-0x000000018150BD40
	// [IDTag] // 0x00000001896FF290-0x00000001896FF2D0
	// [XID] // 0x00000001896FF290-0x00000001896FF2D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF689 */, bool useObjectPool = false /* Metadata: 0x00AEF68D */) => default; // 0x000000018150BD40-0x000000018150C090
}

