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

public static class ReunionScheduleExcelConfigLoader // TypeDefIndex: 16055
{
	// Fields
	private static Dictionary<uint, ReunionScheduleExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReunionScheduleExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReunionScheduleExcelConfig, ReunionScheduleExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReunionScheduleExcelConfig>, Dictionary<uint, ReunionScheduleExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReunionScheduleExcelConfig> dataDict { /* [XID] */ /* 0x00000001899F8850-0x00000001899F8870 */ get; } // 0x0000000181A971E0-0x0000000181A97290 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A07730-0x0000000189A07750 */ get; } // 0x0000000181A96030-0x0000000181A960D0 

	// Methods
	// [XID] // 0x00000001899F1050-0x00000001899F1070
	public static void Register() {} // 0x0000000181A975C0-0x0000000181A97660
	// [XID] // 0x00000001899FFE60-0x00000001899FFE80
	public static ReunionScheduleExcelConfig GetData(uint id) => default; // 0x0000000181A95F00-0x0000000181A96030
	// [XID] // 0x0000000189A0EB90-0x0000000189A0EBB0
	public static void LoadData() {} // 0x0000000181A96660-0x0000000181A96750
	// [XID] // 0x0000000189A16380-0x0000000189A163A0
	private static void RegisterHotfixGenerated() {} // 0x0000000181A96490-0x0000000181A96660
	// [XID] // 0x0000000189A1D920-0x0000000189A1D940
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181A960D0-0x0000000181A96490
	// [IDTag] // 0x0000000189A24D30-0x0000000189A24D70
	// [XID] // 0x0000000189A24D30-0x0000000189A24D70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181A96890-0x0000000181A96990
	// [XID] // 0x0000000189A2F350-0x0000000189A2F370
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReunionScheduleExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181A97290-0x0000000181A975C0
	// [XID] // 0x0000000189A36DD0-0x0000000189A36DF0
	private static bool ParseConfigFromLine(string line, out ReunionScheduleExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181A96750-0x0000000181A96890
	// [IDTag] // 0x0000000189A3E3D0-0x0000000189A3E410
	// [XID] // 0x0000000189A3E3D0-0x0000000189A3E410
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReunionScheduleExcelConfig> configList) => default; // 0x0000000181A96990-0x0000000181A96C40
	// [IDTag] // 0x0000000189A489F0-0x0000000189A48A30
	// [XID] // 0x0000000189A489F0-0x0000000189A48A30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F0C */, bool useObjectPool = false /* Metadata: 0x00AF2F10 */) => default; // 0x0000000181A96C40-0x0000000181A96E90
	// [IDTag] // 0x0000000189A53060-0x0000000189A530A0
	// [XID] // 0x0000000189A53060-0x0000000189A530A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F11 */, bool useObjectPool = false /* Metadata: 0x00AF2F15 */) => default; // 0x0000000181A96E90-0x0000000181A971E0
}

