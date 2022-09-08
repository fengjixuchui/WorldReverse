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

public static class WidgetGeneralExcelConfigLoader // TypeDefIndex: 16285
{
	// Fields
	private static Dictionary<uint, WidgetGeneralExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WidgetGeneralExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WidgetGeneralExcelConfig, WidgetGeneralExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WidgetGeneralExcelConfig>, Dictionary<uint, WidgetGeneralExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WidgetGeneralExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A4D0A0-0x0000000189A4D0C0 */ get; } // 0x000000018172A3D0-0x000000018172A480 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A5C2E0-0x0000000189A5C300 */ get; } // 0x0000000181729220-0x00000001817292C0 

	// Methods
	// [XID] // 0x0000000189A459C0-0x0000000189A459E0
	public static void Register() {} // 0x000000018172A7B0-0x000000018172A850
	// [XID] // 0x0000000189A54850-0x0000000189A54870
	public static WidgetGeneralExcelConfig GetData(uint materialID) => default; // 0x00000001817290F0-0x0000000181729220
	// [XID] // 0x0000000189A63CD0-0x0000000189A63CF0
	public static void LoadData() {} // 0x0000000181729850-0x0000000181729940
	// [XID] // 0x0000000189A6B4F0-0x0000000189A6B510
	private static void RegisterHotfixGenerated() {} // 0x0000000181729680-0x0000000181729850
	// [XID] // 0x0000000189A72CE0-0x0000000189A72D00
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001817292C0-0x0000000181729680
	// [IDTag] // 0x0000000189A7A830-0x0000000189A7A870
	// [XID] // 0x0000000189A7A830-0x0000000189A7A870
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181729D30-0x0000000181729E30
	// [XID] // 0x0000000189A84E60-0x0000000189A84E80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WidgetGeneralExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018172A480-0x000000018172A7B0
	// [XID] // 0x0000000189A8C770-0x0000000189A8C790
	private static bool ParseConfigFromLine(string line, out WidgetGeneralExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181729940-0x0000000181729A80
	// [IDTag] // 0x0000000189A93B50-0x0000000189A93B90
	// [XID] // 0x0000000189A93B50-0x0000000189A93B90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WidgetGeneralExcelConfig> configList) => default; // 0x0000000181729A80-0x0000000181729D30
	// [IDTag] // 0x0000000189A9E1F0-0x0000000189A9E230
	// [XID] // 0x0000000189A9E1F0-0x0000000189A9E230
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3671 */, bool useObjectPool = false /* Metadata: 0x00AF3675 */) => default; // 0x000000018172A180-0x000000018172A3D0
	// [IDTag] // 0x0000000189AA8780-0x0000000189AA87C0
	// [XID] // 0x0000000189AA8780-0x0000000189AA87C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3676 */, bool useObjectPool = false /* Metadata: 0x00AF367A */) => default; // 0x0000000181729E30-0x000000018172A180
}

