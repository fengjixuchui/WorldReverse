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

public static class HuntingClueGatherExcelConfigLoader // TypeDefIndex: 15753
{
	// Fields
	private static Dictionary<uint, HuntingClueGatherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingClueGatherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingClueGatherExcelConfig, HuntingClueGatherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingClueGatherExcelConfig>, Dictionary<uint, HuntingClueGatherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingClueGatherExcelConfig> dataDict { /* [XID] */ /* 0x00000001896D24C0-0x00000001896D24E0 */ get; } // 0x0000000181808CE0-0x0000000181808D90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896E1530-0x00000001896E1550 */ get; } // 0x0000000181807B30-0x0000000181807BD0 

	// Methods
	// [XID] // 0x00000001896CAE50-0x00000001896CAE70
	public static void Register() {} // 0x00000001818090C0-0x0000000181809160
	// [XID] // 0x00000001896D9F30-0x00000001896D9F50
	public static HuntingClueGatherExcelConfig GetData(uint configId) => default; // 0x0000000181807A00-0x0000000181807B30
	// [XID] // 0x00000001896E8840-0x00000001896E8860
	public static void LoadData() {} // 0x0000000181808160-0x0000000181808250
	// [XID] // 0x00000001896EFCC0-0x00000001896EFCE0
	private static void RegisterHotfixGenerated() {} // 0x0000000181807F90-0x0000000181808160
	// [XID] // 0x00000001896F76B0-0x00000001896F76D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181807BD0-0x0000000181807F90
	// [IDTag] // 0x00000001896FF0F0-0x00000001896FF130
	// [XID] // 0x00000001896FF0F0-0x00000001896FF130
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181808390-0x0000000181808490
	// [XID] // 0x00000001897095E0-0x0000000189709600
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingClueGatherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181808D90-0x00000001818090C0
	// [XID] // 0x0000000189710E90-0x0000000189710EB0
	private static bool ParseConfigFromLine(string line, out HuntingClueGatherExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181808250-0x0000000181808390
	// [IDTag] // 0x00000001897181B0-0x00000001897181F0
	// [XID] // 0x00000001897181B0-0x00000001897181F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingClueGatherExcelConfig> configList) => default; // 0x0000000181808490-0x0000000181808740
	// [IDTag] // 0x0000000189722820-0x0000000189722860
	// [XID] // 0x0000000189722820-0x0000000189722860
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2517 */, bool useObjectPool = false /* Metadata: 0x00AF251B */) => default; // 0x0000000181808740-0x0000000181808990
	// [IDTag] // 0x000000018972CF40-0x000000018972CF80
	// [XID] // 0x000000018972CF40-0x000000018972CF80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF251C */, bool useObjectPool = false /* Metadata: 0x00AF2520 */) => default; // 0x0000000181808990-0x0000000181808CE0
}

