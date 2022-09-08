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

public static class PSActivitiesTaskConfigLoader // TypeDefIndex: 15960
{
	// Fields
	private static Dictionary<uint, PSActivitiesTaskConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PSActivitiesTaskConfig>> customApplyHotfixAction; // 0x08
	public static Action<PSActivitiesTaskConfig, PSActivitiesTaskConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PSActivitiesTaskConfig>, Dictionary<uint, PSActivitiesTaskConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PSActivitiesTaskConfig> dataDict { /* [XID] */ /* 0x0000000189A50200-0x0000000189A50220 */ get; } // 0x0000000182BCB380-0x0000000182BCB430 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A5F2B0-0x0000000189A5F2D0 */ get; } // 0x0000000182BCA1D0-0x0000000182BCA270 

	// Methods
	// [XID] // 0x0000000189A48A70-0x0000000189A48A90
	public static void Register() {} // 0x0000000182BCB760-0x0000000182BCB800
	// [XID] // 0x0000000189A57790-0x0000000189A577B0
	public static PSActivitiesTaskConfig GetData(uint ID) => default; // 0x0000000182BCA0A0-0x0000000182BCA1D0
	// [XID] // 0x0000000189A66BA0-0x0000000189A66BC0
	public static void LoadData() {} // 0x0000000182BCA800-0x0000000182BCA8F0
	// [XID] // 0x0000000189A6E4A0-0x0000000189A6E4C0
	private static void RegisterHotfixGenerated() {} // 0x0000000182BCA630-0x0000000182BCA800
	// [XID] // 0x0000000189A75B70-0x0000000189A75B90
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182BCA270-0x0000000182BCA630
	// [IDTag] // 0x0000000189A7D790-0x0000000189A7D7D0
	// [XID] // 0x0000000189A7D790-0x0000000189A7D7D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182BCAA30-0x0000000182BCAB30
	// [XID] // 0x0000000189A87FE0-0x0000000189A88000
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PSActivitiesTaskConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182BCB430-0x0000000182BCB760
	// [XID] // 0x0000000189A8F850-0x0000000189A8F870
	private static bool ParseConfigFromLine(string line, out PSActivitiesTaskConfig data) {
		data = default;
		return default;
	} // 0x0000000182BCA8F0-0x0000000182BCAA30
	// [IDTag] // 0x0000000189A96E00-0x0000000189A96E40
	// [XID] // 0x0000000189A96E00-0x0000000189A96E40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PSActivitiesTaskConfig> configList) => default; // 0x0000000182BCAB30-0x0000000182BCADE0
	// [IDTag] // 0x0000000189AA1120-0x0000000189AA1160
	// [XID] // 0x0000000189AA1120-0x0000000189AA1160
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C4D */, bool useObjectPool = false /* Metadata: 0x00AF2C51 */) => default; // 0x0000000182BCB130-0x0000000182BCB380
	// [IDTag] // 0x0000000189AABA70-0x0000000189AABAB0
	// [XID] // 0x0000000189AABA70-0x0000000189AABAB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C52 */, bool useObjectPool = false /* Metadata: 0x00AF2C56 */) => default; // 0x0000000182BCADE0-0x0000000182BCB130
}

