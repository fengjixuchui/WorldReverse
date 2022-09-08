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

public static class MechanicusCardExcelConfigLoader // TypeDefIndex: 16222
{
	// Fields
	private static Dictionary<uint, MechanicusCardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusCardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusCardExcelConfig, MechanicusCardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusCardExcelConfig>, Dictionary<uint, MechanicusCardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusCardExcelConfig> dataDict { /* [XID] */ /* 0x0000000189725840-0x0000000189725860 */ get; } // 0x00000001845CD260-0x00000001845CD310 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189734530-0x0000000189734550 */ get; } // 0x00000001845CC0B0-0x00000001845CC150 

	// Methods
	// [XID] // 0x000000018971E300-0x000000018971E320
	public static void Register() {} // 0x00000001845CD640-0x00000001845CD6E0
	// [XID] // 0x000000018972CD40-0x000000018972CD60
	public static MechanicusCardExcelConfig GetData(uint ID) => default; // 0x00000001845CBF80-0x00000001845CC0B0
	// [XID] // 0x000000018973BEC0-0x000000018973BEE0
	public static void LoadData() {} // 0x00000001845CC6E0-0x00000001845CC7D0
	// [XID] // 0x00000001897436D0-0x00000001897436F0
	private static void RegisterHotfixGenerated() {} // 0x00000001845CC510-0x00000001845CC6E0
	// [XID] // 0x000000018974B360-0x000000018974B380
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001845CC150-0x00000001845CC510
	// [IDTag] // 0x00000001897524D0-0x0000000189752510
	// [XID] // 0x00000001897524D0-0x0000000189752510
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001845CCBC0-0x00000001845CCCC0
	// [XID] // 0x000000018975CB30-0x000000018975CB50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusCardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001845CD310-0x00000001845CD640
	// [XID] // 0x0000000189764340-0x0000000189764360
	private static bool ParseConfigFromLine(string line, out MechanicusCardExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001845CC7D0-0x00000001845CC910
	// [IDTag] // 0x000000018976BC20-0x000000018976BC60
	// [XID] // 0x000000018976BC20-0x000000018976BC60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusCardExcelConfig> configList) => default; // 0x00000001845CC910-0x00000001845CCBC0
	// [IDTag] // 0x0000000189776340-0x0000000189776380
	// [XID] // 0x0000000189776340-0x0000000189776380
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF34B9 */, bool useObjectPool = false /* Metadata: 0x00AF34BD */) => default; // 0x00000001845CD010-0x00000001845CD260
	// [IDTag] // 0x0000000189780A40-0x0000000189780A80
	// [XID] // 0x0000000189780A40-0x0000000189780A80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34BE */, bool useObjectPool = false /* Metadata: 0x00AF34C2 */) => default; // 0x00000001845CCCC0-0x00000001845CD010
}

