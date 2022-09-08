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

public static class BonusActivityExcelConfigLoader // TypeDefIndex: 16166
{
	// Fields
	private static Dictionary<uint, BonusActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BonusActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BonusActivityExcelConfig, BonusActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BonusActivityExcelConfig>, Dictionary<uint, BonusActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BonusActivityExcelConfig> dataDict { /* [XID] */ /* 0x000000018969C200-0x000000018969C220 */ get; } // 0x00000001838ECA80-0x00000001838ECB30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896AAB70-0x00000001896AAB90 */ get; } // 0x00000001838EB8D0-0x00000001838EB970 

	// Methods
	// [XID] // 0x0000000189694A00-0x0000000189694A20
	public static void Register() {} // 0x00000001838ECE60-0x00000001838ECF00
	// [XID] // 0x00000001896A3660-0x00000001896A3680
	public static BonusActivityExcelConfig GetData(uint id) => default; // 0x00000001838EB7A0-0x00000001838EB8D0
	// [XID] // 0x00000001896B1AF0-0x00000001896B1B10
	public static void LoadData() {} // 0x00000001838EBF00-0x00000001838EBFF0
	// [XID] // 0x00000001896B9550-0x00000001896B9570
	private static void RegisterHotfixGenerated() {} // 0x00000001838EBD30-0x00000001838EBF00
	// [XID] // 0x00000001896C08C0-0x00000001896C08E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001838EB970-0x00000001838EBD30
	// [IDTag] // 0x00000001896C8030-0x00000001896C8070
	// [XID] // 0x00000001896C8030-0x00000001896C8070
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001838EC130-0x00000001838EC230
	// [XID] // 0x00000001896D2400-0x00000001896D2420
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BonusActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001838ECB30-0x00000001838ECE60
	// [XID] // 0x00000001896D9E10-0x00000001896D9E30
	private static bool ParseConfigFromLine(string line, out BonusActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001838EBFF0-0x00000001838EC130
	// [IDTag] // 0x00000001896E1470-0x00000001896E14B0
	// [XID] // 0x00000001896E1470-0x00000001896E14B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BonusActivityExcelConfig> configList) => default; // 0x00000001838EC230-0x00000001838EC4E0
	// [IDTag] // 0x00000001896EB800-0x00000001896EB840
	// [XID] // 0x00000001896EB800-0x00000001896EB840
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF330D */, bool useObjectPool = false /* Metadata: 0x00AF3311 */) => default; // 0x00000001838EC4E0-0x00000001838EC730
	// [IDTag] // 0x00000001896F5F20-0x00000001896F5F60
	// [XID] // 0x00000001896F5F20-0x00000001896F5F60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3312 */, bool useObjectPool = false /* Metadata: 0x00AF3316 */) => default; // 0x00000001838EC730-0x00000001838ECA80
}

