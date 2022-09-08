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

public static class FleurFairPreviewExcelConfigLoader // TypeDefIndex: 14821
{
	// Fields
	private static Dictionary<uint, FleurFairPreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FleurFairPreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FleurFairPreviewExcelConfig, FleurFairPreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FleurFairPreviewExcelConfig>, Dictionary<uint, FleurFairPreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FleurFairPreviewExcelConfig> dataDict { /* [XID] */ /* 0x0000000189727440-0x0000000189727460 */ get; } // 0x00000001843BBC20-0x00000001843BBCD0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189736140-0x0000000189736160 */ get; } // 0x00000001843BAA70-0x00000001843BAB10 

	// Methods
	// [XID] // 0x00000001897184B0-0x00000001897184D0
	public static FleurFairPreviewExcelConfig GetConfig(uint activityID) => default; // 0x00000001843BA6F0-0x00000001843BA940
	// [XID] // 0x000000018971FD90-0x000000018971FDB0
	public static void Register() {} // 0x00000001843BC000-0x00000001843BC0A0
	// [XID] // 0x000000018972E9D0-0x000000018972E9F0
	public static FleurFairPreviewExcelConfig GetData(uint id) => default; // 0x00000001843BA940-0x00000001843BAA70
	// [XID] // 0x000000018973DEB0-0x000000018973DED0
	public static void LoadData() {} // 0x00000001843BB0A0-0x00000001843BB190
	// [XID] // 0x00000001897452F0-0x0000000189745310
	private static void RegisterHotfixGenerated() {} // 0x00000001843BAED0-0x00000001843BB0A0
	// [XID] // 0x000000018974CDE0-0x000000018974CE00
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843BAB10-0x00000001843BAED0
	// [IDTag] // 0x0000000189754160-0x00000001897541A0
	// [XID] // 0x0000000189754160-0x00000001897541A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001843BB580-0x00000001843BB680
	// [XID] // 0x000000018975E7D0-0x000000018975E7F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FleurFairPreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001843BBCD0-0x00000001843BC000
	// [XID] // 0x0000000189765DB0-0x0000000189765DD0
	private static bool ParseConfigFromLine(string line, out FleurFairPreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001843BB190-0x00000001843BB2D0
	// [IDTag] // 0x000000018976D5E0-0x000000018976D620
	// [XID] // 0x000000018976D5E0-0x000000018976D620
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FleurFairPreviewExcelConfig> configList) => default; // 0x00000001843BB2D0-0x00000001843BB580
	// [IDTag] // 0x0000000189777B70-0x0000000189777BB0
	// [XID] // 0x0000000189777B70-0x0000000189777BB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF68E */, bool useObjectPool = false /* Metadata: 0x00AEF692 */) => default; // 0x00000001843BB680-0x00000001843BB8D0
	// [IDTag] // 0x00000001897826A0-0x00000001897826E0
	// [XID] // 0x00000001897826A0-0x00000001897826E0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF693 */, bool useObjectPool = false /* Metadata: 0x00AEF697 */) => default; // 0x00000001843BB8D0-0x00000001843BBC20
}

