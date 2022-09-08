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

public static class HuntingClueMonsterExcelConfigLoader // TypeDefIndex: 15751
{
	// Fields
	private static Dictionary<uint, HuntingClueMonsterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingClueMonsterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingClueMonsterExcelConfig, HuntingClueMonsterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingClueMonsterExcelConfig>, Dictionary<uint, HuntingClueMonsterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingClueMonsterExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BBCE00-0x0000000189BBCE20 */ get; } // 0x0000000181C5F3B0-0x0000000181C5F460 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BCC520-0x0000000189BCC540 */ get; } // 0x0000000181C5E200-0x0000000181C5E2A0 

	// Methods
	// [XID] // 0x0000000189BB5750-0x0000000189BB5770
	public static void Register() {} // 0x0000000181C5F790-0x0000000181C5F830
	// [XID] // 0x0000000189BC4A60-0x0000000189BC4A80
	public static HuntingClueMonsterExcelConfig GetData(uint configId) => default; // 0x0000000181C5E0D0-0x0000000181C5E200
	// [XID] // 0x0000000189BD3BB0-0x0000000189BD3BD0
	public static void LoadData() {} // 0x0000000181C5E830-0x0000000181C5E920
	// [XID] // 0x0000000189BDB4A0-0x0000000189BDB4C0
	private static void RegisterHotfixGenerated() {} // 0x0000000181C5E660-0x0000000181C5E830
	// [XID] // 0x00000001895E7DB0-0x00000001895E7DD0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181C5E2A0-0x0000000181C5E660
	// [IDTag] // 0x00000001895EF700-0x00000001895EF740
	// [XID] // 0x00000001895EF700-0x00000001895EF740
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181C5ED10-0x0000000181C5EE10
	// [XID] // 0x00000001895F9E20-0x00000001895F9E40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingClueMonsterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181C5F460-0x0000000181C5F790
	// [XID] // 0x0000000189601660-0x0000000189601680
	private static bool ParseConfigFromLine(string line, out HuntingClueMonsterExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181C5E920-0x0000000181C5EA60
	// [IDTag] // 0x0000000189608ED0-0x0000000189608F10
	// [XID] // 0x0000000189608ED0-0x0000000189608F10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingClueMonsterExcelConfig> configList) => default; // 0x0000000181C5EA60-0x0000000181C5ED10
	// [IDTag] // 0x0000000189613420-0x0000000189613460
	// [XID] // 0x0000000189613420-0x0000000189613460
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2508 */, bool useObjectPool = false /* Metadata: 0x00AF250C */) => default; // 0x0000000181C5EE10-0x0000000181C5F060
	// [IDTag] // 0x000000018961DCB0-0x000000018961DCF0
	// [XID] // 0x000000018961DCB0-0x000000018961DCF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF250D */, bool useObjectPool = false /* Metadata: 0x00AF2511 */) => default; // 0x0000000181C5F060-0x0000000181C5F3B0
}

