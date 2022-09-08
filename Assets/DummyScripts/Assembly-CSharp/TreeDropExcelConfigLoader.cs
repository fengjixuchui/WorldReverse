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

public static class TreeDropExcelConfigLoader // TypeDefIndex: 16232
{
	// Fields
	private static Dictionary<int, TreeDropExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TreeDropExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TreeDropExcelConfig, TreeDropExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TreeDropExcelConfig>, Dictionary<int, TreeDropExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, TreeDropExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BA27B0-0x0000000189BA27D0 */ get; } // 0x00000001849710B0-0x0000000184971160 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BB14F0-0x0000000189BB1510 */ get; } // 0x000000018496FF00-0x000000018496FFA0 

	// Methods
	// [XID] // 0x0000000189B9AF60-0x0000000189B9AF80
	public static void Register() {} // 0x0000000184971490-0x0000000184971530
	// [XID] // 0x0000000189BA9BA0-0x0000000189BA9BC0
	public static TreeDropExcelConfig GetData(TreeType treeType) => default; // 0x000000018496FDD0-0x000000018496FF00
	// [XID] // 0x0000000189BB8480-0x0000000189BB84A0
	public static void LoadData() {} // 0x0000000184970530-0x0000000184970620
	// [XID] // 0x0000000189BBFD30-0x0000000189BBFD50
	private static void RegisterHotfixGenerated() {} // 0x0000000184970360-0x0000000184970530
	// [XID] // 0x0000000189BC77C0-0x0000000189BC77E0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018496FFA0-0x0000000184970360
	// [IDTag] // 0x0000000189BCF3B0-0x0000000189BCF3F0
	// [XID] // 0x0000000189BCF3B0-0x0000000189BCF3F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184970A10-0x0000000184970B10
	// [XID] // 0x0000000189BD9880-0x0000000189BD98A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TreeDropExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184971160-0x0000000184971490
	// [XID] // 0x00000001895E6310-0x00000001895E6330
	private static bool ParseConfigFromLine(string line, out TreeDropExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184970620-0x0000000184970760
	// [IDTag] // 0x00000001895EDCD0-0x00000001895EDD10
	// [XID] // 0x00000001895EDCD0-0x00000001895EDD10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TreeDropExcelConfig> configList) => default; // 0x0000000184970760-0x0000000184970A10
	// [IDTag] // 0x00000001895F8650-0x00000001895F8690
	// [XID] // 0x00000001895F8650-0x00000001895F8690
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3515 */, bool useObjectPool = false /* Metadata: 0x00AF3519 */) => default; // 0x0000000184970E60-0x00000001849710B0
	// [IDTag] // 0x0000000189602C90-0x0000000189602CD0
	// [XID] // 0x0000000189602C90-0x0000000189602CD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF351A */, bool useObjectPool = false /* Metadata: 0x00AF351E */) => default; // 0x0000000184970B10-0x0000000184970E60
}

