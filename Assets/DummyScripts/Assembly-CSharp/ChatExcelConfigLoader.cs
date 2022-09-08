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

public static class ChatExcelConfigLoader // TypeDefIndex: 15300
{
	// Fields
	private static Dictionary<uint, ChatExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChatExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChatExcelConfig, ChatExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChatExcelConfig>, Dictionary<uint, ChatExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChatExcelConfig> dataDict { /* [XID] */ /* 0x000000018997CFD0-0x000000018997CFF0 */ get; } // 0x0000000185519360-0x0000000185519410 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018998C830-0x000000018998C850 */ get; } // 0x00000001855181B0-0x0000000185518250 

	// Methods
	// [XID] // 0x0000000189975E90-0x0000000189975EB0
	public static void Register() {} // 0x0000000185519740-0x00000001855197E0
	// [XID] // 0x0000000189984C10-0x0000000189984C30
	public static ChatExcelConfig GetData(uint id) => default; // 0x0000000185518080-0x00000001855181B0
	// [XID] // 0x0000000189994550-0x0000000189994570
	public static void LoadData() {} // 0x00000001855187E0-0x00000001855188D0
	// [XID] // 0x000000018999BD20-0x000000018999BD40
	private static void RegisterHotfixGenerated() {} // 0x0000000185518610-0x00000001855187E0
	// [XID] // 0x00000001899A3590-0x00000001899A35B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185518250-0x0000000185518610
	// [IDTag] // 0x00000001899AB0C0-0x00000001899AB100
	// [XID] // 0x00000001899AB0C0-0x00000001899AB100
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185518CC0-0x0000000185518DC0
	// [XID] // 0x00000001899B5740-0x00000001899B5760
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChatExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185519410-0x0000000185519740
	// [XID] // 0x00000001899BCED0-0x00000001899BCEF0
	private static bool ParseConfigFromLine(string line, out ChatExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001855188D0-0x0000000185518A10
	// [IDTag] // 0x00000001899C4860-0x00000001899C48A0
	// [XID] // 0x00000001899C4860-0x00000001899C48A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChatExcelConfig> configList) => default; // 0x0000000185518A10-0x0000000185518CC0
	// [IDTag] // 0x00000001899CEDE0-0x00000001899CEE20
	// [XID] // 0x00000001899CEDE0-0x00000001899CEE20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF06C1 */, bool useObjectPool = false /* Metadata: 0x00AF06C5 */) => default; // 0x0000000185519110-0x0000000185519360
	// [IDTag] // 0x00000001899D9310-0x00000001899D9350
	// [XID] // 0x00000001899D9310-0x00000001899D9350
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF06C6 */, bool useObjectPool = false /* Metadata: 0x00AF06CA */) => default; // 0x0000000185518DC0-0x0000000185519110
}

