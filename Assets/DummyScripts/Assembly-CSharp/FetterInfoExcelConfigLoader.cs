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

public static class FetterInfoExcelConfigLoader // TypeDefIndex: 15613
{
	// Fields
	private static Dictionary<uint, FetterInfoExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FetterInfoExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FetterInfoExcelConfig, FetterInfoExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FetterInfoExcelConfig>, Dictionary<uint, FetterInfoExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FetterInfoExcelConfig> dataDict { /* [XID] */ /* 0x0000000189796FF0-0x0000000189797010 */ get; } // 0x0000000183167B50-0x0000000183167C00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001897A6600-0x00000001897A6620 */ get; } // 0x00000001831669A0-0x0000000183166A40 

	// Methods
	// [XID] // 0x000000018978F7C0-0x000000018978F7E0
	public static void Register() {} // 0x0000000183167F30-0x0000000183167FD0
	// [XID] // 0x000000018979F010-0x000000018979F030
	public static FetterInfoExcelConfig GetData(uint fetter_id) => default; // 0x0000000183166870-0x00000001831669A0
	// [XID] // 0x00000001897ADBD0-0x00000001897ADBF0
	public static void LoadData() {} // 0x0000000183166FD0-0x00000001831670C0
	// [XID] // 0x00000001897B5D50-0x00000001897B5D70
	private static void RegisterHotfixGenerated() {} // 0x0000000183166E00-0x0000000183166FD0
	// [XID] // 0x00000001897BDB40-0x00000001897BDB60
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183166A40-0x0000000183166E00
	// [IDTag] // 0x00000001897C4F20-0x00000001897C4F60
	// [XID] // 0x00000001897C4F20-0x00000001897C4F60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183167200-0x0000000183167300
	// [XID] // 0x00000001897CF7F0-0x00000001897CF810
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FetterInfoExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183167C00-0x0000000183167F30
	// [XID] // 0x00000001897D70C0-0x00000001897D70E0
	private static bool ParseConfigFromLine(string line, out FetterInfoExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001831670C0-0x0000000183167200
	// [IDTag] // 0x00000001897DE650-0x00000001897DE690
	// [XID] // 0x00000001897DE650-0x00000001897DE690
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FetterInfoExcelConfig> configList) => default; // 0x0000000183167300-0x00000001831675B0
	// [IDTag] // 0x00000001897E90D0-0x00000001897E9110
	// [XID] // 0x00000001897E90D0-0x00000001897E9110
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF209C */, bool useObjectPool = false /* Metadata: 0x00AF20A0 */) => default; // 0x0000000183167900-0x0000000183167B50
	// [IDTag] // 0x00000001897F3D30-0x00000001897F3D70
	// [XID] // 0x00000001897F3D30-0x00000001897F3D70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20A1 */, bool useObjectPool = false /* Metadata: 0x00AF20A5 */) => default; // 0x00000001831675B0-0x0000000183167900
}

