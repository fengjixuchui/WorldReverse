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

public static class ReliquaryMainPropExcelConfigLoader // TypeDefIndex: 16018
{
	// Fields
	private static Dictionary<uint, ReliquaryMainPropExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryMainPropExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryMainPropExcelConfig, ReliquaryMainPropExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryMainPropExcelConfig>, Dictionary<uint, ReliquaryMainPropExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReliquaryMainPropExcelConfig> dataDict { /* [XID] */ /* 0x0000000189647A90-0x0000000189647AB0 */ get; } // 0x00000001858A68F0-0x00000001858A69A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189656AB0-0x0000000189656AD0 */ get; } // 0x00000001858A5740-0x00000001858A57E0 

	// Methods
	// [XID] // 0x0000000189640230-0x0000000189640250
	public static void Register() {} // 0x00000001858A6CD0-0x00000001858A6D70
	// [XID] // 0x000000018964F140-0x000000018964F160
	public static ReliquaryMainPropExcelConfig GetData(uint id) => default; // 0x00000001858A5610-0x00000001858A5740
	// [XID] // 0x000000018965E170-0x000000018965E190
	public static void LoadData() {} // 0x00000001858A5D70-0x00000001858A5E60
	// [XID] // 0x0000000189665830-0x0000000189665850
	private static void RegisterHotfixGenerated() {} // 0x00000001858A5BA0-0x00000001858A5D70
	// [XID] // 0x000000018966CF40-0x000000018966CF60
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001858A57E0-0x00000001858A5BA0
	// [IDTag] // 0x0000000189674DD0-0x0000000189674E10
	// [XID] // 0x0000000189674DD0-0x0000000189674E10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001858A5FA0-0x00000001858A60A0
	// [XID] // 0x000000018967F4C0-0x000000018967F4E0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryMainPropExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001858A69A0-0x00000001858A6CD0
	// [XID] // 0x0000000189686CF0-0x0000000189686D10
	private static bool ParseConfigFromLine(string line, out ReliquaryMainPropExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001858A5E60-0x00000001858A5FA0
	// [IDTag] // 0x000000018968EC10-0x000000018968EC50
	// [XID] // 0x000000018968EC10-0x000000018968EC50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryMainPropExcelConfig> configList) => default; // 0x00000001858A60A0-0x00000001858A6350
	// [IDTag] // 0x0000000189699280-0x00000001896992C0
	// [XID] // 0x0000000189699280-0x00000001896992C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E04 */, bool useObjectPool = false /* Metadata: 0x00AF2E08 */) => default; // 0x00000001858A66A0-0x00000001858A68F0
	// [IDTag] // 0x00000001896A3680-0x00000001896A36C0
	// [XID] // 0x00000001896A3680-0x00000001896A36C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E09 */, bool useObjectPool = false /* Metadata: 0x00AF2E0D */) => default; // 0x00000001858A6350-0x00000001858A66A0
}

