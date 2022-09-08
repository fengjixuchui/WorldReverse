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

public static class ActivityAbilityGroupExcelConfigLoader // TypeDefIndex: 15002
{
	// Fields
	private static List<ActivityAbilityGroupExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityAbilityGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityAbilityGroupExcelConfig, ActivityAbilityGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityAbilityGroupExcelConfig>, List<ActivityAbilityGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ActivityAbilityGroupExcelConfig> dataList { /* [XID] */ /* 0x0000000189975EB0-0x0000000189975ED0 */ get; } // 0x0000000183DF3040-0x0000000183DF30F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018997D030-0x000000018997D050 */ get; } // 0x0000000183DF1E50-0x0000000183DF1EF0 

	// Methods
	// [XID] // 0x000000018996E360-0x000000018996E380
	public static void Register() {} // 0x0000000183DF3420-0x0000000183DF34C0
	// [XID] // 0x0000000189984C30-0x0000000189984C50
	public static void LoadData() {} // 0x0000000183DF24F0-0x0000000183DF25E0
	// [XID] // 0x000000018998C8D0-0x000000018998C8F0
	private static void RegisterHotfixGenerated() {} // 0x0000000183DF2320-0x0000000183DF24F0
	// [XID] // 0x0000000189994610-0x0000000189994630
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183DF1EF0-0x0000000183DF2320
	// [IDTag] // 0x000000018999BDE0-0x000000018999BE20
	// [XID] // 0x000000018999BDE0-0x000000018999BE20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183DF29C0-0x0000000183DF2AC0
	// [XID] // 0x00000001899A6790-0x00000001899A67B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityAbilityGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183DF30F0-0x0000000183DF3420
	// [XID] // 0x00000001899ADFE0-0x00000001899AE000
	private static bool ParseConfigFromLine(string line, out ActivityAbilityGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183DF25E0-0x0000000183DF2720
	// [IDTag] // 0x00000001899B57A0-0x00000001899B57E0
	// [XID] // 0x00000001899B57A0-0x00000001899B57E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityAbilityGroupExcelConfig> configList) => default; // 0x0000000183DF2720-0x0000000183DF29C0
	// [IDTag] // 0x00000001899C0010-0x00000001899C0050
	// [XID] // 0x00000001899C0010-0x00000001899C0050
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE20 */, bool useObjectPool = false /* Metadata: 0x00AEFE24 */) => default; // 0x0000000183DF2AC0-0x0000000183DF2D10
	// [IDTag] // 0x00000001899CA740-0x00000001899CA780
	// [XID] // 0x00000001899CA740-0x00000001899CA780
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE25 */, bool useObjectPool = false /* Metadata: 0x00AEFE29 */) => default; // 0x0000000183DF2D10-0x0000000183DF3040
}

