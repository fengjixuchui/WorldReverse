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

public static class AnimalDescribeExcelConfigLoader // TypeDefIndex: 15849
{
	// Fields
	private static Dictionary<uint, AnimalDescribeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AnimalDescribeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AnimalDescribeExcelConfig, AnimalDescribeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AnimalDescribeExcelConfig>, Dictionary<uint, AnimalDescribeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AnimalDescribeExcelConfig> dataDict { /* [XID] */ /* 0x00000001897003C0-0x00000001897003E0 */ get; } // 0x00000001836DD3F0-0x00000001836DD4A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018970F680-0x000000018970F6A0 */ get; } // 0x00000001836DC240-0x00000001836DC2E0 

	// Methods
	// [XID] // 0x00000001896F8BE0-0x00000001896F8C00
	public static void Register() {} // 0x00000001836DD7D0-0x00000001836DD870
	// [XID] // 0x0000000189707B90-0x0000000189707BB0
	public static AnimalDescribeExcelConfig GetData(uint id) => default; // 0x00000001836DC110-0x00000001836DC240
	// [XID] // 0x00000001897169A0-0x00000001897169C0
	public static void LoadData() {} // 0x00000001836DC870-0x00000001836DC960
	// [XID] // 0x000000018971E3E0-0x000000018971E400
	private static void RegisterHotfixGenerated() {} // 0x00000001836DC6A0-0x00000001836DC870
	// [XID] // 0x0000000189725980-0x00000001897259A0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001836DC2E0-0x00000001836DC6A0
	// [IDTag] // 0x000000018972CEC0-0x000000018972CF00
	// [XID] // 0x000000018972CEC0-0x000000018972CF00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836DCAA0-0x00000001836DCBA0
	// [XID] // 0x00000001897379E0-0x0000000189737A00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AnimalDescribeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001836DD4A0-0x00000001836DD7D0
	// [XID] // 0x000000018973F4C0-0x000000018973F4E0
	private static bool ParseConfigFromLine(string line, out AnimalDescribeExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836DC960-0x00000001836DCAA0
	// [IDTag] // 0x0000000189746860-0x00000001897468A0
	// [XID] // 0x0000000189746860-0x00000001897468A0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AnimalDescribeExcelConfig> configList) => default; // 0x00000001836DCBA0-0x00000001836DCE50
	// [IDTag] // 0x0000000189750F00-0x0000000189750F40
	// [XID] // 0x0000000189750F00-0x0000000189750F40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF284A */, bool useObjectPool = false /* Metadata: 0x00AF284E */) => default; // 0x00000001836DD1A0-0x00000001836DD3F0
	// [IDTag] // 0x000000018975B320-0x000000018975B360
	// [XID] // 0x000000018975B320-0x000000018975B360
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF284F */, bool useObjectPool = false /* Metadata: 0x00AF2853 */) => default; // 0x00000001836DCE50-0x00000001836DD1A0
}

