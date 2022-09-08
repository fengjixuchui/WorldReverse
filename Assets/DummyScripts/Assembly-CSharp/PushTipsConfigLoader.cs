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

public static class PushTipsConfigLoader // TypeDefIndex: 16265
{
	// Fields
	private static Dictionary<uint, PushTipsConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PushTipsConfig>> customApplyHotfixAction; // 0x08
	public static Action<PushTipsConfig, PushTipsConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PushTipsConfig>, Dictionary<uint, PushTipsConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PushTipsConfig> dataDict { /* [XID] */ /* 0x0000000189B61350-0x0000000189B61370 */ get; } // 0x0000000182EA0560-0x0000000182EA0610 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B70220-0x0000000189B70240 */ get; } // 0x0000000182E9F3B0-0x0000000182E9F450 

	// Methods
	// [XID] // 0x0000000189B59C00-0x0000000189B59C20
	public static void Register() {} // 0x0000000182EA0940-0x0000000182EA09E0
	// [XID] // 0x0000000189B68CE0-0x0000000189B68D00
	public static PushTipsConfig GetData(uint pushTipsId) => default; // 0x0000000182E9F280-0x0000000182E9F3B0
	// [XID] // 0x0000000189B77690-0x0000000189B776B0
	public static void LoadData() {} // 0x0000000182E9F9E0-0x0000000182E9FAD0
	// [XID] // 0x0000000189B7EC40-0x0000000189B7EC60
	private static void RegisterHotfixGenerated() {} // 0x0000000182E9F810-0x0000000182E9F9E0
	// [XID] // 0x0000000189B86800-0x0000000189B86820
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E9F450-0x0000000182E9F810
	// [IDTag] // 0x0000000189B8D9D0-0x0000000189B8DA10
	// [XID] // 0x0000000189B8D9D0-0x0000000189B8DA10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E9FC10-0x0000000182E9FD10
	// [XID] // 0x0000000189B97F20-0x0000000189B97F40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PushTipsConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182EA0610-0x0000000182EA0940
	// [XID] // 0x0000000189B9F350-0x0000000189B9F370
	private static bool ParseConfigFromLine(string line, out PushTipsConfig data) {
		data = default;
		return default;
	} // 0x0000000182E9FAD0-0x0000000182E9FC10
	// [IDTag] // 0x0000000189BA6BC0-0x0000000189BA6C00
	// [XID] // 0x0000000189BA6BC0-0x0000000189BA6C00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PushTipsConfig> configList) => default; // 0x0000000182E9FD10-0x0000000182E9FFC0
	// [IDTag] // 0x0000000189BB14B0-0x0000000189BB14F0
	// [XID] // 0x0000000189BB14B0-0x0000000189BB14F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF35F2 */, bool useObjectPool = false /* Metadata: 0x00AF35F6 */) => default; // 0x0000000182EA0310-0x0000000182EA0560
	// [IDTag] // 0x0000000189BBB610-0x0000000189BBB650
	// [XID] // 0x0000000189BBB610-0x0000000189BBB650
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF35F7 */, bool useObjectPool = false /* Metadata: 0x00AF35FB */) => default; // 0x0000000182E9FFC0-0x0000000182EA0310
}

