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

public static class WorldAreaConfigLoader // TypeDefIndex: 14925
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, WorldAreaConfig>> _areaIndex2Level1WorldArea; // 0x00
	private static Dictionary<uint, Dictionary<uint, WorldAreaConfig>> _areaIndex2Level2WorldArea; // 0x08
	private static Dictionary<uint, WorldAreaConfig> _dataDict; // 0x10
	public static Action<List<DataHotfixMeta>, List<WorldAreaConfig>> customApplyHotfixAction; // 0x18
	public static Action<WorldAreaConfig, WorldAreaConfig> onUpdateConfig; // 0x20
	public static Action onApplyHotfixFinish; // 0x28
	public static Func<List<DataHotfixMeta>, List<WorldAreaConfig>, Dictionary<uint, WorldAreaConfig>, string, bool> customValidateFunc; // 0x30

	// Properties
	public static Dictionary<uint, WorldAreaConfig> dataDict { /* [XID] */ /* 0x000000018982CA10-0x000000018982CA30 */ get; } // 0x00000001851BB640-0x00000001851BB710 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018983B360-0x000000018983B380 */ get; } // 0x00000001851B9DD0-0x00000001851B9E70 

	// Constructors
	static WorldAreaConfigLoader() {} // 0x00000001851BC140-0x00000001851BC200

	// Methods
	// [XID] // 0x0000000189807430-0x0000000189807450
	public static void BuildIndex() {} // 0x00000001851BB860-0x00000001851BBD30
	// [XID] // 0x000000018980EA10-0x000000018980EA30
	public static WorldAreaConfig GetAreaCfg(uint sceneID, uint greyLevel) => default; // 0x00000001851BA790-0x00000001851BA8E0
	// [XID] // 0x00000001898160D0-0x00000001898160F0
	public static WorldAreaConfig GetSubAreaCfg(uint areaID_1, uint greyLevel) => default; // 0x00000001851BB710-0x00000001851BB860
	// [XID] // 0x000000018981DB70-0x000000018981DB90
	public static WorldAreaConfig GetAreaCfgByID(uint sceneID, uint areaID) => default; // 0x00000001851BA350-0x00000001851BA520
	// [XID] // 0x0000000189824FA0-0x0000000189824FC0
	public static void Register() {} // 0x00000001851BC080-0x00000001851BC140
	// [XID] // 0x0000000189833F00-0x0000000189833F20
	public static WorldAreaConfig GetData(uint ID) => default; // 0x00000001851B9C30-0x00000001851B9DD0
	// [XID] // 0x0000000189842C80-0x0000000189842CA0
	public static void LoadData() {} // 0x00000001851BA8E0-0x00000001851BAA10
	// [XID] // 0x000000018984A090-0x000000018984A0B0
	private static void RegisterHotfixGenerated() {} // 0x00000001851BA520-0x00000001851BA790
	// [XID] // 0x0000000189851670-0x0000000189851690
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001851B9E70-0x00000001851BA350
	// [IDTag] // 0x0000000189858C60-0x0000000189858CA0
	// [XID] // 0x0000000189858C60-0x0000000189858CA0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001851BAEA0-0x00000001851BB000
	// [XID] // 0x0000000189863130-0x0000000189863150
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WorldAreaConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001851BBD30-0x00000001851BC080
	// [XID] // 0x000000018986A680-0x000000018986A6A0
	private static bool ParseConfigFromLine(string line, out WorldAreaConfig data) {
		data = default;
		return default;
	} // 0x00000001851BAA10-0x00000001851BAB50
	// [IDTag] // 0x0000000189871A70-0x0000000189871AB0
	// [XID] // 0x0000000189871A70-0x0000000189871AB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WorldAreaConfig> configList) => default; // 0x00000001851BAB50-0x00000001851BAEA0
	// [IDTag] // 0x000000018987C260-0x000000018987C2A0
	// [XID] // 0x000000018987C260-0x000000018987C2A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA2D */, bool useObjectPool = false /* Metadata: 0x00AEFA31 */) => default; // 0x00000001851BB000-0x00000001851BB2B0
	// [IDTag] // 0x0000000189886700-0x0000000189886740
	// [XID] // 0x0000000189886700-0x0000000189886740
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA32 */, bool useObjectPool = false /* Metadata: 0x00AEFA36 */) => default; // 0x00000001851BB2B0-0x00000001851BB640
}

