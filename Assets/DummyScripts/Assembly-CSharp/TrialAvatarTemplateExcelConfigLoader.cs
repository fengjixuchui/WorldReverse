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

public static class TrialAvatarTemplateExcelConfigLoader // TypeDefIndex: 16245
{
	// Fields
	private static List<TrialAvatarTemplateExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<TrialAvatarTemplateExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TrialAvatarTemplateExcelConfig, TrialAvatarTemplateExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TrialAvatarTemplateExcelConfig>, List<TrialAvatarTemplateExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<TrialAvatarTemplateExcelConfig> dataList { /* [XID] */ /* 0x0000000189602C70-0x0000000189602C90 */ get; } // 0x00000001823E5090-0x00000001823E5140 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018960A5B0-0x000000018960A5D0 */ get; } // 0x00000001823E3EA0-0x00000001823E3F40 

	// Methods
	// [XID] // 0x00000001895FB570-0x00000001895FB590
	public static void Register() {} // 0x00000001823E5470-0x00000001823E5510
	// [XID] // 0x0000000189611D40-0x0000000189611D60
	public static void LoadData() {} // 0x00000001823E4540-0x00000001823E4630
	// [XID] // 0x0000000189619600-0x0000000189619620
	private static void RegisterHotfixGenerated() {} // 0x00000001823E4370-0x00000001823E4540
	// [XID] // 0x0000000189620BA0-0x0000000189620BC0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001823E3F40-0x00000001823E4370
	// [IDTag] // 0x00000001896281D0-0x0000000189628210
	// [XID] // 0x00000001896281D0-0x0000000189628210
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001823E4A10-0x00000001823E4B10
	// [XID] // 0x00000001896329A0-0x00000001896329C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TrialAvatarTemplateExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001823E5140-0x00000001823E5470
	// [XID] // 0x000000018963A4B0-0x000000018963A4D0
	private static bool ParseConfigFromLine(string line, out TrialAvatarTemplateExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001823E4630-0x00000001823E4770
	// [IDTag] // 0x0000000189641AC0-0x0000000189641B00
	// [XID] // 0x0000000189641AC0-0x0000000189641B00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TrialAvatarTemplateExcelConfig> configList) => default; // 0x00000001823E4770-0x00000001823E4A10
	// [IDTag] // 0x000000018964C430-0x000000018964C470
	// [XID] // 0x000000018964C430-0x000000018964C470
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3569 */, bool useObjectPool = false /* Metadata: 0x00AF356D */) => default; // 0x00000001823E4E40-0x00000001823E5090
	// [IDTag] // 0x0000000189656A10-0x0000000189656A50
	// [XID] // 0x0000000189656A10-0x0000000189656A50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF356E */, bool useObjectPool = false /* Metadata: 0x00AF3572 */) => default; // 0x00000001823E4B10-0x00000001823E4E40
}

