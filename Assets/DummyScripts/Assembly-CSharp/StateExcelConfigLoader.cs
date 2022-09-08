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

public static class StateExcelConfigLoader // TypeDefIndex: 14916
{
	// Fields
	private static Dictionary<AbilityState, StateExcelConfig> _dataDic; // 0x00
	private static List<StateExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<StateExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<StateExcelConfig, StateExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<StateExcelConfig>, List<StateExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<StateExcelConfig> dataList { /* [XID] */ /* 0x0000000189913540-0x0000000189913560 */ get; } // 0x00000001837B61E0-0x00000001837B62B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018991AD30-0x000000018991AD50 */ get; } // 0x00000001837B4C50-0x00000001837B4CF0 

	// Constructors
	static StateExcelConfigLoader() {} // 0x00000001837B68E0-0x00000001837B6970

	// Methods
	// [XID] // 0x00000001898FC990-0x00000001898FC9B0
	public static StateExcelConfig GetData(AbilityState state) => default; // 0x00000001837B4B40-0x00000001837B4C50
	// [XID] // 0x00000001899043D0-0x00000001899043F0
	public static void InitEnumeDic() {} // 0x00000001837B66C0-0x00000001837B68E0
	// [XID] // 0x000000018990BA10-0x000000018990BA30
	public static void Register() {} // 0x00000001837B6600-0x00000001837B66C0
	// [XID] // 0x00000001899224C0-0x00000001899224E0
	public static void LoadData() {} // 0x00000001837B54B0-0x00000001837B55E0
	// [XID] // 0x0000000189929C40-0x0000000189929C60
	private static void RegisterHotfixGenerated() {} // 0x00000001837B5240-0x00000001837B54B0
	// [XID] // 0x00000001899313A0-0x00000001899313C0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001837B4CF0-0x00000001837B5240
	// [IDTag] // 0x0000000189938890-0x00000001899388D0
	// [XID] // 0x0000000189938890-0x00000001899388D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837B5A50-0x00000001837B5BB0
	// [XID] // 0x0000000189942F30-0x0000000189942F50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<StateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001837B62B0-0x00000001837B6600
	// [XID] // 0x000000018994A6A0-0x000000018994A6C0
	private static bool ParseConfigFromLine(string line, out StateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001837B55E0-0x00000001837B5720
	// [IDTag] // 0x00000001899520D0-0x0000000189952110
	// [XID] // 0x00000001899520D0-0x0000000189952110
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<StateExcelConfig> configList) => default; // 0x00000001837B5720-0x00000001837B5A50
	// [IDTag] // 0x000000018995C600-0x000000018995C640
	// [XID] // 0x000000018995C600-0x000000018995C640
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9D3 */, bool useObjectPool = false /* Metadata: 0x00AEF9D7 */) => default; // 0x00000001837B5F30-0x00000001837B61E0
	// [IDTag] // 0x00000001899670D0-0x0000000189967110
	// [XID] // 0x00000001899670D0-0x0000000189967110
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9D8 */, bool useObjectPool = false /* Metadata: 0x00AEF9DC */) => default; // 0x00000001837B5BB0-0x00000001837B5F30
}

