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

public static class MpPlayLevelTextDataExcelConfigLoader // TypeDefIndex: 15876
{
	// Fields
	private static Dictionary<uint, MpPlayLevelTextDataExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayLevelTextDataExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayLevelTextDataExcelConfig, MpPlayLevelTextDataExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayLevelTextDataExcelConfig>, Dictionary<uint, MpPlayLevelTextDataExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayLevelTextDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189994430-0x0000000189994450 */ get; } // 0x00000001821243A0-0x0000000182124450 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A3430-0x00000001899A3450 */ get; } // 0x00000001821231F0-0x0000000182123290 

	// Methods
	// [XID] // 0x000000018998C6F0-0x000000018998C710
	public static void Register() {} // 0x0000000182124780-0x0000000182124820
	// [XID] // 0x000000018999BC80-0x000000018999BCA0
	public static MpPlayLevelTextDataExcelConfig GetData(uint id) => default; // 0x00000001821230C0-0x00000001821231F0
	// [XID] // 0x00000001899AAF80-0x00000001899AAFA0
	public static void LoadData() {} // 0x0000000182123820-0x0000000182123910
	// [XID] // 0x00000001899B2990-0x00000001899B29B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182123650-0x0000000182123820
	// [XID] // 0x00000001899B9B70-0x00000001899B9B90
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182123290-0x0000000182123650
	// [IDTag] // 0x00000001899C1690-0x00000001899C16D0
	// [XID] // 0x00000001899C1690-0x00000001899C16D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182123A50-0x0000000182123B50
	// [XID] // 0x00000001899CBF80-0x00000001899CBFA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayLevelTextDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182124450-0x0000000182124780
	// [XID] // 0x00000001899D34B0-0x00000001899D34D0
	private static bool ParseConfigFromLine(string line, out MpPlayLevelTextDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182123910-0x0000000182123A50
	// [IDTag] // 0x00000001899DAAE0-0x00000001899DAB20
	// [XID] // 0x00000001899DAAE0-0x00000001899DAB20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayLevelTextDataExcelConfig> configList) => default; // 0x0000000182123B50-0x0000000182123E00
	// [IDTag] // 0x00000001899E5680-0x00000001899E56C0
	// [XID] // 0x00000001899E5680-0x00000001899E56C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF291E */, bool useObjectPool = false /* Metadata: 0x00AF2922 */) => default; // 0x0000000182124150-0x00000001821243A0
	// [IDTag] // 0x00000001899EFA30-0x00000001899EFA70
	// [XID] // 0x00000001899EFA30-0x00000001899EFA70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2923 */, bool useObjectPool = false /* Metadata: 0x00AF2927 */) => default; // 0x0000000182123E00-0x0000000182124150
}

