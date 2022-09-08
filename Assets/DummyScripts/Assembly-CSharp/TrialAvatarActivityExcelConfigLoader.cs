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

public static class TrialAvatarActivityExcelConfigLoader // TypeDefIndex: 16236
{
	// Fields
	private static Dictionary<uint, TrialAvatarActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TrialAvatarActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TrialAvatarActivityExcelConfig, TrialAvatarActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TrialAvatarActivityExcelConfig>, Dictionary<uint, TrialAvatarActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TrialAvatarActivityExcelConfig> dataDict { /* [XID] */ /* 0x00000001897A9440-0x00000001897A9460 */ get; } // 0x0000000185616290-0x0000000185616340 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897B8900-0x00000001897B8920 */ get; } // 0x00000001856150E0-0x0000000185615180 

	// Methods
	// [XID] // 0x00000001897A1BA0-0x00000001897A1BC0
	public static void Register() {} // 0x0000000185616670-0x0000000185616710
	// [XID] // 0x00000001897B0B80-0x00000001897B0BA0
	public static TrialAvatarActivityExcelConfig GetData(uint scheduleId) => default; // 0x0000000185614FB0-0x00000001856150E0
	// [XID] // 0x00000001897C0940-0x00000001897C0960
	public static void LoadData() {} // 0x0000000185615710-0x0000000185615800
	// [XID] // 0x00000001897C82F0-0x00000001897C8310
	private static void RegisterHotfixGenerated() {} // 0x0000000185615540-0x0000000185615710
	// [XID] // 0x00000001897CF6F0-0x00000001897CF710
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185615180-0x0000000185615540
	// [IDTag] // 0x00000001897D6F40-0x00000001897D6F80
	// [XID] // 0x00000001897D6F40-0x00000001897D6F80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185615940-0x0000000185615A40
	// [XID] // 0x00000001897E17A0-0x00000001897E17C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TrialAvatarActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185616340-0x0000000185616670
	// [XID] // 0x00000001897E9030-0x00000001897E9050
	private static bool ParseConfigFromLine(string line, out TrialAvatarActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185615800-0x0000000185615940
	// [IDTag] // 0x00000001897F0C00-0x00000001897F0C40
	// [XID] // 0x00000001897F0C00-0x00000001897F0C40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TrialAvatarActivityExcelConfig> configList) => default; // 0x0000000185615A40-0x0000000185615CF0
	// [IDTag] // 0x00000001897FB5B0-0x00000001897FB5F0
	// [XID] // 0x00000001897FB5B0-0x00000001897FB5F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3533 */, bool useObjectPool = false /* Metadata: 0x00AF3537 */) => default; // 0x0000000185616040-0x0000000185616290
	// [IDTag] // 0x00000001898056D0-0x0000000189805710
	// [XID] // 0x00000001898056D0-0x0000000189805710
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3538 */, bool useObjectPool = false /* Metadata: 0x00AF353C */) => default; // 0x0000000185615CF0-0x0000000185616040
}

