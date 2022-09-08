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

public static class AvatarLevelExcelConfigLoader // TypeDefIndex: 15210
{
	// Fields
	private static Dictionary<uint, AvatarLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarLevelExcelConfig, AvatarLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarLevelExcelConfig>, Dictionary<uint, AvatarLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarLevelExcelConfig> dataDict { /* [XID] */ /* 0x000000018970DD10-0x000000018970DD30 */ get; } // 0x0000000181F2EBB0-0x0000000181F2EC60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018971CD20-0x000000018971CD40 */ get; } // 0x0000000181F2DA00-0x0000000181F2DAA0 

	// Methods
	// [XID] // 0x0000000189706400-0x0000000189706420
	public static void Register() {} // 0x0000000181F2EF90-0x0000000181F2F030
	// [XID] // 0x00000001897151B0-0x00000001897151D0
	public static AvatarLevelExcelConfig GetData(uint level) => default; // 0x0000000181F2D8D0-0x0000000181F2DA00
	// [XID] // 0x0000000189724110-0x0000000189724130
	public static void LoadData() {} // 0x0000000181F2E030-0x0000000181F2E120
	// [XID] // 0x000000018972B870-0x000000018972B890
	private static void RegisterHotfixGenerated() {} // 0x0000000181F2DE60-0x0000000181F2E030
	// [XID] // 0x0000000189733040-0x0000000189733060
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F2DAA0-0x0000000181F2DE60
	// [IDTag] // 0x000000018973A6F0-0x000000018973A730
	// [XID] // 0x000000018973A6F0-0x000000018973A730
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F2E510-0x0000000181F2E610
	// [XID] // 0x0000000189745150-0x0000000189745170
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F2EC60-0x0000000181F2EF90
	// [XID] // 0x000000018974CC00-0x000000018974CC20
	private static bool ParseConfigFromLine(string line, out AvatarLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F2E120-0x0000000181F2E260
	// [IDTag] // 0x0000000189753F60-0x0000000189753FA0
	// [XID] // 0x0000000189753F60-0x0000000189753FA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarLevelExcelConfig> configList) => default; // 0x0000000181F2E260-0x0000000181F2E510
	// [IDTag] // 0x000000018975E650-0x000000018975E690
	// [XID] // 0x000000018975E650-0x000000018975E690
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF03E9 */, bool useObjectPool = false /* Metadata: 0x00AF03ED */) => default; // 0x0000000181F2E960-0x0000000181F2EBB0
	// [IDTag] // 0x0000000189768C20-0x0000000189768C60
	// [XID] // 0x0000000189768C20-0x0000000189768C60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03EE */, bool useObjectPool = false /* Metadata: 0x00AF03F2 */) => default; // 0x0000000181F2E610-0x0000000181F2E960
}

