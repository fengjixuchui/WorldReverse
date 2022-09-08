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

public static class InvestigationMonsterConfigLoader // TypeDefIndex: 15773
{
	// Fields
	private static Dictionary<uint, InvestigationMonsterConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<InvestigationMonsterConfig>> customApplyHotfixAction; // 0x08
	public static Action<InvestigationMonsterConfig, InvestigationMonsterConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<InvestigationMonsterConfig>, Dictionary<uint, InvestigationMonsterConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, InvestigationMonsterConfig> dataDict { /* [XID] */ /* 0x0000000189941480-0x00000001899414A0 */ get; } // 0x0000000183CC9580-0x0000000183CC9630 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899507D0-0x00000001899507F0 */ get; } // 0x0000000183CC83D0-0x0000000183CC8470 

	// Methods
	// [XID] // 0x000000018993A410-0x000000018993A430
	public static void Register() {} // 0x0000000183CC9960-0x0000000183CC9A00
	// [XID] // 0x0000000189948FE0-0x0000000189949000
	public static InvestigationMonsterConfig GetData(uint id) => default; // 0x0000000183CC82A0-0x0000000183CC83D0
	// [XID] // 0x0000000189957DC0-0x0000000189957DE0
	public static void LoadData() {} // 0x0000000183CC8A00-0x0000000183CC8AF0
	// [XID] // 0x000000018995F690-0x000000018995F6B0
	private static void RegisterHotfixGenerated() {} // 0x0000000183CC8830-0x0000000183CC8A00
	// [XID] // 0x0000000189966ED0-0x0000000189966EF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183CC8470-0x0000000183CC8830
	// [IDTag] // 0x000000018996E200-0x000000018996E240
	// [XID] // 0x000000018996E200-0x000000018996E240
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183CC8C30-0x0000000183CC8D30
	// [XID] // 0x00000001899792B0-0x00000001899792D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<InvestigationMonsterConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183CC9630-0x0000000183CC9960
	// [XID] // 0x0000000189980400-0x0000000189980420
	private static bool ParseConfigFromLine(string line, out InvestigationMonsterConfig data) {
		data = default;
		return default;
	} // 0x0000000183CC8AF0-0x0000000183CC8C30
	// [IDTag] // 0x0000000189987C50-0x0000000189987C90
	// [XID] // 0x0000000189987C50-0x0000000189987C90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<InvestigationMonsterConfig> configList) => default; // 0x0000000183CC8D30-0x0000000183CC8FE0
	// [IDTag] // 0x00000001899929B0-0x00000001899929F0
	// [XID] // 0x00000001899929B0-0x00000001899929F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF259C */, bool useObjectPool = false /* Metadata: 0x00AF25A0 */) => default; // 0x0000000183CC9330-0x0000000183CC9580
	// [IDTag] // 0x000000018999D3D0-0x000000018999D410
	// [XID] // 0x000000018999D3D0-0x000000018999D410
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25A1 */, bool useObjectPool = false /* Metadata: 0x00AF25A5 */) => default; // 0x0000000183CC8FE0-0x0000000183CC9330
}

