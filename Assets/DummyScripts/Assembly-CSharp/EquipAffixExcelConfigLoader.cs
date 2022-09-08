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

public static class EquipAffixExcelConfigLoader // TypeDefIndex: 14866
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, EquipAffixExcelConfig>> _equipAffixDic; // 0x00
	private static Dictionary<uint, EquipAffixExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<EquipAffixExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<EquipAffixExcelConfig, EquipAffixExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<EquipAffixExcelConfig>, Dictionary<uint, EquipAffixExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, EquipAffixExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A42E90-0x0000000189A42EB0 */ get; } // 0x000000018388A720-0x000000018388A7F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A51CD0-0x0000000189A51CF0 */ get; } // 0x0000000183889060-0x0000000183889100 

	// Constructors
	static EquipAffixExcelConfigLoader() {} // 0x000000018388B0E0-0x000000018388B140

	// Methods
	// [XID] // 0x0000000189A2C570-0x0000000189A2C590
	public static void BuildEquipAffixDic() {} // 0x000000018388A7F0-0x000000018388ACD0
	// [XID] // 0x0000000189A33C60-0x0000000189A33C80
	public static Dictionary<uint, EquipAffixExcelConfig> GetEquipAffixDicByAffixId(uint affixId) => default; // 0x0000000183889980-0x0000000183889AF0
	// [XID] // 0x0000000189A3B400-0x0000000189A3B420
	public static void Register() {} // 0x000000018388B020-0x000000018388B0E0
	// [XID] // 0x0000000189A4A320-0x0000000189A4A340
	public static EquipAffixExcelConfig GetData(uint affixId) => default; // 0x0000000183888EC0-0x0000000183889060
	// [XID] // 0x0000000189A59440-0x0000000189A59460
	public static void LoadData() {} // 0x0000000183889850-0x0000000183889980
	// [XID] // 0x0000000189A60E00-0x0000000189A60E20
	private static void RegisterHotfixGenerated() {} // 0x00000001838895E0-0x0000000183889850
	// [XID] // 0x0000000189A68A50-0x0000000189A68A70
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183889100-0x00000001838895E0
	// [IDTag] // 0x0000000189A6FDE0-0x0000000189A6FE20
	// [XID] // 0x0000000189A6FDE0-0x0000000189A6FE20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183889F80-0x000000018388A0E0
	// [XID] // 0x0000000189A7AAD0-0x0000000189A7AAF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EquipAffixExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018388ACD0-0x000000018388B020
	// [XID] // 0x0000000189A81F90-0x0000000189A81FB0
	private static bool ParseConfigFromLine(string line, out EquipAffixExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183889AF0-0x0000000183889C30
	// [IDTag] // 0x0000000189A899D0-0x0000000189A89A10
	// [XID] // 0x0000000189A899D0-0x0000000189A89A10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EquipAffixExcelConfig> configList) => default; // 0x0000000183889C30-0x0000000183889F80
	// [IDTag] // 0x0000000189A93E30-0x0000000189A93E70
	// [XID] // 0x0000000189A93E30-0x0000000189A93E70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF83E */, bool useObjectPool = false /* Metadata: 0x00AEF842 */) => default; // 0x000000018388A0E0-0x000000018388A390
	// [IDTag] // 0x0000000189A9E4D0-0x0000000189A9E510
	// [XID] // 0x0000000189A9E4D0-0x0000000189A9E510
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF843 */, bool useObjectPool = false /* Metadata: 0x00AEF847 */) => default; // 0x000000018388A390-0x000000018388A720
}

