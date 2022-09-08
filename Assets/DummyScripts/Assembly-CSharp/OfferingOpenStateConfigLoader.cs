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

public static class OfferingOpenStateConfigLoader // TypeDefIndex: 15921
{
	// Fields
	private static Dictionary<uint, OfferingOpenStateConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<OfferingOpenStateConfig>> customApplyHotfixAction; // 0x08
	public static Action<OfferingOpenStateConfig, OfferingOpenStateConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OfferingOpenStateConfig>, Dictionary<uint, OfferingOpenStateConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, OfferingOpenStateConfig> dataDict { /* [XID] */ /* 0x0000000189BD6720-0x0000000189BD6740 */ get; } // 0x000000018188AEE0-0x000000018188AF90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895EAF90-0x00000001895EAFB0 */ get; } // 0x0000000181889D30-0x0000000181889DD0 

	// Methods
	// [XID] // 0x0000000189BCF3F0-0x0000000189BCF410
	public static void Register() {} // 0x000000018188B2C0-0x000000018188B360
	// [XID] // 0x0000000189BDE420-0x0000000189BDE440
	public static OfferingOpenStateConfig GetData(uint offeringId) => default; // 0x0000000181889C00-0x0000000181889D30
	// [XID] // 0x00000001895F23B0-0x00000001895F23D0
	public static void LoadData() {} // 0x000000018188A360-0x000000018188A450
	// [XID] // 0x00000001895F9D80-0x00000001895F9DA0
	private static void RegisterHotfixGenerated() {} // 0x000000018188A190-0x000000018188A360
	// [XID] // 0x00000001896015C0-0x00000001896015E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181889DD0-0x000000018188A190
	// [IDTag] // 0x0000000189608E50-0x0000000189608E90
	// [XID] // 0x0000000189608E50-0x0000000189608E90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018188A840-0x000000018188A940
	// [XID] // 0x00000001896133A0-0x00000001896133C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OfferingOpenStateConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018188AF90-0x000000018188B2C0
	// [XID] // 0x000000018961AC40-0x000000018961AC60
	private static bool ParseConfigFromLine(string line, out OfferingOpenStateConfig data) {
		data = default;
		return default;
	} // 0x000000018188A450-0x000000018188A590
	// [IDTag] // 0x0000000189622200-0x0000000189622240
	// [XID] // 0x0000000189622200-0x0000000189622240
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OfferingOpenStateConfig> configList) => default; // 0x000000018188A590-0x000000018188A840
	// [IDTag] // 0x000000018962C8B0-0x000000018962C8F0
	// [XID] // 0x000000018962C8B0-0x000000018962C8F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B39 */, bool useObjectPool = false /* Metadata: 0x00AF2B3D */) => default; // 0x000000018188A940-0x000000018188AB90
	// [IDTag] // 0x0000000189637620-0x0000000189637660
	// [XID] // 0x0000000189637620-0x0000000189637660
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B3E */, bool useObjectPool = false /* Metadata: 0x00AF2B42 */) => default; // 0x000000018188AB90-0x000000018188AEE0
}

