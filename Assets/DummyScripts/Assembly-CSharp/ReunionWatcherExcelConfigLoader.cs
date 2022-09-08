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

public static class ReunionWatcherExcelConfigLoader // TypeDefIndex: 16061
{
	// Fields
	private static Dictionary<uint, ReunionWatcherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReunionWatcherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReunionWatcherExcelConfig, ReunionWatcherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReunionWatcherExcelConfig>, Dictionary<uint, ReunionWatcherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReunionWatcherExcelConfig> dataDict { /* [XID] */ /* 0x00000001897271E0-0x0000000189727200 */ get; } // 0x0000000182509420-0x00000001825094D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189735F00-0x0000000189735F20 */ get; } // 0x0000000182508270-0x0000000182508310 

	// Methods
	// [XID] // 0x000000018971FAF0-0x000000018971FB10
	public static void Register() {} // 0x0000000182509800-0x00000001825098A0
	// [XID] // 0x000000018972E770-0x000000018972E790
	public static ReunionWatcherExcelConfig GetData(uint id) => default; // 0x0000000182508140-0x0000000182508270
	// [XID] // 0x000000018973DB50-0x000000018973DB70
	public static void LoadData() {} // 0x00000001825088A0-0x0000000182508990
	// [XID] // 0x0000000189744ED0-0x0000000189744EF0
	private static void RegisterHotfixGenerated() {} // 0x00000001825086D0-0x00000001825088A0
	// [XID] // 0x000000018974CA80-0x000000018974CAA0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182508310-0x00000001825086D0
	// [IDTag] // 0x0000000189753DA0-0x0000000189753DE0
	// [XID] // 0x0000000189753DA0-0x0000000189753DE0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182508D80-0x0000000182508E80
	// [XID] // 0x000000018975E490-0x000000018975E4B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReunionWatcherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001825094D0-0x0000000182509800
	// [XID] // 0x0000000189765B70-0x0000000189765B90
	private static bool ParseConfigFromLine(string line, out ReunionWatcherExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182508990-0x0000000182508AD0
	// [IDTag] // 0x000000018976D2C0-0x000000018976D300
	// [XID] // 0x000000018976D2C0-0x000000018976D300
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReunionWatcherExcelConfig> configList) => default; // 0x0000000182508AD0-0x0000000182508D80
	// [IDTag] // 0x00000001897778B0-0x00000001897778F0
	// [XID] // 0x00000001897778B0-0x00000001897778F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F39 */, bool useObjectPool = false /* Metadata: 0x00AF2F3D */) => default; // 0x00000001825091D0-0x0000000182509420
	// [IDTag] // 0x0000000189782440-0x0000000189782480
	// [XID] // 0x0000000189782440-0x0000000189782480
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F3E */, bool useObjectPool = false /* Metadata: 0x00AF2F42 */) => default; // 0x0000000182508E80-0x00000001825091D0
}

