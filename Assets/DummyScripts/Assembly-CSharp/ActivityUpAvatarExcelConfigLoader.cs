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

public static class ActivityUpAvatarExcelConfigLoader // TypeDefIndex: 15004
{
	// Fields
	private static Dictionary<uint, ActivityUpAvatarExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivityUpAvatarExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivityUpAvatarExcelConfig, ActivityUpAvatarExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivityUpAvatarExcelConfig>, Dictionary<uint, ActivityUpAvatarExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivityUpAvatarExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A8E250-0x0000000189A8E270 */ get; } // 0x0000000182FBAFC0-0x0000000182FBB070 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A9CFD0-0x0000000189A9CFF0 */ get; } // 0x0000000182FB9E10-0x0000000182FB9EB0 

	// Methods
	// [XID] // 0x0000000189A86650-0x0000000189A86670
	public static void Register() {} // 0x0000000182FBB3A0-0x0000000182FBB440
	// [XID] // 0x0000000189A95690-0x0000000189A956B0
	public static ActivityUpAvatarExcelConfig GetData(uint id) => default; // 0x0000000182FB9CE0-0x0000000182FB9E10
	// [XID] // 0x0000000189AA4620-0x0000000189AA4640
	public static void LoadData() {} // 0x0000000182FBA440-0x0000000182FBA530
	// [XID] // 0x0000000189AABCF0-0x0000000189AABD10
	private static void RegisterHotfixGenerated() {} // 0x0000000182FBA270-0x0000000182FBA440
	// [XID] // 0x0000000189AB35E0-0x0000000189AB3600
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182FB9EB0-0x0000000182FBA270
	// [IDTag] // 0x0000000189ABB390-0x0000000189ABB3D0
	// [XID] // 0x0000000189ABB390-0x0000000189ABB3D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182FBA670-0x0000000182FBA770
	// [XID] // 0x0000000189AC5CF0-0x0000000189AC5D10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivityUpAvatarExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182FBB070-0x0000000182FBB3A0
	// [XID] // 0x0000000189ACD200-0x0000000189ACD220
	private static bool ParseConfigFromLine(string line, out ActivityUpAvatarExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182FBA530-0x0000000182FBA670
	// [IDTag] // 0x0000000189AD4F60-0x0000000189AD4FA0
	// [XID] // 0x0000000189AD4F60-0x0000000189AD4FA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivityUpAvatarExcelConfig> configList) => default; // 0x0000000182FBA770-0x0000000182FBAA20
	// [IDTag] // 0x0000000189ADF9D0-0x0000000189ADFA10
	// [XID] // 0x0000000189ADF9D0-0x0000000189ADFA10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFE2F */, bool useObjectPool = false /* Metadata: 0x00AEFE33 */) => default; // 0x0000000182FBAD70-0x0000000182FBAFC0
	// [IDTag] // 0x0000000189AE9E90-0x0000000189AE9ED0
	// [XID] // 0x0000000189AE9E90-0x0000000189AE9ED0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE34 */, bool useObjectPool = false /* Metadata: 0x00AEFE38 */) => default; // 0x0000000182FBAA20-0x0000000182FBAD70
}

