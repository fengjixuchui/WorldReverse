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

public static class BoredCreateMonsterExcelConfigLoader // TypeDefIndex: 15291
{
	// Fields
	private static List<BoredCreateMonsterExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<BoredCreateMonsterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BoredCreateMonsterExcelConfig, BoredCreateMonsterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BoredCreateMonsterExcelConfig>, List<BoredCreateMonsterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<BoredCreateMonsterExcelConfig> dataList { /* [XID] */ /* 0x0000000189AC42C0-0x0000000189AC42E0 */ get; } // 0x0000000183AC4880-0x0000000183AC4930 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ACB850-0x0000000189ACB870 */ get; } // 0x0000000183AC3690-0x0000000183AC3730 

	// Methods
	// [XID] // 0x0000000189ABC9E0-0x0000000189ABCA00
	public static void Register() {} // 0x0000000183AC4C60-0x0000000183AC4D00
	// [XID] // 0x0000000189AD3280-0x0000000189AD32A0
	public static void LoadData() {} // 0x0000000183AC3D30-0x0000000183AC3E20
	// [XID] // 0x0000000189ADAD00-0x0000000189ADAD20
	private static void RegisterHotfixGenerated() {} // 0x0000000183AC3B60-0x0000000183AC3D30
	// [XID] // 0x0000000189AE2520-0x0000000189AE2540
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183AC3730-0x0000000183AC3B60
	// [IDTag] // 0x0000000189AE9DB0-0x0000000189AE9DF0
	// [XID] // 0x0000000189AE9DB0-0x0000000189AE9DF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183AC4200-0x0000000183AC4300
	// [XID] // 0x0000000189AF4770-0x0000000189AF4790
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BoredCreateMonsterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183AC4930-0x0000000183AC4C60
	// [XID] // 0x0000000189AFBDE0-0x0000000189AFBE00
	private static bool ParseConfigFromLine(string line, out BoredCreateMonsterExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183AC3E20-0x0000000183AC3F60
	// [IDTag] // 0x0000000189B036B0-0x0000000189B036F0
	// [XID] // 0x0000000189B036B0-0x0000000189B036F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BoredCreateMonsterExcelConfig> configList) => default; // 0x0000000183AC3F60-0x0000000183AC4200
	// [IDTag] // 0x0000000189B0DEF0-0x0000000189B0DF30
	// [XID] // 0x0000000189B0DEF0-0x0000000189B0DF30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0683 */, bool useObjectPool = false /* Metadata: 0x00AF0687 */) => default; // 0x0000000183AC4630-0x0000000183AC4880
	// [IDTag] // 0x0000000189B18340-0x0000000189B18380
	// [XID] // 0x0000000189B18340-0x0000000189B18380
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0688 */, bool useObjectPool = false /* Metadata: 0x00AF068C */) => default; // 0x0000000183AC4300-0x0000000183AC4630
}

