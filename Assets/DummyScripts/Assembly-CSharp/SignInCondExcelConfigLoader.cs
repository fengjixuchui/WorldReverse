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

public static class SignInCondExcelConfigLoader // TypeDefIndex: 16159
{
	// Fields
	private static Dictionary<uint, SignInCondExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SignInCondExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SignInCondExcelConfig, SignInCondExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SignInCondExcelConfig>, Dictionary<uint, SignInCondExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SignInCondExcelConfig> dataDict { /* [XID] */ /* 0x00000001898F37A0-0x00000001898F37C0 */ get; } // 0x0000000181093640-0x00000001810936F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189902A20-0x0000000189902A40 */ get; } // 0x0000000181092490-0x0000000181092530 

	// Methods
	// [XID] // 0x00000001898EBEF0-0x00000001898EBF10
	public static void Register() {} // 0x0000000181093A20-0x0000000181093AC0
	// [XID] // 0x00000001898FAE40-0x00000001898FAE60
	public static SignInCondExcelConfig GetData(uint configId) => default; // 0x0000000181092360-0x0000000181092490
	// [XID] // 0x0000000189909F40-0x0000000189909F60
	public static void LoadData() {} // 0x0000000181092AC0-0x0000000181092BB0
	// [XID] // 0x0000000189911800-0x0000000189911820
	private static void RegisterHotfixGenerated() {} // 0x00000001810928F0-0x0000000181092AC0
	// [XID] // 0x0000000189919360-0x0000000189919380
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181092530-0x00000001810928F0
	// [IDTag] // 0x0000000189920930-0x0000000189920970
	// [XID] // 0x0000000189920930-0x0000000189920970
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181092FA0-0x00000001810930A0
	// [XID] // 0x000000018992B240-0x000000018992B260
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SignInCondExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001810936F0-0x0000000181093A20
	// [XID] // 0x00000001899328A0-0x00000001899328C0
	private static bool ParseConfigFromLine(string line, out SignInCondExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181092BB0-0x0000000181092CF0
	// [IDTag] // 0x000000018993A2F0-0x000000018993A330
	// [XID] // 0x000000018993A2F0-0x000000018993A330
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SignInCondExcelConfig> configList) => default; // 0x0000000181092CF0-0x0000000181092FA0
	// [IDTag] // 0x0000000189944720-0x0000000189944760
	// [XID] // 0x0000000189944720-0x0000000189944760
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF32DB */, bool useObjectPool = false /* Metadata: 0x00AF32DF */) => default; // 0x00000001810933F0-0x0000000181093640
	// [IDTag] // 0x000000018994ED40-0x000000018994ED80
	// [XID] // 0x000000018994ED40-0x000000018994ED80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32E0 */, bool useObjectPool = false /* Metadata: 0x00AF32E4 */) => default; // 0x00000001810930A0-0x00000001810933F0
}

