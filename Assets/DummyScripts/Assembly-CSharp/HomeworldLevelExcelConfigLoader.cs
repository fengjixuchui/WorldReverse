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

public static class HomeworldLevelExcelConfigLoader // TypeDefIndex: 15719
{
	// Fields
	private static Dictionary<uint, HomeworldLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeworldLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeworldLevelExcelConfig, HomeworldLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeworldLevelExcelConfig>, Dictionary<uint, HomeworldLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeworldLevelExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B61430-0x0000000189B61450 */ get; } // 0x00000001841D7860-0x00000001841D7910 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B702E0-0x0000000189B70300 */ get; } // 0x00000001841D66B0-0x00000001841D6750 

	// Methods
	// [XID] // 0x0000000189B59D20-0x0000000189B59D40
	public static void Register() {} // 0x00000001841D7C40-0x00000001841D7CE0
	// [XID] // 0x0000000189B68EC0-0x0000000189B68EE0
	public static HomeworldLevelExcelConfig GetData(uint level) => default; // 0x00000001841D6580-0x00000001841D66B0
	// [XID] // 0x0000000189B77810-0x0000000189B77830
	public static void LoadData() {} // 0x00000001841D6CE0-0x00000001841D6DD0
	// [XID] // 0x0000000189B7EDE0-0x0000000189B7EE00
	private static void RegisterHotfixGenerated() {} // 0x00000001841D6B10-0x00000001841D6CE0
	// [XID] // 0x0000000189B86940-0x0000000189B86960
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001841D6750-0x00000001841D6B10
	// [IDTag] // 0x0000000189B8DA70-0x0000000189B8DAB0
	// [XID] // 0x0000000189B8DA70-0x0000000189B8DAB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001841D71C0-0x00000001841D72C0
	// [XID] // 0x0000000189B98020-0x0000000189B98040
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeworldLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001841D7910-0x00000001841D7C40
	// [XID] // 0x0000000189B9F4B0-0x0000000189B9F4D0
	private static bool ParseConfigFromLine(string line, out HomeworldLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001841D6DD0-0x00000001841D6F10
	// [IDTag] // 0x0000000189BA6D00-0x0000000189BA6D40
	// [XID] // 0x0000000189BA6D00-0x0000000189BA6D40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeworldLevelExcelConfig> configList) => default; // 0x00000001841D6F10-0x00000001841D71C0
	// [IDTag] // 0x0000000189BB1570-0x0000000189BB15B0
	// [XID] // 0x0000000189BB1570-0x0000000189BB15B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2422 */, bool useObjectPool = false /* Metadata: 0x00AF2426 */) => default; // 0x00000001841D7610-0x00000001841D7860
	// [IDTag] // 0x0000000189BBB730-0x0000000189BBB770
	// [XID] // 0x0000000189BBB730-0x0000000189BBB770
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2427 */, bool useObjectPool = false /* Metadata: 0x00AF242B */) => default; // 0x00000001841D72C0-0x00000001841D7610
}

