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

public static class FetterCharacterCardExcelConfigLoader // TypeDefIndex: 15617
{
	// Fields
	private static List<FetterCharacterCardExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<FetterCharacterCardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FetterCharacterCardExcelConfig, FetterCharacterCardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FetterCharacterCardExcelConfig>, List<FetterCharacterCardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<FetterCharacterCardExcelConfig> dataList { /* [XID] */ /* 0x0000000189A136E0-0x0000000189A13700 */ get; } // 0x000000018340F7D0-0x000000018340F880 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A1A830-0x0000000189A1A850 */ get; } // 0x000000018340E5E0-0x000000018340E680 

	// Methods
	// [XID] // 0x0000000189A0BE50-0x0000000189A0BE70
	public static void Register() {} // 0x000000018340FBB0-0x000000018340FC50
	// [XID] // 0x0000000189A220B0-0x0000000189A220D0
	public static void LoadData() {} // 0x000000018340EC80-0x000000018340ED70
	// [XID] // 0x0000000189A29560-0x0000000189A29580
	private static void RegisterHotfixGenerated() {} // 0x000000018340EAB0-0x000000018340EC80
	// [XID] // 0x0000000189A30A70-0x0000000189A30A90
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018340E680-0x000000018340EAB0
	// [IDTag] // 0x0000000189A38510-0x0000000189A38550
	// [XID] // 0x0000000189A38510-0x0000000189A38550
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018340F150-0x000000018340F250
	// [XID] // 0x0000000189A42D30-0x0000000189A42D50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FetterCharacterCardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018340F880-0x000000018340FBB0
	// [XID] // 0x0000000189A4A160-0x0000000189A4A180
	private static bool ParseConfigFromLine(string line, out FetterCharacterCardExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018340ED70-0x000000018340EEB0
	// [IDTag] // 0x0000000189A51AF0-0x0000000189A51B30
	// [XID] // 0x0000000189A51AF0-0x0000000189A51B30
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FetterCharacterCardExcelConfig> configList) => default; // 0x000000018340EEB0-0x000000018340F150
	// [IDTag] // 0x0000000189A5C4C0-0x0000000189A5C500
	// [XID] // 0x0000000189A5C4C0-0x0000000189A5C500
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF20BA */, bool useObjectPool = false /* Metadata: 0x00AF20BE */) => default; // 0x000000018340F250-0x000000018340F4A0
	// [IDTag] // 0x0000000189A66C20-0x0000000189A66C60
	// [XID] // 0x0000000189A66C20-0x0000000189A66C60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20BF */, bool useObjectPool = false /* Metadata: 0x00AF20C3 */) => default; // 0x000000018340F4A0-0x000000018340F7D0
}

