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

public static class IconAdsorbEffectExcelConfigLoader // TypeDefIndex: 15201
{
	// Fields
	private static Dictionary<uint, IconAdsorbEffectExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<IconAdsorbEffectExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<IconAdsorbEffectExcelConfig, IconAdsorbEffectExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<IconAdsorbEffectExcelConfig>, Dictionary<uint, IconAdsorbEffectExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, IconAdsorbEffectExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A655A0-0x0000000189A655C0 */ get; } // 0x0000000184769280-0x0000000184769330 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A74470-0x0000000189A74490 */ get; } // 0x00000001847680D0-0x0000000184768170 

	// Methods
	// [XID] // 0x0000000189A5DDA0-0x0000000189A5DDC0
	public static void Register() {} // 0x0000000184769660-0x0000000184769700
	// [XID] // 0x0000000189A6CCE0-0x0000000189A6CD00
	public static IconAdsorbEffectExcelConfig GetData(uint effectId) => default; // 0x0000000184767FA0-0x00000001847680D0
	// [XID] // 0x0000000189A7BE80-0x0000000189A7BEA0
	public static void LoadData() {} // 0x0000000184768700-0x00000001847687F0
	// [XID] // 0x0000000189A838A0-0x0000000189A838C0
	private static void RegisterHotfixGenerated() {} // 0x0000000184768530-0x0000000184768700
	// [XID] // 0x0000000189A8B080-0x0000000189A8B0A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184768170-0x0000000184768530
	// [IDTag] // 0x0000000189A92870-0x0000000189A928B0
	// [XID] // 0x0000000189A92870-0x0000000189A928B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184768BE0-0x0000000184768CE0
	// [XID] // 0x0000000189A9CF10-0x0000000189A9CF30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<IconAdsorbEffectExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184769330-0x0000000184769660
	// [XID] // 0x0000000189AA45E0-0x0000000189AA4600
	private static bool ParseConfigFromLine(string line, out IconAdsorbEffectExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001847687F0-0x0000000184768930
	// [IDTag] // 0x0000000189AABC30-0x0000000189AABC70
	// [XID] // 0x0000000189AABC30-0x0000000189AABC70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<IconAdsorbEffectExcelConfig> configList) => default; // 0x0000000184768930-0x0000000184768BE0
	// [IDTag] // 0x0000000189AB65A0-0x0000000189AB65E0
	// [XID] // 0x0000000189AB65A0-0x0000000189AB65E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF03A9 */, bool useObjectPool = false /* Metadata: 0x00AF03AD */) => default; // 0x0000000184769030-0x0000000184769280
	// [IDTag] // 0x0000000189AC0E50-0x0000000189AC0E90
	// [XID] // 0x0000000189AC0E50-0x0000000189AC0E90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03AE */, bool useObjectPool = false /* Metadata: 0x00AF03B2 */) => default; // 0x0000000184768CE0-0x0000000184769030
}

