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

public static class CompoundExcelConfigLoader // TypeDefIndex: 15438
{
	// Fields
	private static Dictionary<uint, CompoundExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CompoundExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CompoundExcelConfig, CompoundExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CompoundExcelConfig>, Dictionary<uint, CompoundExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CompoundExcelConfig> dataDict { /* [XID] */ /* 0x00000001898F9930-0x00000001898F9950 */ get; } // 0x00000001817614B0-0x0000000181761560 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189908AD0-0x0000000189908AF0 */ get; } // 0x0000000181760300-0x00000001817603A0 

	// Methods
	// [XID] // 0x00000001898F2190-0x00000001898F21B0
	public static void Register() {} // 0x0000000181761890-0x0000000181761930
	// [XID] // 0x00000001899012F0-0x0000000189901310
	public static CompoundExcelConfig GetData(uint id) => default; // 0x00000001817601D0-0x0000000181760300
	// [XID] // 0x00000001899100D0-0x00000001899100F0
	public static void LoadData() {} // 0x0000000181760930-0x0000000181760A20
	// [XID] // 0x0000000189917C60-0x0000000189917C80
	private static void RegisterHotfixGenerated() {} // 0x0000000181760760-0x0000000181760930
	// [XID] // 0x000000018991F1A0-0x000000018991F1C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001817603A0-0x0000000181760760
	// [IDTag] // 0x0000000189926C00-0x0000000189926C40
	// [XID] // 0x0000000189926C00-0x0000000189926C40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181760E10-0x0000000181760F10
	// [XID] // 0x0000000189931180-0x00000001899311A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CompoundExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181761560-0x0000000181761890
	// [XID] // 0x00000001899386D0-0x00000001899386F0
	private static bool ParseConfigFromLine(string line, out CompoundExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181760A20-0x0000000181760B60
	// [IDTag] // 0x0000000189940080-0x00000001899400C0
	// [XID] // 0x0000000189940080-0x00000001899400C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CompoundExcelConfig> configList) => default; // 0x0000000181760B60-0x0000000181760E10
	// [IDTag] // 0x000000018994A5E0-0x000000018994A620
	// [XID] // 0x000000018994A5E0-0x000000018994A620
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1652 */, bool useObjectPool = false /* Metadata: 0x00AF1656 */) => default; // 0x0000000181760F10-0x0000000181761160
	// [IDTag] // 0x0000000189954CE0-0x0000000189954D20
	// [XID] // 0x0000000189954CE0-0x0000000189954D20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1657 */, bool useObjectPool = false /* Metadata: 0x00AF165B */) => default; // 0x0000000181761160-0x00000001817614B0
}

