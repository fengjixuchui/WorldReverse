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

public static class ActivityShopSheetExcelConfigLoader // TypeDefIndex: 15193
{
	// Fields
	private static Dictionary<uint, ActivityShopSheetExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityShopSheetExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityShopSheetExcelConfig, ActivityShopSheetExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityShopSheetExcelConfig>, Dictionary<uint, ActivityShopSheetExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityShopSheetExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A41470-0x0000000189A41490 */ get; } // 0x00000001826FDF20-0x00000001826FDFD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A502C0-0x0000000189A502E0 */ get; } // 0x00000001826FCD70-0x00000001826FCE10 

	// Methods
	// [XID] // 0x0000000189A39C50-0x0000000189A39C70
	public static void Register() {} // 0x00000001826FE300-0x00000001826FE3A0
	// [XID] // 0x0000000189A48B70-0x0000000189A48B90
	public static ActivityShopSheetExcelConfig GetData(uint id) => default; // 0x00000001826FCC40-0x00000001826FCD70
	// [XID] // 0x0000000189A57890-0x0000000189A578B0
	public static void LoadData() {} // 0x00000001826FD3A0-0x00000001826FD490
	// [XID] // 0x0000000189A5F490-0x0000000189A5F4B0
	private static void RegisterHotfixGenerated() {} // 0x00000001826FD1D0-0x00000001826FD3A0
	// [XID] // 0x0000000189A66DC0-0x0000000189A66DE0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001826FCE10-0x00000001826FD1D0
	// [IDTag] // 0x0000000189A6E5A0-0x0000000189A6E5E0
	// [XID] // 0x0000000189A6E5A0-0x0000000189A6E5E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001826FD5D0-0x00000001826FD6D0
	// [XID] // 0x0000000189A78F20-0x0000000189A78F40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityShopSheetExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001826FDFD0-0x00000001826FE300
	// [XID] // 0x0000000189A803A0-0x0000000189A803C0
	private static bool ParseConfigFromLine(string line, out ActivityShopSheetExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001826FD490-0x00000001826FD5D0
	// [IDTag] // 0x0000000189A88140-0x0000000189A88180
	// [XID] // 0x0000000189A88140-0x0000000189A88180
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityShopSheetExcelConfig> configList) => default; // 0x00000001826FD6D0-0x00000001826FD980
	// [IDTag] // 0x0000000189A928B0-0x0000000189A928F0
	// [XID] // 0x0000000189A928B0-0x0000000189A928F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF036D */, bool useObjectPool = false /* Metadata: 0x00AF0371 */) => default; // 0x00000001826FDCD0-0x00000001826FDF20
	// [IDTag] // 0x0000000189A9CF30-0x0000000189A9CF70
	// [XID] // 0x0000000189A9CF30-0x0000000189A9CF70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0372 */, bool useObjectPool = false /* Metadata: 0x00AF0376 */) => default; // 0x00000001826FD980-0x00000001826FDCD0
}

