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

public static class ExhibitionCardExcelConfigLoader // TypeDefIndex: 15590
{
	// Fields
	private static Dictionary<uint, ExhibitionCardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExhibitionCardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExhibitionCardExcelConfig, ExhibitionCardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExhibitionCardExcelConfig>, Dictionary<uint, ExhibitionCardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExhibitionCardExcelConfig> dataDict { /* [XID] */ /* 0x000000018985E1B0-0x000000018985E1D0 */ get; } // 0x0000000182DADCE0-0x0000000182DADD90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018986D130-0x000000018986D150 */ get; } // 0x0000000182DACB30-0x0000000182DACBD0 

	// Methods
	// [XID] // 0x0000000189857080-0x00000001898570A0
	public static void Register() {} // 0x0000000182DAE0C0-0x0000000182DAE160
	// [XID] // 0x0000000189865B90-0x0000000189865BB0
	public static ExhibitionCardExcelConfig GetData(uint id) => default; // 0x0000000182DACA00-0x0000000182DACB30
	// [XID] // 0x0000000189874560-0x0000000189874580
	public static void LoadData() {} // 0x0000000182DAD160-0x0000000182DAD250
	// [XID] // 0x000000018987C120-0x000000018987C140
	private static void RegisterHotfixGenerated() {} // 0x0000000182DACF90-0x0000000182DAD160
	// [XID] // 0x0000000189883290-0x00000001898832B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182DACBD0-0x0000000182DACF90
	// [IDTag] // 0x000000018988A9B0-0x000000018988A9F0
	// [XID] // 0x000000018988A9B0-0x000000018988A9F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182DAD390-0x0000000182DAD490
	// [XID] // 0x0000000189894E50-0x0000000189894E70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExhibitionCardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182DADD90-0x0000000182DAE0C0
	// [XID] // 0x000000018989C520-0x000000018989C540
	private static bool ParseConfigFromLine(string line, out ExhibitionCardExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182DAD250-0x0000000182DAD390
	// [IDTag] // 0x00000001898A3CA0-0x00000001898A3CE0
	// [XID] // 0x00000001898A3CA0-0x00000001898A3CE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExhibitionCardExcelConfig> configList) => default; // 0x0000000182DAD490-0x0000000182DAD740
	// [IDTag] // 0x00000001898AE410-0x00000001898AE450
	// [XID] // 0x00000001898AE410-0x00000001898AE450
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1FF0 */, bool useObjectPool = false /* Metadata: 0x00AF1FF4 */) => default; // 0x0000000182DADA90-0x0000000182DADCE0
	// [IDTag] // 0x00000001898B8B40-0x00000001898B8B80
	// [XID] // 0x00000001898B8B40-0x00000001898B8B80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1FF5 */, bool useObjectPool = false /* Metadata: 0x00AF1FF9 */) => default; // 0x0000000182DAD740-0x0000000182DADA90
}

