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

public static class MusicGameBasicConfigLoader // TypeDefIndex: 14823
{
	// Fields
	private static Dictionary<uint, MusicGameBasicConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MusicGameBasicConfig>> customApplyHotfixAction; // 0x08
	public static Action<MusicGameBasicConfig, MusicGameBasicConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MusicGameBasicConfig>, Dictionary<uint, MusicGameBasicConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MusicGameBasicConfig> dataDict { /* [XID] */ /* 0x000000018983E380-0x000000018983E3A0 */ get; } // 0x00000001839037D0-0x0000000183903880 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018984D080-0x000000018984D0A0 */ get; } // 0x0000000183902620-0x00000001839026C0 

	// Methods
	// [XID] // 0x000000018982F640-0x000000018982F660
	public static MusicGameBasicConfig GetMusicBasicConfig(uint musicID, uint level) => default; // 0x0000000183903C50-0x0000000183903EA0
	// [XID] // 0x0000000189836F50-0x0000000189836F70
	public static void Register() {} // 0x0000000183903BB0-0x0000000183903C50
	// [XID] // 0x0000000189845B50-0x0000000189845B70
	public static MusicGameBasicConfig GetData(uint id) => default; // 0x00000001839024F0-0x0000000183902620
	// [XID] // 0x00000001898541C0-0x00000001898541E0
	public static void LoadData() {} // 0x0000000183902C50-0x0000000183902D40
	// [XID] // 0x000000018985BB50-0x000000018985BB70
	private static void RegisterHotfixGenerated() {} // 0x0000000183902A80-0x0000000183902C50
	// [XID] // 0x0000000189863150-0x0000000189863170
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001839026C0-0x0000000183902A80
	// [IDTag] // 0x000000018986A6A0-0x000000018986A6E0
	// [XID] // 0x000000018986A6A0-0x000000018986A6E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183903130-0x0000000183903230
	// [XID] // 0x0000000189874740-0x0000000189874760
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MusicGameBasicConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183903880-0x0000000183903BB0
	// [XID] // 0x000000018987C300-0x000000018987C320
	private static bool ParseConfigFromLine(string line, out MusicGameBasicConfig data) {
		data = default;
		return default;
	} // 0x0000000183902D40-0x0000000183902E80
	// [IDTag] // 0x0000000189883410-0x0000000189883450
	// [XID] // 0x0000000189883410-0x0000000189883450
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MusicGameBasicConfig> configList) => default; // 0x0000000183902E80-0x0000000183903130
	// [IDTag] // 0x000000018988D920-0x000000018988D960
	// [XID] // 0x000000018988D920-0x000000018988D960
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6A2 */, bool useObjectPool = false /* Metadata: 0x00AEF6A6 */) => default; // 0x0000000183903230-0x0000000183903480
	// [IDTag] // 0x0000000189897E60-0x0000000189897EA0
	// [XID] // 0x0000000189897E60-0x0000000189897EA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6A7 */, bool useObjectPool = false /* Metadata: 0x00AEF6AB */) => default; // 0x0000000183903480-0x00000001839037D0
}

