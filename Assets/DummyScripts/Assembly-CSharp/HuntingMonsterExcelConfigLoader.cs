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

public static class HuntingMonsterExcelConfigLoader // TypeDefIndex: 15756
{
	// Fields
	private static Dictionary<uint, HuntingMonsterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingMonsterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingMonsterExcelConfig, HuntingMonsterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingMonsterExcelConfig>, Dictionary<uint, HuntingMonsterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingMonsterExcelConfig> dataDict { /* [XID] */ /* 0x00000001899414A0-0x00000001899414C0 */ get; } // 0x00000001819789A0-0x0000000181978A50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899507F0-0x0000000189950810 */ get; } // 0x00000001819777F0-0x0000000181977890 

	// Methods
	// [XID] // 0x000000018993A430-0x000000018993A450
	public static void Register() {} // 0x0000000181978D80-0x0000000181978ED0
	// [XID] // 0x0000000189949000-0x0000000189949020
	public static HuntingMonsterExcelConfig GetData(uint configId) => default; // 0x00000001819776C0-0x00000001819777F0
	// [XID] // 0x0000000189957DE0-0x0000000189957E00
	public static void LoadData() {} // 0x0000000181977E20-0x0000000181977F10
	// [XID] // 0x000000018995F6B0-0x000000018995F6D0
	private static void RegisterHotfixGenerated() {} // 0x0000000181977C50-0x0000000181977E20
	// [XID] // 0x0000000189966EF0-0x0000000189966F10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181977890-0x0000000181977C50
	// [IDTag] // 0x000000018996E240-0x000000018996E280
	// [XID] // 0x000000018996E240-0x000000018996E280
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181978300-0x0000000181978400
	// [XID] // 0x00000001899792D0-0x00000001899792F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingMonsterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181978A50-0x0000000181978D80
	// [XID] // 0x0000000189980420-0x0000000189980440
	private static bool ParseConfigFromLine(string line, out HuntingMonsterExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181977F10-0x0000000181978050
	// [IDTag] // 0x0000000189987C90-0x0000000189987CD0
	// [XID] // 0x0000000189987C90-0x0000000189987CD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingMonsterExcelConfig> configList) => default; // 0x0000000181978050-0x0000000181978300
	// [IDTag] // 0x00000001899929F0-0x0000000189992A30
	// [XID] // 0x00000001899929F0-0x0000000189992A30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF252B */, bool useObjectPool = false /* Metadata: 0x00AF252F */) => default; // 0x0000000181978750-0x00000001819789A0
	// [IDTag] // 0x000000018999D410-0x000000018999D450
	// [XID] // 0x000000018999D410-0x000000018999D450
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2530 */, bool useObjectPool = false /* Metadata: 0x00AF2534 */) => default; // 0x0000000181978400-0x0000000181978750
}

