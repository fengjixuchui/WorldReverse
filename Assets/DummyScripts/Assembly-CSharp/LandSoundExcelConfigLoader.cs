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

public static class LandSoundExcelConfigLoader // TypeDefIndex: 15644
{
	// Fields
	private static Dictionary<uint, LandSoundExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LandSoundExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LandSoundExcelConfig, LandSoundExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LandSoundExcelConfig>, Dictionary<uint, LandSoundExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, LandSoundExcelConfig> dataDict { /* [XID] */ /* 0x0000000189822230-0x0000000189822250 */ get; } // 0x000000018212A330-0x000000018212A3E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189830D40-0x0000000189830D60 */ get; } // 0x0000000182129180-0x0000000182129220 

	// Methods
	// [XID] // 0x000000018981AA20-0x000000018981AA40
	public static void Register() {} // 0x000000018212A710-0x000000018212A7B0
	// [XID] // 0x0000000189A8E6D0-0x0000000189A8E6F0
	public static LandSoundExcelConfig GetData(uint id) => default; // 0x0000000182129050-0x0000000182129180
	// [XID] // 0x0000000189838480-0x00000001898384A0
	public static void LoadData() {} // 0x00000001821297B0-0x00000001821298A0
	// [XID] // 0x000000018983FA90-0x000000018983FAB0
	private static void RegisterHotfixGenerated() {} // 0x00000001821295E0-0x00000001821297B0
	// [XID] // 0x0000000189847110-0x0000000189847130
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182129220-0x00000001821295E0
	// [IDTag] // 0x000000018984E760-0x000000018984E7A0
	// [XID] // 0x000000018984E760-0x000000018984E7A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001821299E0-0x0000000182129AE0
	// [XID] // 0x0000000189858B60-0x0000000189858B80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LandSoundExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018212A3E0-0x000000018212A710
	// [XID] // 0x000000018985FCD0-0x000000018985FCF0
	private static bool ParseConfigFromLine(string line, out LandSoundExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001821298A0-0x00000001821299E0
	// [IDTag] // 0x0000000189867390-0x00000001898673D0
	// [XID] // 0x0000000189867390-0x00000001898673D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LandSoundExcelConfig> configList) => default; // 0x0000000182129AE0-0x0000000182129D90
	// [IDTag] // 0x0000000189871910-0x0000000189871950
	// [XID] // 0x0000000189871910-0x0000000189871950
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2184 */, bool useObjectPool = false /* Metadata: 0x00AF2188 */) => default; // 0x000000018212A0E0-0x000000018212A330
	// [IDTag] // 0x000000018987C0C0-0x000000018987C100
	// [XID] // 0x000000018987C0C0-0x000000018987C100
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2189 */, bool useObjectPool = false /* Metadata: 0x00AF218D */) => default; // 0x0000000182129D90-0x000000018212A0E0
}

