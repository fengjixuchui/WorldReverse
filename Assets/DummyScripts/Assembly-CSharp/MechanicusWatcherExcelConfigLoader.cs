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

public static class MechanicusWatcherExcelConfigLoader // TypeDefIndex: 14919
{
	// Fields
	private static List<MechanicusWatcherExcelConfig> configList; // 0x00
	private static Dictionary<uint, MechanicusWatcherExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MechanicusWatcherExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<MechanicusWatcherExcelConfig, MechanicusWatcherExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MechanicusWatcherExcelConfig>, Dictionary<uint, MechanicusWatcherExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, MechanicusWatcherExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AAD4C0-0x0000000189AAD4E0 */ get; } // 0x0000000185454CA0-0x0000000185454D50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ABCA40-0x0000000189ABCA60 */ get; } // 0x0000000185453850-0x00000001854538F0 

	// Methods
	// [XID] // 0x0000000189A8FA70-0x0000000189A8FA90
	private static void BuildData() {} // 0x00000001854538F0-0x0000000185453B90
	// [XID] // 0x0000000189A970E0-0x0000000189A97100
	public static List<MechanicusWatcherExcelConfig> GetChallengeDataList() => default; // 0x0000000185454D50-0x0000000185454E20
	// [XID] // 0x0000000189A9E490-0x0000000189A9E4B0
	public static uint GetTotalCoinCount() => default; // 0x00000001854535B0-0x0000000185453710
	// [XID] // 0x0000000189AA5DC0-0x0000000189AA5DE0
	public static void Register() {} // 0x0000000185455150-0x00000001854551F0
	// [XID] // 0x0000000189AB4DB0-0x0000000189AB4DD0
	public static MechanicusWatcherExcelConfig GetData(uint id) => default; // 0x0000000185453710-0x0000000185453850
	// [XID] // 0x0000000189AC43A0-0x0000000189AC43C0
	public static void LoadData() {} // 0x0000000185454120-0x0000000185454210
	// [XID] // 0x0000000189ACB910-0x0000000189ACB930
	private static void RegisterHotfixGenerated() {} // 0x0000000185453F50-0x0000000185454120
	// [XID] // 0x0000000189AD33C0-0x0000000189AD33E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185453B90-0x0000000185453F50
	// [IDTag] // 0x0000000189ADAE80-0x0000000189ADAEC0
	// [XID] // 0x0000000189ADAE80-0x0000000189ADAEC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185454600-0x0000000185454700
	// [XID] // 0x0000000189AE5B20-0x0000000189AE5B40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusWatcherExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185454E20-0x0000000185455150
	// [XID] // 0x0000000189AECFC0-0x0000000189AECFE0
	private static bool ParseConfigFromLine(string line, out MechanicusWatcherExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185454210-0x0000000185454350
	// [IDTag] // 0x0000000189AF48F0-0x0000000189AF4930
	// [XID] // 0x0000000189AF48F0-0x0000000189AF4930
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusWatcherExcelConfig> configList) => default; // 0x0000000185454350-0x0000000185454600
	// [IDTag] // 0x0000000189AFEFF0-0x0000000189AFF030
	// [XID] // 0x0000000189AFEFF0-0x0000000189AFF030
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9F1 */, bool useObjectPool = false /* Metadata: 0x00AEF9F5 */) => default; // 0x0000000185454A50-0x0000000185454CA0
	// [IDTag] // 0x0000000189B096B0-0x0000000189B096F0
	// [XID] // 0x0000000189B096B0-0x0000000189B096F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9F6 */, bool useObjectPool = false /* Metadata: 0x00AEF9FA */) => default; // 0x0000000185454700-0x0000000185454A50
}

