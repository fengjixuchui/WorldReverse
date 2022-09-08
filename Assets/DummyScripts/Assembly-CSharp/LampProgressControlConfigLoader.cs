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

public static class LampProgressControlConfigLoader // TypeDefIndex: 15179
{
	// Fields
	private static List<LampProgressControlConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<LampProgressControlConfig>> customApplyHotfixAction; // 0x08
	public static Action<LampProgressControlConfig, LampProgressControlConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LampProgressControlConfig>, List<LampProgressControlConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<LampProgressControlConfig> dataList { /* [XID] */ /* 0x00000001898D2290-0x00000001898D22B0 */ get; } // 0x00000001819B4D80-0x00000001819B4E30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898D9AB0-0x00000001898D9AD0 */ get; } // 0x00000001819B3B90-0x00000001819B3C30 

	// Methods
	// [XID] // 0x00000001898CABC0-0x00000001898CABE0
	public static void Register() {} // 0x00000001819B5160-0x00000001819B5200
	// [XID] // 0x00000001898E1750-0x00000001898E1770
	public static void LoadData() {} // 0x00000001819B4230-0x00000001819B4320
	// [XID] // 0x00000001898E9220-0x00000001898E9240
	private static void RegisterHotfixGenerated() {} // 0x00000001819B4060-0x00000001819B4230
	// [XID] // 0x00000001898F0A20-0x00000001898F0A40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001819B3C30-0x00000001819B4060
	// [IDTag] // 0x00000001898F8330-0x00000001898F8370
	// [XID] // 0x00000001898F8330-0x00000001898F8370
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001819B4460-0x00000001819B4560
	// [XID] // 0x0000000189902AA0-0x0000000189902AC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LampProgressControlConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001819B4E30-0x00000001819B5160
	// [XID] // 0x000000018990A060-0x000000018990A080
	private static bool ParseConfigFromLine(string line, out LampProgressControlConfig data) {
		data = default;
		return default;
	} // 0x00000001819B4320-0x00000001819B4460
	// [IDTag] // 0x0000000189911940-0x0000000189911980
	// [XID] // 0x0000000189911940-0x0000000189911980
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LampProgressControlConfig> configList) => default; // 0x00000001819B4560-0x00000001819B4800
	// [IDTag] // 0x000000018991C680-0x000000018991C6C0
	// [XID] // 0x000000018991C680-0x000000018991C6C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0308 */, bool useObjectPool = false /* Metadata: 0x00AF030C */) => default; // 0x00000001819B4B30-0x00000001819B4D80
	// [IDTag] // 0x0000000189926D00-0x0000000189926D40
	// [XID] // 0x0000000189926D00-0x0000000189926D40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF030D */, bool useObjectPool = false /* Metadata: 0x00AF0311 */) => default; // 0x00000001819B4800-0x00000001819B4B30
}

