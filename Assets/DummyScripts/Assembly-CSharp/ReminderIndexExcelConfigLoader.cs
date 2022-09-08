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

public static class ReminderIndexExcelConfigLoader // TypeDefIndex: 16033
{
	// Fields
	private static Dictionary<uint, ReminderIndexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReminderIndexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReminderIndexExcelConfig, ReminderIndexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReminderIndexExcelConfig>, Dictionary<uint, ReminderIndexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReminderIndexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B585B0-0x0000000189B585D0 */ get; } // 0x00000001821EE6E0-0x00000001821EE790 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B67660-0x0000000189B67680 */ get; } // 0x00000001821ED530-0x00000001821ED5D0 

	// Methods
	// [XID] // 0x0000000189B50DA0-0x0000000189B50DC0
	public static void Register() {} // 0x00000001821EEAC0-0x00000001821EEB60
	// [XID] // 0x0000000189B5FFA0-0x0000000189B5FFC0
	public static ReminderIndexExcelConfig GetData(uint id) => default; // 0x00000001821ED400-0x00000001821ED530
	// [XID] // 0x0000000189B6E8A0-0x0000000189B6E8C0
	public static void LoadData() {} // 0x00000001821EDB60-0x00000001821EDC50
	// [XID] // 0x0000000189B76150-0x0000000189B76170
	private static void RegisterHotfixGenerated() {} // 0x00000001821ED990-0x00000001821EDB60
	// [XID] // 0x0000000189B7D640-0x0000000189B7D660
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821ED5D0-0x00000001821ED990
	// [IDTag] // 0x0000000189B85390-0x0000000189B853D0
	// [XID] // 0x0000000189B85390-0x0000000189B853D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821EE040-0x00000001821EE140
	// [XID] // 0x0000000189B8F210-0x0000000189B8F230
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReminderIndexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001821EE790-0x00000001821EEAC0
	// [XID] // 0x0000000189B966E0-0x0000000189B96700
	private static bool ParseConfigFromLine(string line, out ReminderIndexExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821EDC50-0x00000001821EDD90
	// [IDTag] // 0x0000000189B9DBC0-0x0000000189B9DC00
	// [XID] // 0x0000000189B9DBC0-0x0000000189B9DC00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReminderIndexExcelConfig> configList) => default; // 0x00000001821EDD90-0x00000001821EE040
	// [IDTag] // 0x0000000189BA82F0-0x0000000189BA8330
	// [XID] // 0x0000000189BA82F0-0x0000000189BA8330
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E69 */, bool useObjectPool = false /* Metadata: 0x00AF2E6D */) => default; // 0x00000001821EE490-0x00000001821EE6E0
	// [IDTag] // 0x0000000189BB2890-0x0000000189BB28D0
	// [XID] // 0x0000000189BB2890-0x0000000189BB28D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E6E */, bool useObjectPool = false /* Metadata: 0x00AF2E72 */) => default; // 0x00000001821EE140-0x00000001821EE490
}

