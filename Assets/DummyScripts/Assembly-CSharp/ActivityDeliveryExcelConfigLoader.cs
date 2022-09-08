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

public static class ActivityDeliveryExcelConfigLoader // TypeDefIndex: 15055
{
	// Fields
	private static Dictionary<uint, ActivityDeliveryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityDeliveryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityDeliveryExcelConfig, ActivityDeliveryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityDeliveryExcelConfig>, Dictionary<uint, ActivityDeliveryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityDeliveryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189969DA0-0x0000000189969DC0 */ get; } // 0x0000000182B8F720-0x0000000182B8F7D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899793F0-0x0000000189979410 */ get; } // 0x0000000182B8E570-0x0000000182B8E610 

	// Methods
	// [XID] // 0x0000000189962A70-0x0000000189962A90
	public static void Register() {} // 0x0000000182B8FB00-0x0000000182B8FBA0
	// [XID] // 0x0000000189971B40-0x0000000189971B60
	public static ActivityDeliveryExcelConfig GetData(uint scheduleId) => default; // 0x0000000182B8E440-0x0000000182B8E570
	// [XID] // 0x0000000189980520-0x0000000189980540
	public static void LoadData() {} // 0x0000000182B8EBA0-0x0000000182B8EC90
	// [XID] // 0x0000000189987E70-0x0000000189987E90
	private static void RegisterHotfixGenerated() {} // 0x0000000182B8E9D0-0x0000000182B8EBA0
	// [XID] // 0x000000018998F860-0x000000018998F880
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B8E610-0x0000000182B8E9D0
	// [IDTag] // 0x0000000189997280-0x00000001899972C0
	// [XID] // 0x0000000189997280-0x00000001899972C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B8F080-0x0000000182B8F180
	// [XID] // 0x00000001899A1F30-0x00000001899A1F50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityDeliveryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B8F7D0-0x0000000182B8FB00
	// [XID] // 0x00000001899A9800-0x00000001899A9820
	private static bool ParseConfigFromLine(string line, out ActivityDeliveryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B8EC90-0x0000000182B8EDD0
	// [IDTag] // 0x00000001899B1210-0x00000001899B1250
	// [XID] // 0x00000001899B1210-0x00000001899B1250
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityDeliveryExcelConfig> configList) => default; // 0x0000000182B8EDD0-0x0000000182B8F080
	// [IDTag] // 0x00000001899BB670-0x00000001899BB6B0
	// [XID] // 0x00000001899BB670-0x00000001899BB6B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFF8C */, bool useObjectPool = false /* Metadata: 0x00AEFF90 */) => default; // 0x0000000182B8F180-0x0000000182B8F3D0
	// [IDTag] // 0x00000001899C6030-0x00000001899C6070
	// [XID] // 0x00000001899C6030-0x00000001899C6070
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF91 */, bool useObjectPool = false /* Metadata: 0x00AEFF95 */) => default; // 0x0000000182B8F3D0-0x0000000182B8F720
}

