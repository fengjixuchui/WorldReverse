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

public static class GadgetTitleExcelConfigLoader // TypeDefIndex: 15650
{
	// Fields
	private static Dictionary<uint, GadgetTitleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GadgetTitleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GadgetTitleExcelConfig, GadgetTitleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GadgetTitleExcelConfig>, Dictionary<uint, GadgetTitleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GadgetTitleExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B8DAF0-0x0000000189B8DB10 */ get; } // 0x00000001812F57A0-0x00000001812F5850 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B9C740-0x0000000189B9C760 */ get; } // 0x00000001812F45F0-0x00000001812F4690 

	// Methods
	// [XID] // 0x0000000189B86960-0x0000000189B86980
	public static void Register() {} // 0x00000001812F5B80-0x00000001812F5C20
	// [XID] // 0x0000000189B94FF0-0x0000000189B95010
	public static GadgetTitleExcelConfig GetData(uint gadgetId) => default; // 0x00000001812F44C0-0x00000001812F45F0
	// [XID] // 0x0000000189BA3DD0-0x0000000189BA3DF0
	public static void LoadData() {} // 0x00000001812F4C20-0x00000001812F4D10
	// [XID] // 0x0000000189BAB380-0x0000000189BAB3A0
	private static void RegisterHotfixGenerated() {} // 0x00000001812F4A50-0x00000001812F4C20
	// [XID] // 0x0000000189BB2950-0x0000000189BB2970
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812F4690-0x00000001812F4A50
	// [IDTag] // 0x0000000189BB9D80-0x0000000189BB9DC0
	// [XID] // 0x0000000189BB9D80-0x0000000189BB9DC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001812F5100-0x00000001812F5200
	// [XID] // 0x0000000189BC4A80-0x0000000189BC4AA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GadgetTitleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001812F5850-0x00000001812F5B80
	// [XID] // 0x0000000189BCC540-0x0000000189BCC560
	private static bool ParseConfigFromLine(string line, out GadgetTitleExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001812F4D10-0x00000001812F4E50
	// [IDTag] // 0x0000000189BD3BD0-0x0000000189BD3C10
	// [XID] // 0x0000000189BD3BD0-0x0000000189BD3C10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GadgetTitleExcelConfig> configList) => default; // 0x00000001812F4E50-0x00000001812F5100
	// [IDTag] // 0x0000000189BDE4E0-0x0000000189BDE520
	// [XID] // 0x0000000189BDE4E0-0x0000000189BDE520
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF21B1 */, bool useObjectPool = false /* Metadata: 0x00AF21B5 */) => default; // 0x00000001812F5550-0x00000001812F57A0
	// [IDTag] // 0x00000001895EDE90-0x00000001895EDED0
	// [XID] // 0x00000001895EDE90-0x00000001895EDED0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF21B6 */, bool useObjectPool = false /* Metadata: 0x00AF21BA */) => default; // 0x00000001812F5200-0x00000001812F5550
}

