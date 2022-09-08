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

public static class AsterLittleExcelConfigLoader // TypeDefIndex: 15014
{
	// Fields
	private static Dictionary<uint, AsterLittleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AsterLittleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AsterLittleExcelConfig, AsterLittleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AsterLittleExcelConfig>, Dictionary<uint, AsterLittleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AsterLittleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A356F0-0x0000000189A35710 */ get; } // 0x0000000182A8A820-0x0000000182A8A8D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A445B0-0x0000000189A445D0 */ get; } // 0x0000000182A89670-0x0000000182A89710 

	// Methods
	// [XID] // 0x0000000189A2DAD0-0x0000000189A2DAF0
	public static void Register() {} // 0x0000000182A8AC00-0x0000000182A8ACA0
	// [XID] // 0x0000000189A3CB60-0x0000000189A3CB80
	public static AsterLittleExcelConfig GetData(uint stage_id) => default; // 0x0000000182A89540-0x0000000182A89670
	// [XID] // 0x0000000189A4BB40-0x0000000189A4BB60
	public static void LoadData() {} // 0x0000000182A89CA0-0x0000000182A89D90
	// [XID] // 0x0000000189A53260-0x0000000189A53280
	private static void RegisterHotfixGenerated() {} // 0x0000000182A89AD0-0x0000000182A89CA0
	// [XID] // 0x0000000189A5A990-0x0000000189A5A9B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182A89710-0x0000000182A89AD0
	// [IDTag] // 0x0000000189A62190-0x0000000189A621D0
	// [XID] // 0x0000000189A62190-0x0000000189A621D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182A89ED0-0x0000000182A89FD0
	// [XID] // 0x0000000189A6CD20-0x0000000189A6CD40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterLittleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182A8A8D0-0x0000000182A8AC00
	// [XID] // 0x0000000189A744B0-0x0000000189A744D0
	private static bool ParseConfigFromLine(string line, out AsterLittleExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182A89D90-0x0000000182A89ED0
	// [IDTag] // 0x0000000189A7BF00-0x0000000189A7BF40
	// [XID] // 0x0000000189A7BF00-0x0000000189A7BF40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterLittleExcelConfig> configList) => default; // 0x0000000182A89FD0-0x0000000182A8A280
	// [IDTag] // 0x0000000189A86610-0x0000000189A86650
	// [XID] // 0x0000000189A86610-0x0000000189A86650
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE7B */, bool useObjectPool = false /* Metadata: 0x00AEFE7F */) => default; // 0x0000000182A8A5D0-0x0000000182A8A820
	// [IDTag] // 0x0000000189A910F0-0x0000000189A91130
	// [XID] // 0x0000000189A910F0-0x0000000189A91130
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE80 */, bool useObjectPool = false /* Metadata: 0x00AEFE84 */) => default; // 0x0000000182A8A280-0x0000000182A8A5D0
}

