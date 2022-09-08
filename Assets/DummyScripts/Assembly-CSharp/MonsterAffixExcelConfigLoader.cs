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

public static class MonsterAffixExcelConfigLoader // TypeDefIndex: 15844
{
	// Fields
	private static Dictionary<uint, MonsterAffixExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterAffixExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterAffixExcelConfig, MonsterAffixExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterAffixExcelConfig>, Dictionary<uint, MonsterAffixExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterAffixExcelConfig> dataDict { /* [XID] */ /* 0x00000001899FD130-0x00000001899FD150 */ get; } // 0x0000000181B1E950-0x0000000181B1EA00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A0BD90-0x0000000189A0BDB0 */ get; } // 0x0000000181B1D7A0-0x0000000181B1D840 

	// Methods
	// [XID] // 0x00000001899F5970-0x00000001899F5990
	public static void Register() {} // 0x0000000181B1ED30-0x0000000181B1EDD0
	// [XID] // 0x0000000189A04610-0x0000000189A04630
	public static MonsterAffixExcelConfig GetData(uint id) => default; // 0x0000000181B1D670-0x0000000181B1D7A0
	// [XID] // 0x0000000189A13640-0x0000000189A13660
	public static void LoadData() {} // 0x0000000181B1DDD0-0x0000000181B1DEC0
	// [XID] // 0x0000000189A1A7B0-0x0000000189A1A7D0
	private static void RegisterHotfixGenerated() {} // 0x0000000181B1DC00-0x0000000181B1DDD0
	// [XID] // 0x0000000189A22030-0x0000000189A22050
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181B1D840-0x0000000181B1DC00
	// [IDTag] // 0x0000000189A29480-0x0000000189A294C0
	// [XID] // 0x0000000189A29480-0x0000000189A294C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181B1E000-0x0000000181B1E100
	// [XID] // 0x0000000189A33A60-0x0000000189A33A80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterAffixExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181B1EA00-0x0000000181B1ED30
	// [XID] // 0x0000000189A3B200-0x0000000189A3B220
	private static bool ParseConfigFromLine(string line, out MonsterAffixExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181B1DEC0-0x0000000181B1E000
	// [IDTag] // 0x0000000189A42C50-0x0000000189A42C90
	// [XID] // 0x0000000189A42C50-0x0000000189A42C90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterAffixExcelConfig> configList) => default; // 0x0000000181B1E100-0x0000000181B1E3B0
	// [IDTag] // 0x0000000189A4D280-0x0000000189A4D2C0
	// [XID] // 0x0000000189A4D280-0x0000000189A4D2C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2827 */, bool useObjectPool = false /* Metadata: 0x00AF282B */) => default; // 0x0000000181B1E3B0-0x0000000181B1E600
	// [IDTag] // 0x0000000189A57810-0x0000000189A57850
	// [XID] // 0x0000000189A57810-0x0000000189A57850
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF282C */, bool useObjectPool = false /* Metadata: 0x00AF2830 */) => default; // 0x0000000181B1E600-0x0000000181B1E950
}

