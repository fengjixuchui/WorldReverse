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

public static class MaterialExcelConfigLoader // TypeDefIndex: 14874
{
	// Fields
	private static List<uint> _totalNameCardIdList; // 0x00
	private static Dictionary<uint, MaterialExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MaterialExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<MaterialExcelConfig, MaterialExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MaterialExcelConfig>, Dictionary<uint, MaterialExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, MaterialExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A3CBC0-0x0000000189A3CBE0 */ get; } // 0x0000000184BE90E0-0x0000000184BE91B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A4BC00-0x0000000189A4BC20 */ get; } // 0x0000000184BE77C0-0x0000000184BE7860 

	// Constructors
	static MaterialExcelConfigLoader() {} // 0x0000000184BE95C0-0x0000000184BE9620

	// Methods
	// [XID] // 0x0000000189A26800-0x0000000189A26820
	public static void BuildTotalNameCardIdList() {} // 0x0000000184BE7860-0x0000000184BE7B60
	// [XID] // 0x0000000189A2DB70-0x0000000189A2DB90
	public static List<uint> GetTotalNameCardIdList() => default; // 0x0000000184BE82B0-0x0000000184BE8380
	// [XID] // 0x0000000189A35750-0x0000000189A35770
	public static void Register() {} // 0x0000000184BE9500-0x0000000184BE95C0
	// [XID] // 0x0000000189ABE6E0-0x0000000189ABE700
	public static MaterialExcelConfig GetData(uint id) => default; // 0x0000000184BE7620-0x0000000184BE77C0
	// [XID] // 0x0000000189A53300-0x0000000189A53320
	public static void LoadData() {} // 0x0000000184BE8380-0x0000000184BE84B0
	// [XID] // 0x0000000189A5AA70-0x0000000189A5AA90
	private static void RegisterHotfixGenerated() {} // 0x0000000184BE8040-0x0000000184BE82B0
	// [XID] // 0x0000000189A62210-0x0000000189A62230
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184BE7B60-0x0000000184BE8040
	// [IDTag] // 0x0000000189A6A170-0x0000000189A6A1B0
	// [XID] // 0x0000000189A6A170-0x0000000189A6A1B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184BE85F0-0x0000000184BE8750
	// [XID] // 0x0000000189A74530-0x0000000189A74550
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MaterialExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184BE91B0-0x0000000184BE9500
	// [XID] // 0x0000000189A7BFC0-0x0000000189A7BFE0
	private static bool ParseConfigFromLine(string line, out MaterialExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184BE84B0-0x0000000184BE85F0
	// [IDTag] // 0x0000000189A839C0-0x0000000189A83A00
	// [XID] // 0x0000000189A839C0-0x0000000189A83A00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MaterialExcelConfig> configList) => default; // 0x0000000184BE8750-0x0000000184BE8AA0
	// [IDTag] // 0x0000000189A8E2D0-0x0000000189A8E310
	// [XID] // 0x0000000189A8E2D0-0x0000000189A8E310
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8A9 */, bool useObjectPool = false /* Metadata: 0x00AEF8AD */) => default; // 0x0000000184BE8E30-0x0000000184BE90E0
	// [IDTag] // 0x0000000189A98B20-0x0000000189A98B60
	// [XID] // 0x0000000189A98B20-0x0000000189A98B60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8AE */, bool useObjectPool = false /* Metadata: 0x00AEF8B2 */) => default; // 0x0000000184BE8AA0-0x0000000184BE8E30
}

