/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RandomQuestExcelConfigLoader // TypeDefIndex: 15991
{
	// Fields
	private static Dictionary<uint, RandomQuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandomQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandomQuestExcelConfig, RandomQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandomQuestExcelConfig>, Dictionary<uint, RandomQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandomQuestExcelConfig> dataDict { /* [XID] */ /* 0x000000018978DF90-0x000000018978DFB0 */ get; } // 0x00000001843C1000-0x00000001843C10B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018979DAF0-0x000000018979DB10 */ get; } // 0x00000001843BFE50-0x00000001843BFEF0 

	// Methods
	// [XID] // 0x0000000189786940-0x0000000189786960
	public static void Register() {} // 0x00000001843C13E0-0x00000001843C1480
	// [XID] // 0x0000000189795680-0x00000001897956A0
	public static RandomQuestExcelConfig GetData(uint subId) => default; // 0x00000001843BFD20-0x00000001843BFE50
	// [XID] // 0x00000001897A4E50-0x00000001897A4E70
	public static void LoadData() {} // 0x00000001843C0480-0x00000001843C0570
	// [XID] // 0x00000001897AC3E0-0x00000001897AC400
	private static void RegisterHotfixGenerated() {} // 0x00000001843C02B0-0x00000001843C0480
	// [XID] // 0x00000001897B4350-0x00000001897B4370
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843BFEF0-0x00000001843C02B0
	// [IDTag] // 0x00000001897BC010-0x00000001897BC050
	// [XID] // 0x00000001897BC010-0x00000001897BC050
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001843C06B0-0x00000001843C07B0
	// [XID] // 0x00000001897C6940-0x00000001897C6960
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandomQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001843C10B0-0x00000001843C13E0
	// [XID] // 0x00000001897CE100-0x00000001897CE120
	private static bool ParseConfigFromLine(string line, out RandomQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001843C0570-0x00000001843C06B0
	// [IDTag] // 0x00000001897D5690-0x00000001897D56D0
	// [XID] // 0x00000001897D5690-0x00000001897D56D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandomQuestExcelConfig> configList) => default; // 0x00000001843C07B0-0x00000001843C0A60
	// [IDTag] // 0x00000001897DFF70-0x00000001897DFFB0
	// [XID] // 0x00000001897DFF70-0x00000001897DFFB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D24 */, bool useObjectPool = false /* Metadata: 0x00AF2D28 */) => default; // 0x00000001843C0DB0-0x00000001843C1000
	// [IDTag] // 0x00000001897EA7A0-0x00000001897EA7E0
	// [XID] // 0x00000001897EA7A0-0x00000001897EA7E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D29 */, bool useObjectPool = false /* Metadata: 0x00AF2D2D */) => default; // 0x00000001843C0A60-0x00000001843C0DB0
}

