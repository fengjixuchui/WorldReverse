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

public static class FettersExcelConfigLoader // TypeDefIndex: 15611
{
	// Fields
	private static Dictionary<uint, FettersExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FettersExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FettersExcelConfig, FettersExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FettersExcelConfig>, Dictionary<uint, FettersExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FettersExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B4F550-0x0000000189B4F570 */ get; } // 0x0000000185031050-0x0000000185031100 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B5E740-0x0000000189B5E760 */ get; } // 0x000000018502FEA0-0x000000018502FF40 

	// Methods
	// [XID] // 0x0000000189B47C60-0x0000000189B47C80
	public static void Register() {} // 0x0000000185031430-0x00000001850314D0
	// [XID] // 0x0000000189B56E30-0x0000000189B56E50
	public static FettersExcelConfig GetData(uint fetter_id) => default; // 0x000000018502FD70-0x000000018502FEA0
	// [XID] // 0x0000000189B65CA0-0x0000000189B65CC0
	public static void LoadData() {} // 0x00000001850304D0-0x00000001850305C0
	// [XID] // 0x0000000189B6D280-0x0000000189B6D2A0
	private static void RegisterHotfixGenerated() {} // 0x0000000185030300-0x00000001850304D0
	// [XID] // 0x0000000189B74970-0x0000000189B74990
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018502FF40-0x0000000185030300
	// [IDTag] // 0x0000000189B7BF30-0x0000000189B7BF70
	// [XID] // 0x0000000189B7BF30-0x0000000189B7BF70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001850309B0-0x0000000185030AB0
	// [XID] // 0x0000000189B869A0-0x0000000189B869C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FettersExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185031100-0x0000000185031430
	// [XID] // 0x0000000189B8DB30-0x0000000189B8DB50
	private static bool ParseConfigFromLine(string line, out FettersExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001850305C0-0x0000000185030700
	// [IDTag] // 0x0000000189B95030-0x0000000189B95070
	// [XID] // 0x0000000189B95030-0x0000000189B95070
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FettersExcelConfig> configList) => default; // 0x0000000185030700-0x00000001850309B0
	// [IDTag] // 0x0000000189B9F4D0-0x0000000189B9F510
	// [XID] // 0x0000000189B9F4D0-0x0000000189B9F510
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF208D */, bool useObjectPool = false /* Metadata: 0x00AF2091 */) => default; // 0x0000000185030E00-0x0000000185031050
	// [IDTag] // 0x0000000189BA9CC0-0x0000000189BA9D00
	// [XID] // 0x0000000189BA9CC0-0x0000000189BA9D00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2092 */, bool useObjectPool = false /* Metadata: 0x00AF2096 */) => default; // 0x0000000185030AB0-0x0000000185030E00
}

