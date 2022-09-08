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

public static class MechanicusSequenceExcelConfigLoader // TypeDefIndex: 16215
{
	// Fields
	private static Dictionary<uint, MechanicusSequenceExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusSequenceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusSequenceExcelConfig, MechanicusSequenceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusSequenceExcelConfig>, Dictionary<uint, MechanicusSequenceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusSequenceExcelConfig> dataDict { /* [XID] */ /* 0x00000001897CE060-0x00000001897CE080 */ get; } // 0x0000000182E83170-0x0000000182E83220 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897DCDD0-0x00000001897DCDF0 */ get; } // 0x0000000182E81FC0-0x0000000182E82060 

	// Methods
	// [XID] // 0x00000001897C68E0-0x00000001897C6900
	public static void Register() {} // 0x0000000182E83550-0x0000000182E835F0
	// [XID] // 0x00000001897D55F0-0x00000001897D5610
	public static MechanicusSequenceExcelConfig GetData(uint sequenceID) => default; // 0x0000000182E81E90-0x0000000182E81FC0
	// [XID] // 0x00000001897E46D0-0x00000001897E46F0
	public static void LoadData() {} // 0x0000000182E825F0-0x0000000182E826E0
	// [XID] // 0x00000001897EC260-0x00000001897EC280
	private static void RegisterHotfixGenerated() {} // 0x0000000182E82420-0x0000000182E825F0
	// [XID] // 0x00000001897F3BF0-0x00000001897F3C10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182E82060-0x0000000182E82420
	// [IDTag] // 0x00000001897FB5F0-0x00000001897FB630
	// [XID] // 0x00000001897FB5F0-0x00000001897FB630
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182E82AD0-0x0000000182E82BD0
	// [XID] // 0x0000000189805710-0x0000000189805730
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusSequenceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182E83220-0x0000000182E83550
	// [XID] // 0x000000018980CD10-0x000000018980CD30
	private static bool ParseConfigFromLine(string line, out MechanicusSequenceExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182E826E0-0x0000000182E82820
	// [IDTag] // 0x0000000189814550-0x0000000189814590
	// [XID] // 0x0000000189814550-0x0000000189814590
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusSequenceExcelConfig> configList) => default; // 0x0000000182E82820-0x0000000182E82AD0
	// [IDTag] // 0x000000018981F120-0x000000018981F160
	// [XID] // 0x000000018981F120-0x000000018981F160
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF348C */, bool useObjectPool = false /* Metadata: 0x00AF3490 */) => default; // 0x0000000182E82F20-0x0000000182E83170
	// [IDTag] // 0x0000000189829690-0x00000001898296D0
	// [XID] // 0x0000000189829690-0x00000001898296D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3491 */, bool useObjectPool = false /* Metadata: 0x00AF3495 */) => default; // 0x0000000182E82BD0-0x0000000182E82F20
}

