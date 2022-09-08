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

public static class MatchExcelConfigLoader // TypeDefIndex: 15806
{
	// Fields
	private static Dictionary<uint, MatchExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MatchExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MatchExcelConfig, MatchExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MatchExcelConfig>, Dictionary<uint, MatchExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MatchExcelConfig> dataDict { /* [XID] */ /* 0x0000000189881BC0-0x0000000189881BE0 */ get; } // 0x0000000182FB2030-0x0000000182FB20E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189890720-0x0000000189890740 */ get; } // 0x0000000182FB0E80-0x0000000182FB0F20 

	// Methods
	// [XID] // 0x000000018987AC30-0x000000018987AC50
	public static void Register() {} // 0x0000000182FB2410-0x0000000182FB24B0
	// [XID] // 0x00000001898892C0-0x00000001898892E0
	public static MatchExcelConfig GetData(uint id) => default; // 0x0000000182FB0D50-0x0000000182FB0E80
	// [XID] // 0x0000000189897D00-0x0000000189897D20
	public static void LoadData() {} // 0x0000000182FB14B0-0x0000000182FB15A0
	// [XID] // 0x000000018989F0A0-0x000000018989F0C0
	private static void RegisterHotfixGenerated() {} // 0x0000000182FB12E0-0x0000000182FB14B0
	// [XID] // 0x00000001898A6C00-0x00000001898A6C20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182FB0F20-0x0000000182FB12E0
	// [IDTag] // 0x00000001898AE310-0x00000001898AE350
	// [XID] // 0x00000001898AE310-0x00000001898AE350
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182FB16E0-0x0000000182FB17E0
	// [XID] // 0x00000001898B8AE0-0x00000001898B8B00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MatchExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182FB20E0-0x0000000182FB2410
	// [XID] // 0x00000001898C0140-0x00000001898C0160
	private static bool ParseConfigFromLine(string line, out MatchExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182FB15A0-0x0000000182FB16E0
	// [IDTag] // 0x00000001898C7A40-0x00000001898C7A80
	// [XID] // 0x00000001898C7A40-0x00000001898C7A80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MatchExcelConfig> configList) => default; // 0x0000000182FB17E0-0x0000000182FB1A90
	// [IDTag] // 0x00000001898D20B0-0x00000001898D20F0
	// [XID] // 0x00000001898D20B0-0x00000001898D20F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF267B */, bool useObjectPool = false /* Metadata: 0x00AF267F */) => default; // 0x0000000182FB1A90-0x0000000182FB1CE0
	// [IDTag] // 0x00000001898DCAB0-0x00000001898DCAF0
	// [XID] // 0x00000001898DCAB0-0x00000001898DCAF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2680 */, bool useObjectPool = false /* Metadata: 0x00AF2684 */) => default; // 0x0000000182FB1CE0-0x0000000182FB2030
}

