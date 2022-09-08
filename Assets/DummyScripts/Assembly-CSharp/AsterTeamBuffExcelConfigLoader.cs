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

public static class AsterTeamBuffExcelConfigLoader // TypeDefIndex: 14833
{
	// Fields
	private static List<AsterTeamBuffExcelConfig> asterTeamBuffList; // 0x00
	private static Dictionary<uint, AsterTeamBuffExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<AsterTeamBuffExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<AsterTeamBuffExcelConfig, AsterTeamBuffExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<AsterTeamBuffExcelConfig>, Dictionary<uint, AsterTeamBuffExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, AsterTeamBuffExcelConfig> dataDict { /* [XID] */ /* 0x000000018979F1B0-0x000000018979F1D0 */ get; } // 0x0000000184955690-0x0000000184955760 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897ADE90-0x00000001897ADEB0 */ get; } // 0x0000000184953E50-0x0000000184953EF0 

	// Constructors
	static AsterTeamBuffExcelConfigLoader() {} // 0x0000000184955B70-0x0000000184955BD0

	// Methods
	// [XID] // 0x000000018978F960-0x000000018978F980
	public static List<AsterTeamBuffExcelConfig> GetAsterTeamBuffList(uint activityId) => default; // 0x00000001849548B0-0x0000000184954BA0
	// [XID] // 0x0000000189797190-0x00000001897971B0
	public static void Register() {} // 0x0000000184955AB0-0x0000000184955B70
	// [XID] // 0x00000001897A6840-0x00000001897A6860
	public static AsterTeamBuffExcelConfig GetData(uint id) => default; // 0x0000000184953CB0-0x0000000184953E50
	// [XID] // 0x00000001897B5F70-0x00000001897B5F90
	public static void LoadData() {} // 0x0000000184954640-0x0000000184954770
	// [XID] // 0x00000001897BDD80-0x00000001897BDDA0
	private static void RegisterHotfixGenerated() {} // 0x00000001849543D0-0x0000000184954640
	// [XID] // 0x00000001897C5140-0x00000001897C5160
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184953EF0-0x00000001849543D0
	// [IDTag] // 0x00000001897CC990-0x00000001897CC9D0
	// [XID] // 0x00000001897CC990-0x00000001897CC9D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184954BA0-0x0000000184954D00
	// [XID] // 0x00000001897D72C0-0x00000001897D72E0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterTeamBuffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184955760-0x0000000184955AB0
	// [XID] // 0x00000001897DE810-0x00000001897DE830
	private static bool ParseConfigFromLine(string line, out AsterTeamBuffExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184954770-0x00000001849548B0
	// [IDTag] // 0x00000001897E62F0-0x00000001897E6330
	// [XID] // 0x00000001897E62F0-0x00000001897E6330
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterTeamBuffExcelConfig> configList) => default; // 0x0000000184954D00-0x0000000184955050
	// [IDTag] // 0x00000001897F0E60-0x00000001897F0EA0
	// [XID] // 0x00000001897F0E60-0x00000001897F0EA0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6F7 */, bool useObjectPool = false /* Metadata: 0x00AEF6FB */) => default; // 0x0000000184955050-0x0000000184955300
	// [IDTag] // 0x00000001897FB8F0-0x00000001897FB930
	// [XID] // 0x00000001897FB8F0-0x00000001897FB930
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6FC */, bool useObjectPool = false /* Metadata: 0x00AEF700 */) => default; // 0x0000000184955300-0x0000000184955690
}

