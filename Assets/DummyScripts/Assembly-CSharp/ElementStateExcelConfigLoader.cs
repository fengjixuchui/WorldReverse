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

public static class ElementStateExcelConfigLoader // TypeDefIndex: 14915
{
	// Fields
	private static Dictionary<int, ElementStateExcelConfig> _dataDic; // 0x00
	private static List<ElementStateExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<ElementStateExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<ElementStateExcelConfig, ElementStateExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<ElementStateExcelConfig>, List<ElementStateExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<ElementStateExcelConfig> dataList { /* [XID] */ /* 0x000000018988F140-0x000000018988F160 */ get; } // 0x00000001849EC500-0x00000001849EC5D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898966E0-0x0000000189896700 */ get; } // 0x00000001849EAF70-0x00000001849EB010 

	// Constructors
	static ElementStateExcelConfigLoader() {} // 0x00000001849ECB80-0x00000001849ECC10

	// Methods
	// [XID] // 0x0000000189ACA6F0-0x0000000189ACA710
	public static ElementStateExcelConfig GetData(ElementType elemType) => default; // 0x00000001849EAE70-0x00000001849EAF70
	// [XID] // 0x0000000189880860-0x0000000189880880
	public static void InitEnumeDic() {} // 0x00000001849EC9E0-0x00000001849ECB80
	// [XID] // 0x0000000189887D80-0x0000000189887DA0
	public static void Register() {} // 0x00000001849EC920-0x00000001849EC9E0
	// [XID] // 0x000000018989DC80-0x000000018989DCA0
	public static void LoadData() {} // 0x00000001849EB7D0-0x00000001849EB900
	// [XID] // 0x00000001898A5640-0x00000001898A5660
	private static void RegisterHotfixGenerated() {} // 0x00000001849EB560-0x00000001849EB7D0
	// [XID] // 0x00000001898ACBE0-0x00000001898ACC00
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001849EB010-0x00000001849EB560
	// [IDTag] // 0x00000001898B4020-0x00000001898B4060
	// [XID] // 0x00000001898B4020-0x00000001898B4060
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001849EBA40-0x00000001849EBBA0
	// [XID] // 0x00000001898BE940-0x00000001898BE960
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ElementStateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001849EC5D0-0x00000001849EC920
	// [XID] // 0x00000001898C60D0-0x00000001898C60F0
	private static bool ParseConfigFromLine(string line, out ElementStateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001849EB900-0x00000001849EBA40
	// [IDTag] // 0x00000001898CD880-0x00000001898CD8C0
	// [XID] // 0x00000001898CD880-0x00000001898CD8C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ElementStateExcelConfig> configList) => default; // 0x00000001849EBBA0-0x00000001849EBED0
	// [IDTag] // 0x00000001898D8220-0x00000001898D8260
	// [XID] // 0x00000001898D8220-0x00000001898D8260
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9C9 */, bool useObjectPool = false /* Metadata: 0x00AEF9CD */) => default; // 0x00000001849EBED0-0x00000001849EC180
	// [IDTag] // 0x00000001898E2F00-0x00000001898E2F40
	// [XID] // 0x00000001898E2F00-0x00000001898E2F40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9CE */, bool useObjectPool = false /* Metadata: 0x00AEF9D2 */) => default; // 0x00000001849EC180-0x00000001849EC500
}

