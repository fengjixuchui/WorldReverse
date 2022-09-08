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

public static class WeatherExcelConfigLoader // TypeDefIndex: 16277
{
	// Fields
	private static Dictionary<uint, WeatherExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WeatherExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WeatherExcelConfig, WeatherExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WeatherExcelConfig>, Dictionary<uint, WeatherExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WeatherExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B4DAE0-0x0000000189B4DB00 */ get; } // 0x0000000183AF1C80-0x0000000183AF1D30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B5CD30-0x0000000189B5CD50 */ get; } // 0x0000000183AF0AD0-0x0000000183AF0B70 

	// Methods
	// [XID] // 0x0000000189B46500-0x0000000189B46520
	public static void Register() {} // 0x0000000183AF2060-0x0000000183AF2100
	// [XID] // 0x0000000189B55330-0x0000000189B55350
	public static WeatherExcelConfig GetData(uint areaID) => default; // 0x0000000183AF09A0-0x0000000183AF0AD0
	// [XID] // 0x0000000189B643F0-0x0000000189B64410
	public static void LoadData() {} // 0x0000000183AF1100-0x0000000183AF11F0
	// [XID] // 0x0000000189B6B970-0x0000000189B6B990
	private static void RegisterHotfixGenerated() {} // 0x0000000183AF0F30-0x0000000183AF1100
	// [XID] // 0x0000000189B730D0-0x0000000189B730F0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183AF0B70-0x0000000183AF0F30
	// [IDTag] // 0x0000000189B7A6B0-0x0000000189B7A6F0
	// [XID] // 0x0000000189B7A6B0-0x0000000189B7A6F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183AF15E0-0x0000000183AF16E0
	// [XID] // 0x0000000189B85330-0x0000000189B85350
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WeatherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183AF1D30-0x0000000183AF2060
	// [XID] // 0x0000000189B8C140-0x0000000189B8C160
	private static bool ParseConfigFromLine(string line, out WeatherExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183AF11F0-0x0000000183AF1330
	// [IDTag] // 0x0000000189B93970-0x0000000189B939B0
	// [XID] // 0x0000000189B93970-0x0000000189B939B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WeatherExcelConfig> configList) => default; // 0x0000000183AF1330-0x0000000183AF15E0
	// [IDTag] // 0x0000000189B9DB00-0x0000000189B9DB40
	// [XID] // 0x0000000189B9DB00-0x0000000189B9DB40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3635 */, bool useObjectPool = false /* Metadata: 0x00AF3639 */) => default; // 0x0000000183AF16E0-0x0000000183AF1930
	// [IDTag] // 0x0000000189BA82B0-0x0000000189BA82F0
	// [XID] // 0x0000000189BA82B0-0x0000000189BA82F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF363A */, bool useObjectPool = false /* Metadata: 0x00AF363E */) => default; // 0x0000000183AF1930-0x0000000183AF1C80
}

