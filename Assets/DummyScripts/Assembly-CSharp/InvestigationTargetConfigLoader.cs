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

public static class InvestigationTargetConfigLoader // TypeDefIndex: 15770
{
	// Fields
	private static Dictionary<uint, InvestigationTargetConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<InvestigationTargetConfig>> customApplyHotfixAction; // 0x08
	public static Action<InvestigationTargetConfig, InvestigationTargetConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<InvestigationTargetConfig>, Dictionary<uint, InvestigationTargetConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, InvestigationTargetConfig> dataDict { /* [XID] */ /* 0x00000001896FF0D0-0x00000001896FF0F0 */ get; } // 0x000000018401D9B0-0x000000018401DA60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018970DC50-0x000000018970DC70 */ get; } // 0x000000018401C800-0x000000018401C8A0 

	// Methods
	// [XID] // 0x00000001896F7690-0x00000001896F76B0
	public static void Register() {} // 0x000000018401DD90-0x000000018401DE30
	// [XID] // 0x00000001897063A0-0x00000001897063C0
	public static InvestigationTargetConfig GetData(uint id) => default; // 0x000000018401C6D0-0x000000018401C800
	// [XID] // 0x00000001897150F0-0x0000000189715110
	public static void LoadData() {} // 0x000000018401CE30-0x000000018401CF20
	// [XID] // 0x000000018971CC00-0x000000018971CC20
	private static void RegisterHotfixGenerated() {} // 0x000000018401CC60-0x000000018401CE30
	// [XID] // 0x0000000189723FB0-0x0000000189723FD0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018401C8A0-0x000000018401CC60
	// [IDTag] // 0x000000018972B790-0x000000018972B7D0
	// [XID] // 0x000000018972B790-0x000000018972B7D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018401D310-0x000000018401D410
	// [XID] // 0x0000000189735F60-0x0000000189735F80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<InvestigationTargetConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018401DA60-0x000000018401DD90
	// [XID] // 0x000000018973DBF0-0x000000018973DC10
	private static bool ParseConfigFromLine(string line, out InvestigationTargetConfig data) {
		data = default;
		return default;
	} // 0x000000018401CF20-0x000000018401D060
	// [IDTag] // 0x0000000189744FB0-0x0000000189744FF0
	// [XID] // 0x0000000189744FB0-0x0000000189744FF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<InvestigationTargetConfig> configList) => default; // 0x000000018401D060-0x000000018401D310
	// [IDTag] // 0x000000018974F990-0x000000018974F9D0
	// [XID] // 0x000000018974F990-0x000000018974F9D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2588 */, bool useObjectPool = false /* Metadata: 0x00AF258C */) => default; // 0x000000018401D760-0x000000018401D9B0
	// [IDTag] // 0x0000000189759B60-0x0000000189759BA0
	// [XID] // 0x0000000189759B60-0x0000000189759BA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF258D */, bool useObjectPool = false /* Metadata: 0x00AF2591 */) => default; // 0x000000018401D410-0x000000018401D760
}

