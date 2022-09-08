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

public static class RoomWeatherExcelConfigLoader // TypeDefIndex: 16281
{
	// Fields
	private static Dictionary<uint, RoomWeatherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RoomWeatherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RoomWeatherExcelConfig, RoomWeatherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RoomWeatherExcelConfig>, Dictionary<uint, RoomWeatherExcelConfig>, string, bool> customValidateFunc; // 0x20
	private static Dictionary<uint, Dictionary<uint, string>> _roomId2AreaId; // 0x28

	// Properties
	public static Dictionary<uint, RoomWeatherExcelConfig> dataDict { /* [XID] */ /* 0x00000001897A6580-0x00000001897A65A0 */ get; } // 0x00000001836BFC80-0x00000001836BFD50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897B5C30-0x00000001897B5C50 */ get; } // 0x00000001836BE680-0x00000001836BE720 

	// Constructors
	static RoomWeatherExcelConfigLoader() {} // 0x00000001836C0160-0x00000001836C01F0

	// Methods
	// [XID] // 0x000000018979EF10-0x000000018979EF30
	public static void Register() {} // 0x00000001836C00A0-0x00000001836C0160
	// [XID] // 0x00000001897ADAD0-0x00000001897ADAF0
	public static RoomWeatherExcelConfig GetData(uint id) => default; // 0x00000001836BDFB0-0x00000001836BE140
	// [XID] // 0x00000001897BDA40-0x00000001897BDA60
	public static void LoadData() {} // 0x00000001836BEE70-0x00000001836BEFA0
	// [XID] // 0x00000001897C4DE0-0x00000001897C4E00
	private static void RegisterHotfixGenerated() {} // 0x00000001836BEC00-0x00000001836BEE70
	// [XID] // 0x00000001897CC610-0x00000001897CC630
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001836BE720-0x00000001836BEC00
	// [IDTag] // 0x00000001897D3F00-0x00000001897D3F40
	// [XID] // 0x00000001897D3F00-0x00000001897D3F40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836BF4E0-0x00000001836BF640
	// [XID] // 0x00000001897DE5F0-0x00000001897DE610
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RoomWeatherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001836BFD50-0x00000001836C00A0
	// [XID] // 0x00000001897E60D0-0x00000001897E60F0
	private static bool ParseConfigFromLine(string line, out RoomWeatherExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836BEFA0-0x00000001836BF0E0
	// [IDTag] // 0x00000001897EDA70-0x00000001897EDAB0
	// [XID] // 0x00000001897EDA70-0x00000001897EDAB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RoomWeatherExcelConfig> configList) => default; // 0x00000001836BF1A0-0x00000001836BF4E0
	// [IDTag] // 0x00000001897F83E0-0x00000001897F8420
	// [XID] // 0x00000001897F83E0-0x00000001897F8420
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3653 */, bool useObjectPool = false /* Metadata: 0x00AF3657 */) => default; // 0x00000001836BF9D0-0x00000001836BFC80
	// [IDTag] // 0x0000000189802A40-0x0000000189802A80
	// [XID] // 0x0000000189802A40-0x0000000189802A80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3658 */, bool useObjectPool = false /* Metadata: 0x00AF365C */) => default; // 0x00000001836BF640-0x00000001836BF9D0
	// [XID] // 0x000000018980CCF0-0x000000018980CD10
	public static void BulidRoomData() {} // 0x00000001836BE320-0x00000001836BE680
	// [XID] // 0x0000000189814530-0x0000000189814550
	public static void LoadAndBuildData() {} // 0x00000001836BF0E0-0x00000001836BF1A0
	// [XID] // 0x000000018981C000-0x000000018981C020
	public static string GetProfileName(uint roomID, uint areaID) => default; // 0x00000001836BE140-0x00000001836BE320
}

