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

public static class MaterialCodexExcelConfigLoader // TypeDefIndex: 15316
{
	// Fields
	private static Dictionary<uint, MaterialCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MaterialCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MaterialCodexExcelConfig, MaterialCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MaterialCodexExcelConfig>, Dictionary<uint, MaterialCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MaterialCodexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A66D20-0x0000000189A66D40 */ get; } // 0x000000018477D230-0x000000018477D2E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A75C70-0x0000000189A75C90 */ get; } // 0x000000018477C080-0x000000018477C120 

	// Methods
	// [XID] // 0x0000000189A5F470-0x0000000189A5F490
	public static void Register() {} // 0x000000018477D610-0x000000018477D6B0
	// [XID] // 0x0000000189A6E580-0x0000000189A6E5A0
	public static MaterialCodexExcelConfig GetData(uint Id) => default; // 0x000000018477BF50-0x000000018477C080
	// [XID] // 0x0000000189A7D830-0x0000000189A7D850
	public static void LoadData() {} // 0x000000018477C6B0-0x000000018477C7A0
	// [XID] // 0x0000000189A85060-0x0000000189A85080
	private static void RegisterHotfixGenerated() {} // 0x000000018477C4E0-0x000000018477C6B0
	// [XID] // 0x0000000189A8C930-0x0000000189A8C950
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018477C120-0x000000018477C4E0
	// [IDTag] // 0x0000000189A93CD0-0x0000000189A93D10
	// [XID] // 0x0000000189A93CD0-0x0000000189A93D10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018477C8E0-0x000000018477C9E0
	// [XID] // 0x0000000189A9E350-0x0000000189A9E370
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MaterialCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018477D2E0-0x000000018477D610
	// [XID] // 0x0000000189AA5D40-0x0000000189AA5D60
	private static bool ParseConfigFromLine(string line, out MaterialCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018477C7A0-0x000000018477C8E0
	// [IDTag] // 0x0000000189AAD3A0-0x0000000189AAD3E0
	// [XID] // 0x0000000189AAD3A0-0x0000000189AAD3E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MaterialCodexExcelConfig> configList) => default; // 0x000000018477C9E0-0x000000018477CC90
	// [IDTag] // 0x0000000189AB7C40-0x0000000189AB7C80
	// [XID] // 0x0000000189AB7C40-0x0000000189AB7C80
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0754 */, bool useObjectPool = false /* Metadata: 0x00AF0758 */) => default; // 0x000000018477CC90-0x000000018477CEE0
	// [IDTag] // 0x0000000189AC2A60-0x0000000189AC2AA0
	// [XID] // 0x0000000189AC2A60-0x0000000189AC2AA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0759 */, bool useObjectPool = false /* Metadata: 0x00AF075D */) => default; // 0x000000018477CEE0-0x000000018477D230
}

