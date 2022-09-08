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

public static class AvatarFlycloakExcelConfigLoader // TypeDefIndex: 15219
{
	// Fields
	private static Dictionary<uint, AvatarFlycloakExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarFlycloakExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarFlycloakExcelConfig, AvatarFlycloakExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarFlycloakExcelConfig>, Dictionary<uint, AvatarFlycloakExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarFlycloakExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B4ADD0-0x0000000189B4ADF0 */ get; } // 0x0000000182C26E00-0x0000000182C26EB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B59DA0-0x0000000189B59DC0 */ get; } // 0x0000000182C25C50-0x0000000182C25CF0 

	// Methods
	// [XID] // 0x0000000189B435D0-0x0000000189B435F0
	public static void Register() {} // 0x0000000182C271E0-0x0000000182C27280
	// [XID] // 0x0000000189865FF0-0x0000000189866010
	public static AvatarFlycloakExcelConfig GetData(uint flycloakId) => default; // 0x0000000182C25B20-0x0000000182C25C50
	// [XID] // 0x0000000189B614D0-0x0000000189B614F0
	public static void LoadData() {} // 0x0000000182C26280-0x0000000182C26370
	// [XID] // 0x0000000189B68FA0-0x0000000189B68FC0
	private static void RegisterHotfixGenerated() {} // 0x0000000182C260B0-0x0000000182C26280
	// [XID] // 0x0000000189B703E0-0x0000000189B70400
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182C25CF0-0x0000000182C260B0
	// [IDTag] // 0x0000000189B77890-0x0000000189B778D0
	// [XID] // 0x0000000189B77890-0x0000000189B778D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182C264B0-0x0000000182C265B0
	// [XID] // 0x0000000189B82070-0x0000000189B82090
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarFlycloakExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182C26EB0-0x0000000182C271E0
	// [XID] // 0x0000000189B89830-0x0000000189B89850
	private static bool ParseConfigFromLine(string line, out AvatarFlycloakExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182C26370-0x0000000182C264B0
	// [IDTag] // 0x0000000189B90DF0-0x0000000189B90E30
	// [XID] // 0x0000000189B90DF0-0x0000000189B90E30
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarFlycloakExcelConfig> configList) => default; // 0x0000000182C265B0-0x0000000182C26860
	// [IDTag] // 0x0000000189B9B0A0-0x0000000189B9B0E0
	// [XID] // 0x0000000189B9B0A0-0x0000000189B9B0E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0423 */, bool useObjectPool = false /* Metadata: 0x00AF0427 */) => default; // 0x0000000182C26860-0x0000000182C26AB0
	// [IDTag] // 0x0000000189BA5690-0x0000000189BA56D0
	// [XID] // 0x0000000189BA5690-0x0000000189BA56D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0428 */, bool useObjectPool = false /* Metadata: 0x00AF042C */) => default; // 0x0000000182C26AB0-0x0000000182C26E00
}

