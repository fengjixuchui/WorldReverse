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

public static class BlossomTalkExcelConfigLoader // TypeDefIndex: 15280
{
	// Fields
	private static Dictionary<uint, BlossomTalkExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomTalkExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomTalkExcelConfig, BlossomTalkExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomTalkExcelConfig>, Dictionary<uint, BlossomTalkExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomTalkExcelConfig> dataDict { /* [XID] */ /* 0x0000000189740CA0-0x0000000189740CC0 */ get; } // 0x00000001821ECF80-0x00000001821ED030 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018974FA70-0x000000018974FA90 */ get; } // 0x00000001821EBDD0-0x00000001821EBE70 

	// Methods
	// [XID] // 0x0000000189738ED0-0x0000000189738EF0
	public static void Register() {} // 0x00000001821ED360-0x00000001821ED400
	// [XID] // 0x00000001897481E0-0x0000000189748200
	public static BlossomTalkExcelConfig GetData(uint id) => default; // 0x00000001821EBCA0-0x00000001821EBDD0
	// [XID] // 0x0000000189757040-0x0000000189757060
	public static void LoadData() {} // 0x00000001821EC400-0x00000001821EC4F0
	// [XID] // 0x000000018975E630-0x000000018975E650
	private static void RegisterHotfixGenerated() {} // 0x00000001821EC230-0x00000001821EC400
	// [XID] // 0x0000000189765CB0-0x0000000189765CD0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001821EBE70-0x00000001821EC230
	// [IDTag] // 0x000000018976D440-0x000000018976D480
	// [XID] // 0x000000018976D440-0x000000018976D480
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821EC8E0-0x00000001821EC9E0
	// [XID] // 0x00000001897779B0-0x00000001897779D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomTalkExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001821ED030-0x00000001821ED360
	// [XID] // 0x000000018977F0A0-0x000000018977F0C0
	private static bool ParseConfigFromLine(string line, out BlossomTalkExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821EC4F0-0x00000001821EC630
	// [IDTag] // 0x0000000189786A60-0x0000000189786AA0
	// [XID] // 0x0000000189786A60-0x0000000189786AA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomTalkExcelConfig> configList) => default; // 0x00000001821EC630-0x00000001821EC8E0
	// [IDTag] // 0x0000000189790FB0-0x0000000189790FF0
	// [XID] // 0x0000000189790FB0-0x0000000189790FF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF061D */, bool useObjectPool = false /* Metadata: 0x00AF0621 */) => default; // 0x00000001821ECD30-0x00000001821ECF80
	// [IDTag] // 0x000000018979C090-0x000000018979C0D0
	// [XID] // 0x000000018979C090-0x000000018979C0D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0622 */, bool useObjectPool = false /* Metadata: 0x00AF0626 */) => default; // 0x00000001821EC9E0-0x00000001821ECD30
}

