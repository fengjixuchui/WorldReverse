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

public static class NewActivityCondExcelConfigLoader // TypeDefIndex: 15891
{
	// Fields
	private static Dictionary<uint, NewActivityCondExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityCondExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityCondExcelConfig, NewActivityCondExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityCondExcelConfig>, Dictionary<uint, NewActivityCondExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityCondExcelConfig> dataDict { /* [XID] */ /* 0x000000018986EB10-0x000000018986EB30 */ get; } // 0x0000000181185920-0x00000001811859D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018987DBA0-0x000000018987DBC0 */ get; } // 0x0000000181184770-0x0000000181184810 

	// Methods
	// [XID] // 0x0000000189867350-0x0000000189867370
	public static void Register() {} // 0x0000000181185D00-0x0000000181185DA0
	// [XID] // 0x0000000189875FC0-0x0000000189875FE0
	public static NewActivityCondExcelConfig GetData(uint condId) => default; // 0x0000000181184640-0x0000000181184770
	// [XID] // 0x0000000189884A90-0x0000000189884AB0
	public static void LoadData() {} // 0x0000000181184DA0-0x0000000181184E90
	// [XID] // 0x000000018988C140-0x000000018988C160
	private static void RegisterHotfixGenerated() {} // 0x0000000181184BD0-0x0000000181184DA0
	// [XID] // 0x00000001898936B0-0x00000001898936D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181184810-0x0000000181184BD0
	// [IDTag] // 0x000000018989ADB0-0x000000018989ADF0
	// [XID] // 0x000000018989ADB0-0x000000018989ADF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181185280-0x0000000181185380
	// [XID] // 0x00000001898A5360-0x00000001898A5380
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityCondExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001811859D0-0x0000000181185D00
	// [XID] // 0x00000001898AC960-0x00000001898AC980
	private static bool ParseConfigFromLine(string line, out NewActivityCondExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181184E90-0x0000000181184FD0
	// [IDTag] // 0x00000001898B3E00-0x00000001898B3E40
	// [XID] // 0x00000001898B3E00-0x00000001898B3E40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityCondExcelConfig> configList) => default; // 0x0000000181184FD0-0x0000000181185280
	// [IDTag] // 0x00000001898BE760-0x00000001898BE7A0
	// [XID] // 0x00000001898BE760-0x00000001898BE7A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2A5F */, bool useObjectPool = false /* Metadata: 0x00AF2A63 */) => default; // 0x00000001811856D0-0x0000000181185920
	// [IDTag] // 0x00000001898C9120-0x00000001898C9160
	// [XID] // 0x00000001898C9120-0x00000001898C9160
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A64 */, bool useObjectPool = false /* Metadata: 0x00AF2A68 */) => default; // 0x0000000181185380-0x00000001811856D0
}

