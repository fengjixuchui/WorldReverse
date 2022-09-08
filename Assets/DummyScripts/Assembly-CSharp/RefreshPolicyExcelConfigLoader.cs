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

public static class RefreshPolicyExcelConfigLoader // TypeDefIndex: 16010
{
	// Fields
	private static Dictionary<uint, RefreshPolicyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RefreshPolicyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RefreshPolicyExcelConfig, RefreshPolicyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RefreshPolicyExcelConfig>, Dictionary<uint, RefreshPolicyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RefreshPolicyExcelConfig> dataDict { /* [XID] */ /* 0x000000018985CBF0-0x000000018985CC10 */ get; } // 0x0000000184041360-0x0000000184041410 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018986BB80-0x000000018986BBA0 */ get; } // 0x00000001840401B0-0x0000000184040250 

	// Methods
	// [XID] // 0x0000000189855730-0x0000000189855750
	public static void Register() {} // 0x0000000184041740-0x00000001840417E0
	// [XID] // 0x00000001898645F0-0x0000000189864610
	public static RefreshPolicyExcelConfig GetData(uint id) => default; // 0x0000000184040080-0x00000001840401B0
	// [XID] // 0x0000000189872E70-0x0000000189872E90
	public static void LoadData() {} // 0x00000001840407E0-0x00000001840408D0
	// [XID] // 0x000000018987AB70-0x000000018987AB90
	private static void RegisterHotfixGenerated() {} // 0x0000000184040610-0x00000001840407E0
	// [XID] // 0x0000000189881B80-0x0000000189881BA0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184040250-0x0000000184040610
	// [IDTag] // 0x0000000189889260-0x00000001898892A0
	// [XID] // 0x0000000189889260-0x00000001898892A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184040CC0-0x0000000184040DC0
	// [XID] // 0x0000000189893670-0x0000000189893690
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RefreshPolicyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184041410-0x0000000184041740
	// [XID] // 0x000000018989AD70-0x000000018989AD90
	private static bool ParseConfigFromLine(string line, out RefreshPolicyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001840408D0-0x0000000184040A10
	// [IDTag] // 0x00000001898A2100-0x00000001898A2140
	// [XID] // 0x00000001898A2100-0x00000001898A2140
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RefreshPolicyExcelConfig> configList) => default; // 0x0000000184040A10-0x0000000184040CC0
	// [IDTag] // 0x00000001898AC8C0-0x00000001898AC900
	// [XID] // 0x00000001898AC8C0-0x00000001898AC900
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2DA3 */, bool useObjectPool = false /* Metadata: 0x00AF2DA7 */) => default; // 0x0000000184040DC0-0x0000000184041010
	// [IDTag] // 0x00000001898B6F70-0x00000001898B6FB0
	// [XID] // 0x00000001898B6F70-0x00000001898B6FB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DA8 */, bool useObjectPool = false /* Metadata: 0x00AF2DAC */) => default; // 0x0000000184041010-0x0000000184041360
}

