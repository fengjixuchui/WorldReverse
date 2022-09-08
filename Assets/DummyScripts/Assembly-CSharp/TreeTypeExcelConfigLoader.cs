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

public static class TreeTypeExcelConfigLoader // TypeDefIndex: 16234
{
	// Fields
	private static Dictionary<uint, TreeTypeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TreeTypeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TreeTypeExcelConfig, TreeTypeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TreeTypeExcelConfig>, Dictionary<uint, TreeTypeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TreeTypeExcelConfig> dataDict { /* [XID] */ /* 0x00000001896A9400-0x00000001896A9420 */ get; } // 0x0000000183D02C80-0x0000000183D02D30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896B7F50-0x00000001896B7F70 */ get; } // 0x0000000183D01AD0-0x0000000183D01B70 

	// Methods
	// [XID] // 0x00000001896A21C0-0x00000001896A21E0
	public static void Register() {} // 0x0000000183D03060-0x0000000183D03100
	// [XID] // 0x00000001896B0530-0x00000001896B0550
	public static TreeTypeExcelConfig GetData(uint ID) => default; // 0x0000000183D019A0-0x0000000183D01AD0
	// [XID] // 0x00000001896BEFB0-0x00000001896BEFD0
	public static void LoadData() {} // 0x0000000183D02100-0x0000000183D021F0
	// [XID] // 0x00000001896C6930-0x00000001896C6950
	private static void RegisterHotfixGenerated() {} // 0x0000000183D01F30-0x0000000183D02100
	// [XID] // 0x00000001896CDFF0-0x00000001896CE010
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183D01B70-0x0000000183D01F30
	// [IDTag] // 0x00000001896D5560-0x00000001896D55A0
	// [XID] // 0x00000001896D5560-0x00000001896D55A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183D025E0-0x0000000183D026E0
	// [XID] // 0x00000001896DFD00-0x00000001896DFD20
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TreeTypeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183D02D30-0x0000000183D03060
	// [XID] // 0x00000001896E70A0-0x00000001896E70C0
	private static bool ParseConfigFromLine(string line, out TreeTypeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183D021F0-0x0000000183D02330
	// [IDTag] // 0x00000001896EE610-0x00000001896EE650
	// [XID] // 0x00000001896EE610-0x00000001896EE650
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TreeTypeExcelConfig> configList) => default; // 0x0000000183D02330-0x0000000183D025E0
	// [IDTag] // 0x00000001896F8A20-0x00000001896F8A60
	// [XID] // 0x00000001896F8A20-0x00000001896F8A60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3524 */, bool useObjectPool = false /* Metadata: 0x00AF3528 */) => default; // 0x0000000183D02A30-0x0000000183D02C80
	// [IDTag] // 0x0000000189703490-0x00000001897034D0
	// [XID] // 0x0000000189703490-0x00000001897034D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3529 */, bool useObjectPool = false /* Metadata: 0x00AF352D */) => default; // 0x0000000183D026E0-0x0000000183D02A30
}

