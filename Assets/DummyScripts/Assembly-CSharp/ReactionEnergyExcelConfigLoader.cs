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

public static class ReactionEnergyExcelConfigLoader // TypeDefIndex: 15564
{
	// Fields
	private static Dictionary<int, ReactionEnergyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReactionEnergyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReactionEnergyExcelConfig, ReactionEnergyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReactionEnergyExcelConfig>, Dictionary<int, ReactionEnergyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, ReactionEnergyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189656B90-0x0000000189656BB0 */ get; } // 0x0000000184AB3E20-0x0000000184AB3ED0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896659D0-0x00000001896659F0 */ get; } // 0x0000000184AB2C70-0x0000000184AB2D10 

	// Methods
	// [XID] // 0x000000018964F200-0x000000018964F220
	public static void Register() {} // 0x0000000184AB4200-0x0000000184AB42A0
	// [XID] // 0x000000018965E290-0x000000018965E2B0
	public static ReactionEnergyExcelConfig GetData(ElementReactionType type) => default; // 0x0000000184AB2B40-0x0000000184AB2C70
	// [XID] // 0x000000018966D0C0-0x000000018966D0E0
	public static void LoadData() {} // 0x0000000184AB32A0-0x0000000184AB3390
	// [XID] // 0x0000000189674FF0-0x0000000189675010
	private static void RegisterHotfixGenerated() {} // 0x0000000184AB30D0-0x0000000184AB32A0
	// [XID] // 0x000000018967C7E0-0x000000018967C800
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184AB2D10-0x0000000184AB30D0
	// [IDTag] // 0x0000000189683E50-0x0000000189683E90
	// [XID] // 0x0000000189683E50-0x0000000189683E90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184AB3780-0x0000000184AB3880
	// [XID] // 0x000000018968ED10-0x000000018968ED30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReactionEnergyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184AB3ED0-0x0000000184AB4200
	// [XID] // 0x0000000189696670-0x0000000189696690
	private static bool ParseConfigFromLine(string line, out ReactionEnergyExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184AB3390-0x0000000184AB34D0
	// [IDTag] // 0x000000018969DCD0-0x000000018969DD10
	// [XID] // 0x000000018969DCD0-0x000000018969DD10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReactionEnergyExcelConfig> configList) => default; // 0x0000000184AB34D0-0x0000000184AB3780
	// [IDTag] // 0x00000001896A7DC0-0x00000001896A7E00
	// [XID] // 0x00000001896A7DC0-0x00000001896A7E00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F34 */, bool useObjectPool = false /* Metadata: 0x00AF1F38 */) => default; // 0x0000000184AB3880-0x0000000184AB3AD0
	// [IDTag] // 0x00000001896B1C30-0x00000001896B1C70
	// [XID] // 0x00000001896B1C30-0x00000001896B1C70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F39 */, bool useObjectPool = false /* Metadata: 0x00AF1F3D */) => default; // 0x0000000184AB3AD0-0x0000000184AB3E20
}

