/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class DialogSelectTimeOutExcelConfigLoader // TypeDefIndex: 15975
{
	// Fields
	private static Dictionary<uint, DialogSelectTimeOutExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<DialogSelectTimeOutExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<DialogSelectTimeOutExcelConfig, DialogSelectTimeOutExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<DialogSelectTimeOutExcelConfig>, Dictionary<uint, DialogSelectTimeOutExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, DialogSelectTimeOutExcelConfig> dataDict { /* [XID] */ /* 0x0000000189936D90-0x0000000189936DB0 */ get; } // 0x0000000183755030-0x00000001837550E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189945FC0-0x0000000189945FE0 */ get; } // 0x0000000183753E80-0x0000000183753F20 

	// Methods
	// [XID] // 0x000000018992F880-0x000000018992F8A0
	public static void Register() {} // 0x0000000183755410-0x00000001837554B0
	// [XID] // 0x000000018993E950-0x000000018993E970
	public static DialogSelectTimeOutExcelConfig GetData(uint id) => default; // 0x0000000183753D50-0x0000000183753E80
	// [XID] // 0x000000018994D490-0x000000018994D4B0
	public static void LoadData() {} // 0x00000001837544B0-0x00000001837545A0
	// [XID] // 0x0000000189954B60-0x0000000189954B80
	private static void RegisterHotfixGenerated() {} // 0x00000001837542E0-0x00000001837544B0
	// [XID] // 0x000000018995C380-0x000000018995C3A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183753F20-0x00000001837542E0
	// [IDTag] // 0x0000000189963DC0-0x0000000189963E00
	// [XID] // 0x0000000189963DC0-0x0000000189963E00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001837546E0-0x00000001837547E0
	// [XID] // 0x000000018996E180-0x000000018996E1A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<DialogSelectTimeOutExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001837550E0-0x0000000183755410
	// [XID] // 0x0000000189975D30-0x0000000189975D50
	private static bool ParseConfigFromLine(string line, out DialogSelectTimeOutExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001837545A0-0x00000001837546E0
	// [IDTag] // 0x000000018997CE50-0x000000018997CE90
	// [XID] // 0x000000018997CE50-0x000000018997CE90
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<DialogSelectTimeOutExcelConfig> configList) => default; // 0x00000001837547E0-0x0000000183754A90
	// [IDTag] // 0x0000000189987BF0-0x0000000189987C30
	// [XID] // 0x0000000189987BF0-0x0000000189987C30
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2CB6 */, bool useObjectPool = false /* Metadata: 0x00AF2CBA */) => default; // 0x0000000183754A90-0x0000000183754CE0
	// [IDTag] // 0x0000000189992910-0x0000000189992950
	// [XID] // 0x0000000189992910-0x0000000189992950
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CBB */, bool useObjectPool = false /* Metadata: 0x00AF2CBF */) => default; // 0x0000000183754CE0-0x0000000183755030
}

