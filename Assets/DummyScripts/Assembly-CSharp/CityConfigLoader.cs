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

public static class CityConfigLoader // TypeDefIndex: 14927
{
	// Fields
	private static List<CityConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<CityConfig>> customApplyHotfixAction; // 0x08
	public static Action<CityConfig, CityConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CityConfig>, List<CityConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<CityConfig> dataList { /* [XID] */ /* 0x000000018994EF00-0x000000018994EF20 */ get; } // 0x0000000184443F70-0x0000000184444020 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189956580-0x00000001899565A0 */ get; } // 0x0000000184442B30-0x0000000184442BD0 

	// Methods
	// [XID] // 0x000000018992B4A0-0x000000018992B4C0
	public static CityConfig GetConfigByAreaID(uint sceneID, uint areaID) => default; // 0x0000000184443400-0x0000000184443650
	// [IDTag] // 0x0000000189932B80-0x0000000189932BC0
	// [XID] // 0x0000000189932B80-0x0000000189932BC0
	public static CityConfig GetConfig(uint sceneID, uint cityID) => default; // 0x0000000184442750-0x0000000184442950
	// [IDTag] // 0x000000018993D370-0x000000018993D3B0
	// [XID] // 0x000000018993D370-0x000000018993D3B0
	public static CityConfig GetConfig(uint cityID) => default; // 0x0000000184442950-0x0000000184442B30
	// [XID] // 0x00000001899476E0-0x0000000189947700
	public static void Register() {} // 0x0000000184444350-0x00000001844443F0
	// [XID] // 0x000000018995DFB0-0x000000018995DFD0
	public static void LoadData() {} // 0x00000001844431D0-0x00000001844432C0
	// [XID] // 0x00000001899657B0-0x00000001899657D0
	private static void RegisterHotfixGenerated() {} // 0x0000000184443000-0x00000001844431D0
	// [XID] // 0x000000018996CF30-0x000000018996CF50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184442BD0-0x0000000184443000
	// [IDTag] // 0x0000000189974790-0x00000001899747D0
	// [XID] // 0x0000000189974790-0x00000001899747D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184443650-0x0000000184443750
	// [XID] // 0x000000018997EC00-0x000000018997EC20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CityConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184444020-0x0000000184444350
	// [XID] // 0x00000001899864F0-0x0000000189986510
	private static bool ParseConfigFromLine(string line, out CityConfig data) {
		data = default;
		return default;
	} // 0x00000001844432C0-0x0000000184443400
	// [IDTag] // 0x000000018998E160-0x000000018998E1A0
	// [XID] // 0x000000018998E160-0x000000018998E1A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CityConfig> configList) => default; // 0x0000000184443750-0x00000001844439F0
	// [IDTag] // 0x0000000189998E10-0x0000000189998E50
	// [XID] // 0x0000000189998E10-0x0000000189998E50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA41 */, bool useObjectPool = false /* Metadata: 0x00AEFA45 */) => default; // 0x0000000184443D20-0x0000000184443F70
	// [IDTag] // 0x00000001899A36D0-0x00000001899A3710
	// [XID] // 0x00000001899A36D0-0x00000001899A3710
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA46 */, bool useObjectPool = false /* Metadata: 0x00AEFA4A */) => default; // 0x00000001844439F0-0x0000000184443D20
}

