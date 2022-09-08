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

public static class TriggerExcelConfigLoader // TypeDefIndex: 16091
{
	// Fields
	private static Dictionary<uint, TriggerExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TriggerExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TriggerExcelConfig, TriggerExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TriggerExcelConfig>, Dictionary<uint, TriggerExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TriggerExcelConfig> dataDict { /* [XID] */ /* 0x00000001896A9460-0x00000001896A9480 */ get; } // 0x00000001839AE330-0x00000001839AE3E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896B7FD0-0x00000001896B7FF0 */ get; } // 0x00000001839AD180-0x00000001839AD220 

	// Methods
	// [XID] // 0x00000001896A2220-0x00000001896A2240
	public static void Register() {} // 0x00000001839AE710-0x00000001839AE7B0
	// [XID] // 0x00000001896B0590-0x00000001896B05B0
	public static TriggerExcelConfig GetData(uint id) => default; // 0x00000001839AD050-0x00000001839AD180
	// [XID] // 0x00000001896BF030-0x00000001896BF050
	public static void LoadData() {} // 0x00000001839AD7B0-0x00000001839AD8A0
	// [XID] // 0x00000001896C6990-0x00000001896C69B0
	private static void RegisterHotfixGenerated() {} // 0x00000001839AD5E0-0x00000001839AD7B0
	// [XID] // 0x00000001896CE050-0x00000001896CE070
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001839AD220-0x00000001839AD5E0
	// [IDTag] // 0x00000001896D55A0-0x00000001896D55E0
	// [XID] // 0x00000001896D55A0-0x00000001896D55E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001839ADC90-0x00000001839ADD90
	// [XID] // 0x00000001896DFE00-0x00000001896DFE20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TriggerExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001839AE3E0-0x00000001839AE710
	// [XID] // 0x00000001896E70E0-0x00000001896E7100
	private static bool ParseConfigFromLine(string line, out TriggerExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001839AD8A0-0x00000001839AD9E0
	// [IDTag] // 0x00000001896EE670-0x00000001896EE6B0
	// [XID] // 0x00000001896EE670-0x00000001896EE6B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TriggerExcelConfig> configList) => default; // 0x00000001839AD9E0-0x00000001839ADC90
	// [IDTag] // 0x00000001896F8B00-0x00000001896F8B40
	// [XID] // 0x00000001896F8B00-0x00000001896F8B40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2FFF */, bool useObjectPool = false /* Metadata: 0x00AF3003 */) => default; // 0x00000001839ADD90-0x00000001839ADFE0
	// [IDTag] // 0x0000000189703510-0x0000000189703550
	// [XID] // 0x0000000189703510-0x0000000189703550
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3004 */, bool useObjectPool = false /* Metadata: 0x00AF3008 */) => default; // 0x00000001839ADFE0-0x00000001839AE330
}

