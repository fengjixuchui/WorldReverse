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

public static class ReminderExcelConfigLoader // TypeDefIndex: 16034
{
	// Fields
	private static Dictionary<uint, ReminderExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReminderExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReminderExcelConfig, ReminderExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReminderExcelConfig>, Dictionary<uint, ReminderExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReminderExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BD3A50-0x0000000189BD3A70 */ get; } // 0x0000000182B6E160-0x0000000182B6E210 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895E7CF0-0x00000001895E7D10 */ get; } // 0x0000000182B6CFB0-0x0000000182B6D050 

	// Methods
	// [XID] // 0x0000000189BCC3A0-0x0000000189BCC3C0
	public static void Register() {} // 0x0000000182B6E540-0x0000000182B6E5E0
	// [XID] // 0x0000000189BDB380-0x0000000189BDB3A0
	public static ReminderExcelConfig GetData(uint id) => default; // 0x0000000182B6CE80-0x0000000182B6CFB0
	// [XID] // 0x00000001895EF620-0x00000001895EF640
	public static void LoadData() {} // 0x0000000182B6D5E0-0x0000000182B6D6D0
	// [XID] // 0x00000001895F7020-0x00000001895F7040
	private static void RegisterHotfixGenerated() {} // 0x0000000182B6D410-0x0000000182B6D5E0
	// [XID] // 0x00000001895FE3C0-0x00000001895FE3E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B6D050-0x0000000182B6D410
	// [IDTag] // 0x0000000189605D70-0x0000000189605DB0
	// [XID] // 0x0000000189605D70-0x0000000189605DB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B6D810-0x0000000182B6D910
	// [XID] // 0x0000000189610670-0x0000000189610690
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReminderExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B6E210-0x0000000182B6E540
	// [XID] // 0x0000000189617970-0x0000000189617990
	private static bool ParseConfigFromLine(string line, out ReminderExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B6D6D0-0x0000000182B6D810
	// [IDTag] // 0x000000018961F580-0x000000018961F5C0
	// [XID] // 0x000000018961F580-0x000000018961F5C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReminderExcelConfig> configList) => default; // 0x0000000182B6D910-0x0000000182B6DBC0
	// [IDTag] // 0x0000000189629B30-0x0000000189629B70
	// [XID] // 0x0000000189629B30-0x0000000189629B70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2E73 */, bool useObjectPool = false /* Metadata: 0x00AF2E77 */) => default; // 0x0000000182B6DF10-0x0000000182B6E160
	// [IDTag] // 0x00000001896345B0-0x00000001896345F0
	// [XID] // 0x00000001896345B0-0x00000001896345F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E78 */, bool useObjectPool = false /* Metadata: 0x00AF2E7C */) => default; // 0x0000000182B6DBC0-0x0000000182B6DF10
}

