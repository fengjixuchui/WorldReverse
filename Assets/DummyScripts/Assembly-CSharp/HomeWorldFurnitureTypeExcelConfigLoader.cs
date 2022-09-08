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

public static class HomeWorldFurnitureTypeExcelConfigLoader // TypeDefIndex: 14870
{
	// Fields
	private static List<uint> _screenIdList; // 0x00
	private static Dictionary<uint, HomeWorldFurnitureTypeExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<HomeWorldFurnitureTypeExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<HomeWorldFurnitureTypeExcelConfig, HomeWorldFurnitureTypeExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<HomeWorldFurnitureTypeExcelConfig>, Dictionary<uint, HomeWorldFurnitureTypeExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<uint> screenIdList { /* [XID] */ /* 0x00000001896283D0-0x00000001896283F0 */ get; } // 0x000000018196B650-0x000000018196B770 
	public static Dictionary<uint, HomeWorldFurnitureTypeExcelConfig> dataDict { /* [XID] */ /* 0x000000018963ECE0-0x000000018963ED00 */ get; } // 0x000000018196B230-0x000000018196B300 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018964DD20-0x000000018964DD40 */ get; } // 0x0000000181969A30-0x0000000181969AD0 

	// Constructors
	static HomeWorldFurnitureTypeExcelConfigLoader() {} // 0x000000018196B830-0x000000018196B890

	// Methods
	// [XID] // 0x000000018962FCE0-0x000000018962FD00
	private static void Build() {} // 0x000000018196A220-0x000000018196A4D0
	// [XID] // 0x0000000189637980-0x00000001896379A0
	public static void Register() {} // 0x000000018196B770-0x000000018196B830
	// [XID] // 0x00000001896464E0-0x0000000189646500
	public static HomeWorldFurnitureTypeExcelConfig GetData(uint typeID) => default; // 0x0000000181969890-0x0000000181969A30
	// [XID] // 0x0000000189655560-0x0000000189655580
	public static void LoadData() {} // 0x000000018196A4D0-0x000000018196A600
	// [XID] // 0x000000018965CD20-0x000000018965CD40
	private static void RegisterHotfixGenerated() {} // 0x0000000181969FB0-0x000000018196A220
	// [XID] // 0x0000000189664220-0x0000000189664240
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181969AD0-0x0000000181969FB0
	// [IDTag] // 0x000000018966B960-0x000000018966B9A0
	// [XID] // 0x000000018966B960-0x000000018966B9A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018196AA90-0x000000018196ABF0
	// [XID] // 0x0000000189676780-0x00000001896767A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldFurnitureTypeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018196B300-0x000000018196B650
	// [XID] // 0x000000018967DF40-0x000000018967DF60
	private static bool ParseConfigFromLine(string line, out HomeWorldFurnitureTypeExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018196A600-0x000000018196A740
	// [IDTag] // 0x0000000189685760-0x00000001896857A0
	// [XID] // 0x0000000189685760-0x00000001896857A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldFurnitureTypeExcelConfig> configList) => default; // 0x000000018196A740-0x000000018196AA90
	// [IDTag] // 0x00000001896906C0-0x0000000189690700
	// [XID] // 0x00000001896906C0-0x0000000189690700
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF882 */, bool useObjectPool = false /* Metadata: 0x00AEF886 */) => default; // 0x000000018196AF80-0x000000018196B230
	// [IDTag] // 0x000000018969AA90-0x000000018969AAD0
	// [XID] // 0x000000018969AA90-0x000000018969AAD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF887 */, bool useObjectPool = false /* Metadata: 0x00AEF88B */) => default; // 0x000000018196ABF0-0x000000018196AF80
}

