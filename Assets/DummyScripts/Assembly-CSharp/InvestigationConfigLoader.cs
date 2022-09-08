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

public static class InvestigationConfigLoader // TypeDefIndex: 15768
{
	// Fields
	private static Dictionary<uint, InvestigationConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<InvestigationConfig>> customApplyHotfixAction; // 0x08
	public static Action<InvestigationConfig, InvestigationConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<InvestigationConfig>, Dictionary<uint, InvestigationConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, InvestigationConfig> dataDict { /* [XID] */ /* 0x0000000189BBB710-0x0000000189BBB730 */ get; } // 0x0000000181770CC0-0x0000000181770D70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BCADB0-0x0000000189BCADD0 */ get; } // 0x000000018176FB10-0x000000018176FBB0 

	// Methods
	// [XID] // 0x0000000189BB4070-0x0000000189BB4090
	public static void Register() {} // 0x00000001817710A0-0x0000000181771140
	// [XID] // 0x0000000189BC3590-0x0000000189BC35B0
	public static InvestigationConfig GetData(uint id) => default; // 0x000000018176F9E0-0x000000018176FB10
	// [XID] // 0x0000000189BD23C0-0x0000000189BD23E0
	public static void LoadData() {} // 0x0000000181770140-0x0000000181770230
	// [XID] // 0x0000000189BD99A0-0x0000000189BD99C0
	private static void RegisterHotfixGenerated() {} // 0x000000018176FF70-0x0000000181770140
	// [XID] // 0x00000001895E63F0-0x00000001895E6410
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018176FBB0-0x000000018176FF70
	// [IDTag] // 0x00000001895EDE50-0x00000001895EDE90
	// [XID] // 0x00000001895EDE50-0x00000001895EDE90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181770370-0x0000000181770470
	// [XID] // 0x00000001895F8790-0x00000001895F87B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<InvestigationConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181770D70-0x00000001817710A0
	// [XID] // 0x00000001895FFC30-0x00000001895FFC50
	private static bool ParseConfigFromLine(string line, out InvestigationConfig data) {
		data = default;
		return default;
	} // 0x0000000181770230-0x0000000181770370
	// [IDTag] // 0x00000001896073C0-0x0000000189607400
	// [XID] // 0x00000001896073C0-0x0000000189607400
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<InvestigationConfig> configList) => default; // 0x0000000181770470-0x0000000181770720
	// [IDTag] // 0x0000000189611E00-0x0000000189611E40
	// [XID] // 0x0000000189611E00-0x0000000189611E40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2579 */, bool useObjectPool = false /* Metadata: 0x00AF257D */) => default; // 0x0000000181770A70-0x0000000181770CC0
	// [IDTag] // 0x000000018961C600-0x000000018961C640
	// [XID] // 0x000000018961C600-0x000000018961C640
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF257E */, bool useObjectPool = false /* Metadata: 0x00AF2582 */) => default; // 0x0000000181770720-0x0000000181770A70
}

