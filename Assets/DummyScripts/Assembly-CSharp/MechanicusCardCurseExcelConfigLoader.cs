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

public static class MechanicusCardCurseExcelConfigLoader // TypeDefIndex: 16226
{
	// Fields
	private static Dictionary<uint, MechanicusCardCurseExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusCardCurseExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusCardCurseExcelConfig, MechanicusCardCurseExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusCardCurseExcelConfig>, Dictionary<uint, MechanicusCardCurseExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusCardCurseExcelConfig> dataDict { /* [XID] */ /* 0x00000001899A04B0-0x00000001899A04D0 */ get; } // 0x0000000182D7ED20-0x0000000182D7EDD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899AF690-0x00000001899AF6B0 */ get; } // 0x0000000182D7DB70-0x0000000182D7DC10 

	// Methods
	// [XID] // 0x0000000189998B50-0x0000000189998B70
	public static void Register() {} // 0x0000000182D7F100-0x0000000182D7F1A0
	// [XID] // 0x00000001899A7FC0-0x00000001899A7FE0
	public static MechanicusCardCurseExcelConfig GetData(uint ID) => default; // 0x0000000182D7DA40-0x0000000182D7DB70
	// [XID] // 0x00000001899B6B70-0x00000001899B6B90
	public static void LoadData() {} // 0x0000000182D7E1A0-0x0000000182D7E290
	// [XID] // 0x00000001899BE670-0x00000001899BE690
	private static void RegisterHotfixGenerated() {} // 0x0000000182D7DFD0-0x0000000182D7E1A0
	// [XID] // 0x00000001899C5E70-0x00000001899C5E90
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D7DC10-0x0000000182D7DFD0
	// [IDTag] // 0x00000001899CD5B0-0x00000001899CD5F0
	// [XID] // 0x00000001899CD5B0-0x00000001899CD5F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D7E680-0x0000000182D7E780
	// [XID] // 0x00000001899D7A50-0x00000001899D7A70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusCardCurseExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D7EDD0-0x0000000182D7F100
	// [XID] // 0x00000001899DEF10-0x00000001899DEF30
	private static bool ParseConfigFromLine(string line, out MechanicusCardCurseExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D7E290-0x0000000182D7E3D0
	// [IDTag] // 0x00000001899E6B30-0x00000001899E6B70
	// [XID] // 0x00000001899E6B30-0x00000001899E6B70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusCardCurseExcelConfig> configList) => default; // 0x0000000182D7E3D0-0x0000000182D7E680
	// [IDTag] // 0x00000001899F0FD0-0x00000001899F1010
	// [XID] // 0x00000001899F0FD0-0x00000001899F1010
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF34D7 */, bool useObjectPool = false /* Metadata: 0x00AF34DB */) => default; // 0x0000000182D7EAD0-0x0000000182D7ED20
	// [IDTag] // 0x00000001899FBB90-0x00000001899FBBD0
	// [XID] // 0x00000001899FBB90-0x00000001899FBBD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34DC */, bool useObjectPool = false /* Metadata: 0x00AF34E0 */) => default; // 0x0000000182D7E780-0x0000000182D7EAD0
}

