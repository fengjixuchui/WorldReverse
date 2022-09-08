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

public static class RewardExcelConfigLoader // TypeDefIndex: 14910
{
	// Fields
	private static Dictionary<uint, RewardExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RewardExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RewardExcelConfig, RewardExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RewardExcelConfig>, Dictionary<uint, RewardExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RewardExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AD5020-0x0000000189AD5040 */ get; } // 0x0000000183BC2420-0x0000000183BC24D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE70D0-0x0000000189AE70F0 */ get; } // 0x0000000183BC1270-0x0000000183BC1310 

	// Methods
	// [XID] // 0x0000000189AB3660-0x0000000189AB3680
	public static void BuildIndex() {} // 0x0000000183BC24D0-0x0000000183BC2560
	// [IDTag] // 0x0000000189ABB3F0-0x0000000189ABB430
	// [XID] // 0x0000000189ABB3F0-0x0000000189ABB430
	public static void GetData(uint id, ref List<RewardExcelConfig> rewards) {} // 0x0000000183BC1030-0x0000000183BC1270
	// [XID] // 0x0000000189AC5D30-0x0000000189AC5D50
	public static List<RewardItemConfig> GenerateFullItemList(RewardExcelConfig reward) => default; // 0x0000000183BC2890-0x0000000183BC2C90
	// [XID] // 0x0000000189ACD260-0x0000000189ACD280
	public static void Register() {} // 0x0000000183BC2C90-0x0000000183BC2D30
	// [IDTag] // 0x0000000189ADC860-0x0000000189ADC8A0
	// [XID] // 0x0000000189ADC860-0x0000000189ADC8A0
	public static RewardExcelConfig GetData(uint rewardId) => default; // 0x0000000183BC0F00-0x0000000183BC1030
	// [XID] // 0x0000000189AEED40-0x0000000189AEED60
	public static void LoadData() {} // 0x0000000183BC18A0-0x0000000183BC1990
	// [XID] // 0x0000000189AF6230-0x0000000189AF6250
	private static void RegisterHotfixGenerated() {} // 0x0000000183BC16D0-0x0000000183BC18A0
	// [XID] // 0x0000000189AFD8B0-0x0000000189AFD8D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183BC1310-0x0000000183BC16D0
	// [IDTag] // 0x0000000189B05080-0x0000000189B050C0
	// [XID] // 0x0000000189B05080-0x0000000189B050C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183BC1AD0-0x0000000183BC1BD0
	// [XID] // 0x0000000189B0F850-0x0000000189B0F870
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183BC2560-0x0000000183BC2890
	// [XID] // 0x0000000189B16A30-0x0000000189B16A50
	private static bool ParseConfigFromLine(string line, out RewardExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183BC1990-0x0000000183BC1AD0
	// [IDTag] // 0x0000000189B1E110-0x0000000189B1E150
	// [XID] // 0x0000000189B1E110-0x0000000189B1E150
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RewardExcelConfig> configList) => default; // 0x0000000183BC1BD0-0x0000000183BC1E80
	// [IDTag] // 0x0000000189B287F0-0x0000000189B28830
	// [XID] // 0x0000000189B287F0-0x0000000189B28830
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF9A6 */, bool useObjectPool = false /* Metadata: 0x00AEF9AA */) => default; // 0x0000000183BC21D0-0x0000000183BC2420
	// [IDTag] // 0x0000000189B32C40-0x0000000189B32C80
	// [XID] // 0x0000000189B32C40-0x0000000189B32C80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9AB */, bool useObjectPool = false /* Metadata: 0x00AEF9AF */) => default; // 0x0000000183BC1E80-0x0000000183BC21D0
}

