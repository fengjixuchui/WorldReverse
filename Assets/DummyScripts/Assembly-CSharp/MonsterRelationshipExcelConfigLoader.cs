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

public static class MonsterRelationshipExcelConfigLoader // TypeDefIndex: 15846
{
	// Fields
	private static Dictionary<uint, MonsterRelationshipExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterRelationshipExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterRelationshipExcelConfig, MonsterRelationshipExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterRelationshipExcelConfig>, Dictionary<uint, MonsterRelationshipExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterRelationshipExcelConfig> dataDict { /* [XID] */ /* 0x0000000189AFEE90-0x0000000189AFEEB0 */ get; } // 0x0000000184EA3E60-0x0000000184EA3F10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B0DE30-0x0000000189B0DE50 */ get; } // 0x0000000184EA2CB0-0x0000000184EA2D50 

	// Methods
	// [XID] // 0x0000000189AF78A0-0x0000000189AF78C0
	public static void Register() {} // 0x0000000184EA4240-0x0000000184EA42E0
	// [XID] // 0x0000000189B06700-0x0000000189B06720
	public static MonsterRelationshipExcelConfig GetData(uint id) => default; // 0x0000000184EA2B80-0x0000000184EA2CB0
	// [XID] // 0x0000000189B15190-0x0000000189B151B0
	public static void LoadData() {} // 0x0000000184EA32E0-0x0000000184EA33D0
	// [XID] // 0x0000000189B1CC10-0x0000000189B1CC30
	private static void RegisterHotfixGenerated() {} // 0x0000000184EA3110-0x0000000184EA32E0
	// [XID] // 0x0000000189B241A0-0x0000000189B241C0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184EA2D50-0x0000000184EA3110
	// [IDTag] // 0x0000000189B2B550-0x0000000189B2B590
	// [XID] // 0x0000000189B2B550-0x0000000189B2B590
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184EA3510-0x0000000184EA3610
	// [XID] // 0x0000000189B357A0-0x0000000189B357C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterRelationshipExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184EA3F10-0x0000000184EA4240
	// [XID] // 0x0000000189B3CFA0-0x0000000189B3CFC0
	private static bool ParseConfigFromLine(string line, out MonsterRelationshipExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184EA33D0-0x0000000184EA3510
	// [IDTag] // 0x0000000189B44DB0-0x0000000189B44DF0
	// [XID] // 0x0000000189B44DB0-0x0000000189B44DF0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterRelationshipExcelConfig> configList) => default; // 0x0000000184EA3610-0x0000000184EA38C0
	// [IDTag] // 0x0000000189B4F4F0-0x0000000189B4F530
	// [XID] // 0x0000000189B4F4F0-0x0000000189B4F530
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2836 */, bool useObjectPool = false /* Metadata: 0x00AF283A */) => default; // 0x0000000184EA3C10-0x0000000184EA3E60
	// [IDTag] // 0x0000000189B59CE0-0x0000000189B59D20
	// [XID] // 0x0000000189B59CE0-0x0000000189B59D20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF283B */, bool useObjectPool = false /* Metadata: 0x00AF283F */) => default; // 0x0000000184EA38C0-0x0000000184EA3C10
}

