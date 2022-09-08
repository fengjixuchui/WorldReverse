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

public static class NewActivityScoreRewardExcelConfigLoader // TypeDefIndex: 15902
{
	// Fields
	private static Dictionary<uint, NewActivityScoreRewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityScoreRewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityScoreRewardExcelConfig, NewActivityScoreRewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityScoreRewardExcelConfig>, Dictionary<uint, NewActivityScoreRewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityScoreRewardExcelConfig> dataDict { /* [XID] */ /* 0x00000001899058C0-0x00000001899058E0 */ get; } // 0x00000001821FE270-0x00000001821FE320 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189914940-0x0000000189914960 */ get; } // 0x00000001821FD0C0-0x00000001821FD160 

	// Methods
	// [XID] // 0x00000001898FE0A0-0x00000001898FE0C0
	public static void Register() {} // 0x00000001821FE650-0x00000001821FE6F0
	// [XID] // 0x000000018990D1F0-0x000000018990D210
	public static NewActivityScoreRewardExcelConfig GetData(uint id) => default; // 0x00000001821FCF90-0x00000001821FD0C0
	// [XID] // 0x000000018991C540-0x000000018991C560
	public static void LoadData() {} // 0x00000001821FD6F0-0x00000001821FD7E0
	// [XID] // 0x0000000189923D00-0x0000000189923D20
	private static void RegisterHotfixGenerated() {} // 0x00000001821FD520-0x00000001821FD6F0
	// [XID] // 0x000000018992B2C0-0x000000018992B2E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821FD160-0x00000001821FD520
	// [IDTag] // 0x0000000189932980-0x00000001899329C0
	// [XID] // 0x0000000189932980-0x00000001899329C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821FDBD0-0x00000001821FDCD0
	// [XID] // 0x000000018993D150-0x000000018993D170
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityScoreRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001821FE320-0x00000001821FE650
	// [XID] // 0x0000000189944800-0x0000000189944820
	private static bool ParseConfigFromLine(string line, out NewActivityScoreRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821FD7E0-0x00000001821FD920
	// [IDTag] // 0x000000018994BDE0-0x000000018994BE20
	// [XID] // 0x000000018994BDE0-0x000000018994BE20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityScoreRewardExcelConfig> configList) => default; // 0x00000001821FD920-0x00000001821FDBD0
	// [IDTag] // 0x0000000189956320-0x0000000189956360
	// [XID] // 0x0000000189956320-0x0000000189956360
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2AAF */, bool useObjectPool = false /* Metadata: 0x00AF2AB3 */) => default; // 0x00000001821FDCD0-0x00000001821FDF20
	// [IDTag] // 0x0000000189960D40-0x0000000189960D80
	// [XID] // 0x0000000189960D40-0x0000000189960D80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AB4 */, bool useObjectPool = false /* Metadata: 0x00AF2AB8 */) => default; // 0x00000001821FDF20-0x00000001821FE270
}

