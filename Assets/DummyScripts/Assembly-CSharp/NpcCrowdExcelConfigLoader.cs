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

public static class NpcCrowdExcelConfigLoader // TypeDefIndex: 15908
{
	// Fields
	private static Dictionary<uint, NpcCrowdExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NpcCrowdExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NpcCrowdExcelConfig, NpcCrowdExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NpcCrowdExcelConfig>, Dictionary<uint, NpcCrowdExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NpcCrowdExcelConfig> dataDict { /* [XID] */ /* 0x00000001895EAFB0-0x00000001895EAFD0 */ get; } // 0x0000000181CFF630-0x0000000181CFF6E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895F9DA0-0x00000001895F9DC0 */ get; } // 0x0000000181CFE480-0x0000000181CFE520 

	// Methods
	// [XID] // 0x0000000189BDE440-0x0000000189BDE460
	public static void Register() {} // 0x0000000181CFFA10-0x0000000181CFFAB0
	// [XID] // 0x00000001895F23D0-0x00000001895F23F0
	public static NpcCrowdExcelConfig GetData(uint id) => default; // 0x0000000181CFE350-0x0000000181CFE480
	// [XID] // 0x00000001896015E0-0x0000000189601600
	public static void LoadData() {} // 0x0000000181CFEAB0-0x0000000181CFEBA0
	// [XID] // 0x0000000189608E90-0x0000000189608EB0
	private static void RegisterHotfixGenerated() {} // 0x0000000181CFE8E0-0x0000000181CFEAB0
	// [XID] // 0x0000000189610690-0x00000001896106B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181CFE520-0x0000000181CFE8E0
	// [IDTag] // 0x0000000189617990-0x00000001896179D0
	// [XID] // 0x0000000189617990-0x00000001896179D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181CFEF90-0x0000000181CFF090
	// [XID] // 0x0000000189622240-0x0000000189622260
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NpcCrowdExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181CFF6E0-0x0000000181CFFA10
	// [XID] // 0x0000000189629B90-0x0000000189629BB0
	private static bool ParseConfigFromLine(string line, out NpcCrowdExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181CFEBA0-0x0000000181CFECE0
	// [IDTag] // 0x00000001896313E0-0x0000000189631420
	// [XID] // 0x00000001896313E0-0x0000000189631420
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NpcCrowdExcelConfig> configList) => default; // 0x0000000181CFECE0-0x0000000181CFEF90
	// [IDTag] // 0x000000018963BD00-0x000000018963BD40
	// [XID] // 0x000000018963BD00-0x000000018963BD40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2ADC */, bool useObjectPool = false /* Metadata: 0x00AF2AE0 */) => default; // 0x0000000181CFF3E0-0x0000000181CFF630
	// [IDTag] // 0x00000001896462E0-0x0000000189646320
	// [XID] // 0x00000001896462E0-0x0000000189646320
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AE1 */, bool useObjectPool = false /* Metadata: 0x00AF2AE5 */) => default; // 0x0000000181CFF090-0x0000000181CFF3E0
}

