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

public static class EffigyRewardExcelConfigLoader // TypeDefIndex: 15080
{
	// Fields
	private static Dictionary<uint, EffigyRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EffigyRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EffigyRewardExcelConfig, EffigyRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EffigyRewardExcelConfig>, Dictionary<uint, EffigyRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EffigyRewardExcelConfig> dataDict { /* [XID] */ /* 0x00000001897BC2D0-0x00000001897BC2F0 */ get; } // 0x0000000180F25AE0-0x0000000180F25B90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897CB150-0x00000001897CB170 */ get; } // 0x0000000180F24930-0x0000000180F249D0 

	// Methods
	// [XID] // 0x00000001897B4550-0x00000001897B4570
	public static void Register() {} // 0x0000000180F25EC0-0x0000000180F25F60
	// [XID] // 0x00000001897C39D0-0x00000001897C39F0
	public static EffigyRewardExcelConfig GetData(uint id) => default; // 0x0000000180F24800-0x0000000180F24930
	// [XID] // 0x00000001897D2830-0x00000001897D2850
	public static void LoadData() {} // 0x0000000180F24F60-0x0000000180F25050
	// [XID] // 0x00000001897DA530-0x00000001897DA550
	private static void RegisterHotfixGenerated() {} // 0x0000000180F24D90-0x0000000180F24F60
	// [XID] // 0x00000001897E19C0-0x00000001897E19E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000180F249D0-0x0000000180F24D90
	// [IDTag] // 0x00000001897E9170-0x00000001897E91B0
	// [XID] // 0x00000001897E9170-0x00000001897E91B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000180F25440-0x0000000180F25540
	// [XID] // 0x00000001897F3E70-0x00000001897F3E90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EffigyRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000180F25B90-0x0000000180F25EC0
	// [XID] // 0x00000001897FB7D0-0x00000001897FB7F0
	private static bool ParseConfigFromLine(string line, out EffigyRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000180F25050-0x0000000180F25190
	// [IDTag] // 0x0000000189802C20-0x0000000189802C60
	// [XID] // 0x0000000189802C20-0x0000000189802C60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EffigyRewardExcelConfig> configList) => default; // 0x0000000180F25190-0x0000000180F25440
	// [IDTag] // 0x000000018980CED0-0x000000018980CF10
	// [XID] // 0x000000018980CED0-0x000000018980CF10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF003F */, bool useObjectPool = false /* Metadata: 0x00AF0043 */) => default; // 0x0000000180F25890-0x0000000180F25AE0
	// [IDTag] // 0x0000000189817A00-0x0000000189817A40
	// [XID] // 0x0000000189817A00-0x0000000189817A40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0044 */, bool useObjectPool = false /* Metadata: 0x00AF0048 */) => default; // 0x0000000180F25540-0x0000000180F25890
}

