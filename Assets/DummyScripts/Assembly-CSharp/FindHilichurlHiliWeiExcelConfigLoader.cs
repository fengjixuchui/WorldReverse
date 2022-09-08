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

public static class FindHilichurlHiliWeiExcelConfigLoader // TypeDefIndex: 14827
{
	// Fields
	private static Dictionary<uint, FindHilichurlHiliWeiExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FindHilichurlHiliWeiExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FindHilichurlHiliWeiExcelConfig, FindHilichurlHiliWeiExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FindHilichurlHiliWeiExcelConfig>, Dictionary<uint, FindHilichurlHiliWeiExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FindHilichurlHiliWeiExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A88220-0x0000000189A88240 */ get; } // 0x00000001851254E0-0x0000000185125590 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A97120-0x0000000189A97140 */ get; } // 0x0000000185124200-0x00000001851242A0 

	// Methods
	// [XID] // 0x0000000189A6A1D0-0x0000000189A6A1F0
	public static uint GetDayIndex(uint id) => default; // 0x0000000185125AD0-0x0000000185125C00
	// [XID] // 0x0000000189A714A0-0x0000000189A714C0
	public static uint GetWatcherId(uint id) => default; // 0x0000000185124920-0x0000000185124A50
	// [XID] // 0x0000000189A790A0-0x0000000189A790C0
	public static string GetDurationHint(uint id) => default; // 0x0000000185125590-0x0000000185125700
	// [XID] // 0x0000000189A80500-0x0000000189A80520
	public static void Register() {} // 0x0000000185125A30-0x0000000185125AD0
	// [XID] // 0x0000000189A8FB30-0x0000000189A8FB50
	public static FindHilichurlHiliWeiExcelConfig GetData(uint id) => default; // 0x00000001851240D0-0x0000000185124200
	// [XID] // 0x0000000189A9E510-0x0000000189A9E530
	public static void LoadData() {} // 0x0000000185124830-0x0000000185124920
	// [XID] // 0x0000000189AA5E00-0x0000000189AA5E20
	private static void RegisterHotfixGenerated() {} // 0x0000000185124660-0x0000000185124830
	// [XID] // 0x0000000189AAD500-0x0000000189AAD520
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001851242A0-0x0000000185124660
	// [IDTag] // 0x0000000189AB4DF0-0x0000000189AB4E30
	// [XID] // 0x0000000189AB4DF0-0x0000000189AB4E30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185124E40-0x0000000185124F40
	// [XID] // 0x0000000189ABF850-0x0000000189ABF870
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FindHilichurlHiliWeiExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185125700-0x0000000185125A30
	// [XID] // 0x0000000189AC7240-0x0000000189AC7260
	private static bool ParseConfigFromLine(string line, out FindHilichurlHiliWeiExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185124A50-0x0000000185124B90
	// [IDTag] // 0x0000000189ACE950-0x0000000189ACE990
	// [XID] // 0x0000000189ACE950-0x0000000189ACE990
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FindHilichurlHiliWeiExcelConfig> configList) => default; // 0x0000000185124B90-0x0000000185124E40
	// [IDTag] // 0x0000000189AD9730-0x0000000189AD9770
	// [XID] // 0x0000000189AD9730-0x0000000189AD9770
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6CA */, bool useObjectPool = false /* Metadata: 0x00AEF6CE */) => default; // 0x0000000185125290-0x00000001851254E0
	// [IDTag] // 0x0000000189AE4210-0x0000000189AE4250
	// [XID] // 0x0000000189AE4210-0x0000000189AE4250
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6CF */, bool useObjectPool = false /* Metadata: 0x00AEF6D3 */) => default; // 0x0000000185124F40-0x0000000185125290
}

