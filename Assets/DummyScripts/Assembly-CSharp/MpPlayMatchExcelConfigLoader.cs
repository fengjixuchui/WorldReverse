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

public static class MpPlayMatchExcelConfigLoader // TypeDefIndex: 15864
{
	// Fields
	private static Dictionary<uint, MpPlayMatchExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayMatchExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayMatchExcelConfig, MpPlayMatchExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayMatchExcelConfig>, Dictionary<uint, MpPlayMatchExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayMatchExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BA6CC0-0x0000000189BA6CE0 */ get; } // 0x00000001833CD950-0x00000001833CDA00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BB56B0-0x0000000189BB56D0 */ get; } // 0x00000001833CC7A0-0x00000001833CC840 

	// Methods
	// [XID] // 0x0000000189B9F470-0x0000000189B9F490
	public static void Register() {} // 0x00000001833CDD30-0x00000001833CDDD0
	// [XID] // 0x0000000189BADE60-0x0000000189BADE80
	public static MpPlayMatchExcelConfig GetData(uint id) => default; // 0x00000001833CC670-0x00000001833CC7A0
	// [XID] // 0x0000000189BBCDA0-0x0000000189BBCDC0
	public static void LoadData() {} // 0x00000001833CCDD0-0x00000001833CCEC0
	// [XID] // 0x0000000189BC4A00-0x0000000189BC4A20
	private static void RegisterHotfixGenerated() {} // 0x00000001833CCC00-0x00000001833CCDD0
	// [XID] // 0x0000000189BCC440-0x0000000189BCC460
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001833CC840-0x00000001833CCC00
	// [IDTag] // 0x0000000189BD3B30-0x0000000189BD3B70
	// [XID] // 0x0000000189BD3B30-0x0000000189BD3B70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833CD2B0-0x00000001833CD3B0
	// [XID] // 0x0000000189BDE460-0x0000000189BDE480
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayMatchExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001833CDA00-0x00000001833CDD30
	// [XID] // 0x00000001895EAFF0-0x00000001895EB010
	private static bool ParseConfigFromLine(string line, out MpPlayMatchExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001833CCEC0-0x00000001833CD000
	// [IDTag] // 0x00000001895F2410-0x00000001895F2450
	// [XID] // 0x00000001895F2410-0x00000001895F2450
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayMatchExcelConfig> configList) => default; // 0x00000001833CD000-0x00000001833CD2B0
	// [IDTag] // 0x00000001895FCBF0-0x00000001895FCC30
	// [XID] // 0x00000001895FCBF0-0x00000001895FCC30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF28C4 */, bool useObjectPool = false /* Metadata: 0x00AF28C8 */) => default; // 0x00000001833CD700-0x00000001833CD950
	// [IDTag] // 0x0000000189607360-0x00000001896073A0
	// [XID] // 0x0000000189607360-0x00000001896073A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28C9 */, bool useObjectPool = false /* Metadata: 0x00AF28CD */) => default; // 0x00000001833CD3B0-0x00000001833CD700
}

