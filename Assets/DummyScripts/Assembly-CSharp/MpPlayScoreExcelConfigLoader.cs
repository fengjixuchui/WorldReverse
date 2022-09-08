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

public static class MpPlayScoreExcelConfigLoader // TypeDefIndex: 15878
{
	// Fields
	private static List<MpPlayScoreExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayScoreExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayScoreExcelConfig, MpPlayScoreExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayScoreExcelConfig>, List<MpPlayScoreExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<MpPlayScoreExcelConfig> dataList { /* [XID] */ /* 0x0000000189A95550-0x0000000189A95570 */ get; } // 0x00000001821F1320-0x00000001821F13D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A9CDF0-0x0000000189A9CE10 */ get; } // 0x00000001821F0130-0x00000001821F01D0 

	// Methods
	// [XID] // 0x0000000189A8E070-0x0000000189A8E090
	public static void Register() {} // 0x00000001821F1700-0x00000001821F17A0
	// [XID] // 0x0000000189AA4540-0x0000000189AA4560
	public static void LoadData() {} // 0x00000001821F07D0-0x00000001821F08C0
	// [XID] // 0x0000000189AABB10-0x0000000189AABB30
	private static void RegisterHotfixGenerated() {} // 0x00000001821F0600-0x00000001821F07D0
	// [XID] // 0x0000000189AB34C0-0x0000000189AB34E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821F01D0-0x00000001821F0600
	// [IDTag] // 0x0000000189ABB1F0-0x0000000189ABB230
	// [XID] // 0x0000000189ABB1F0-0x0000000189ABB230
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821F0CA0-0x00000001821F0DA0
	// [XID] // 0x0000000189AC5AD0-0x0000000189AC5AF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayScoreExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001821F13D0-0x00000001821F1700
	// [XID] // 0x0000000189ACD020-0x0000000189ACD040
	private static bool ParseConfigFromLine(string line, out MpPlayScoreExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821F08C0-0x00000001821F0A00
	// [IDTag] // 0x0000000189AD4DA0-0x0000000189AD4DE0
	// [XID] // 0x0000000189AD4DA0-0x0000000189AD4DE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayScoreExcelConfig> configList) => default; // 0x00000001821F0A00-0x00000001821F0CA0
	// [IDTag] // 0x0000000189ADF830-0x0000000189ADF870
	// [XID] // 0x0000000189ADF830-0x0000000189ADF870
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF292D */, bool useObjectPool = false /* Metadata: 0x00AF2931 */) => default; // 0x00000001821F10D0-0x00000001821F1320
	// [IDTag] // 0x0000000189AE9CF0-0x0000000189AE9D30
	// [XID] // 0x0000000189AE9CF0-0x0000000189AE9D30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2932 */, bool useObjectPool = false /* Metadata: 0x00AF2936 */) => default; // 0x00000001821F0DA0-0x00000001821F10D0
}

