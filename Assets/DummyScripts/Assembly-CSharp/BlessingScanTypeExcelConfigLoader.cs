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

public static class BlessingScanTypeExcelConfigLoader // TypeDefIndex: 14807
{
	// Fields
	private static Dictionary<uint, BlessingScanTypeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlessingScanTypeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlessingScanTypeExcelConfig, BlessingScanTypeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlessingScanTypeExcelConfig>, Dictionary<uint, BlessingScanTypeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlessingScanTypeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BC37D0-0x0000000189BC37F0 */ get; } // 0x000000018321DEC0-0x000000018321DF70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BD2660-0x0000000189BD2680 */ get; } // 0x000000018321CAC0-0x000000018321CB60 

	// Methods
	// [XID] // 0x0000000189BB4330-0x0000000189BB4350
	public static BlessingScanTypeExcelConfig GetConfigByTypeId(uint typeId) => default; // 0x000000018321D320-0x000000018321D570
	// [XID] // 0x0000000189BBB930-0x0000000189BBB950
	public static void Register() {} // 0x000000018321E2A0-0x000000018321E340
	// [XID] // 0x0000000189BCAF90-0x0000000189BCAFB0
	public static BlessingScanTypeExcelConfig GetData(uint id) => default; // 0x000000018321C990-0x000000018321CAC0
	// [XID] // 0x0000000189BD9BA0-0x0000000189BD9BC0
	public static void LoadData() {} // 0x000000018321D0F0-0x000000018321D1E0
	// [XID] // 0x00000001895E65F0-0x00000001895E6610
	private static void RegisterHotfixGenerated() {} // 0x000000018321CF20-0x000000018321D0F0
	// [XID] // 0x00000001895EE130-0x00000001895EE150
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018321CB60-0x000000018321CF20
	// [IDTag] // 0x00000001895F5850-0x00000001895F5890
	// [XID] // 0x00000001895F5850-0x00000001895F5890
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018321D570-0x000000018321D670
	// [XID] // 0x00000001895FFE50-0x00000001895FFE70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlessingScanTypeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018321DF70-0x000000018321E2A0
	// [XID] // 0x00000001896075C0-0x00000001896075E0
	private static bool ParseConfigFromLine(string line, out BlessingScanTypeExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018321D1E0-0x000000018321D320
	// [IDTag] // 0x000000018960F0C0-0x000000018960F100
	// [XID] // 0x000000018960F0C0-0x000000018960F100
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlessingScanTypeExcelConfig> configList) => default; // 0x000000018321D670-0x000000018321D920
	// [IDTag] // 0x00000001896197C0-0x0000000189619800
	// [XID] // 0x00000001896197C0-0x0000000189619800
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF602 */, bool useObjectPool = false /* Metadata: 0x00AEF606 */) => default; // 0x000000018321DC70-0x000000018321DEC0
	// [IDTag] // 0x0000000189623C20-0x0000000189623C60
	// [XID] // 0x0000000189623C20-0x0000000189623C60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF607 */, bool useObjectPool = false /* Metadata: 0x00AEF60B */) => default; // 0x000000018321D920-0x000000018321DC70
}

