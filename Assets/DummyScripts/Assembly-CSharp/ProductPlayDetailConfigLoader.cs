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

public static class ProductPlayDetailConfigLoader // TypeDefIndex: 16143
{
	// Fields
	private static Dictionary<uint, ProductPlayDetailConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ProductPlayDetailConfig>> customApplyHotfixAction; // 0x08
	public static Action<ProductPlayDetailConfig, ProductPlayDetailConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ProductPlayDetailConfig>, Dictionary<uint, ProductPlayDetailConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ProductPlayDetailConfig> dataDict { /* [XID] */ /* 0x00000001899F2A80-0x00000001899F2AA0 */ get; } // 0x000000018514E920-0x000000018514E9D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A013B0-0x0000000189A013D0 */ get; } // 0x000000018514D770-0x000000018514D810 

	// Methods
	// [XID] // 0x00000001899EAE60-0x00000001899EAE80
	public static void Register() {} // 0x000000018514ED00-0x000000018514EDA0
	// [XID] // 0x00000001899FA010-0x00000001899FA030
	public static ProductPlayDetailConfig GetData(uint configId) => default; // 0x000000018514D640-0x000000018514D770
	// [XID] // 0x0000000189A08CF0-0x0000000189A08D10
	public static void LoadData() {} // 0x000000018514DDA0-0x000000018514DE90
	// [XID] // 0x0000000189A102D0-0x0000000189A102F0
	private static void RegisterHotfixGenerated() {} // 0x000000018514DBD0-0x000000018514DDA0
	// [XID] // 0x0000000189A178D0-0x0000000189A178F0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018514D810-0x000000018514DBD0
	// [IDTag] // 0x0000000189A1EF30-0x0000000189A1EF70
	// [XID] // 0x0000000189A1EF30-0x0000000189A1EF70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018514E280-0x000000018514E380
	// [XID] // 0x0000000189A293A0-0x0000000189A293C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProductPlayDetailConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018514E9D0-0x000000018514ED00
	// [XID] // 0x0000000189A30950-0x0000000189A30970
	private static bool ParseConfigFromLine(string line, out ProductPlayDetailConfig data) {
		data = default;
		return default;
	} // 0x000000018514DE90-0x000000018514DFD0
	// [IDTag] // 0x0000000189A38390-0x0000000189A383D0
	// [XID] // 0x0000000189A38390-0x0000000189A383D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProductPlayDetailConfig> configList) => default; // 0x000000018514DFD0-0x000000018514E280
	// [IDTag] // 0x0000000189A42B30-0x0000000189A42B70
	// [XID] // 0x0000000189A42B30-0x0000000189A42B70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3259 */, bool useObjectPool = false /* Metadata: 0x00AF325D */) => default; // 0x000000018514E6D0-0x000000018514E920
	// [IDTag] // 0x0000000189A4D140-0x0000000189A4D180
	// [XID] // 0x0000000189A4D140-0x0000000189A4D180
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF325E */, bool useObjectPool = false /* Metadata: 0x00AF3262 */) => default; // 0x000000018514E380-0x000000018514E6D0
}

