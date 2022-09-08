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

public static class GlobalWatcherConfigLoader // TypeDefIndex: 16263
{
	// Fields
	private static Dictionary<uint, GlobalWatcherConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GlobalWatcherConfig>> customApplyHotfixAction; // 0x08
	public static Action<GlobalWatcherConfig, GlobalWatcherConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GlobalWatcherConfig>, Dictionary<uint, GlobalWatcherConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GlobalWatcherConfig> dataDict { /* [XID] */ /* 0x00000001899CA360-0x00000001899CA380 */ get; } // 0x000000018182FF60-0x0000000181830010 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899D9090-0x00000001899D90B0 */ get; } // 0x000000018182EDB0-0x000000018182EE50 

	// Methods
	// [XID] // 0x00000001899C2FC0-0x00000001899C2FE0
	public static void Register() {} // 0x0000000181830340-0x00000001818303E0
	// [XID] // 0x00000001899D1BE0-0x00000001899D1C00
	public static GlobalWatcherConfig GetData(uint id) => default; // 0x000000018182EC80-0x000000018182EDB0
	// [XID] // 0x00000001899E0820-0x00000001899E0840
	public static void LoadData() {} // 0x000000018182F3E0-0x000000018182F4D0
	// [XID] // 0x00000001899E82E0-0x00000001899E8300
	private static void RegisterHotfixGenerated() {} // 0x000000018182F210-0x000000018182F3E0
	// [XID] // 0x00000001899EF8B0-0x00000001899EF8D0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018182EE50-0x000000018182F210
	// [IDTag] // 0x00000001899F7070-0x00000001899F70B0
	// [XID] // 0x00000001899F7070-0x00000001899F70B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018182F8C0-0x000000018182F9C0
	// [XID] // 0x0000000189A01350-0x0000000189A01370
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GlobalWatcherConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181830010-0x0000000181830340
	// [XID] // 0x0000000189A08CB0-0x0000000189A08CD0
	private static bool ParseConfigFromLine(string line, out GlobalWatcherConfig data) {
		data = default;
		return default;
	} // 0x000000018182F4D0-0x000000018182F610
	// [IDTag] // 0x0000000189A10270-0x0000000189A102B0
	// [XID] // 0x0000000189A10270-0x0000000189A102B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GlobalWatcherConfig> configList) => default; // 0x000000018182F610-0x000000018182F8C0
	// [IDTag] // 0x0000000189A1A6B0-0x0000000189A1A6F0
	// [XID] // 0x0000000189A1A6B0-0x0000000189A1A6F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF35E3 */, bool useObjectPool = false /* Metadata: 0x00AF35E7 */) => default; // 0x000000018182F9C0-0x000000018182FC10
	// [IDTag] // 0x0000000189A24C50-0x0000000189A24C90
	// [XID] // 0x0000000189A24C50-0x0000000189A24C90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF35E8 */, bool useObjectPool = false /* Metadata: 0x00AF35EC */) => default; // 0x000000018182FC10-0x000000018182FF60
}

