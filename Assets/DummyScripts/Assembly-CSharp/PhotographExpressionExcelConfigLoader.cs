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

public static class PhotographExpressionExcelConfigLoader // TypeDefIndex: 15949
{
	// Fields
	private static Dictionary<uint, PhotographExpressionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PhotographExpressionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PhotographExpressionExcelConfig, PhotographExpressionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PhotographExpressionExcelConfig>, Dictionary<uint, PhotographExpressionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PhotographExpressionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A9A180-0x0000000189A9A1A0 */ get; } // 0x000000018471DC90-0x000000018471DD40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AA88A0-0x0000000189AA88C0 */ get; } // 0x000000018471CAE0-0x000000018471CB80 

	// Methods
	// [XID] // 0x0000000189A926F0-0x0000000189A92710
	public static void Register() {} // 0x000000018471E070-0x000000018471E110
	// [XID] // 0x0000000189AA1160-0x0000000189AA1180
	public static PhotographExpressionExcelConfig GetData(uint fetter_id) => default; // 0x000000018471C9B0-0x000000018471CAE0
	// [XID] // 0x0000000189AB04A0-0x0000000189AB04C0
	public static void LoadData() {} // 0x000000018471D110-0x000000018471D200
	// [XID] // 0x0000000189AB7B00-0x0000000189AB7B20
	private static void RegisterHotfixGenerated() {} // 0x000000018471CF40-0x000000018471D110
	// [XID] // 0x0000000189ABF5F0-0x0000000189ABF610
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018471CB80-0x000000018471CF40
	// [IDTag] // 0x0000000189AC6FC0-0x0000000189AC7000
	// [XID] // 0x0000000189AC6FC0-0x0000000189AC7000
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018471D5F0-0x000000018471D6F0
	// [XID] // 0x0000000189AD17D0-0x0000000189AD17F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PhotographExpressionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018471DD40-0x000000018471E070
	// [XID] // 0x0000000189AD9570-0x0000000189AD9590
	private static bool ParseConfigFromLine(string line, out PhotographExpressionExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018471D200-0x000000018471D340
	// [IDTag] // 0x0000000189AE1020-0x0000000189AE1060
	// [XID] // 0x0000000189AE1020-0x0000000189AE1060
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PhotographExpressionExcelConfig> configList) => default; // 0x000000018471D340-0x000000018471D5F0
	// [IDTag] // 0x0000000189AEB830-0x0000000189AEB870
	// [XID] // 0x0000000189AEB830-0x0000000189AEB870
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BFC */, bool useObjectPool = false /* Metadata: 0x00AF2C00 */) => default; // 0x000000018471D6F0-0x000000018471D940
	// [IDTag] // 0x0000000189AF60B0-0x0000000189AF60F0
	// [XID] // 0x0000000189AF60B0-0x0000000189AF60F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C01 */, bool useObjectPool = false /* Metadata: 0x00AF2C05 */) => default; // 0x000000018471D940-0x000000018471DC90
}

