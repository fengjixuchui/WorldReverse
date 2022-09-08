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

public static class DialogExcelConfigLoader // TypeDefIndex: 15976
{
	// Fields
	private static Dictionary<uint, DialogExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DialogExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DialogExcelConfig, DialogExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DialogExcelConfig>, Dictionary<uint, DialogExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DialogExcelConfig> dataDict { /* [XID] */ /* 0x00000001899B40C0-0x00000001899B40E0 */ get; } // 0x00000001822DC570-0x00000001822DC620 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899C30C0-0x00000001899C30E0 */ get; } // 0x00000001822DB3C0-0x00000001822DB460 

	// Methods
	// [XID] // 0x00000001899AC8F0-0x00000001899AC910
	public static void Register() {} // 0x00000001822DC950-0x00000001822DC9F0
	// [XID] // 0x00000001899BB530-0x00000001899BB550
	public static DialogExcelConfig GetData(uint id) => default; // 0x00000001822DB290-0x00000001822DB3C0
	// [XID] // 0x00000001899CA4E0-0x00000001899CA500
	public static void LoadData() {} // 0x00000001822DB9F0-0x00000001822DBAE0
	// [XID] // 0x00000001899D1CA0-0x00000001899D1CC0
	private static void RegisterHotfixGenerated() {} // 0x00000001822DB820-0x00000001822DB9F0
	// [XID] // 0x00000001899D9110-0x00000001899D9130
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001822DB460-0x00000001822DB820
	// [IDTag] // 0x00000001899E08E0-0x00000001899E0920
	// [XID] // 0x00000001899E08E0-0x00000001899E0920
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001822DBED0-0x00000001822DBFD0
	// [XID] // 0x00000001899EAE80-0x00000001899EAEA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DialogExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001822DC620-0x00000001822DC950
	// [XID] // 0x00000001899F2AA0-0x00000001899F2AC0
	private static bool ParseConfigFromLine(string line, out DialogExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001822DBAE0-0x00000001822DBC20
	// [IDTag] // 0x00000001899FA070-0x00000001899FA0B0
	// [XID] // 0x00000001899FA070-0x00000001899FA0B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DialogExcelConfig> configList) => default; // 0x00000001822DBC20-0x00000001822DBED0
	// [IDTag] // 0x0000000189A04590-0x0000000189A045D0
	// [XID] // 0x0000000189A04590-0x0000000189A045D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2CC0 */, bool useObjectPool = false /* Metadata: 0x00AF2CC4 */) => default; // 0x00000001822DC320-0x00000001822DC570
	// [IDTag] // 0x0000000189A0EBD0-0x0000000189A0EC10
	// [XID] // 0x0000000189A0EBD0-0x0000000189A0EC10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CC5 */, bool useObjectPool = false /* Metadata: 0x00AF2CC9 */) => default; // 0x00000001822DBFD0-0x00000001822DC320
}

