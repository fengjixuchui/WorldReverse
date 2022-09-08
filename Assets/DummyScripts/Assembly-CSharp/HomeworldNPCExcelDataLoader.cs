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

public static class HomeworldNPCExcelDataLoader // TypeDefIndex: 15711
{
	// Fields
	private static Dictionary<uint, HomeworldNPCExcelData> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeworldNPCExcelData>> customApplyHotfixAction; // 0x08
	public static Action<HomeworldNPCExcelData, HomeworldNPCExcelData> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeworldNPCExcelData>, Dictionary<uint, HomeworldNPCExcelData>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeworldNPCExcelData> dataDict { /* [XID] */ /* 0x0000000189BB4090-0x0000000189BB40B0 */ get; } // 0x00000001835C9900-0x00000001835C99B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BC35B0-0x0000000189BC35D0 */ get; } // 0x00000001835C8750-0x00000001835C87F0 

	// Methods
	// [XID] // 0x0000000189BAC810-0x0000000189BAC830
	public static void Register() {} // 0x00000001835C9CE0-0x00000001835C9D80
	// [XID] // 0x0000000189BBB770-0x0000000189BBB790
	public static HomeworldNPCExcelData GetData(uint avatarID) => default; // 0x00000001835C8620-0x00000001835C8750
	// [XID] // 0x0000000189BCADD0-0x0000000189BCADF0
	public static void LoadData() {} // 0x00000001835C8D80-0x00000001835C8E70
	// [XID] // 0x0000000189BD23E0-0x0000000189BD2400
	private static void RegisterHotfixGenerated() {} // 0x00000001835C8BB0-0x00000001835C8D80
	// [XID] // 0x0000000189BD99C0-0x0000000189BD99E0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001835C87F0-0x00000001835C8BB0
	// [IDTag] // 0x00000001895E6410-0x00000001895E6450
	// [XID] // 0x00000001895E6410-0x00000001895E6450
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001835C8FB0-0x00000001835C90B0
	// [XID] // 0x00000001895F0DC0-0x00000001895F0DE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeworldNPCExcelData> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001835C99B0-0x00000001835C9CE0
	// [XID] // 0x00000001895F87D0-0x00000001895F87F0
	private static bool ParseConfigFromLine(string line, out HomeworldNPCExcelData data) {
		data = default;
		return default;
	} // 0x00000001835C8E70-0x00000001835C8FB0
	// [IDTag] // 0x00000001895FFC70-0x00000001895FFCB0
	// [XID] // 0x00000001895FFC70-0x00000001895FFCB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeworldNPCExcelData> configList) => default; // 0x00000001835C90B0-0x00000001835C9360
	// [IDTag] // 0x000000018960A6D0-0x000000018960A710
	// [XID] // 0x000000018960A6D0-0x000000018960A710
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF23E6 */, bool useObjectPool = false /* Metadata: 0x00AF23EA */) => default; // 0x00000001835C9360-0x00000001835C95B0
	// [IDTag] // 0x0000000189614DA0-0x0000000189614DE0
	// [XID] // 0x0000000189614DA0-0x0000000189614DE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23EB */, bool useObjectPool = false /* Metadata: 0x00AF23EF */) => default; // 0x00000001835C95B0-0x00000001835C9900
}

