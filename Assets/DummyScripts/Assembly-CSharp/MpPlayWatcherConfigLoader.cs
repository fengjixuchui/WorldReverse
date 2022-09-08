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

public static class MpPlayWatcherConfigLoader // TypeDefIndex: 15868
{
	// Fields
	private static Dictionary<uint, MpPlayWatcherConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayWatcherConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayWatcherConfig, MpPlayWatcherConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayWatcherConfig>, Dictionary<uint, MpPlayWatcherConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayWatcherConfig> dataDict { /* [XID] */ /* 0x0000000189951F50-0x0000000189951F70 */ get; } // 0x0000000182D46940-0x0000000182D469F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189960D80-0x0000000189960DA0 */ get; } // 0x0000000182D45790-0x0000000182D45830 

	// Methods
	// [XID] // 0x000000018994A480-0x000000018994A4A0
	public static void Register() {} // 0x0000000182D46D20-0x0000000182D46DC0
	// [XID] // 0x00000001899594D0-0x00000001899594F0
	public static MpPlayWatcherConfig GetData(uint id) => default; // 0x0000000182D45660-0x0000000182D45790
	// [XID] // 0x00000001899684E0-0x0000000189968500
	public static void LoadData() {} // 0x0000000182D45DC0-0x0000000182D45EB0
	// [XID] // 0x000000018996F9E0-0x000000018996FA00
	private static void RegisterHotfixGenerated() {} // 0x0000000182D45BF0-0x0000000182D45DC0
	// [XID] // 0x00000001899777C0-0x00000001899777E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D45830-0x0000000182D45BF0
	// [IDTag] // 0x000000018997EA00-0x000000018997EA40
	// [XID] // 0x000000018997EA00-0x000000018997EA40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D462A0-0x0000000182D463A0
	// [XID] // 0x0000000189989940-0x0000000189989960
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayWatcherConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D469F0-0x0000000182D46D20
	// [XID] // 0x00000001899911B0-0x00000001899911D0
	private static bool ParseConfigFromLine(string line, out MpPlayWatcherConfig data) {
		data = default;
		return default;
	} // 0x0000000182D45EB0-0x0000000182D45FF0
	// [IDTag] // 0x0000000189998C10-0x0000000189998C50
	// [XID] // 0x0000000189998C10-0x0000000189998C50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayWatcherConfig> configList) => default; // 0x0000000182D45FF0-0x0000000182D462A0
	// [IDTag] // 0x00000001899A3450-0x00000001899A3490
	// [XID] // 0x00000001899A3450-0x00000001899A3490
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF28E2 */, bool useObjectPool = false /* Metadata: 0x00AF28E6 */) => default; // 0x0000000182D463A0-0x0000000182D465F0
	// [IDTag] // 0x00000001899ADEA0-0x00000001899ADEE0
	// [XID] // 0x00000001899ADEA0-0x00000001899ADEE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28E7 */, bool useObjectPool = false /* Metadata: 0x00AF28EB */) => default; // 0x0000000182D465F0-0x0000000182D46940
}

