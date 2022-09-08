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

public static class WidgetExcelConfigLoader // TypeDefIndex: 16283
{
	// Fields
	private static Dictionary<uint, WidgetExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<WidgetExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<WidgetExcelConfig, WidgetExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WidgetExcelConfig>, Dictionary<uint, WidgetExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, WidgetExcelConfig> dataDict { /* [XID] */ /* 0x00000001898C49C0-0x00000001898C49E0 */ get; } // 0x0000000182069A40-0x0000000182069AF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898D36D0-0x00000001898D36F0 */ get; } // 0x0000000182068890-0x0000000182068930 

	// Methods
	// [XID] // 0x00000001898BD220-0x00000001898BD240
	public static void Register() {} // 0x0000000182069E20-0x0000000182069EC0
	// [XID] // 0x00000001898CBE90-0x00000001898CBEB0
	public static WidgetExcelConfig GetData(uint materialID) => default; // 0x0000000182068760-0x0000000182068890
	// [XID] // 0x00000001898DAEE0-0x00000001898DAF00
	public static void LoadData() {} // 0x0000000182068EC0-0x0000000182068FB0
	// [XID] // 0x00000001898E2C00-0x00000001898E2C20
	private static void RegisterHotfixGenerated() {} // 0x0000000182068CF0-0x0000000182068EC0
	// [XID] // 0x00000001898EA870-0x00000001898EA890
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182068930-0x0000000182068CF0
	// [IDTag] // 0x00000001898F1F70-0x00000001898F1FB0
	// [XID] // 0x00000001898F1F70-0x00000001898F1FB0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820690F0-0x00000001820691F0
	// [XID] // 0x00000001898FC650-0x00000001898FC670
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WidgetExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182069AF0-0x0000000182069E20
	// [XID] // 0x00000001899040D0-0x00000001899040F0
	private static bool ParseConfigFromLine(string line, out WidgetExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182068FB0-0x00000001820690F0
	// [IDTag] // 0x000000018990B6B0-0x000000018990B6F0
	// [XID] // 0x000000018990B6B0-0x000000018990B6F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WidgetExcelConfig> configList) => default; // 0x00000001820691F0-0x00000001820694A0
	// [IDTag] // 0x0000000189916000-0x0000000189916040
	// [XID] // 0x0000000189916000-0x0000000189916040
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3662 */, bool useObjectPool = false /* Metadata: 0x00AF3666 */) => default; // 0x00000001820697F0-0x0000000182069A40
	// [IDTag] // 0x00000001899208F0-0x0000000189920930
	// [XID] // 0x00000001899208F0-0x0000000189920930
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3667 */, bool useObjectPool = false /* Metadata: 0x00AF366B */) => default; // 0x00000001820694A0-0x00000001820697F0
}

