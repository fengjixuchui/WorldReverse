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

public static class ReunionPrivilegeExcelConfigLoader // TypeDefIndex: 16064
{
	// Fields
	private static Dictionary<uint, ReunionPrivilegeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReunionPrivilegeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReunionPrivilegeExcelConfig, ReunionPrivilegeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReunionPrivilegeExcelConfig>, Dictionary<uint, ReunionPrivilegeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReunionPrivilegeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189897C80-0x0000000189897CA0 */ get; } // 0x0000000181E09400-0x0000000181E094B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898A6BC0-0x00000001898A6BE0 */ get; } // 0x0000000181E08250-0x0000000181E082F0 

	// Methods
	// [XID] // 0x00000001898906E0-0x0000000189890700
	public static void Register() {} // 0x0000000181E097E0-0x0000000181E09880
	// [XID] // 0x000000018989F060-0x000000018989F080
	public static ReunionPrivilegeExcelConfig GetData(uint id) => default; // 0x0000000181E08120-0x0000000181E08250
	// [XID] // 0x00000001898AE2D0-0x00000001898AE2F0
	public static void LoadData() {} // 0x0000000181E08880-0x0000000181E08970
	// [XID] // 0x00000001898B5850-0x00000001898B5870
	private static void RegisterHotfixGenerated() {} // 0x0000000181E086B0-0x0000000181E08880
	// [XID] // 0x00000001898BD2C0-0x00000001898BD2E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181E082F0-0x0000000181E086B0
	// [IDTag] // 0x00000001898C4A20-0x00000001898C4A60
	// [XID] // 0x00000001898C4A20-0x00000001898C4A60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181E08AB0-0x0000000181E08BB0
	// [XID] // 0x00000001898CF0D0-0x00000001898CF0F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReunionPrivilegeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181E094B0-0x0000000181E097E0
	// [XID] // 0x00000001898D6A60-0x00000001898D6A80
	private static bool ParseConfigFromLine(string line, out ReunionPrivilegeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181E08970-0x0000000181E08AB0
	// [IDTag] // 0x00000001898DE660-0x00000001898DE6A0
	// [XID] // 0x00000001898DE660-0x00000001898DE6A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReunionPrivilegeExcelConfig> configList) => default; // 0x0000000181E08BB0-0x0000000181E08E60
	// [IDTag] // 0x00000001898E90C0-0x00000001898E9100
	// [XID] // 0x00000001898E90C0-0x00000001898E9100
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F4D */, bool useObjectPool = false /* Metadata: 0x00AF2F51 */) => default; // 0x0000000181E091B0-0x0000000181E09400
	// [IDTag] // 0x00000001898F37C0-0x00000001898F3800
	// [XID] // 0x00000001898F37C0-0x00000001898F3800
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F52 */, bool useObjectPool = false /* Metadata: 0x00AF2F56 */) => default; // 0x0000000181E08E60-0x0000000181E091B0
}

