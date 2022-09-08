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

public static class AvatarCodexExcelConfigLoader // TypeDefIndex: 15203
{
	// Fields
	private static List<AvatarCodexExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarCodexExcelConfig, AvatarCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarCodexExcelConfig>, List<AvatarCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<AvatarCodexExcelConfig> dataList { /* [XID] */ /* 0x0000000189B76230-0x0000000189B76250 */ get; } // 0x0000000182321870-0x0000000182321920 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B7D7A0-0x0000000189B7D7C0 */ get; } // 0x0000000182320680-0x0000000182320720 

	// Methods
	// [XID] // 0x0000000189B6E9E0-0x0000000189B6EA00
	public static void Register() {} // 0x0000000182321C50-0x0000000182321CF0
	// [XID] // 0x0000000189B85550-0x0000000189B85570
	public static void LoadData() {} // 0x0000000182320D20-0x0000000182320E10
	// [XID] // 0x0000000189B8C2C0-0x0000000189B8C2E0
	private static void RegisterHotfixGenerated() {} // 0x0000000182320B50-0x0000000182320D20
	// [XID] // 0x0000000189B93B90-0x0000000189B93BB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182320720-0x0000000182320B50
	// [IDTag] // 0x0000000189B9B0E0-0x0000000189B9B120
	// [XID] // 0x0000000189B9B0E0-0x0000000189B9B120
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823211F0-0x00000001823212F0
	// [XID] // 0x0000000189BA56D0-0x0000000189BA56F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182321920-0x0000000182321C50
	// [XID] // 0x0000000189BAC910-0x0000000189BAC930
	private static bool ParseConfigFromLine(string line, out AvatarCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182320E10-0x0000000182320F50
	// [IDTag] // 0x0000000189BB4190-0x0000000189BB41D0
	// [XID] // 0x0000000189BB4190-0x0000000189BB41D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarCodexExcelConfig> configList) => default; // 0x0000000182320F50-0x00000001823211F0
	// [IDTag] // 0x0000000189BBE4D0-0x0000000189BBE510
	// [XID] // 0x0000000189BBE4D0-0x0000000189BBE510
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF03B8 */, bool useObjectPool = false /* Metadata: 0x00AF03BC */) => default; // 0x00000001823212F0-0x0000000182321540
	// [IDTag] // 0x0000000189BC9360-0x0000000189BC93A0
	// [XID] // 0x0000000189BC9360-0x0000000189BC93A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03BD */, bool useObjectPool = false /* Metadata: 0x00AF03C1 */) => default; // 0x0000000182321540-0x0000000182321870
}

