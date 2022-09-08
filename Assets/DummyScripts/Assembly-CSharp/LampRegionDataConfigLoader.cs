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

public static class LampRegionDataConfigLoader // TypeDefIndex: 15181
{
	// Fields
	private static Dictionary<string, LampRegionDataConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LampRegionDataConfig>> customApplyHotfixAction; // 0x08
	public static Action<LampRegionDataConfig, LampRegionDataConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LampRegionDataConfig>, Dictionary<string, LampRegionDataConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, LampRegionDataConfig> dataDict { /* [XID] */ /* 0x00000001899BE790-0x00000001899BE7B0 */ get; } // 0x00000001825CF0D0-0x00000001825CF180 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899CD7B0-0x00000001899CD7D0 */ get; } // 0x00000001825CDF30-0x00000001825CDFD0 

	// Methods
	// [XID] // 0x00000001899B6CB0-0x00000001899B6CD0
	public static void Register() {} // 0x00000001825CF4B0-0x00000001825CF550
	// [XID] // 0x00000001899C5FB0-0x00000001899C5FD0
	public static LampRegionDataConfig GetData(string region) => default; // 0x00000001825CDDF0-0x00000001825CDF30
	// [XID] // 0x00000001899D4C50-0x00000001899D4C70
	public static void LoadData() {} // 0x00000001825CE560-0x00000001825CE650
	// [XID] // 0x00000001899DC2D0-0x00000001899DC2F0
	private static void RegisterHotfixGenerated() {} // 0x00000001825CE390-0x00000001825CE560
	// [XID] // 0x00000001899E3B30-0x00000001899E3B50
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001825CDFD0-0x00000001825CE390
	// [IDTag] // 0x00000001899EAFA0-0x00000001899EAFE0
	// [XID] // 0x00000001899EAFA0-0x00000001899EAFE0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001825CEA30-0x00000001825CEB30
	// [XID] // 0x00000001899F5A30-0x00000001899F5A50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LampRegionDataConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001825CF180-0x00000001825CF4B0
	// [XID] // 0x00000001899FD1B0-0x00000001899FD1D0
	private static bool ParseConfigFromLine(string line, out LampRegionDataConfig data) {
		data = default;
		return default;
	} // 0x00000001825CE650-0x00000001825CE790
	// [IDTag] // 0x0000000189A04710-0x0000000189A04750
	// [XID] // 0x0000000189A04710-0x0000000189A04750
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LampRegionDataConfig> configList) => default; // 0x00000001825CE790-0x00000001825CEA30
	// [IDTag] // 0x0000000189A0ECF0-0x0000000189A0ED30
	// [XID] // 0x0000000189A0ECF0-0x0000000189A0ED30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0317 */, bool useObjectPool = false /* Metadata: 0x00AF031B */) => default; // 0x00000001825CEB30-0x00000001825CED80
	// [IDTag] // 0x0000000189A19270-0x0000000189A192B0
	// [XID] // 0x0000000189A19270-0x0000000189A192B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF031C */, bool useObjectPool = false /* Metadata: 0x00AF0320 */) => default; // 0x00000001825CED80-0x00000001825CF0D0
}

