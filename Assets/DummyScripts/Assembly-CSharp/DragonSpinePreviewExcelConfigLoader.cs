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

public static class DragonSpinePreviewExcelConfigLoader // TypeDefIndex: 14818
{
	// Fields
	private static Dictionary<uint, DragonSpinePreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DragonSpinePreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DragonSpinePreviewExcelConfig, DragonSpinePreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DragonSpinePreviewExcelConfig>, Dictionary<uint, DragonSpinePreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DragonSpinePreviewExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B98200-0x0000000189B98220 */ get; } // 0x0000000182569EF0-0x0000000182569FA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BA6EE0-0x0000000189BA6F00 */ get; } // 0x0000000182568D40-0x0000000182568DE0 

	// Methods
	// [XID] // 0x0000000189B89950-0x0000000189B89970
	public static DragonSpinePreviewExcelConfig GetDataByActivityID(uint activityId) => default; // 0x000000018256A370-0x000000018256A5A0
	// [XID] // 0x0000000189B90FB0-0x0000000189B90FD0
	public static void Register() {} // 0x000000018256A2D0-0x000000018256A370
	// [XID] // 0x0000000189B9F6D0-0x0000000189B9F6F0
	public static DragonSpinePreviewExcelConfig GetData(uint id) => default; // 0x0000000182568C10-0x0000000182568D40
	// [XID] // 0x0000000189BAE080-0x0000000189BAE0A0
	public static void LoadData() {} // 0x0000000182569370-0x0000000182569460
	// [XID] // 0x0000000189BB5930-0x0000000189BB5950
	private static void RegisterHotfixGenerated() {} // 0x00000001825691A0-0x0000000182569370
	// [XID] // 0x0000000189BBD0E0-0x0000000189BBD100
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182568DE0-0x00000001825691A0
	// [IDTag] // 0x0000000189BC4C80-0x0000000189BC4CC0
	// [XID] // 0x0000000189BC4C80-0x0000000189BC4CC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182569850-0x0000000182569950
	// [XID] // 0x0000000189BCF5B0-0x0000000189BCF5D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DragonSpinePreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182569FA0-0x000000018256A2D0
	// [XID] // 0x0000000189BD6940-0x0000000189BD6960
	private static bool ParseConfigFromLine(string line, out DragonSpinePreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182569460-0x00000001825695A0
	// [IDTag] // 0x0000000189BDE740-0x0000000189BDE780
	// [XID] // 0x0000000189BDE740-0x0000000189BDE780
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DragonSpinePreviewExcelConfig> configList) => default; // 0x00000001825695A0-0x0000000182569850
	// [IDTag] // 0x00000001895EE0F0-0x00000001895EE130
	// [XID] // 0x00000001895EE0F0-0x00000001895EE130
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF670 */, bool useObjectPool = false /* Metadata: 0x00AEF674 */) => default; // 0x0000000182569950-0x0000000182569BA0
	// [IDTag] // 0x00000001895F8A70-0x00000001895F8AB0
	// [XID] // 0x00000001895F8A70-0x00000001895F8AB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF675 */, bool useObjectPool = false /* Metadata: 0x00AEF679 */) => default; // 0x0000000182569BA0-0x0000000182569EF0
}

