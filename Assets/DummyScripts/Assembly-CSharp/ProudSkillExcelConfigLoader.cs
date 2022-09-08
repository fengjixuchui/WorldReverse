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

public static class ProudSkillExcelConfigLoader // TypeDefIndex: 14837
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, ProudSkillExcelConfig>> _skillGroupDic; // 0x00
	private static Dictionary<uint, ProudSkillExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<ProudSkillExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<ProudSkillExcelConfig, ProudSkillExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<ProudSkillExcelConfig>, Dictionary<uint, ProudSkillExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, ProudSkillExcelConfig> dataDict { /* [XID] */ /* 0x0000000189639030-0x0000000189639050 */ get; } // 0x000000018266CF40-0x000000018266D010 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189647C50-0x0000000189647C70 */ get; } // 0x000000018266B750-0x000000018266B7F0 

	// Constructors
	static ProudSkillExcelConfigLoader() {} // 0x000000018266D7E0-0x000000018266D840

	// Methods
	// [XID] // 0x000000018961AEE0-0x000000018961AF00
	public static void BuildSkillGroupDic() {} // 0x000000018266D360-0x000000018266D720
	// [XID] // 0x0000000189622420-0x0000000189622440
	public static ProudSkillExcelConfig GetSkillGroupConfig(uint groupId, uint skillLevel) => default; // 0x000000018266BE00-0x000000018266BF70
	// [XID] // 0x0000000189629E10-0x0000000189629E30
	public static Dictionary<uint, ProudSkillExcelConfig> GetSkillGroupConfigDic(uint groupId) => default; // 0x000000018266B7F0-0x000000018266B920
	// [XID] // 0x00000001896315A0-0x00000001896315C0
	public static void Register() {} // 0x000000018266D720-0x000000018266D7E0
	// [XID] // 0x00000001896403F0-0x0000000189640410
	public static ProudSkillExcelConfig GetData(uint proudSkillId) => default; // 0x000000018266B5B0-0x000000018266B750
	// [XID] // 0x000000018964F3A0-0x000000018964F3C0
	public static void LoadData() {} // 0x000000018266C1E0-0x000000018266C310
	// [XID] // 0x0000000189656D90-0x0000000189656DB0
	private static void RegisterHotfixGenerated() {} // 0x000000018266BF70-0x000000018266C1E0
	// [XID] // 0x000000018965E4B0-0x000000018965E4D0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018266B920-0x000000018266BE00
	// [IDTag] // 0x0000000189665B70-0x0000000189665BB0
	// [XID] // 0x0000000189665B70-0x0000000189665BB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018266C450-0x000000018266C5B0
	// [XID] // 0x00000001896708F0-0x0000000189670910
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProudSkillExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018266D010-0x000000018266D360
	// [XID] // 0x00000001896780D0-0x00000001896780F0
	private static bool ParseConfigFromLine(string line, out ProudSkillExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018266C310-0x000000018266C450
	// [IDTag] // 0x000000018967F920-0x000000018967F960
	// [XID] // 0x000000018967F920-0x000000018967F960
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProudSkillExcelConfig> configList) => default; // 0x000000018266C5B0-0x000000018266C900
	// [IDTag] // 0x000000018968A2F0-0x000000018968A330
	// [XID] // 0x000000018968A2F0-0x000000018968A330
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF71A */, bool useObjectPool = false /* Metadata: 0x00AEF71E */) => default; // 0x000000018266CC90-0x000000018266CF40
	// [IDTag] // 0x0000000189694D40-0x0000000189694D80
	// [XID] // 0x0000000189694D40-0x0000000189694D80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF71F */, bool useObjectPool = false /* Metadata: 0x00AEF723 */) => default; // 0x000000018266C900-0x000000018266CC90
}

