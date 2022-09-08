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

public static class GalleryExcelConfigLoader // TypeDefIndex: 15654
{
	// Fields
	private static Dictionary<uint, GalleryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GalleryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GalleryExcelConfig, GalleryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GalleryExcelConfig>, Dictionary<uint, GalleryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GalleryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189854040-0x0000000189854060 */ get; } // 0x0000000184048BA0-0x0000000184048C50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189863030-0x0000000189863050 */ get; } // 0x00000001840479F0-0x0000000184047A90 

	// Methods
	// [XID] // 0x000000018984CFA0-0x000000018984CFC0
	public static void Register() {} // 0x0000000184048F80-0x0000000184049020
	// [XID] // 0x000000018985BA50-0x000000018985BA70
	public static GalleryExcelConfig GetData(uint id) => default; // 0x00000001840478C0-0x00000001840479F0
	// [XID] // 0x000000018986A4A0-0x000000018986A4C0
	public static void LoadData() {} // 0x0000000184048020-0x0000000184048110
	// [XID] // 0x00000001898718F0-0x0000000189871910
	private static void RegisterHotfixGenerated() {} // 0x0000000184047E50-0x0000000184048020
	// [XID] // 0x00000001898791B0-0x00000001898791D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184047A90-0x0000000184047E50
	// [IDTag] // 0x0000000189880760-0x00000001898807A0
	// [XID] // 0x0000000189880760-0x00000001898807A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184048500-0x0000000184048600
	// [XID] // 0x000000018988A970-0x000000018988A990
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GalleryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184048C50-0x0000000184048F80
	// [XID] // 0x0000000189891E60-0x0000000189891E80
	private static bool ParseConfigFromLine(string line, out GalleryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184048110-0x0000000184048250
	// [IDTag] // 0x0000000189899770-0x00000001898997B0
	// [XID] // 0x0000000189899770-0x00000001898997B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GalleryExcelConfig> configList) => default; // 0x0000000184048250-0x0000000184048500
	// [IDTag] // 0x00000001898A3BC0-0x00000001898A3C00
	// [XID] // 0x00000001898A3BC0-0x00000001898A3C00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF21F4 */, bool useObjectPool = false /* Metadata: 0x00AF21F8 */) => default; // 0x0000000184048950-0x0000000184048BA0
	// [IDTag] // 0x00000001898AE370-0x00000001898AE3B0
	// [XID] // 0x00000001898AE370-0x00000001898AE3B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF21F9 */, bool useObjectPool = false /* Metadata: 0x00AF21FD */) => default; // 0x0000000184048600-0x0000000184048950
}

