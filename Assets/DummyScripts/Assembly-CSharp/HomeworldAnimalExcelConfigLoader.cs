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

public static class HomeworldAnimalExcelConfigLoader // TypeDefIndex: 15713
{
	// Fields
	private static Dictionary<uint, HomeworldAnimalExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeworldAnimalExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeworldAnimalExcelConfig, HomeworldAnimalExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeworldAnimalExcelConfig>, Dictionary<uint, HomeworldAnimalExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeworldAnimalExcelConfig> dataDict { /* [XID] */ /* 0x00000001896C9610-0x00000001896C9630 */ get; } // 0x0000000184C5A9D0-0x0000000184C5AA80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896D84F0-0x00000001896D8510 */ get; } // 0x0000000184C59820-0x0000000184C598C0 

	// Methods
	// [XID] // 0x00000001896C2040-0x00000001896C2060
	public static void Register() {} // 0x0000000184C5ADB0-0x0000000184C5AE50
	// [XID] // 0x00000001896D0DE0-0x00000001896D0E00
	public static HomeworldAnimalExcelConfig GetData(uint furnitureID) => default; // 0x0000000184C596F0-0x0000000184C59820
	// [XID] // 0x00000001896DFE20-0x00000001896DFE40
	public static void LoadData() {} // 0x0000000184C59E50-0x0000000184C59F40
	// [XID] // 0x00000001896E7100-0x00000001896E7120
	private static void RegisterHotfixGenerated() {} // 0x0000000184C59C80-0x0000000184C59E50
	// [XID] // 0x00000001896EE730-0x00000001896EE750
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184C598C0-0x0000000184C59C80
	// [IDTag] // 0x00000001896F5FC0-0x00000001896F6000
	// [XID] // 0x00000001896F5FC0-0x00000001896F6000
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184C5A330-0x0000000184C5A430
	// [XID] // 0x00000001897003E0-0x0000000189700400
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeworldAnimalExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184C5AA80-0x0000000184C5ADB0
	// [XID] // 0x0000000189707BB0-0x0000000189707BD0
	private static bool ParseConfigFromLine(string line, out HomeworldAnimalExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184C59F40-0x0000000184C5A080
	// [IDTag] // 0x000000018970F6E0-0x000000018970F720
	// [XID] // 0x000000018970F6E0-0x000000018970F720
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeworldAnimalExcelConfig> configList) => default; // 0x0000000184C5A080-0x0000000184C5A330
	// [IDTag] // 0x0000000189719DB0-0x0000000189719DF0
	// [XID] // 0x0000000189719DB0-0x0000000189719DF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF23F5 */, bool useObjectPool = false /* Metadata: 0x00AF23F9 */) => default; // 0x0000000184C5A780-0x0000000184C5A9D0
	// [IDTag] // 0x0000000189723FD0-0x0000000189724010
	// [XID] // 0x0000000189723FD0-0x0000000189724010
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23FA */, bool useObjectPool = false /* Metadata: 0x00AF23FE */) => default; // 0x0000000184C5A430-0x0000000184C5A780
}

