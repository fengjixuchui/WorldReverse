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

public static class TrialAvatarActivityDataExcelConfigLoader // TypeDefIndex: 14923
{
	// Fields
	private static Dictionary<uint, TrialAvatarActivityDataExcelConfig> _avatarIndexIdDic; // 0x00
	private static Dictionary<uint, TrialAvatarActivityDataExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<TrialAvatarActivityDataExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<TrialAvatarActivityDataExcelConfig, TrialAvatarActivityDataExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<TrialAvatarActivityDataExcelConfig>, Dictionary<uint, TrialAvatarActivityDataExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, TrialAvatarActivityDataExcelConfig> dataDict { /* [XID] */ /* 0x0000000189706560-0x0000000189706580 */ get; } // 0x0000000182737190-0x0000000182737240 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897152D0-0x00000001897152F0 */ get; } // 0x0000000182735D40-0x0000000182735DE0 

	// Methods
	// [XID] // 0x00000001896EFE20-0x00000001896EFE40
	public static void BuildAvatarIndexDic() {} // 0x00000001827361A0-0x0000000182736440
	// [XID] // 0x00000001896F7830-0x00000001896F7850
	public static TrialAvatarActivityDataExcelConfig GetTrialAvatarConfig(uint id) => default; // 0x0000000182737570-0x0000000182737650
	// [XID] // 0x00000001896FF230-0x00000001896FF250
	public static void Register() {} // 0x0000000182737650-0x00000001827376F0
	// [XID] // 0x000000018970DE50-0x000000018970DE70
	public static TrialAvatarActivityDataExcelConfig GetData(uint id) => default; // 0x0000000182735C00-0x0000000182735D40
	// [XID] // 0x000000018971CDE0-0x000000018971CE00
	public static void LoadData() {} // 0x0000000182736610-0x0000000182736700
	// [XID] // 0x0000000189724190-0x00000001897241B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182736440-0x0000000182736610
	// [XID] // 0x000000018972B910-0x000000018972B930
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182735DE0-0x00000001827361A0
	// [IDTag] // 0x0000000189733100-0x0000000189733140
	// [XID] // 0x0000000189733100-0x0000000189733140
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182736AF0-0x0000000182736BF0
	// [XID] // 0x000000018973DE30-0x000000018973DE50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TrialAvatarActivityDataExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182737240-0x0000000182737570
	// [XID] // 0x0000000189745270-0x0000000189745290
	private static bool ParseConfigFromLine(string line, out TrialAvatarActivityDataExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182736700-0x0000000182736840
	// [IDTag] // 0x000000018974CD40-0x000000018974CD80
	// [XID] // 0x000000018974CD40-0x000000018974CD80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TrialAvatarActivityDataExcelConfig> configList) => default; // 0x0000000182736840-0x0000000182736AF0
	// [IDTag] // 0x00000001897571A0-0x00000001897571E0
	// [XID] // 0x00000001897571A0-0x00000001897571E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA19 */, bool useObjectPool = false /* Metadata: 0x00AEFA1D */) => default; // 0x0000000182736F40-0x0000000182737190
	// [IDTag] // 0x0000000189761910-0x0000000189761950
	// [XID] // 0x0000000189761910-0x0000000189761950
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA1E */, bool useObjectPool = false /* Metadata: 0x00AEFA22 */) => default; // 0x0000000182736BF0-0x0000000182736F40
}

