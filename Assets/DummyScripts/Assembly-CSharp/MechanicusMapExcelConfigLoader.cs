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

public static class MechanicusMapExcelConfigLoader // TypeDefIndex: 16217
{
	// Fields
	private static Dictionary<uint, MechanicusMapExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusMapExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusMapExcelConfig, MechanicusMapExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusMapExcelConfig>, Dictionary<uint, MechanicusMapExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusMapExcelConfig> dataDict { /* [XID] */ /* 0x0000000189936CF0-0x0000000189936D10 */ get; } // 0x0000000181B4F1E0-0x0000000181B4F290 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189945EE0-0x0000000189945F00 */ get; } // 0x0000000181B4E030-0x0000000181B4E0D0 

	// Methods
	// [XID] // 0x000000018992F860-0x000000018992F880
	public static void Register() {} // 0x0000000181B4F5C0-0x0000000181B4F660
	// [XID] // 0x000000018993E8F0-0x000000018993E910
	public static MechanicusMapExcelConfig GetData(uint mechanicusMapID) => default; // 0x0000000181B4DF00-0x0000000181B4E030
	// [XID] // 0x000000018994D430-0x000000018994D450
	public static void LoadData() {} // 0x0000000181B4E660-0x0000000181B4E750
	// [XID] // 0x0000000189954AC0-0x0000000189954AE0
	private static void RegisterHotfixGenerated() {} // 0x0000000181B4E490-0x0000000181B4E660
	// [XID] // 0x000000018995C2C0-0x000000018995C2E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181B4E0D0-0x0000000181B4E490
	// [IDTag] // 0x0000000189963D20-0x0000000189963D60
	// [XID] // 0x0000000189963D20-0x0000000189963D60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181B4EB40-0x0000000181B4EC40
	// [XID] // 0x000000018996E160-0x000000018996E180
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusMapExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181B4F290-0x0000000181B4F5C0
	// [XID] // 0x0000000189975D10-0x0000000189975D30
	private static bool ParseConfigFromLine(string line, out MechanicusMapExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181B4E750-0x0000000181B4E890
	// [IDTag] // 0x000000018997CE10-0x000000018997CE50
	// [XID] // 0x000000018997CE10-0x000000018997CE50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusMapExcelConfig> configList) => default; // 0x0000000181B4E890-0x0000000181B4EB40
	// [IDTag] // 0x0000000189987B90-0x0000000189987BD0
	// [XID] // 0x0000000189987B90-0x0000000189987BD0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF349B */, bool useObjectPool = false /* Metadata: 0x00AF349F */) => default; // 0x0000000181B4EC40-0x0000000181B4EE90
	// [IDTag] // 0x0000000189992870-0x00000001899928B0
	// [XID] // 0x0000000189992870-0x00000001899928B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34A0 */, bool useObjectPool = false /* Metadata: 0x00AF34A4 */) => default; // 0x0000000181B4EE90-0x0000000181B4F1E0
}

