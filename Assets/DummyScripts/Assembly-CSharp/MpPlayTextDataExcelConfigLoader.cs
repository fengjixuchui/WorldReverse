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

public static class MpPlayTextDataExcelConfigLoader // TypeDefIndex: 15874
{
	// Fields
	private static Dictionary<uint, MpPlayTextDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayTextDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayTextDataExcelConfig, MpPlayTextDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayTextDataExcelConfig>, Dictionary<uint, MpPlayTextDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayTextDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189874520-0x0000000189874540 */ get; } // 0x0000000184ED16E0-0x0000000184ED1790 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189883250-0x0000000189883270 */ get; } // 0x0000000184ED0530-0x0000000184ED05D0 

	// Methods
	// [XID] // 0x000000018986D0F0-0x000000018986D110
	public static void Register() {} // 0x0000000184ED1AC0-0x0000000184ED1B60
	// [XID] // 0x000000018987C0A0-0x000000018987C0C0
	public static MpPlayTextDataExcelConfig GetData(uint mpPlayId) => default; // 0x0000000184ED0400-0x0000000184ED0530
	// [XID] // 0x000000018988A950-0x000000018988A970
	public static void LoadData() {} // 0x0000000184ED0B60-0x0000000184ED0C50
	// [XID] // 0x0000000189891E40-0x0000000189891E60
	private static void RegisterHotfixGenerated() {} // 0x0000000184ED0990-0x0000000184ED0B60
	// [XID] // 0x0000000189899750-0x0000000189899770
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184ED05D0-0x0000000184ED0990
	// [IDTag] // 0x00000001898A0870-0x00000001898A08B0
	// [XID] // 0x00000001898A0870-0x00000001898A08B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184ED0D90-0x0000000184ED0E90
	// [XID] // 0x00000001898AAEA0-0x00000001898AAEC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayTextDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184ED1790-0x0000000184ED1AC0
	// [XID] // 0x00000001898B2790-0x00000001898B27B0
	private static bool ParseConfigFromLine(string line, out MpPlayTextDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184ED0C50-0x0000000184ED0D90
	// [IDTag] // 0x00000001898BA520-0x00000001898BA560
	// [XID] // 0x00000001898BA520-0x00000001898BA560
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayTextDataExcelConfig> configList) => default; // 0x0000000184ED0E90-0x0000000184ED1140
	// [IDTag] // 0x00000001898C4A80-0x00000001898C4AC0
	// [XID] // 0x00000001898C4A80-0x00000001898C4AC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF290F */, bool useObjectPool = false /* Metadata: 0x00AF2913 */) => default; // 0x0000000184ED1140-0x0000000184ED1390
	// [IDTag] // 0x00000001898CF130-0x00000001898CF170
	// [XID] // 0x00000001898CF130-0x00000001898CF170
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2914 */, bool useObjectPool = false /* Metadata: 0x00AF2918 */) => default; // 0x0000000184ED1390-0x0000000184ED16E0
}

