/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RandomQuestElemPoolExcelConfigLoader // TypeDefIndex: 15987
{
	// Fields
	private static Dictionary<uint, RandomQuestElemPoolExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandomQuestElemPoolExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandomQuestElemPoolExcelConfig, RandomQuestElemPoolExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandomQuestElemPoolExcelConfig>, Dictionary<uint, RandomQuestElemPoolExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandomQuestElemPoolExcelConfig> dataDict { /* [XID] */ /* 0x0000000189932960-0x0000000189932980 */ get; } // 0x000000018295EA30-0x000000018295EAE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189941400-0x0000000189941420 */ get; } // 0x000000018295D880-0x000000018295D920 

	// Methods
	// [XID] // 0x000000018992B2A0-0x000000018992B2C0
	public static void Register() {} // 0x000000018295EE10-0x000000018295EEB0
	// [XID] // 0x000000018993A350-0x000000018993A370
	public static RandomQuestElemPoolExcelConfig GetData(uint id) => default; // 0x000000018295D750-0x000000018295D880
	// [XID] // 0x0000000189948FA0-0x0000000189948FC0
	public static void LoadData() {} // 0x000000018295DEB0-0x000000018295DFA0
	// [XID] // 0x0000000189950790-0x00000001899507B0
	private static void RegisterHotfixGenerated() {} // 0x000000018295DCE0-0x000000018295DEB0
	// [XID] // 0x0000000189957D80-0x0000000189957DA0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018295D920-0x000000018295DCE0
	// [IDTag] // 0x000000018995F630-0x000000018995F670
	// [XID] // 0x000000018995F630-0x000000018995F670
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018295E0E0-0x000000018295E1E0
	// [XID] // 0x0000000189969C40-0x0000000189969C60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandomQuestElemPoolExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018295EAE0-0x000000018295EE10
	// [XID] // 0x00000001899719A0-0x00000001899719C0
	private static bool ParseConfigFromLine(string line, out RandomQuestElemPoolExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018295DFA0-0x000000018295E0E0
	// [IDTag] // 0x0000000189979250-0x0000000189979290
	// [XID] // 0x0000000189979250-0x0000000189979290
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandomQuestElemPoolExcelConfig> configList) => default; // 0x000000018295E1E0-0x000000018295E490
	// [IDTag] // 0x0000000189983770-0x00000001899837B0
	// [XID] // 0x0000000189983770-0x00000001899837B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D06 */, bool useObjectPool = false /* Metadata: 0x00AF2D0A */) => default; // 0x000000018295E490-0x000000018295E6E0
	// [IDTag] // 0x000000018998DF20-0x000000018998DF60
	// [XID] // 0x000000018998DF20-0x000000018998DF60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D0B */, bool useObjectPool = false /* Metadata: 0x00AF2D0F */) => default; // 0x000000018295E6E0-0x000000018295EA30
}

