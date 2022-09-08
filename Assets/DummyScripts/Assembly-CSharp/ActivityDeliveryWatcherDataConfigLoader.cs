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

public static class ActivityDeliveryWatcherDataConfigLoader // TypeDefIndex: 15060
{
	// Fields
	private static Dictionary<uint, ActivityDeliveryWatcherDataConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityDeliveryWatcherDataConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityDeliveryWatcherDataConfig, ActivityDeliveryWatcherDataConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityDeliveryWatcherDataConfig>, Dictionary<uint, ActivityDeliveryWatcherDataConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityDeliveryWatcherDataConfig> dataDict { /* [XID] */ /* 0x00000001895F2570-0x00000001895F2590 */ get; } // 0x00000001838912D0-0x0000000183891380 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189601720-0x0000000189601740 */ get; } // 0x0000000183890120-0x00000001838901C0 

	// Methods
	// [XID] // 0x00000001895EB0F0-0x00000001895EB110
	public static void Register() {} // 0x00000001838916B0-0x0000000183891750
	// [XID] // 0x00000001895F9FC0-0x00000001895F9FE0
	public static ActivityDeliveryWatcherDataConfig GetData(uint id) => default; // 0x000000018388FFF0-0x0000000183890120
	// [XID] // 0x0000000189608FD0-0x0000000189608FF0
	public static void LoadData() {} // 0x0000000183890750-0x0000000183890840
	// [XID] // 0x0000000189610810-0x0000000189610830
	private static void RegisterHotfixGenerated() {} // 0x0000000183890580-0x0000000183890750
	// [XID] // 0x0000000189617AD0-0x0000000189617AF0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001838901C0-0x0000000183890580
	// [IDTag] // 0x000000018961F7A0-0x000000018961F7E0
	// [XID] // 0x000000018961F7A0-0x000000018961F7E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183890980-0x0000000183890A80
	// [XID] // 0x0000000189629D90-0x0000000189629DB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityDeliveryWatcherDataConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183891380-0x00000001838916B0
	// [XID] // 0x0000000189631560-0x0000000189631580
	private static bool ParseConfigFromLine(string line, out ActivityDeliveryWatcherDataConfig data) {
		data = default;
		return default;
	} // 0x0000000183890840-0x0000000183890980
	// [IDTag] // 0x0000000189638FD0-0x0000000189639010
	// [XID] // 0x0000000189638FD0-0x0000000189639010
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityDeliveryWatcherDataConfig> configList) => default; // 0x0000000183890A80-0x0000000183890D30
	// [IDTag] // 0x0000000189643640-0x0000000189643680
	// [XID] // 0x0000000189643640-0x0000000189643680
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFFAF */, bool useObjectPool = false /* Metadata: 0x00AEFFB3 */) => default; // 0x0000000183890D30-0x0000000183890F80
	// [IDTag] // 0x000000018964DC60-0x000000018964DCA0
	// [XID] // 0x000000018964DC60-0x000000018964DCA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFB4 */, bool useObjectPool = false /* Metadata: 0x00AEFFB8 */) => default; // 0x0000000183890F80-0x00000001838912D0
}

