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

public static class BlessingScanExcelConfigLoader // TypeDefIndex: 14806
{
	// Fields
	private static Dictionary<uint, List<BlessingScanExcelConfig>> _configListDict; // 0x00
	private static Dictionary<uint, BlessingScanExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<BlessingScanExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<BlessingScanExcelConfig, BlessingScanExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<BlessingScanExcelConfig>, Dictionary<uint, BlessingScanExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, BlessingScanExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B405A0-0x0000000189B405C0 */ get; } // 0x00000001834E9850-0x00000001834E9900 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B4F6D0-0x0000000189B4F6F0 */ get; } // 0x00000001834E86A0-0x00000001834E8740 

	// Methods
	// [XID] // 0x0000000189B2A0E0-0x0000000189B2A100
	public static void LoadConfigList() {} // 0x00000001834E8230-0x00000001834E8560
	// [XID] // 0x0000000189B317F0-0x0000000189B31810
	public static List<BlessingScanExcelConfig> GetConfigList(uint typeId) => default; // 0x00000001834E9900-0x00000001834E9A00
	// [XID] // 0x0000000189B38BB0-0x0000000189B38BD0
	public static void Register() {} // 0x00000001834E9D30-0x00000001834E9DD0
	// [XID] // 0x0000000189B47F40-0x0000000189B47F60
	public static BlessingScanExcelConfig GetData(uint id) => default; // 0x00000001834E8560-0x00000001834E86A0
	// [XID] // 0x0000000189B56F70-0x0000000189B56F90
	public static void LoadData() {} // 0x00000001834E8CD0-0x00000001834E8DC0
	// [XID] // 0x0000000189B5E8E0-0x0000000189B5E900
	private static void RegisterHotfixGenerated() {} // 0x00000001834E8B00-0x00000001834E8CD0
	// [XID] // 0x0000000189B65F20-0x0000000189B65F40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001834E8740-0x00000001834E8B00
	// [IDTag] // 0x0000000189B6D4E0-0x0000000189B6D520
	// [XID] // 0x0000000189B6D4E0-0x0000000189B6D520
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001834E8F00-0x00000001834E9000
	// [XID] // 0x0000000189B779F0-0x0000000189B77A10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlessingScanExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001834E9A00-0x00000001834E9D30
	// [XID] // 0x0000000189B7EFC0-0x0000000189B7EFE0
	private static bool ParseConfigFromLine(string line, out BlessingScanExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001834E8DC0-0x00000001834E8F00
	// [IDTag] // 0x0000000189B86BE0-0x0000000189B86C20
	// [XID] // 0x0000000189B86BE0-0x0000000189B86C20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlessingScanExcelConfig> configList) => default; // 0x00000001834E9000-0x00000001834E92B0
	// [IDTag] // 0x0000000189B90FD0-0x0000000189B91010
	// [XID] // 0x0000000189B90FD0-0x0000000189B91010
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF5F8 */, bool useObjectPool = false /* Metadata: 0x00AEF5FC */) => default; // 0x00000001834E9600-0x00000001834E9850
	// [IDTag] // 0x0000000189B9B2C0-0x0000000189B9B300
	// [XID] // 0x0000000189B9B2C0-0x0000000189B9B300
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5FD */, bool useObjectPool = false /* Metadata: 0x00AEF601 */) => default; // 0x00000001834E92B0-0x00000001834E9600
}

