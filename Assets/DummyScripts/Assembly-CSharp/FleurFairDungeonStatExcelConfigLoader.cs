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

public static class FleurFairDungeonStatExcelConfigLoader // TypeDefIndex: 15108
{
	// Fields
	private static Dictionary<uint, FleurFairDungeonStatExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairDungeonStatExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairDungeonStatExcelConfig, FleurFairDungeonStatExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairDungeonStatExcelConfig>, Dictionary<uint, FleurFairDungeonStatExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairDungeonStatExcelConfig> dataDict { /* [XID] */ /* 0x00000001895FCD10-0x00000001895FCD30 */ get; } // 0x0000000184557380-0x0000000184557430 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018960C000-0x000000018960C020 */ get; } // 0x00000001845561D0-0x0000000184556270 

	// Methods
	// [XID] // 0x00000001895F57B0-0x00000001895F57D0
	public static void Register() {} // 0x0000000184557760-0x0000000184557800
	// [XID] // 0x00000001896046F0-0x0000000189604710
	public static FleurFairDungeonStatExcelConfig GetData(uint id) => default; // 0x00000001845560A0-0x00000001845561D0
	// [XID] // 0x0000000189613540-0x0000000189613560
	public static void LoadData() {} // 0x0000000184556800-0x00000001845568F0
	// [XID] // 0x000000018961AE00-0x000000018961AE20
	private static void RegisterHotfixGenerated() {} // 0x0000000184556630-0x0000000184556800
	// [XID] // 0x0000000189622360-0x0000000189622380
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184556270-0x0000000184556630
	// [IDTag] // 0x0000000189629D10-0x0000000189629D50
	// [XID] // 0x0000000189629D10-0x0000000189629D50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184556A30-0x0000000184556B30
	// [XID] // 0x00000001896347D0-0x00000001896347F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairDungeonStatExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184557430-0x0000000184557760
	// [XID] // 0x000000018963BF00-0x000000018963BF20
	private static bool ParseConfigFromLine(string line, out FleurFairDungeonStatExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001845568F0-0x0000000184556A30
	// [IDTag] // 0x00000001896435E0-0x0000000189643620
	// [XID] // 0x00000001896435E0-0x0000000189643620
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairDungeonStatExcelConfig> configList) => default; // 0x0000000184556B30-0x0000000184556DE0
	// [IDTag] // 0x000000018964DBE0-0x000000018964DC20
	// [XID] // 0x000000018964DBE0-0x000000018964DC20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0107 */, bool useObjectPool = false /* Metadata: 0x00AF010B */) => default; // 0x0000000184557130-0x0000000184557380
	// [IDTag] // 0x00000001896583F0-0x0000000189658430
	// [XID] // 0x00000001896583F0-0x0000000189658430
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF010C */, bool useObjectPool = false /* Metadata: 0x00AF0110 */) => default; // 0x0000000184556DE0-0x0000000184557130
}

