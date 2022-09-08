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

public static class BuffExcelConfigLoader // TypeDefIndex: 15297
{
	// Fields
	private static Dictionary<uint, BuffExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BuffExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BuffExcelConfig, BuffExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BuffExcelConfig>, Dictionary<uint, BuffExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BuffExcelConfig> dataDict { /* [XID] */ /* 0x0000000189716A80-0x0000000189716AA0 */ get; } // 0x0000000183CB4A80-0x0000000183CB4B30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189725AA0-0x0000000189725AC0 */ get; } // 0x0000000183CB38D0-0x0000000183CB3970 

	// Methods
	// [XID] // 0x000000018970F800-0x000000018970F820
	public static void Register() {} // 0x0000000183CB4E60-0x0000000183CB4F00
	// [XID] // 0x000000018971E4A0-0x000000018971E4C0
	public static BuffExcelConfig GetData(uint serverBuffId) => default; // 0x0000000183CB37A0-0x0000000183CB38D0
	// [XID] // 0x000000018972D020-0x000000018972D040
	public static void LoadData() {} // 0x0000000183CB3F00-0x0000000183CB3FF0
	// [XID] // 0x00000001897347B0-0x00000001897347D0
	private static void RegisterHotfixGenerated() {} // 0x0000000183CB3D30-0x0000000183CB3F00
	// [XID] // 0x000000018973C180-0x000000018973C1A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183CB3970-0x0000000183CB3D30
	// [IDTag] // 0x00000001897438F0-0x0000000189743930
	// [XID] // 0x00000001897438F0-0x0000000189743930
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183CB43E0-0x0000000183CB44E0
	// [XID] // 0x000000018974E330-0x000000018974E350
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BuffExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183CB4B30-0x0000000183CB4E60
	// [XID] // 0x0000000189755950-0x0000000189755970
	private static bool ParseConfigFromLine(string line, out BuffExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183CB3FF0-0x0000000183CB4130
	// [IDTag] // 0x000000018975CC70-0x000000018975CCB0
	// [XID] // 0x000000018975CC70-0x000000018975CCB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BuffExcelConfig> configList) => default; // 0x0000000183CB4130-0x0000000183CB43E0
	// [IDTag] // 0x00000001897674C0-0x0000000189767500
	// [XID] // 0x00000001897674C0-0x0000000189767500
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF06AD */, bool useObjectPool = false /* Metadata: 0x00AF06B1 */) => default; // 0x0000000183CB44E0-0x0000000183CB4730
	// [IDTag] // 0x0000000189771C90-0x0000000189771CD0
	// [XID] // 0x0000000189771C90-0x0000000189771CD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF06B2 */, bool useObjectPool = false /* Metadata: 0x00AF06B6 */) => default; // 0x0000000183CB4730-0x0000000183CB4A80
}

