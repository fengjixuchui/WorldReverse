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

public static class PSActivitiesSubTaskConfigLoader // TypeDefIndex: 15962
{
	// Fields
	private static Dictionary<uint, PSActivitiesSubTaskConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PSActivitiesSubTaskConfig>> customApplyHotfixAction; // 0x08
	public static Action<PSActivitiesSubTaskConfig, PSActivitiesSubTaskConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PSActivitiesSubTaskConfig>, Dictionary<uint, PSActivitiesSubTaskConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PSActivitiesSubTaskConfig> dataDict { /* [XID] */ /* 0x0000000189B2E2D0-0x0000000189B2E2F0 */ get; } // 0x00000001821B7F00-0x00000001821B7FB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B3CF60-0x0000000189B3CF80 */ get; } // 0x00000001821B6D50-0x00000001821B6DF0 

	// Methods
	// [XID] // 0x0000000189B27120-0x0000000189B27140
	public static void Register() {} // 0x00000001821B82E0-0x00000001821B8380
	// [XID] // 0x0000000189B35720-0x0000000189B35740
	public static PSActivitiesSubTaskConfig GetData(uint ID) => default; // 0x00000001821B6C20-0x00000001821B6D50
	// [XID] // 0x0000000189B44D50-0x0000000189B44D70
	public static void LoadData() {} // 0x00000001821B7380-0x00000001821B7470
	// [XID] // 0x0000000189B4C5C0-0x0000000189B4C5E0
	private static void RegisterHotfixGenerated() {} // 0x00000001821B71B0-0x00000001821B7380
	// [XID] // 0x0000000189B53C00-0x0000000189B53C20
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821B6DF0-0x00000001821B71B0
	// [IDTag] // 0x0000000189B5B490-0x0000000189B5B4D0
	// [XID] // 0x0000000189B5B490-0x0000000189B5B4D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821B75B0-0x00000001821B76B0
	// [XID] // 0x0000000189B65BE0-0x0000000189B65C00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PSActivitiesSubTaskConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001821B7FB0-0x00000001821B82E0
	// [XID] // 0x0000000189B6D1E0-0x0000000189B6D200
	private static bool ParseConfigFromLine(string line, out PSActivitiesSubTaskConfig data) {
		data = default;
		return default;
	} // 0x00000001821B7470-0x00000001821B75B0
	// [IDTag] // 0x0000000189B74830-0x0000000189B74870
	// [XID] // 0x0000000189B74830-0x0000000189B74870
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PSActivitiesSubTaskConfig> configList) => default; // 0x00000001821B76B0-0x00000001821B7960
	// [IDTag] // 0x0000000189B7ED40-0x0000000189B7ED80
	// [XID] // 0x0000000189B7ED40-0x0000000189B7ED80
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C5C */, bool useObjectPool = false /* Metadata: 0x00AF2C60 */) => default; // 0x00000001821B7960-0x00000001821B7BB0
	// [IDTag] // 0x0000000189B896D0-0x0000000189B89710
	// [XID] // 0x0000000189B896D0-0x0000000189B89710
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C61 */, bool useObjectPool = false /* Metadata: 0x00AF2C65 */) => default; // 0x00000001821B7BB0-0x00000001821B7F00
}

