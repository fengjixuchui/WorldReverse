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

public static class NewActivityEntryConfigLoader // TypeDefIndex: 15895
{
	// Fields
	private static Dictionary<uint, NewActivityEntryConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityEntryConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityEntryConfig, NewActivityEntryConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityEntryConfig>, Dictionary<uint, NewActivityEntryConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityEntryConfig> dataDict { /* [XID] */ /* 0x0000000189AD4D80-0x0000000189AD4DA0 */ get; } // 0x000000018451EBC0-0x000000018451EC70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AE3FB0-0x0000000189AE3FD0 */ get; } // 0x000000018451DA10-0x000000018451DAB0 

	// Methods
	// [XID] // 0x0000000189ACD000-0x0000000189ACD020
	public static void Register() {} // 0x000000018451EFA0-0x000000018451F040
	// [XID] // 0x0000000189ADC660-0x0000000189ADC680
	public static NewActivityEntryConfig GetData(uint id) => default; // 0x000000018451D8E0-0x000000018451DA10
	// [XID] // 0x0000000189AEB890-0x0000000189AEB8B0
	public static void LoadData() {} // 0x000000018451E040-0x000000018451E130
	// [XID] // 0x0000000189AF31F0-0x0000000189AF3210
	private static void RegisterHotfixGenerated() {} // 0x000000018451DE70-0x000000018451E040
	// [XID] // 0x0000000189AFAA80-0x0000000189AFAAA0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018451DAB0-0x000000018451DE70
	// [IDTag] // 0x0000000189B02030-0x0000000189B02070
	// [XID] // 0x0000000189B02030-0x0000000189B02070
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018451E270-0x000000018451E370
	// [XID] // 0x0000000189B0C5D0-0x0000000189B0C5F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityEntryConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018451EC70-0x000000018451EFA0
	// [XID] // 0x0000000189B13AD0-0x0000000189B13AF0
	private static bool ParseConfigFromLine(string line, out NewActivityEntryConfig data) {
		data = default;
		return default;
	} // 0x000000018451E130-0x000000018451E270
	// [IDTag] // 0x0000000189B1B180-0x0000000189B1B1C0
	// [XID] // 0x0000000189B1B180-0x0000000189B1B1C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityEntryConfig> configList) => default; // 0x000000018451E370-0x000000018451E620
	// [IDTag] // 0x0000000189B25820-0x0000000189B25860
	// [XID] // 0x0000000189B25820-0x0000000189B25860
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2A7D */, bool useObjectPool = false /* Metadata: 0x00AF2A81 */) => default; // 0x000000018451E970-0x000000018451EBC0
	// [IDTag] // 0x0000000189B2F950-0x0000000189B2F990
	// [XID] // 0x0000000189B2F950-0x0000000189B2F990
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A82 */, bool useObjectPool = false /* Metadata: 0x00AF2A86 */) => default; // 0x000000018451E620-0x000000018451E970
}

