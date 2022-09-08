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

public static class ReliquaryCodexExcelConfigLoader // TypeDefIndex: 15312
{
	// Fields
	private static Dictionary<uint, ReliquaryCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReliquaryCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReliquaryCodexExcelConfig, ReliquaryCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReliquaryCodexExcelConfig>, Dictionary<uint, ReliquaryCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ReliquaryCodexExcelConfig> dataDict { /* [XID] */ /* 0x0000000189765C90-0x0000000189765CB0 */ get; } // 0x0000000181E1BA10-0x0000000181E1BAC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189774870-0x0000000189774890 */ get; } // 0x0000000181E1A860-0x0000000181E1A900 

	// Methods
	// [XID] // 0x000000018975E610-0x000000018975E630
	public static void Register() {} // 0x0000000181E1BDF0-0x0000000181E1BE90
	// [XID] // 0x000000018976D420-0x000000018976D440
	public static ReliquaryCodexExcelConfig GetData(uint Id) => default; // 0x0000000181E1A730-0x0000000181E1A860
	// [XID] // 0x000000018977C280-0x000000018977C2A0
	public static void LoadData() {} // 0x0000000181E1AE90-0x0000000181E1AF80
	// [XID] // 0x0000000189783CD0-0x0000000189783CF0
	private static void RegisterHotfixGenerated() {} // 0x0000000181E1ACC0-0x0000000181E1AE90
	// [XID] // 0x000000018978B480-0x000000018978B4A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181E1A900-0x0000000181E1ACC0
	// [IDTag] // 0x00000001897928E0-0x0000000189792920
	// [XID] // 0x00000001897928E0-0x0000000189792920
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181E1B370-0x0000000181E1B470
	// [XID] // 0x000000018979DCB0-0x000000018979DCD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReliquaryCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181E1BAC0-0x0000000181E1BDF0
	// [XID] // 0x00000001897A4FD0-0x00000001897A4FF0
	private static bool ParseConfigFromLine(string line, out ReliquaryCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181E1AF80-0x0000000181E1B0C0
	// [IDTag] // 0x00000001897AC560-0x00000001897AC5A0
	// [XID] // 0x00000001897AC560-0x00000001897AC5A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReliquaryCodexExcelConfig> configList) => default; // 0x0000000181E1B0C0-0x0000000181E1B370
	// [IDTag] // 0x00000001897B7550-0x00000001897B7590
	// [XID] // 0x00000001897B7550-0x00000001897B7590
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0736 */, bool useObjectPool = false /* Metadata: 0x00AF073A */) => default; // 0x0000000181E1B7C0-0x0000000181E1BA10
	// [IDTag] // 0x00000001897C20B0-0x00000001897C20F0
	// [XID] // 0x00000001897C20B0-0x00000001897C20F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF073B */, bool useObjectPool = false /* Metadata: 0x00AF073F */) => default; // 0x0000000181E1B470-0x0000000181E1B7C0
}

