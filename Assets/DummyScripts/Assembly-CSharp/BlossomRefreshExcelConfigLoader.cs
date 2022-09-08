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

public static class BlossomRefreshExcelConfigLoader // TypeDefIndex: 15270
{
	// Fields
	private static Dictionary<uint, BlossomRefreshExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomRefreshExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomRefreshExcelConfig, BlossomRefreshExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomRefreshExcelConfig>, Dictionary<uint, BlossomRefreshExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomRefreshExcelConfig> dataDict { /* [XID] */ /* 0x0000000189737A80-0x0000000189737AA0 */ get; } // 0x0000000182B511F0-0x0000000182B512A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189746980-0x00000001897469A0 */ get; } // 0x0000000182B50040-0x0000000182B500E0 

	// Methods
	// [XID] // 0x0000000189730100-0x0000000189730120
	public static void Register() {} // 0x0000000182B515D0-0x0000000182B51670
	// [XID] // 0x000000018973F5C0-0x000000018973F5E0
	public static BlossomRefreshExcelConfig GetData(uint id) => default; // 0x0000000182B4FF10-0x0000000182B50040
	// [XID] // 0x000000018974E350-0x000000018974E370
	public static void LoadData() {} // 0x0000000182B50670-0x0000000182B50760
	// [XID] // 0x0000000189755970-0x0000000189755990
	private static void RegisterHotfixGenerated() {} // 0x0000000182B504A0-0x0000000182B50670
	// [XID] // 0x000000018975CCB0-0x000000018975CCD0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B500E0-0x0000000182B504A0
	// [IDTag] // 0x0000000189764420-0x0000000189764460
	// [XID] // 0x0000000189764420-0x0000000189764460
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B50B50-0x0000000182B50C50
	// [XID] // 0x000000018976EA80-0x000000018976EAA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomRefreshExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B512A0-0x0000000182B515D0
	// [XID] // 0x0000000189776560-0x0000000189776580
	private static bool ParseConfigFromLine(string line, out BlossomRefreshExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B50760-0x0000000182B508A0
	// [IDTag] // 0x000000018977DB80-0x000000018977DBC0
	// [XID] // 0x000000018977DB80-0x000000018977DBC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomRefreshExcelConfig> configList) => default; // 0x0000000182B508A0-0x0000000182B50B50
	// [IDTag] // 0x0000000189788200-0x0000000189788240
	// [XID] // 0x0000000189788200-0x0000000189788240
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF05D2 */, bool useObjectPool = false /* Metadata: 0x00AF05D6 */) => default; // 0x0000000182B50C50-0x0000000182B50EA0
	// [IDTag] // 0x0000000189792940-0x0000000189792980
	// [XID] // 0x0000000189792940-0x0000000189792980
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05D7 */, bool useObjectPool = false /* Metadata: 0x00AF05DB */) => default; // 0x0000000182B50EA0-0x0000000182B511F0
}

