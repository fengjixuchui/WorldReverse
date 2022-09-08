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

public static class NewActivityExcelConfigLoader // TypeDefIndex: 15888
{
	// Fields
	private static Dictionary<uint, NewActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityExcelConfig, NewActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityExcelConfig>, Dictionary<uint, NewActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityExcelConfig> dataDict { /* [XID] */ /* 0x00000001896FD770-0x00000001896FD790 */ get; } // 0x0000000181970DF0-0x0000000181970EA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018970C3B0-0x000000018970C3D0 */ get; } // 0x000000018196FC40-0x000000018196FCE0 

	// Methods
	// [XID] // 0x00000001896F5FA0-0x00000001896F5FC0
	public static void Register() {} // 0x00000001819711D0-0x0000000181971270
	// [XID] // 0x0000000189704C70-0x0000000189704C90
	public static NewActivityExcelConfig GetData(uint activityId) => default; // 0x000000018196FB10-0x000000018196FC40
	// [XID] // 0x0000000189713D80-0x0000000189713DA0
	public static void LoadData() {} // 0x0000000181970270-0x0000000181970360
	// [XID] // 0x000000018971B560-0x000000018971B580
	private static void RegisterHotfixGenerated() {} // 0x00000001819700A0-0x0000000181970270
	// [XID] // 0x0000000189722800-0x0000000189722820
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018196FCE0-0x00000001819700A0
	// [IDTag] // 0x0000000189729EC0-0x0000000189729F00
	// [XID] // 0x0000000189729EC0-0x0000000189729F00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181970750-0x0000000181970850
	// [XID] // 0x0000000189734610-0x0000000189734630
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181970EA0-0x00000001819711D0
	// [XID] // 0x000000018973BFE0-0x000000018973C000
	private static bool ParseConfigFromLine(string line, out NewActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181970360-0x00000001819704A0
	// [IDTag] // 0x00000001897437B0-0x00000001897437F0
	// [XID] // 0x00000001897437B0-0x00000001897437F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityExcelConfig> configList) => default; // 0x00000001819704A0-0x0000000181970750
	// [IDTag] // 0x000000018974E1F0-0x000000018974E230
	// [XID] // 0x000000018974E1F0-0x000000018974E230
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2A4B */, bool useObjectPool = false /* Metadata: 0x00AF2A4F */) => default; // 0x0000000181970850-0x0000000181970AA0
	// [IDTag] // 0x00000001897583B0-0x00000001897583F0
	// [XID] // 0x00000001897583B0-0x00000001897583F0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A50 */, bool useObjectPool = false /* Metadata: 0x00AF2A54 */) => default; // 0x0000000181970AA0-0x0000000181970DF0
}

