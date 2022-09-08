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

public static class BuffIconExcelConfigLoader // TypeDefIndex: 14840
{
	// Fields
	private static List<BuffIconExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<BuffIconExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BuffIconExcelConfig, BuffIconExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BuffIconExcelConfig>, List<BuffIconExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<BuffIconExcelConfig> dataList { /* [XID] */ /* 0x00000001897D2890-0x00000001897D28B0 */ get; } // 0x0000000184304990-0x0000000184304A40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897DA5F0-0x00000001897DA610 */ get; } // 0x00000001843036E0-0x0000000184303780 

	// Methods
	// [XID] // 0x00000001897BC3F0-0x00000001897BC410
	public static BuffIconExcelConfig GetData(int id) => default; // 0x0000000184303560-0x00000001843036E0
	// [XID] // 0x00000001897C3AB0-0x00000001897C3AD0
	public static bool IsDebuff(BuffIconExcelConfig config) => default; // 0x0000000184304350-0x0000000184304410
	// [XID] // 0x00000001897CB1F0-0x00000001897CB210
	public static void Register() {} // 0x0000000184304D70-0x0000000184304E10
	// [XID] // 0x00000001897E1AA0-0x00000001897E1AC0
	public static void LoadData() {} // 0x0000000184303D80-0x0000000184303E70
	// [XID] // 0x00000001897E92B0-0x00000001897E92D0
	private static void RegisterHotfixGenerated() {} // 0x0000000184303BB0-0x0000000184303D80
	// [XID] // 0x00000001897F0E40-0x00000001897F0E60
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184303780-0x0000000184303BB0
	// [IDTag] // 0x00000001897F86A0-0x00000001897F86E0
	// [XID] // 0x00000001897F86A0-0x00000001897F86E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184304250-0x0000000184304350
	// [XID] // 0x0000000189802D40-0x0000000189802D60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BuffIconExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184304A40-0x0000000184304D70
	// [XID] // 0x000000018980A2D0-0x000000018980A2F0
	private static bool ParseConfigFromLine(string line, out BuffIconExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184303E70-0x0000000184303FB0
	// [IDTag] // 0x0000000189811A20-0x0000000189811A60
	// [XID] // 0x0000000189811A20-0x0000000189811A60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BuffIconExcelConfig> configList) => default; // 0x0000000184303FB0-0x0000000184304250
	// [IDTag] // 0x000000018981C280-0x000000018981C2C0
	// [XID] // 0x000000018981C280-0x000000018981C2C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF738 */, bool useObjectPool = false /* Metadata: 0x00AEF73C */) => default; // 0x0000000184304410-0x0000000184304660
	// [IDTag] // 0x00000001898268D0-0x0000000189826910
	// [XID] // 0x00000001898268D0-0x0000000189826910
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF73D */, bool useObjectPool = false /* Metadata: 0x00AEF741 */) => default; // 0x0000000184304660-0x0000000184304990
}

