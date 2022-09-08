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

public static class NewActivityWatcherConfigLoader // TypeDefIndex: 15893
{
	// Fields
	private static Dictionary<uint, NewActivityWatcherConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityWatcherConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityWatcherConfig, NewActivityWatcherConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityWatcherConfig>, Dictionary<uint, NewActivityWatcherConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityWatcherConfig> dataDict { /* [XID] */ /* 0x00000001899971A0-0x00000001899971C0 */ get; } // 0x0000000182C6CE90-0x0000000182C6CF40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A66D0-0x00000001899A66F0 */ get; } // 0x0000000182C6BCE0-0x0000000182C6BD80 

	// Methods
	// [XID] // 0x000000018998F7C0-0x000000018998F7E0
	public static void Register() {} // 0x0000000182C6D270-0x0000000182C6D310
	// [XID] // 0x000000018999EDF0-0x000000018999EE10
	public static NewActivityWatcherConfig GetData(uint id) => default; // 0x0000000182C6BBB0-0x0000000182C6BCE0
	// [XID] // 0x00000001899ADE80-0x00000001899ADEA0
	public static void LoadData() {} // 0x0000000182C6C310-0x0000000182C6C400
	// [XID] // 0x00000001899B56A0-0x00000001899B56C0
	private static void RegisterHotfixGenerated() {} // 0x0000000182C6C140-0x0000000182C6C310
	// [XID] // 0x00000001899BCDF0-0x00000001899BCE10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182C6BD80-0x0000000182C6C140
	// [IDTag] // 0x00000001899C4740-0x00000001899C4780
	// [XID] // 0x00000001899C4740-0x00000001899C4780
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182C6C7F0-0x0000000182C6C8F0
	// [XID] // 0x00000001899CEC60-0x00000001899CEC80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityWatcherConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182C6CF40-0x0000000182C6D270
	// [XID] // 0x00000001899D63D0-0x00000001899D63F0
	private static bool ParseConfigFromLine(string line, out NewActivityWatcherConfig data) {
		data = default;
		return default;
	} // 0x0000000182C6C400-0x0000000182C6C540
	// [IDTag] // 0x00000001899DD860-0x00000001899DD8A0
	// [XID] // 0x00000001899DD860-0x00000001899DD8A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityWatcherConfig> configList) => default; // 0x0000000182C6C540-0x0000000182C6C7F0
	// [IDTag] // 0x00000001899E83E0-0x00000001899E8420
	// [XID] // 0x00000001899E83E0-0x00000001899E8420
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2A6E */, bool useObjectPool = false /* Metadata: 0x00AF2A72 */) => default; // 0x0000000182C6C8F0-0x0000000182C6CB40
	// [IDTag] // 0x00000001899F2AE0-0x00000001899F2B20
	// [XID] // 0x00000001899F2AE0-0x00000001899F2B20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A73 */, bool useObjectPool = false /* Metadata: 0x00AF2A77 */) => default; // 0x0000000182C6CB40-0x0000000182C6CE90
}

