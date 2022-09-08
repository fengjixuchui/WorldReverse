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

public static class PlayerLevelLockExcelConfigLoader // TypeDefIndex: 15953
{
	// Fields
	private static Dictionary<uint, PlayerLevelLockExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PlayerLevelLockExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PlayerLevelLockExcelConfig, PlayerLevelLockExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PlayerLevelLockExcelConfig>, Dictionary<uint, PlayerLevelLockExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PlayerLevelLockExcelConfig> dataDict { /* [XID] */ /* 0x000000018976A2F0-0x000000018976A310 */ get; } // 0x00000001823A9440-0x00000001823A94F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897792E0-0x0000000189779300 */ get; } // 0x00000001823A8290-0x00000001823A8330 

	// Methods
	// [XID] // 0x0000000189762CF0-0x0000000189762D10
	public static void Register() {} // 0x00000001823A9820-0x00000001823A98C0
	// [XID] // 0x0000000189771B30-0x0000000189771B50
	public static PlayerLevelLockExcelConfig GetData(uint worldLevel) => default; // 0x00000001823A8160-0x00000001823A8290
	// [XID] // 0x0000000189780AE0-0x0000000189780B00
	public static void LoadData() {} // 0x00000001823A88C0-0x00000001823A89B0
	// [XID] // 0x0000000189788120-0x0000000189788140
	private static void RegisterHotfixGenerated() {} // 0x00000001823A86F0-0x00000001823A88C0
	// [XID] // 0x000000018978F6E0-0x000000018978F700
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823A8330-0x00000001823A86F0
	// [IDTag] // 0x0000000189796EF0-0x0000000189796F30
	// [XID] // 0x0000000189796EF0-0x0000000189796F30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823A8AF0-0x00000001823A8BF0
	// [XID] // 0x00000001897A1CA0-0x00000001897A1CC0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PlayerLevelLockExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823A94F0-0x00000001823A9820
	// [XID] // 0x00000001897A94C0-0x00000001897A94E0
	private static bool ParseConfigFromLine(string line, out PlayerLevelLockExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001823A89B0-0x00000001823A8AF0
	// [IDTag] // 0x00000001897B0C20-0x00000001897B0C60
	// [XID] // 0x00000001897B0C20-0x00000001897B0C60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PlayerLevelLockExcelConfig> configList) => default; // 0x00000001823A8BF0-0x00000001823A8EA0
	// [IDTag] // 0x00000001897BC090-0x00000001897BC0D0
	// [XID] // 0x00000001897BC090-0x00000001897BC0D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C1A */, bool useObjectPool = false /* Metadata: 0x00AF2C1E */) => default; // 0x00000001823A8EA0-0x00000001823A90F0
	// [IDTag] // 0x00000001897C6960-0x00000001897C69A0
	// [XID] // 0x00000001897C6960-0x00000001897C69A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C1F */, bool useObjectPool = false /* Metadata: 0x00AF2C23 */) => default; // 0x00000001823A90F0-0x00000001823A9440
}

