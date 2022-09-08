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

public static class EntityMultiPlayerExcelConfigLoader // TypeDefIndex: 15333
{
	// Fields
	private static Dictionary<uint, EntityMultiPlayerExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EntityMultiPlayerExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EntityMultiPlayerExcelConfig, EntityMultiPlayerExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EntityMultiPlayerExcelConfig>, Dictionary<uint, EntityMultiPlayerExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EntityMultiPlayerExcelConfig> dataDict { /* [XID] */ /* 0x00000001897DA490-0x00000001897DA4B0 */ get; } // 0x0000000181B50940-0x0000000181B509F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897E9110-0x00000001897E9130 */ get; } // 0x0000000181B4F790-0x0000000181B4F830 

	// Methods
	// [XID] // 0x00000001897D2790-0x00000001897D27B0
	public static void Register() {} // 0x0000000181B50D20-0x0000000181B50DC0
	// [XID] // 0x00000001897E1960-0x00000001897E1980
	public static EntityMultiPlayerExcelConfig GetData(uint id) => default; // 0x0000000181B4F660-0x0000000181B4F790
	// [XID] // 0x00000001897F0D20-0x00000001897F0D40
	public static void LoadData() {} // 0x0000000181B4FDC0-0x0000000181B4FEB0
	// [XID] // 0x00000001897F8560-0x00000001897F8580
	private static void RegisterHotfixGenerated() {} // 0x0000000181B4FBF0-0x0000000181B4FDC0
	// [XID] // 0x00000001897FFC50-0x00000001897FFC70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181B4F830-0x0000000181B4FBF0
	// [IDTag] // 0x00000001898072B0-0x00000001898072F0
	// [XID] // 0x00000001898072B0-0x00000001898072F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181B502A0-0x0000000181B503A0
	// [XID] // 0x0000000189811860-0x0000000189811880
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EntityMultiPlayerExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181B509F0-0x0000000181B50D20
	// [XID] // 0x0000000189819490-0x00000001898194B0
	private static bool ParseConfigFromLine(string line, out EntityMultiPlayerExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181B4FEB0-0x0000000181B4FFF0
	// [IDTag] // 0x0000000189820C50-0x0000000189820C90
	// [XID] // 0x0000000189820C50-0x0000000189820C90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EntityMultiPlayerExcelConfig> configList) => default; // 0x0000000181B4FFF0-0x0000000181B502A0
	// [IDTag] // 0x000000018982AFB0-0x000000018982AFF0
	// [XID] // 0x000000018982AFB0-0x000000018982AFF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF07D1 */, bool useObjectPool = false /* Metadata: 0x00AF07D5 */) => default; // 0x0000000181B506F0-0x0000000181B50940
	// [IDTag] // 0x0000000189835450-0x0000000189835490
	// [XID] // 0x0000000189835450-0x0000000189835490
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07D6 */, bool useObjectPool = false /* Metadata: 0x00AF07DA */) => default; // 0x0000000181B503A0-0x0000000181B506F0
}

