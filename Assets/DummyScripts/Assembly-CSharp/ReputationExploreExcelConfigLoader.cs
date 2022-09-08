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

public static class ReputationExploreExcelConfigLoader // TypeDefIndex: 14908
{
	// Fields
	private static List<ReputationExploreExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReputationExploreExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReputationExploreExcelConfig, ReputationExploreExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReputationExploreExcelConfig>, List<ReputationExploreExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ReputationExploreExcelConfig> dataList { /* [XID] */ /* 0x000000018997BDA0-0x000000018997BDC0 */ get; } // 0x0000000182112780-0x0000000182112830 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189983930-0x0000000189983950 */ get; } // 0x0000000182111390-0x0000000182111430 

	// Methods
	// [XID] // 0x000000018996CF50-0x000000018996CF70
	public static List<ReputationExploreExcelConfig> GetCityConfigList(uint cityId) => default; // 0x0000000182111C60-0x0000000182111E60
	// [XID] // 0x00000001899747D0-0x00000001899747F0
	public static void Register() {} // 0x0000000182112B60-0x0000000182112C60
	// [XID] // 0x000000018998B180-0x000000018998B1A0
	public static void LoadData() {} // 0x0000000182111A30-0x0000000182111B20
	// [XID] // 0x0000000189992D10-0x0000000189992D30
	private static void RegisterHotfixGenerated() {} // 0x0000000182111860-0x0000000182111A30
	// [XID] // 0x000000018999A8B0-0x000000018999A8D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182111430-0x0000000182111860
	// [IDTag] // 0x00000001899A1FB0-0x00000001899A1FF0
	// [XID] // 0x00000001899A1FB0-0x00000001899A1FF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182111E60-0x0000000182111F60
	// [XID] // 0x00000001899ACA70-0x00000001899ACA90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReputationExploreExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182112830-0x0000000182112B60
	// [XID] // 0x00000001899B4240-0x00000001899B4260
	private static bool ParseConfigFromLine(string line, out ReputationExploreExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182111B20-0x0000000182111C60
	// [IDTag] // 0x00000001899BB6D0-0x00000001899BB710
	// [XID] // 0x00000001899BB6D0-0x00000001899BB710
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReputationExploreExcelConfig> configList) => default; // 0x0000000182111F60-0x0000000182112200
	// [IDTag] // 0x00000001899C60F0-0x00000001899C6130
	// [XID] // 0x00000001899C60F0-0x00000001899C6130
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF997 */, bool useObjectPool = false /* Metadata: 0x00AEF99B */) => default; // 0x0000000182112200-0x0000000182112450
	// [IDTag] // 0x00000001899D0750-0x00000001899D0790
	// [XID] // 0x00000001899D0750-0x00000001899D0790
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF99C */, bool useObjectPool = false /* Metadata: 0x00AEF9A0 */) => default; // 0x0000000182112450-0x0000000182112780
}

