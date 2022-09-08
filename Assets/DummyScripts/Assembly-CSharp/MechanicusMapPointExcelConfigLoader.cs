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

public static class MechanicusMapPointExcelConfigLoader // TypeDefIndex: 16228
{
	// Fields
	private static Dictionary<uint, MechanicusMapPointExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusMapPointExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusMapPointExcelConfig, MechanicusMapPointExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusMapPointExcelConfig>, Dictionary<uint, MechanicusMapPointExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusMapPointExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AA1060-0x0000000189AA1080 */ get; } // 0x0000000182F6DEB0-0x0000000182F6DF60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AB03E0-0x0000000189AB0400 */ get; } // 0x0000000182F6CD00-0x0000000182F6CDA0 

	// Methods
	// [XID] // 0x0000000189A9A100-0x0000000189A9A120
	public static void Register() {} // 0x0000000182F6E290-0x0000000182F6E330
	// [XID] // 0x0000000189AA8800-0x0000000189AA8820
	public static MechanicusMapPointExcelConfig GetData(uint ID) => default; // 0x0000000182F6CBD0-0x0000000182F6CD00
	// [XID] // 0x0000000189AB7AA0-0x0000000189AB7AC0
	public static void LoadData() {} // 0x0000000182F6D330-0x0000000182F6D420
	// [XID] // 0x0000000189ABF4F0-0x0000000189ABF510
	private static void RegisterHotfixGenerated() {} // 0x0000000182F6D160-0x0000000182F6D330
	// [XID] // 0x0000000189AC6F80-0x0000000189AC6FA0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182F6CDA0-0x0000000182F6D160
	// [IDTag] // 0x0000000189ACE710-0x0000000189ACE750
	// [XID] // 0x0000000189ACE710-0x0000000189ACE750
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182F6D810-0x0000000182F6D910
	// [XID] // 0x0000000189AD9510-0x0000000189AD9530
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusMapPointExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182F6DF60-0x0000000182F6E290
	// [XID] // 0x0000000189AE1000-0x0000000189AE1020
	private static bool ParseConfigFromLine(string line, out MechanicusMapPointExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182F6D420-0x0000000182F6D560
	// [IDTag] // 0x0000000189AE83D0-0x0000000189AE8410
	// [XID] // 0x0000000189AE83D0-0x0000000189AE8410
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusMapPointExcelConfig> configList) => default; // 0x0000000182F6D560-0x0000000182F6D810
	// [IDTag] // 0x0000000189AF30B0-0x0000000189AF30F0
	// [XID] // 0x0000000189AF30B0-0x0000000189AF30F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF34E6 */, bool useObjectPool = false /* Metadata: 0x00AF34EA */) => default; // 0x0000000182F6D910-0x0000000182F6DB60
	// [IDTag] // 0x0000000189AFD590-0x0000000189AFD5D0
	// [XID] // 0x0000000189AFD590-0x0000000189AFD5D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34EB */, bool useObjectPool = false /* Metadata: 0x00AF34EF */) => default; // 0x0000000182F6DB60-0x0000000182F6DEB0
}

