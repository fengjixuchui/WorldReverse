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

public static class QuestSummarizationTextExcelConfigLoader // TypeDefIndex: 15324
{
	// Fields
	private static Dictionary<uint, QuestSummarizationTextExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<QuestSummarizationTextExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<QuestSummarizationTextExcelConfig, QuestSummarizationTextExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<QuestSummarizationTextExcelConfig>, Dictionary<uint, QuestSummarizationTextExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, QuestSummarizationTextExcelConfig> dataDict { /* [XID] */ /* 0x0000000189941500-0x0000000189941520 */ get; } // 0x00000001839AB150-0x00000001839AB200 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189950890-0x00000001899508B0 */ get; } // 0x00000001839A9FA0-0x00000001839AA040 

	// Methods
	// [XID] // 0x000000018993A4D0-0x000000018993A4F0
	public static void Register() {} // 0x00000001839AB530-0x00000001839AB5D0
	// [XID] // 0x0000000189949080-0x00000001899490A0
	public static QuestSummarizationTextExcelConfig GetData(uint Id) => default; // 0x00000001839A9E70-0x00000001839A9FA0
	// [XID] // 0x0000000189957EE0-0x0000000189957F00
	public static void LoadData() {} // 0x00000001839AA5D0-0x00000001839AA6C0
	// [XID] // 0x000000018995F7B0-0x000000018995F7D0
	private static void RegisterHotfixGenerated() {} // 0x00000001839AA400-0x00000001839AA5D0
	// [XID] // 0x0000000189966FF0-0x0000000189967010
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001839AA040-0x00000001839AA400
	// [IDTag] // 0x000000018996E320-0x000000018996E360
	// [XID] // 0x000000018996E320-0x000000018996E360
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001839AAAB0-0x00000001839AABB0
	// [XID] // 0x0000000189979370-0x0000000189979390
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<QuestSummarizationTextExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001839AB200-0x00000001839AB530
	// [XID] // 0x00000001899804A0-0x00000001899804C0
	private static bool ParseConfigFromLine(string line, out QuestSummarizationTextExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001839AA6C0-0x00000001839AA800
	// [IDTag] // 0x0000000189987D90-0x0000000189987DD0
	// [XID] // 0x0000000189987D90-0x0000000189987DD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<QuestSummarizationTextExcelConfig> configList) => default; // 0x00000001839AA800-0x00000001839AAAB0
	// [IDTag] // 0x0000000189992B30-0x0000000189992B70
	// [XID] // 0x0000000189992B30-0x0000000189992B70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0790 */, bool useObjectPool = false /* Metadata: 0x00AF0794 */) => default; // 0x00000001839AAF00-0x00000001839AB150
	// [IDTag] // 0x000000018999D510-0x000000018999D550
	// [XID] // 0x000000018999D510-0x000000018999D550
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0795 */, bool useObjectPool = false /* Metadata: 0x00AF0799 */) => default; // 0x00000001839AABB0-0x00000001839AAF00
}

