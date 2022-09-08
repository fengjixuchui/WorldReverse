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

public static class BattlePassRewardExcelConfigLoader // TypeDefIndex: 14839
{
	// Fields
	private static Dictionary<uint, List<BattlePassRewardExcelConfig>> _bpRewardListDic; // 0x00
	private static List<BattlePassRewardExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<BattlePassRewardExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<BattlePassRewardExcelConfig, BattlePassRewardExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<BattlePassRewardExcelConfig>, List<BattlePassRewardExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<BattlePassRewardExcelConfig> dataList { /* [XID] */ /* 0x000000018974E470-0x000000018974E490 */ get; } // 0x000000018511BBA0-0x000000018511BC70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189755AF0-0x0000000189755B10 */ get; } // 0x000000018511A610-0x000000018511A6B0 

	// Constructors
	static BattlePassRewardExcelConfigLoader() {} // 0x000000018511C400-0x000000018511C460

	// Methods
	// [XID] // 0x0000000189737BE0-0x0000000189737C00
	public static void BuildBPRewardDic() {} // 0x000000018511BFC0-0x000000018511C340
	// [XID] // 0x000000018973F760-0x000000018973F780
	public static List<BattlePassRewardExcelConfig> GetBPRewardListByIndexId(uint indexId) => default; // 0x000000018511A4E0-0x000000018511A610
	// [XID] // 0x0000000189746AC0-0x0000000189746AE0
	public static void Register() {} // 0x000000018511C340-0x000000018511C400
	// [XID] // 0x000000018975CDD0-0x000000018975CDF0
	public static void LoadData() {} // 0x000000018511AE70-0x000000018511AFA0
	// [XID] // 0x0000000189764640-0x0000000189764660
	private static void RegisterHotfixGenerated() {} // 0x000000018511AC00-0x000000018511AE70
	// [XID] // 0x000000018976BEE0-0x000000018976BF00
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018511A6B0-0x000000018511AC00
	// [IDTag] // 0x00000001897733C0-0x0000000189773400
	// [XID] // 0x00000001897733C0-0x0000000189773400
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018511B410-0x000000018511B570
	// [XID] // 0x000000018977DC40-0x000000018977DC60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BattlePassRewardExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018511BC70-0x000000018511BFC0
	// [XID] // 0x00000001897854A0-0x00000001897854C0
	private static bool ParseConfigFromLine(string line, out BattlePassRewardExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018511AFA0-0x000000018511B0E0
	// [IDTag] // 0x000000018978C910-0x000000018978C950
	// [XID] // 0x000000018978C910-0x000000018978C950
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BattlePassRewardExcelConfig> configList) => default; // 0x000000018511B0E0-0x000000018511B410
	// [IDTag] // 0x0000000189797150-0x0000000189797190
	// [XID] // 0x0000000189797150-0x0000000189797190
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF72E */, bool useObjectPool = false /* Metadata: 0x00AEF732 */) => default; // 0x000000018511B8F0-0x000000018511BBA0
	// [IDTag] // 0x00000001897A1E80-0x00000001897A1EC0
	// [XID] // 0x00000001897A1E80-0x00000001897A1EC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF733 */, bool useObjectPool = false /* Metadata: 0x00AEF737 */) => default; // 0x000000018511B570-0x000000018511B8F0
}

