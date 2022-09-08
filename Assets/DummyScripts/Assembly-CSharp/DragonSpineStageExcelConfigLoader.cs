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

public static class DragonSpineStageExcelConfigLoader // TypeDefIndex: 14819
{
	// Fields
	private static Dictionary<uint, DragonSpineStageExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DragonSpineStageExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DragonSpineStageExcelConfig, DragonSpineStageExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DragonSpineStageExcelConfig>, Dictionary<uint, DragonSpineStageExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DragonSpineStageExcelConfig> dataDict { /* [XID] */ /* 0x0000000189620DA0-0x0000000189620DC0 */ get; } // 0x00000001847588D0-0x0000000184758980 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018962FD40-0x000000018962FD60 */ get; } // 0x0000000184757720-0x00000001847577C0 

	// Methods
	// [XID] // 0x0000000189611F00-0x0000000189611F20
	public static DragonSpineStageExcelConfig GetDataByChapterId(uint chapterId) => default; // 0x00000001847574F0-0x0000000184757720
	// [XID] // 0x00000001896197A0-0x00000001896197C0
	public static void Register() {} // 0x0000000184758CB0-0x0000000184758D50
	// [XID] // 0x0000000189628410-0x0000000189628430
	public static DragonSpineStageExcelConfig GetData(uint id) => default; // 0x00000001847573C0-0x00000001847574F0
	// [XID] // 0x00000001896379A0-0x00000001896379C0
	public static void LoadData() {} // 0x0000000184757D50-0x0000000184757E40
	// [XID] // 0x000000018963ED00-0x000000018963ED20
	private static void RegisterHotfixGenerated() {} // 0x0000000184757B80-0x0000000184757D50
	// [XID] // 0x0000000189646500-0x0000000189646520
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847577C0-0x0000000184757B80
	// [IDTag] // 0x000000018964DD40-0x000000018964DD80
	// [XID] // 0x000000018964DD40-0x000000018964DD80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184757F80-0x0000000184758080
	// [XID] // 0x0000000189658590-0x00000001896585B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DragonSpineStageExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184758980-0x0000000184758CB0
	// [XID] // 0x000000018965FAE0-0x000000018965FB00
	private static bool ParseConfigFromLine(string line, out DragonSpineStageExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184757E40-0x0000000184757F80
	// [IDTag] // 0x0000000189667550-0x0000000189667590
	// [XID] // 0x0000000189667550-0x0000000189667590
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DragonSpineStageExcelConfig> configList) => default; // 0x0000000184758080-0x0000000184758330
	// [IDTag] // 0x0000000189672180-0x00000001896721C0
	// [XID] // 0x0000000189672180-0x00000001896721C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF67A */, bool useObjectPool = false /* Metadata: 0x00AEF67E */) => default; // 0x0000000184758330-0x0000000184758580
	// [IDTag] // 0x000000018967C900-0x000000018967C940
	// [XID] // 0x000000018967C900-0x000000018967C940
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF67F */, bool useObjectPool = false /* Metadata: 0x00AEF683 */) => default; // 0x0000000184758580-0x00000001847588D0
}

