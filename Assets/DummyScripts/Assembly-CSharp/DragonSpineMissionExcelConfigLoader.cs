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

public static class DragonSpineMissionExcelConfigLoader // TypeDefIndex: 15069
{
	// Fields
	private static Dictionary<uint, DragonSpineMissionExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DragonSpineMissionExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DragonSpineMissionExcelConfig, DragonSpineMissionExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DragonSpineMissionExcelConfig>, Dictionary<uint, DragonSpineMissionExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DragonSpineMissionExcelConfig> dataDict { /* [XID] */ /* 0x000000018995C5A0-0x000000018995C5C0 */ get; } // 0x0000000183248A00-0x0000000183248AB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018996B490-0x000000018996B4B0 */ get; } // 0x0000000183247850-0x00000001832478F0 

	// Methods
	// [XID] // 0x0000000189954D80-0x0000000189954DA0
	public static void Register() {} // 0x0000000183248DE0-0x0000000183248E80
	// [XID] // 0x0000000189963F20-0x0000000189963F40
	public static DragonSpineMissionExcelConfig GetData(uint id) => default; // 0x0000000183247720-0x0000000183247850
	// [XID] // 0x0000000189972F90-0x0000000189972FB0
	public static void LoadData() {} // 0x0000000183247E80-0x0000000183247F70
	// [XID] // 0x000000018997A850-0x000000018997A870
	private static void RegisterHotfixGenerated() {} // 0x0000000183247CB0-0x0000000183247E80
	// [XID] // 0x00000001899822A0-0x00000001899822C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001832478F0-0x0000000183247CB0
	// [IDTag] // 0x0000000189989A40-0x0000000189989A80
	// [XID] // 0x0000000189989A40-0x0000000189989A80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001832480B0-0x00000001832481B0
	// [XID] // 0x00000001899945F0-0x0000000189994610
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DragonSpineMissionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183248AB0-0x0000000183248DE0
	// [XID] // 0x000000018999BDC0-0x000000018999BDE0
	private static bool ParseConfigFromLine(string line, out DragonSpineMissionExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183247F70-0x00000001832480B0
	// [IDTag] // 0x00000001899A35F0-0x00000001899A3630
	// [XID] // 0x00000001899A35F0-0x00000001899A3630
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DragonSpineMissionExcelConfig> configList) => default; // 0x00000001832481B0-0x0000000183248460
	// [IDTag] // 0x00000001899ADF60-0x00000001899ADFA0
	// [XID] // 0x00000001899ADF60-0x00000001899ADFA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFFED */, bool useObjectPool = false /* Metadata: 0x00AEFFF1 */) => default; // 0x0000000183248460-0x00000001832486B0
	// [IDTag] // 0x00000001899B8470-0x00000001899B84B0
	// [XID] // 0x00000001899B8470-0x00000001899B84B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFF2 */, bool useObjectPool = false /* Metadata: 0x00AEFFF6 */) => default; // 0x00000001832486B0-0x0000000183248A00
}

