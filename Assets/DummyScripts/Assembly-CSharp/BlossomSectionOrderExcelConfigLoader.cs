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

public static class BlossomSectionOrderExcelConfigLoader // TypeDefIndex: 15274
{
	// Fields
	private static Dictionary<uint, BlossomSectionOrderExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomSectionOrderExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomSectionOrderExcelConfig, BlossomSectionOrderExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomSectionOrderExcelConfig>, Dictionary<uint, BlossomSectionOrderExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomSectionOrderExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A0BEB0-0x0000000189A0BED0 */ get; } // 0x00000001827FB260-0x00000001827FB310 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A1A8D0-0x0000000189A1A8F0 */ get; } // 0x00000001827FA0B0-0x00000001827FA150 

	// Methods
	// [XID] // 0x0000000189A04670-0x0000000189A04690
	public static void Register() {} // 0x00000001827FB640-0x00000001827FB6E0
	// [XID] // 0x0000000189A137C0-0x0000000189A137E0
	public static BlossomSectionOrderExcelConfig GetData(uint id) => default; // 0x00000001827F9F80-0x00000001827FA0B0
	// [XID] // 0x0000000189A22150-0x0000000189A22170
	public static void LoadData() {} // 0x00000001827FA6E0-0x00000001827FA7D0
	// [XID] // 0x0000000189A295C0-0x0000000189A295E0
	private static void RegisterHotfixGenerated() {} // 0x00000001827FA510-0x00000001827FA6E0
	// [XID] // 0x0000000189A30B10-0x0000000189A30B30
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001827FA150-0x00000001827FA510
	// [IDTag] // 0x0000000189A38590-0x0000000189A385D0
	// [XID] // 0x0000000189A38590-0x0000000189A385D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001827FABC0-0x00000001827FACC0
	// [XID] // 0x0000000189A42D70-0x0000000189A42D90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomSectionOrderExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001827FB310-0x00000001827FB640
	// [XID] // 0x0000000189A4A200-0x0000000189A4A220
	private static bool ParseConfigFromLine(string line, out BlossomSectionOrderExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001827FA7D0-0x00000001827FA910
	// [IDTag] // 0x0000000189A51BD0-0x0000000189A51C10
	// [XID] // 0x0000000189A51BD0-0x0000000189A51C10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomSectionOrderExcelConfig> configList) => default; // 0x00000001827FA910-0x00000001827FABC0
	// [IDTag] // 0x0000000189A5C600-0x0000000189A5C640
	// [XID] // 0x0000000189A5C600-0x0000000189A5C640
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF05F0 */, bool useObjectPool = false /* Metadata: 0x00AF05F4 */) => default; // 0x00000001827FB010-0x00000001827FB260
	// [IDTag] // 0x0000000189A66D80-0x0000000189A66DC0
	// [XID] // 0x0000000189A66D80-0x0000000189A66DC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05F5 */, bool useObjectPool = false /* Metadata: 0x00AF05F9 */) => default; // 0x00000001827FACC0-0x00000001827FB010
}

