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

public static class EffigyChallengeExcelConfigLoader // TypeDefIndex: 15076
{
	// Fields
	private static Dictionary<uint, EffigyChallengeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<EffigyChallengeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<EffigyChallengeExcelConfig, EffigyChallengeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<EffigyChallengeExcelConfig>, Dictionary<uint, EffigyChallengeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, EffigyChallengeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B96870-0x0000000189B96890 */ get; } // 0x0000000182D439F0-0x0000000182D43AA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BA5710-0x0000000189BA5730 */ get; } // 0x0000000182D42840-0x0000000182D428E0 

	// Methods
	// [XID] // 0x0000000189B8F450-0x0000000189B8F470
	public static void Register() {} // 0x0000000182D43DD0-0x0000000182D43E70
	// [XID] // 0x0000000189B9DDC0-0x0000000189B9DDE0
	public static EffigyChallengeExcelConfig GetData(uint id) => default; // 0x0000000182D42710-0x0000000182D42840
	// [XID] // 0x0000000189BAC970-0x0000000189BAC990
	public static void LoadData() {} // 0x0000000182D42E70-0x0000000182D42F60
	// [XID] // 0x0000000189BB4210-0x0000000189BB4230
	private static void RegisterHotfixGenerated() {} // 0x0000000182D42CA0-0x0000000182D42E70
	// [XID] // 0x0000000189BBB870-0x0000000189BBB890
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D428E0-0x0000000182D42CA0
	// [IDTag] // 0x0000000189BC36D0-0x0000000189BC3710
	// [XID] // 0x0000000189BC36D0-0x0000000189BC3710
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D43350-0x0000000182D43450
	// [XID] // 0x0000000189BCDE60-0x0000000189BCDE80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EffigyChallengeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D43AA0-0x0000000182D43DD0
	// [XID] // 0x0000000189BD5330-0x0000000189BD5350
	private static bool ParseConfigFromLine(string line, out EffigyChallengeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182D42F60-0x0000000182D430A0
	// [IDTag] // 0x0000000189BDCEA0-0x0000000189BDCEE0
	// [XID] // 0x0000000189BDCEA0-0x0000000189BDCEE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EffigyChallengeExcelConfig> configList) => default; // 0x0000000182D430A0-0x0000000182D43350
	// [IDTag] // 0x00000001895EC810-0x00000001895EC850
	// [XID] // 0x00000001895EC810-0x00000001895EC850
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0021 */, bool useObjectPool = false /* Metadata: 0x00AF0025 */) => default; // 0x0000000182D437A0-0x0000000182D439F0
	// [IDTag] // 0x00000001895F7100-0x00000001895F7140
	// [XID] // 0x00000001895F7100-0x00000001895F7140
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0026 */, bool useObjectPool = false /* Metadata: 0x00AF002A */) => default; // 0x0000000182D43450-0x0000000182D437A0
}

