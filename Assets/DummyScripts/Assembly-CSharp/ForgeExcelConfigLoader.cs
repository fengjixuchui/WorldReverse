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

public static class ForgeExcelConfigLoader // TypeDefIndex: 15622
{
	// Fields
	private static Dictionary<uint, ForgeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ForgeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ForgeExcelConfig, ForgeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ForgeExcelConfig>, Dictionary<uint, ForgeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ForgeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189679930-0x0000000189679950 */ get; } // 0x0000000183E660D0-0x0000000183E66180 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189688B00-0x0000000189688B20 */ get; } // 0x0000000183E64F20-0x0000000183E64FC0 

	// Methods
	// [XID] // 0x00000001896720A0-0x00000001896720C0
	public static void Register() {} // 0x0000000183E664B0-0x0000000183E66550
	// [XID] // 0x0000000189681040-0x0000000189681060
	public static ForgeExcelConfig GetData(uint id) => default; // 0x0000000183E64DF0-0x0000000183E64F20
	// [XID] // 0x00000001896904E0-0x0000000189690500
	public static void LoadData() {} // 0x0000000183E65550-0x0000000183E65640
	// [XID] // 0x0000000189697D60-0x0000000189697D80
	private static void RegisterHotfixGenerated() {} // 0x0000000183E65380-0x0000000183E65550
	// [XID] // 0x000000018969F090-0x000000018969F0B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183E64FC0-0x0000000183E65380
	// [IDTag] // 0x00000001896A64D0-0x00000001896A6510
	// [XID] // 0x00000001896A64D0-0x00000001896A6510
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183E65A30-0x0000000183E65B30
	// [XID] // 0x00000001896B06B0-0x00000001896B06D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ForgeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183E66180-0x0000000183E664B0
	// [XID] // 0x00000001896B80D0-0x00000001896B80F0
	private static bool ParseConfigFromLine(string line, out ForgeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183E65640-0x0000000183E65780
	// [IDTag] // 0x00000001896BF190-0x00000001896BF1D0
	// [XID] // 0x00000001896BF190-0x00000001896BF1D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ForgeExcelConfig> configList) => default; // 0x0000000183E65780-0x0000000183E65A30
	// [IDTag] // 0x00000001896C9690-0x00000001896C96D0
	// [XID] // 0x00000001896C9690-0x00000001896C96D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF20DA */, bool useObjectPool = false /* Metadata: 0x00AF20DE */) => default; // 0x0000000183E65B30-0x0000000183E65D80
	// [IDTag] // 0x00000001896D3B00-0x00000001896D3B40
	// [XID] // 0x00000001896D3B00-0x00000001896D3B40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20DF */, bool useObjectPool = false /* Metadata: 0x00AF20E3 */) => default; // 0x0000000183E65D80-0x0000000183E660D0
}

