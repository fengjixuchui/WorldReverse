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

public static class MechanicusCardEffectExcelConfigLoader // TypeDefIndex: 16224
{
	// Fields
	private static Dictionary<uint, MechanicusCardEffectExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusCardEffectExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusCardEffectExcelConfig, MechanicusCardEffectExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusCardEffectExcelConfig>, Dictionary<uint, MechanicusCardEffectExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusCardEffectExcelConfig> dataDict { /* [XID] */ /* 0x0000000189871770-0x0000000189871790 */ get; } // 0x00000001828C8C20-0x00000001828C8CD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898805E0-0x0000000189880600 */ get; } // 0x00000001828C7A70-0x00000001828C7B10 

	// Methods
	// [XID] // 0x000000018986A300-0x000000018986A320
	public static void Register() {} // 0x00000001828C9000-0x00000001828C90A0
	// [XID] // 0x0000000189878F50-0x0000000189878F70
	public static MechanicusCardEffectExcelConfig GetData(uint ID) => default; // 0x00000001828C7940-0x00000001828C7A70
	// [XID] // 0x0000000189887B60-0x0000000189887B80
	public static void LoadData() {} // 0x00000001828C80A0-0x00000001828C8190
	// [XID] // 0x000000018988EE40-0x000000018988EE60
	private static void RegisterHotfixGenerated() {} // 0x00000001828C7ED0-0x00000001828C80A0
	// [XID] // 0x0000000189896360-0x0000000189896380
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001828C7B10-0x00000001828C7ED0
	// [IDTag] // 0x000000018989DA00-0x000000018989DA40
	// [XID] // 0x000000018989DA00-0x000000018989DA40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001828C8580-0x00000001828C8680
	// [XID] // 0x00000001898A7F30-0x00000001898A7F50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusCardEffectExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001828C8CD0-0x00000001828C9000
	// [XID] // 0x00000001898AF9F0-0x00000001898AFA10
	private static bool ParseConfigFromLine(string line, out MechanicusCardEffectExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001828C8190-0x00000001828C82D0
	// [IDTag] // 0x00000001898B6F30-0x00000001898B6F70
	// [XID] // 0x00000001898B6F30-0x00000001898B6F70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusCardEffectExcelConfig> configList) => default; // 0x00000001828C82D0-0x00000001828C8580
	// [IDTag] // 0x00000001898C17A0-0x00000001898C17E0
	// [XID] // 0x00000001898C17A0-0x00000001898C17E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF34C8 */, bool useObjectPool = false /* Metadata: 0x00AF34CC */) => default; // 0x00000001828C8680-0x00000001828C88D0
	// [IDTag] // 0x00000001898CBEB0-0x00000001898CBEF0
	// [XID] // 0x00000001898CBEB0-0x00000001898CBEF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34CD */, bool useObjectPool = false /* Metadata: 0x00AF34D1 */) => default; // 0x00000001828C88D0-0x00000001828C8C20
}

