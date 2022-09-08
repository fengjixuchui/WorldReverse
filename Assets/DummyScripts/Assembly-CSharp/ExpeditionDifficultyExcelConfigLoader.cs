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

public static class ExpeditionDifficultyExcelConfigLoader // TypeDefIndex: 15086
{
	// Fields
	private static Dictionary<uint, ExpeditionDifficultyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionDifficultyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionDifficultyExcelConfig, ExpeditionDifficultyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionDifficultyExcelConfig>, Dictionary<uint, ExpeditionDifficultyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionDifficultyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BADFA0-0x0000000189BADFC0 */ get; } // 0x00000001819B1C10-0x00000001819B1CC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BBCF80-0x0000000189BBCFA0 */ get; } // 0x00000001819B0A60-0x00000001819B0B00 

	// Methods
	// [XID] // 0x0000000189BA6E60-0x0000000189BA6E80
	public static void Register() {} // 0x00000001819B1FF0-0x00000001819B2090
	// [XID] // 0x0000000189BB5870-0x0000000189BB5890
	public static ExpeditionDifficultyExcelConfig GetData(uint id) => default; // 0x00000001819B0930-0x00000001819B0A60
	// [XID] // 0x0000000189BC4BA0-0x0000000189BC4BC0
	public static void LoadData() {} // 0x00000001819B1090-0x00000001819B1180
	// [XID] // 0x0000000189BCC5E0-0x0000000189BCC600
	private static void RegisterHotfixGenerated() {} // 0x00000001819B0EC0-0x00000001819B1090
	// [XID] // 0x0000000189BD3CD0-0x0000000189BD3CF0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001819B0B00-0x00000001819B0EC0
	// [IDTag] // 0x0000000189BDB580-0x0000000189BDB5C0
	// [XID] // 0x0000000189BDB580-0x0000000189BDB5C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001819B12C0-0x00000001819B13C0
	// [XID] // 0x00000001895EB0D0-0x00000001895EB0F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionDifficultyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001819B1CC0-0x00000001819B1FF0
	// [XID] // 0x00000001895F2550-0x00000001895F2570
	private static bool ParseConfigFromLine(string line, out ExpeditionDifficultyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001819B1180-0x00000001819B12C0
	// [IDTag] // 0x00000001895F9F80-0x00000001895F9FC0
	// [XID] // 0x00000001895F9F80-0x00000001895F9FC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionDifficultyExcelConfig> configList) => default; // 0x00000001819B13C0-0x00000001819B1670
	// [IDTag] // 0x0000000189604710-0x0000000189604750
	// [XID] // 0x0000000189604710-0x0000000189604750
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF006C */, bool useObjectPool = false /* Metadata: 0x00AF0070 */) => default; // 0x00000001819B1670-0x00000001819B18C0
	// [IDTag] // 0x000000018960EF40-0x000000018960EF80
	// [XID] // 0x000000018960EF40-0x000000018960EF80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0071 */, bool useObjectPool = false /* Metadata: 0x00AF0075 */) => default; // 0x00000001819B18C0-0x00000001819B1C10
}

