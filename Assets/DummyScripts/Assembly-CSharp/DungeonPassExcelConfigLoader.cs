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

public static class DungeonPassExcelConfigLoader // TypeDefIndex: 15550
{
	// Fields
	private static Dictionary<uint, DungeonPassExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DungeonPassExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DungeonPassExcelConfig, DungeonPassExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DungeonPassExcelConfig>, Dictionary<uint, DungeonPassExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DungeonPassExcelConfig> dataDict { /* [XID] */ /* 0x0000000189926BE0-0x0000000189926C00 */ get; } // 0x0000000182DAF440-0x0000000182DAF4F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899356F0-0x0000000189935710 */ get; } // 0x0000000182DAE290-0x0000000182DAE330 

	// Methods
	// [XID] // 0x000000018991F180-0x000000018991F1A0
	public static void Register() {} // 0x0000000182DAF820-0x0000000182DAF8C0
	// [XID] // 0x000000018992E3D0-0x000000018992E3F0
	public static DungeonPassExcelConfig GetData(uint id) => default; // 0x0000000182DAE160-0x0000000182DAE290
	// [XID] // 0x000000018993D1D0-0x000000018993D1F0
	public static void LoadData() {} // 0x0000000182DAE8C0-0x0000000182DAE9B0
	// [XID] // 0x0000000189944920-0x0000000189944940
	private static void RegisterHotfixGenerated() {} // 0x0000000182DAE6F0-0x0000000182DAE8C0
	// [XID] // 0x000000018994BE80-0x000000018994BEA0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182DAE330-0x0000000182DAE6F0
	// [IDTag] // 0x0000000189953550-0x0000000189953590
	// [XID] // 0x0000000189953550-0x0000000189953590
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182DAEAF0-0x0000000182DAEBF0
	// [XID] // 0x000000018995DE70-0x000000018995DE90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DungeonPassExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182DAF4F0-0x0000000182DAF820
	// [XID] // 0x00000001899656B0-0x00000001899656D0
	private static bool ParseConfigFromLine(string line, out DungeonPassExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182DAE9B0-0x0000000182DAEAF0
	// [IDTag] // 0x000000018996CD50-0x000000018996CD90
	// [XID] // 0x000000018996CD50-0x000000018996CD90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DungeonPassExcelConfig> configList) => default; // 0x0000000182DAEBF0-0x0000000182DAEEA0
	// [IDTag] // 0x0000000189977860-0x00000001899778A0
	// [XID] // 0x0000000189977860-0x00000001899778A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1ED0 */, bool useObjectPool = false /* Metadata: 0x00AF1ED4 */) => default; // 0x0000000182DAEEA0-0x0000000182DAF0F0
	// [IDTag] // 0x0000000189982120-0x0000000189982160
	// [XID] // 0x0000000189982120-0x0000000189982160
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1ED5 */, bool useObjectPool = false /* Metadata: 0x00AF1ED9 */) => default; // 0x0000000182DAF0F0-0x0000000182DAF440
}

