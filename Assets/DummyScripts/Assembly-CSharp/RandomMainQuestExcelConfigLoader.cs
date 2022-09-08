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

public static class RandomMainQuestExcelConfigLoader // TypeDefIndex: 15989
{
	// Fields
	private static Dictionary<uint, RandomMainQuestExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandomMainQuestExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandomMainQuestExcelConfig, RandomMainQuestExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandomMainQuestExcelConfig>, Dictionary<uint, RandomMainQuestExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandomMainQuestExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AEB7F0-0x0000000189AEB810 */ get; } // 0x0000000182C08370-0x0000000182C08420 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AFAA00-0x0000000189AFAA20 */ get; } // 0x0000000182C071C0-0x0000000182C07260 

	// Methods
	// [XID] // 0x0000000189AE3F50-0x0000000189AE3F70
	public static void Register() {} // 0x0000000182C08750-0x0000000182C087F0
	// [XID] // 0x0000000189AF3170-0x0000000189AF3190
	public static RandomMainQuestExcelConfig GetData(uint id) => default; // 0x0000000182C07090-0x0000000182C071C0
	// [XID] // 0x0000000189B01FF0-0x0000000189B02010
	public static void LoadData() {} // 0x0000000182C077F0-0x0000000182C078E0
	// [XID] // 0x0000000189B094B0-0x0000000189B094D0
	private static void RegisterHotfixGenerated() {} // 0x0000000182C07620-0x0000000182C077F0
	// [XID] // 0x0000000189B10F90-0x0000000189B10FB0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182C07260-0x0000000182C07620
	// [IDTag] // 0x0000000189B18240-0x0000000189B18280
	// [XID] // 0x0000000189B18240-0x0000000189B18280
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182C07CD0-0x0000000182C07DD0
	// [XID] // 0x0000000189B22930-0x0000000189B22950
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandomMainQuestExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182C08420-0x0000000182C08750
	// [XID] // 0x0000000189B29E80-0x0000000189B29EA0
	private static bool ParseConfigFromLine(string line, out RandomMainQuestExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182C078E0-0x0000000182C07A20
	// [IDTag] // 0x0000000189B314F0-0x0000000189B31530
	// [XID] // 0x0000000189B314F0-0x0000000189B31530
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandomMainQuestExcelConfig> configList) => default; // 0x0000000182C07A20-0x0000000182C07CD0
	// [IDTag] // 0x0000000189B3BA70-0x0000000189B3BAB0
	// [XID] // 0x0000000189B3BA70-0x0000000189B3BAB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D15 */, bool useObjectPool = false /* Metadata: 0x00AF2D19 */) => default; // 0x0000000182C08120-0x0000000182C08370
	// [IDTag] // 0x0000000189B46580-0x0000000189B465C0
	// [XID] // 0x0000000189B46580-0x0000000189B465C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D1A */, bool useObjectPool = false /* Metadata: 0x00AF2D1E */) => default; // 0x0000000182C07DD0-0x0000000182C08120
}

