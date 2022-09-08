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

public static class GuideTriggerExcelConfigLoader // TypeDefIndex: 15686
{
	// Fields
	private static Dictionary<string, GuideTriggerExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GuideTriggerExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GuideTriggerExcelConfig, GuideTriggerExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GuideTriggerExcelConfig>, Dictionary<string, GuideTriggerExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, GuideTriggerExcelConfig> dataDict { /* [XID] */ /* 0x0000000189936E10-0x0000000189936E30 */ get; } // 0x000000018373DB00-0x000000018373DBB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189946040-0x0000000189946060 */ get; } // 0x000000018373C960-0x000000018373CA00 

	// Methods
	// [XID] // 0x000000018992F900-0x000000018992F920
	public static void Register() {} // 0x000000018373DEE0-0x000000018373DF80
	// [XID] // 0x000000018993E9B0-0x000000018993E9D0
	public static GuideTriggerExcelConfig GetData(string guideName) => default; // 0x000000018373C820-0x000000018373C960
	// [XID] // 0x000000018994D550-0x000000018994D570
	public static void LoadData() {} // 0x000000018373CF90-0x000000018373D080
	// [XID] // 0x0000000189954BE0-0x0000000189954C00
	private static void RegisterHotfixGenerated() {} // 0x000000018373CDC0-0x000000018373CF90
	// [XID] // 0x000000018995C480-0x000000018995C4A0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018373CA00-0x000000018373CDC0
	// [IDTag] // 0x0000000189963EA0-0x0000000189963EE0
	// [XID] // 0x0000000189963EA0-0x0000000189963EE0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018373D460-0x000000018373D560
	// [XID] // 0x000000018996E280-0x000000018996E2A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GuideTriggerExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018373DBB0-0x000000018373DEE0
	// [XID] // 0x0000000189975E10-0x0000000189975E30
	private static bool ParseConfigFromLine(string line, out GuideTriggerExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018373D080-0x000000018373D1C0
	// [IDTag] // 0x000000018997CF30-0x000000018997CF70
	// [XID] // 0x000000018997CF30-0x000000018997CF70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GuideTriggerExcelConfig> configList) => default; // 0x000000018373D1C0-0x000000018373D460
	// [IDTag] // 0x0000000189987D10-0x0000000189987D50
	// [XID] // 0x0000000189987D10-0x0000000189987D50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF230C */, bool useObjectPool = false /* Metadata: 0x00AF2310 */) => default; // 0x000000018373D8B0-0x000000018373DB00
	// [IDTag] // 0x0000000189992A70-0x0000000189992AB0
	// [XID] // 0x0000000189992A70-0x0000000189992AB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2311 */, bool useObjectPool = false /* Metadata: 0x00AF2315 */) => default; // 0x000000018373D560-0x000000018373D8B0
}

