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

public static class HuntingRefreshExcelConfigLoader // TypeDefIndex: 15745
{
	// Fields
	private static Dictionary<uint, HuntingRefreshExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingRefreshExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingRefreshExcelConfig, HuntingRefreshExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingRefreshExcelConfig>, Dictionary<uint, HuntingRefreshExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingRefreshExcelConfig> dataDict { /* [XID] */ /* 0x0000000189807210-0x0000000189807230 */ get; } // 0x000000018348D9F0-0x000000018348DAA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189815FD0-0x0000000189815FF0 */ get; } // 0x000000018348C840-0x000000018348C8E0 

	// Methods
	// [XID] // 0x00000001897FFC10-0x00000001897FFC30
	public static void Register() {} // 0x000000018348DDD0-0x000000018348DE70
	// [XID] // 0x000000018980E850-0x000000018980E870
	public static HuntingRefreshExcelConfig GetData(uint id) => default; // 0x000000018348C710-0x000000018348C840
	// [XID] // 0x000000018981D970-0x000000018981D990
	public static void LoadData() {} // 0x000000018348CE70-0x000000018348CF60
	// [XID] // 0x0000000189824E20-0x0000000189824E40
	private static void RegisterHotfixGenerated() {} // 0x000000018348CCA0-0x000000018348CE70
	// [XID] // 0x000000018982C830-0x000000018982C850
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018348C8E0-0x000000018348CCA0
	// [IDTag] // 0x0000000189833D80-0x0000000189833DC0
	// [XID] // 0x0000000189833D80-0x0000000189833DC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018348D350-0x000000018348D450
	// [XID] // 0x000000018983E1A0-0x000000018983E1C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingRefreshExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018348DAA0-0x000000018348DDD0
	// [XID] // 0x0000000189845930-0x0000000189845950
	private static bool ParseConfigFromLine(string line, out HuntingRefreshExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018348CF60-0x000000018348D0A0
	// [IDTag] // 0x000000018984CF20-0x000000018984CF60
	// [XID] // 0x000000018984CF20-0x000000018984CF60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingRefreshExcelConfig> configList) => default; // 0x000000018348D0A0-0x000000018348D350
	// [IDTag] // 0x0000000189857000-0x0000000189857040
	// [XID] // 0x0000000189857000-0x0000000189857040
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF24DB */, bool useObjectPool = false /* Metadata: 0x00AF24DF */) => default; // 0x000000018348D450-0x000000018348D6A0
	// [IDTag] // 0x0000000189861450-0x0000000189861490
	// [XID] // 0x0000000189861450-0x0000000189861490
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24E0 */, bool useObjectPool = false /* Metadata: 0x00AF24E4 */) => default; // 0x000000018348D6A0-0x000000018348D9F0
}

