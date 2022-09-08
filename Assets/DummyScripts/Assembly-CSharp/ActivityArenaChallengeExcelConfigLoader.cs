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

public static class ActivityArenaChallengeExcelConfigLoader // TypeDefIndex: 15010
{
	// Fields
	private static List<ActivityArenaChallengeExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityArenaChallengeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityArenaChallengeExcelConfig, ActivityArenaChallengeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityArenaChallengeExcelConfig>, List<ActivityArenaChallengeExcelConfig>, string, bool> customValidateFunc; // 0x20
	public static Dictionary<uint, List<ActivityArenaChallengeExcelConfig>> arenaChallengeWatcherDic; // 0x28

	// Properties
	public static List<ActivityArenaChallengeExcelConfig> dataList { /* [XID] */ /* 0x00000001898C02A0-0x00000001898C02C0 */ get; } // 0x0000000181AFF000-0x0000000181AFF0D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898C7BC0-0x00000001898C7BE0 */ get; } // 0x0000000181AFD470-0x0000000181AFD510 

	// Constructors
	static ActivityArenaChallengeExcelConfigLoader() {} // 0x0000000181AFF580-0x0000000181AFF5E0

	// Methods
	// [XID] // 0x00000001898B8C60-0x00000001898B8C80
	public static void Register() {} // 0x0000000181AFF4C0-0x0000000181AFF580
	// [XID] // 0x00000001898CF330-0x00000001898CF350
	public static void LoadData() {} // 0x0000000181AFE2E0-0x0000000181AFE410
	// [XID] // 0x00000001898D6B60-0x00000001898D6B80
	private static void RegisterHotfixGenerated() {} // 0x0000000181AFDA60-0x0000000181AFDCD0
	// [XID] // 0x00000001898DE840-0x00000001898DE860
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181AFD510-0x0000000181AFDA60
	// [IDTag] // 0x00000001898E6020-0x00000001898E6060
	// [XID] // 0x00000001898E6020-0x00000001898E6060
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181AFE870-0x0000000181AFE9D0
	// [XID] // 0x00000001898F0A40-0x00000001898F0A60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityArenaChallengeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181AFF0D0-0x0000000181AFF420
	// [XID] // 0x00000001898F8370-0x00000001898F8390
	private static bool ParseConfigFromLine(string line, out ActivityArenaChallengeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181AFE410-0x0000000181AFE550
	// [IDTag] // 0x00000001898FFA30-0x00000001898FFA70
	// [XID] // 0x00000001898FFA30-0x00000001898FFA70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityArenaChallengeExcelConfig> configList) => default; // 0x0000000181AFE550-0x0000000181AFE870
	// [IDTag] // 0x000000018990A100-0x000000018990A140
	// [XID] // 0x000000018990A100-0x000000018990A140
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE5C */, bool useObjectPool = false /* Metadata: 0x00AEFE60 */) => default; // 0x0000000181AFE9D0-0x0000000181AFEC80
	// [IDTag] // 0x0000000189914A80-0x0000000189914AC0
	// [XID] // 0x0000000189914A80-0x0000000189914AC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE61 */, bool useObjectPool = false /* Metadata: 0x00AEFE65 */) => default; // 0x0000000181AFEC80-0x0000000181AFF000
	// [XID] // 0x000000018991F280-0x000000018991F2A0
	public static void LoadDic(uint scheduleId) {} // 0x0000000181AFDCD0-0x0000000181AFE2E0
}

