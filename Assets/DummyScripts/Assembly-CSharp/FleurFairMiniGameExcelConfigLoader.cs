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

public static class FleurFairMiniGameExcelConfigLoader // TypeDefIndex: 14822
{
	// Fields
	private static Dictionary<uint, FleurFairMiniGameExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairMiniGameExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairMiniGameExcelConfig, FleurFairMiniGameExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairMiniGameExcelConfig>, Dictionary<uint, FleurFairMiniGameExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairMiniGameExcelConfig> dataDict { /* [XID] */ /* 0x00000001897BA050-0x00000001897BA070 */ get; } // 0x0000000182C00260-0x0000000182C00310 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897C99A0-0x00000001897C99C0 */ get; } // 0x0000000182BFE9A0-0x0000000182BFEA40 

	// Methods
	// [XID] // 0x000000018979C210-0x000000018979C230
	public static void GetIDs(FleurFairMiniGameType gameType, ref List<uint> idList) {} // 0x0000000182BFF240-0x0000000182BFF490
	// [XID] // 0x00000001897A3740-0x00000001897A3760
	public static FleurFairMiniGameExcelConfig GetDataByGalleryID(uint galleryID) => default; // 0x0000000182BFF490-0x0000000182BFF6E0
	// [XID] // 0x00000001897AABC0-0x00000001897AABE0
	public static uint GetMiniGameIDByMusicID(uint musicID) => default; // 0x0000000182BFEE00-0x0000000182BFF070
	// [XID] // 0x00000001897B2790-0x00000001897B27B0
	public static void Register() {} // 0x0000000182C00640-0x0000000182C006E0
	// [XID] // 0x00000001897C2170-0x00000001897C2190
	public static FleurFairMiniGameExcelConfig GetData(uint id) => default; // 0x0000000182BFE870-0x0000000182BFE9A0
	// [XID] // 0x00000001897D1010-0x00000001897D1030
	public static void LoadData() {} // 0x0000000182BFF6E0-0x0000000182BFF7D0
	// [XID] // 0x00000001897D8FF0-0x00000001897D9010
	private static void RegisterHotfixGenerated() {} // 0x0000000182BFF070-0x0000000182BFF240
	// [XID] // 0x00000001897E0230-0x00000001897E0250
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182BFEA40-0x0000000182BFEE00
	// [IDTag] // 0x00000001897E78F0-0x00000001897E7930
	// [XID] // 0x00000001897E78F0-0x00000001897E7930
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182BFF910-0x0000000182BFFA10
	// [XID] // 0x00000001897F2810-0x00000001897F2830
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairMiniGameExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182C00310-0x0000000182C00640
	// [XID] // 0x00000001897FA000-0x00000001897FA020
	private static bool ParseConfigFromLine(string line, out FleurFairMiniGameExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182BFF7D0-0x0000000182BFF910
	// [IDTag] // 0x00000001898015C0-0x0000000189801600
	// [XID] // 0x00000001898015C0-0x0000000189801600
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairMiniGameExcelConfig> configList) => default; // 0x0000000182BFFA10-0x0000000182BFFCC0
	// [IDTag] // 0x000000018980B8C0-0x000000018980B900
	// [XID] // 0x000000018980B8C0-0x000000018980B900
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF698 */, bool useObjectPool = false /* Metadata: 0x00AEF69C */) => default; // 0x0000000182C00010-0x0000000182C00260
	// [IDTag] // 0x00000001898160F0-0x0000000189816130
	// [XID] // 0x00000001898160F0-0x0000000189816130
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF69D */, bool useObjectPool = false /* Metadata: 0x00AEF6A1 */) => default; // 0x0000000182BFFCC0-0x0000000182C00010
}

