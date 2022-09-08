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

public static class WeaponExcelConfigLoader // TypeDefIndex: 16272
{
	// Fields
	private static Dictionary<uint, WeaponExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeaponExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeaponExcelConfig, WeaponExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeaponExcelConfig>, Dictionary<uint, WeaponExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WeaponExcelConfig> dataDict { /* [XID] */ /* 0x00000001898220F0-0x0000000189822110 */ get; } // 0x0000000184388290-0x0000000184388340 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189830C80-0x0000000189830CA0 */ get; } // 0x00000001843870E0-0x0000000184387180 

	// Methods
	// [XID] // 0x000000018981A960-0x000000018981A980
	public static void Register() {} // 0x0000000184388670-0x0000000184388710
	// [XID] // 0x0000000189829670-0x0000000189829690
	public static WeaponExcelConfig GetData(uint id) => default; // 0x0000000184386FB0-0x00000001843870E0
	// [XID] // 0x0000000189838360-0x0000000189838380
	public static void LoadData() {} // 0x0000000184387710-0x0000000184387800
	// [XID] // 0x000000018983FA30-0x000000018983FA50
	private static void RegisterHotfixGenerated() {} // 0x0000000184387540-0x0000000184387710
	// [XID] // 0x0000000189846FF0-0x0000000189847010
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184387180-0x0000000184387540
	// [IDTag] // 0x000000018984E640-0x000000018984E680
	// [XID] // 0x000000018984E640-0x000000018984E680
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184387940-0x0000000184387A40
	// [XID] // 0x0000000189858A00-0x0000000189858A20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeaponExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184388340-0x0000000184388670
	// [XID] // 0x000000018985FB50-0x000000018985FB70
	private static bool ParseConfigFromLine(string line, out WeaponExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184387800-0x0000000184387940
	// [IDTag] // 0x0000000189867290-0x00000001898672D0
	// [XID] // 0x0000000189867290-0x00000001898672D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeaponExcelConfig> configList) => default; // 0x0000000184387A40-0x0000000184387CF0
	// [IDTag] // 0x0000000189871730-0x0000000189871770
	// [XID] // 0x0000000189871730-0x0000000189871770
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3612 */, bool useObjectPool = false /* Metadata: 0x00AF3616 */) => default; // 0x0000000184387CF0-0x0000000184387F40
	// [IDTag] // 0x000000018987C020-0x000000018987C060
	// [XID] // 0x000000018987C020-0x000000018987C060
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3617 */, bool useObjectPool = false /* Metadata: 0x00AF361B */) => default; // 0x0000000184387F40-0x0000000184388290
}

