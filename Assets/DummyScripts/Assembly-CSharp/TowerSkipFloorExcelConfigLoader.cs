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

public static class TowerSkipFloorExcelConfigLoader // TypeDefIndex: 16203
{
	// Fields
	private static Dictionary<uint, TowerSkipFloorExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TowerSkipFloorExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TowerSkipFloorExcelConfig, TowerSkipFloorExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TowerSkipFloorExcelConfig>, Dictionary<uint, TowerSkipFloorExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TowerSkipFloorExcelConfig> dataDict { /* [XID] */ /* 0x000000018990B730-0x000000018990B750 */ get; } // 0x0000000181954650-0x0000000181954700 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018991AB70-0x000000018991AB90 */ get; } // 0x00000001819534A0-0x0000000181953540 

	// Methods
	// [XID] // 0x0000000189904110-0x0000000189904130
	public static void Register() {} // 0x0000000181954A30-0x0000000181954AD0
	// [XID] // 0x0000000189913420-0x0000000189913440
	public static TowerSkipFloorExcelConfig GetData(uint prev_level_index) => default; // 0x0000000181953370-0x00000001819534A0
	// [XID] // 0x00000001899223A0-0x00000001899223C0
	public static void LoadData() {} // 0x0000000181953AD0-0x0000000181953BC0
	// [XID] // 0x0000000189929B60-0x0000000189929B80
	private static void RegisterHotfixGenerated() {} // 0x0000000181953900-0x0000000181953AD0
	// [XID] // 0x00000001899310C0-0x00000001899310E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181953540-0x0000000181953900
	// [IDTag] // 0x0000000189938530-0x0000000189938570
	// [XID] // 0x0000000189938530-0x0000000189938570
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181953D00-0x0000000181953E00
	// [XID] // 0x0000000189942BD0-0x0000000189942BF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TowerSkipFloorExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181954700-0x0000000181954A30
	// [XID] // 0x000000018994A3C0-0x000000018994A3E0
	private static bool ParseConfigFromLine(string line, out TowerSkipFloorExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181953BC0-0x0000000181953D00
	// [IDTag] // 0x0000000189951E90-0x0000000189951ED0
	// [XID] // 0x0000000189951E90-0x0000000189951ED0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TowerSkipFloorExcelConfig> configList) => default; // 0x0000000181953E00-0x00000001819540B0
	// [IDTag] // 0x000000018995C2E0-0x000000018995C320
	// [XID] // 0x000000018995C2E0-0x000000018995C320
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF340B */, bool useObjectPool = false /* Metadata: 0x00AF340F */) => default; // 0x0000000181954400-0x0000000181954650
	// [IDTag] // 0x0000000189966DF0-0x0000000189966E30
	// [XID] // 0x0000000189966DF0-0x0000000189966E30
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3410 */, bool useObjectPool = false /* Metadata: 0x00AF3414 */) => default; // 0x00000001819540B0-0x0000000181954400
}

