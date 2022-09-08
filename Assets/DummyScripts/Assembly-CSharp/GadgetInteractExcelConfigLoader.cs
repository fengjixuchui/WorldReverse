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

public static class GadgetInteractExcelConfigLoader // TypeDefIndex: 15646
{
	// Fields
	private static Dictionary<uint, GadgetInteractExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetInteractExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetInteractExcelConfig, GadgetInteractExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetInteractExcelConfig>, Dictionary<uint, GadgetInteractExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetInteractExcelConfig> dataDict { /* [XID] */ /* 0x000000018999A750-0x000000018999A770 */ get; } // 0x00000001822184B0-0x0000000182218560 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A9760-0x00000001899A9780 */ get; } // 0x0000000182217300-0x00000001822173A0 

	// Methods
	// [XID] // 0x0000000189992AD0-0x0000000189992AF0
	public static void Register() {} // 0x0000000182218890-0x0000000182218930
	// [XID] // 0x0000000189B870F0-0x0000000189B87110
	public static GadgetInteractExcelConfig GetData(uint interactId) => default; // 0x00000001822171D0-0x0000000182217300
	// [XID] // 0x00000001899B1170-0x00000001899B1190
	public static void LoadData() {} // 0x0000000182217930-0x0000000182217A20
	// [XID] // 0x00000001899B8410-0x00000001899B8430
	private static void RegisterHotfixGenerated() {} // 0x0000000182217760-0x0000000182217930
	// [XID] // 0x00000001899BFF50-0x00000001899BFF70
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001822173A0-0x0000000182217760
	// [IDTag] // 0x00000001899C7730-0x00000001899C7770
	// [XID] // 0x00000001899C7730-0x00000001899C7770
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182217E10-0x0000000182217F10
	// [XID] // 0x00000001899D1DE0-0x00000001899D1E00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetInteractExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182218560-0x0000000182218890
	// [XID] // 0x00000001899D9230-0x00000001899D9250
	private static bool ParseConfigFromLine(string line, out GadgetInteractExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182217A20-0x0000000182217B60
	// [IDTag] // 0x00000001899E09A0-0x00000001899E09E0
	// [XID] // 0x00000001899E09A0-0x00000001899E09E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetInteractExcelConfig> configList) => default; // 0x0000000182217B60-0x0000000182217E10
	// [IDTag] // 0x00000001899EAEC0-0x00000001899EAF00
	// [XID] // 0x00000001899EAEC0-0x00000001899EAF00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2193 */, bool useObjectPool = false /* Metadata: 0x00AF2197 */) => default; // 0x0000000182217F10-0x0000000182218160
	// [IDTag] // 0x00000001899F5990-0x00000001899F59D0
	// [XID] // 0x00000001899F5990-0x00000001899F59D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2198 */, bool useObjectPool = false /* Metadata: 0x00AF219C */) => default; // 0x0000000182218160-0x00000001822184B0
}

