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

public static class ChannellerSlabLoopDungeonExcelConfigLoader // TypeDefIndex: 15053
{
	// Fields
	private static Dictionary<uint, ChannellerSlabLoopDungeonExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabLoopDungeonExcelConfig, ChannellerSlabLoopDungeonExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabLoopDungeonExcelConfig>, Dictionary<uint, ChannellerSlabLoopDungeonExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabLoopDungeonExcelConfig> dataDict { /* [XID] */ /* 0x0000000189868D70-0x0000000189868D90 */ get; } // 0x00000001850D7700-0x00000001850D77B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189877790-0x00000001898777B0 */ get; } // 0x00000001850D6550-0x00000001850D65F0 

	// Methods
	// [XID] // 0x0000000189861550-0x0000000189861570
	public static void Register() {} // 0x00000001850D7AE0-0x00000001850D7B80
	// [XID] // 0x0000000189870160-0x0000000189870180
	public static ChannellerSlabLoopDungeonExcelConfig GetData(uint id) => default; // 0x00000001850D6420-0x00000001850D6550
	// [XID] // 0x000000018987F020-0x000000018987F040
	public static void LoadData() {} // 0x00000001850D6B80-0x00000001850D6C70
	// [XID] // 0x0000000189886600-0x0000000189886620
	private static void RegisterHotfixGenerated() {} // 0x00000001850D69B0-0x00000001850D6B80
	// [XID] // 0x000000018988D7E0-0x000000018988D800
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001850D65F0-0x00000001850D69B0
	// [IDTag] // 0x0000000189894F30-0x0000000189894F70
	// [XID] // 0x0000000189894F30-0x0000000189894F70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001850D6DB0-0x00000001850D6EB0
	// [XID] // 0x000000018989F180-0x000000018989F1A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabLoopDungeonExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001850D77B0-0x00000001850D7AE0
	// [XID] // 0x00000001898A6D20-0x00000001898A6D40
	private static bool ParseConfigFromLine(string line, out ChannellerSlabLoopDungeonExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001850D6C70-0x00000001850D6DB0
	// [IDTag] // 0x00000001898AE510-0x00000001898AE550
	// [XID] // 0x00000001898AE510-0x00000001898AE550
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabLoopDungeonExcelConfig> configList) => default; // 0x00000001850D6EB0-0x00000001850D7160
	// [IDTag] // 0x00000001898B8C20-0x00000001898B8C60
	// [XID] // 0x00000001898B8C20-0x00000001898B8C60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFF7D */, bool useObjectPool = false /* Metadata: 0x00AEFF81 */) => default; // 0x00000001850D7160-0x00000001850D73B0
	// [IDTag] // 0x00000001898C31E0-0x00000001898C3220
	// [XID] // 0x00000001898C31E0-0x00000001898C3220
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF82 */, bool useObjectPool = false /* Metadata: 0x00AEFF86 */) => default; // 0x00000001850D73B0-0x00000001850D7700
}

