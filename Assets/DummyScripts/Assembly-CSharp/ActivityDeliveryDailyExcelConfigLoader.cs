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

public static class ActivityDeliveryDailyExcelConfigLoader // TypeDefIndex: 15058
{
	// Fields
	private static Dictionary<uint, ActivityDeliveryDailyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityDeliveryDailyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityDeliveryDailyExcelConfig, ActivityDeliveryDailyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityDeliveryDailyExcelConfig>, Dictionary<uint, ActivityDeliveryDailyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityDeliveryDailyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B2E450-0x0000000189B2E470 */ get; } // 0x00000001815D5020-0x00000001815D50D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B3D140-0x0000000189B3D160 */ get; } // 0x00000001815D3E70-0x00000001815D3F10 

	// Methods
	// [XID] // 0x0000000189B272C0-0x0000000189B272E0
	public static void Register() {} // 0x00000001815D5400-0x00000001815D54A0
	// [XID] // 0x0000000189B35960-0x0000000189B35980
	public static ActivityDeliveryDailyExcelConfig GetData(uint dailyConfigId) => default; // 0x00000001815D3D40-0x00000001815D3E70
	// [XID] // 0x0000000189B44F50-0x0000000189B44F70
	public static void LoadData() {} // 0x00000001815D44A0-0x00000001815D4590
	// [XID] // 0x0000000189B4C720-0x0000000189B4C740
	private static void RegisterHotfixGenerated() {} // 0x00000001815D42D0-0x00000001815D44A0
	// [XID] // 0x0000000189B53DC0-0x0000000189B53DE0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001815D3F10-0x00000001815D42D0
	// [IDTag] // 0x0000000189B5B6D0-0x0000000189B5B710
	// [XID] // 0x0000000189B5B6D0-0x0000000189B5B710
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001815D4980-0x00000001815D4A80
	// [XID] // 0x0000000189B65D80-0x0000000189B65DA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityDeliveryDailyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001815D50D0-0x00000001815D5400
	// [XID] // 0x0000000189B6D320-0x0000000189B6D340
	private static bool ParseConfigFromLine(string line, out ActivityDeliveryDailyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001815D4590-0x00000001815D46D0
	// [IDTag] // 0x0000000189B74A30-0x0000000189B74A70
	// [XID] // 0x0000000189B74A30-0x0000000189B74A70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityDeliveryDailyExcelConfig> configList) => default; // 0x00000001815D46D0-0x00000001815D4980
	// [IDTag] // 0x0000000189B7EEC0-0x0000000189B7EF00
	// [XID] // 0x0000000189B7EEC0-0x0000000189B7EF00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFFA0 */, bool useObjectPool = false /* Metadata: 0x00AEFFA4 */) => default; // 0x00000001815D4DD0-0x00000001815D5020
	// [IDTag] // 0x0000000189B89890-0x0000000189B898D0
	// [XID] // 0x0000000189B89890-0x0000000189B898D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFA5 */, bool useObjectPool = false /* Metadata: 0x00AEFFA9 */) => default; // 0x00000001815D4A80-0x00000001815D4DD0
}

