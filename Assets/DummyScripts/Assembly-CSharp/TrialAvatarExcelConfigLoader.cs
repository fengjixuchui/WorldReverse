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

public static class TrialAvatarExcelConfigLoader // TypeDefIndex: 16241
{
	// Fields
	private static Dictionary<uint, TrialAvatarExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TrialAvatarExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TrialAvatarExcelConfig, TrialAvatarExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TrialAvatarExcelConfig>, Dictionary<uint, TrialAvatarExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TrialAvatarExcelConfig> dataDict { /* [XID] */ /* 0x00000001899B1090-0x00000001899B10B0 */ get; } // 0x0000000182725450-0x0000000182725500 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899BFD50-0x00000001899BFD70 */ get; } // 0x00000001827242A0-0x0000000182724340 

	// Methods
	// [XID] // 0x00000001899A95C0-0x00000001899A95E0
	public static void Register() {} // 0x0000000182725830-0x00000001827258D0
	// [XID] // 0x00000001899B8270-0x00000001899B8290
	public static TrialAvatarExcelConfig GetData(uint trialAvatarId) => default; // 0x0000000182724170-0x00000001827242A0
	// [XID] // 0x00000001899C75B0-0x00000001899C75D0
	public static void LoadData() {} // 0x00000001827248D0-0x00000001827249C0
	// [XID] // 0x00000001899CEC00-0x00000001899CEC20
	private static void RegisterHotfixGenerated() {} // 0x0000000182724700-0x00000001827248D0
	// [XID] // 0x00000001899D6370-0x00000001899D6390
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182724340-0x0000000182724700
	// [IDTag] // 0x00000001899DD7E0-0x00000001899DD820
	// [XID] // 0x00000001899DD7E0-0x00000001899DD820
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182724DB0-0x0000000182724EB0
	// [XID] // 0x00000001899E8300-0x00000001899E8320
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TrialAvatarExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182725500-0x0000000182725830
	// [XID] // 0x00000001899EF8D0-0x00000001899EF8F0
	private static bool ParseConfigFromLine(string line, out TrialAvatarExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001827249C0-0x0000000182724B00
	// [IDTag] // 0x00000001899F70B0-0x00000001899F70F0
	// [XID] // 0x00000001899F70B0-0x00000001899F70F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TrialAvatarExcelConfig> configList) => default; // 0x0000000182724B00-0x0000000182724DB0
	// [IDTag] // 0x0000000189A01370-0x0000000189A013B0
	// [XID] // 0x0000000189A01370-0x0000000189A013B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF354B */, bool useObjectPool = false /* Metadata: 0x00AF354F */) => default; // 0x0000000182724EB0-0x0000000182725100
	// [IDTag] // 0x0000000189A0BCD0-0x0000000189A0BD10
	// [XID] // 0x0000000189A0BCD0-0x0000000189A0BD10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3550 */, bool useObjectPool = false /* Metadata: 0x00AF3554 */) => default; // 0x0000000182725100-0x0000000182725450
}

