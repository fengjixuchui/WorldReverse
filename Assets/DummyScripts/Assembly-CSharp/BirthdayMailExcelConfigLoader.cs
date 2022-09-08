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

public static class BirthdayMailExcelConfigLoader // TypeDefIndex: 15798
{
	// Fields
	private static Dictionary<uint, BirthdayMailExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BirthdayMailExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BirthdayMailExcelConfig, BirthdayMailExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BirthdayMailExcelConfig>, Dictionary<uint, BirthdayMailExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BirthdayMailExcelConfig> dataDict { /* [XID] */ /* 0x000000018965E230-0x000000018965E250 */ get; } // 0x00000001812BE9F0-0x00000001812BEAA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018966D020-0x000000018966D040 */ get; } // 0x00000001812BD840-0x00000001812BD8E0 

	// Methods
	// [XID] // 0x0000000189656B50-0x0000000189656B70
	public static void Register() {} // 0x00000001812BEDD0-0x00000001812BEE70
	// [XID] // 0x0000000189665930-0x0000000189665950
	public static BirthdayMailExcelConfig GetData(uint id) => default; // 0x00000001812BD710-0x00000001812BD840
	// [XID] // 0x0000000189674F50-0x0000000189674F70
	public static void LoadData() {} // 0x00000001812BDE70-0x00000001812BDF60
	// [XID] // 0x000000018967C740-0x000000018967C760
	private static void RegisterHotfixGenerated() {} // 0x00000001812BDCA0-0x00000001812BDE70
	// [XID] // 0x0000000189683DF0-0x0000000189683E10
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812BD8E0-0x00000001812BDCA0
	// [IDTag] // 0x000000018968B9D0-0x000000018968BA10
	// [XID] // 0x000000018968B9D0-0x000000018968BA10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001812BE350-0x00000001812BE450
	// [XID] // 0x0000000189696610-0x0000000189696630
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BirthdayMailExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001812BEAA0-0x00000001812BEDD0
	// [XID] // 0x000000018969DC30-0x000000018969DC50
	private static bool ParseConfigFromLine(string line, out BirthdayMailExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001812BDF60-0x00000001812BE0A0
	// [IDTag] // 0x00000001896A4C80-0x00000001896A4CC0
	// [XID] // 0x00000001896A4C80-0x00000001896A4CC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BirthdayMailExcelConfig> configList) => default; // 0x00000001812BE0A0-0x00000001812BE350
	// [IDTag] // 0x00000001896AF1F0-0x00000001896AF230
	// [XID] // 0x00000001896AF1F0-0x00000001896AF230
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2652 */, bool useObjectPool = false /* Metadata: 0x00AF2656 */) => default; // 0x00000001812BE450-0x00000001812BE6A0
	// [IDTag] // 0x00000001896B9650-0x00000001896B9690
	// [XID] // 0x00000001896B9650-0x00000001896B9690
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2657 */, bool useObjectPool = false /* Metadata: 0x00AF265B */) => default; // 0x00000001812BE6A0-0x00000001812BE9F0
}

