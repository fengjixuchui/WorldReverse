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

public static class AsterStageExcelConfigLoader // TypeDefIndex: 14831
{
	// Fields
	private static Dictionary<uint, List<AsterStageExcelConfig>> _asterStageDic; // 0x00
	private static Dictionary<uint, AsterStageExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<AsterStageExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<AsterStageExcelConfig, AsterStageExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<AsterStageExcelConfig>, Dictionary<uint, AsterStageExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, AsterStageExcelConfig> dataDict { /* [XID] */ /* 0x0000000189692070-0x0000000189692090 */ get; } // 0x000000018167D590-0x000000018167D660 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896A0970-0x00000001896A0990 */ get; } // 0x000000018167BA50-0x000000018167BAF0 

	// Constructors
	static AsterStageExcelConfigLoader() {} // 0x000000018167DA70-0x000000018167DAD0

	// Methods
	// [XID] // 0x000000018967AEE0-0x000000018967AF00
	public static void BuildAsterStageDic() {} // 0x000000018167C240-0x000000018167C640
	// [XID] // 0x0000000189682750-0x0000000189682770
	public static AsterStageExcelConfig GetAsterConfig(uint activityId, int index) => default; // 0x000000018167C770-0x000000018167C960
	// [XID] // 0x000000018968A330-0x000000018968A350
	public static void Register() {} // 0x000000018167D9B0-0x000000018167DA70
	// [XID] // 0x0000000189699500-0x0000000189699520
	public static AsterStageExcelConfig GetData(uint id) => default; // 0x000000018167B8B0-0x000000018167BA50
	// [XID] // 0x00000001896A7F40-0x00000001896A7F60
	public static void LoadData() {} // 0x000000018167C640-0x000000018167C770
	// [XID] // 0x00000001896AF330-0x00000001896AF350
	private static void RegisterHotfixGenerated() {} // 0x000000018167BFD0-0x000000018167C240
	// [XID] // 0x00000001896B68A0-0x00000001896B68C0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018167BAF0-0x000000018167BFD0
	// [IDTag] // 0x00000001896BDBA0-0x00000001896BDBE0
	// [XID] // 0x00000001896BDBA0-0x00000001896BDBE0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018167CAA0-0x000000018167CC00
	// [XID] // 0x00000001896C82D0-0x00000001896C82F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterStageExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018167D660-0x000000018167D9B0
	// [XID] // 0x00000001896CFCD0-0x00000001896CFCF0
	private static bool ParseConfigFromLine(string line, out AsterStageExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018167C960-0x000000018167CAA0
	// [IDTag] // 0x00000001896D6F20-0x00000001896D6F60
	// [XID] // 0x00000001896D6F20-0x00000001896D6F60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterStageExcelConfig> configList) => default; // 0x000000018167CC00-0x000000018167CF50
	// [IDTag] // 0x00000001896E1770-0x00000001896E17B0
	// [XID] // 0x00000001896E1770-0x00000001896E17B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6E3 */, bool useObjectPool = false /* Metadata: 0x00AEF6E7 */) => default; // 0x000000018167CF50-0x000000018167D200
	// [IDTag] // 0x00000001896EBAC0-0x00000001896EBB00
	// [XID] // 0x00000001896EBAC0-0x00000001896EBB00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6E8 */, bool useObjectPool = false /* Metadata: 0x00AEF6EC */) => default; // 0x000000018167D200-0x000000018167D590
}

