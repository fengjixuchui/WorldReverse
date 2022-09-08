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

public static class NewActivityTimeGroupExcelConfigLoader // TypeDefIndex: 15904
{
	// Fields
	private static Dictionary<uint, NewActivityTimeGroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NewActivityTimeGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NewActivityTimeGroupExcelConfig, NewActivityTimeGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NewActivityTimeGroupExcelConfig>, Dictionary<uint, NewActivityTimeGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NewActivityTimeGroupExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A07790-0x0000000189A077B0 */ get; } // 0x00000001833BF110-0x00000001833BF1C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A163E0-0x0000000189A16400 */ get; } // 0x00000001833BDF60-0x00000001833BE000 

	// Methods
	// [XID] // 0x00000001899FFEC0-0x00000001899FFEE0
	public static void Register() {} // 0x00000001833BF4F0-0x00000001833BF590
	// [XID] // 0x0000000189A0EC10-0x0000000189A0EC30
	public static NewActivityTimeGroupExcelConfig GetData(uint id) => default; // 0x00000001833BDE30-0x00000001833BDF60
	// [XID] // 0x0000000189A1D9C0-0x0000000189A1D9E0
	public static void LoadData() {} // 0x00000001833BE590-0x00000001833BE680
	// [XID] // 0x0000000189A24DB0-0x0000000189A24DD0
	private static void RegisterHotfixGenerated() {} // 0x00000001833BE3C0-0x00000001833BE590
	// [XID] // 0x0000000189A2C370-0x0000000189A2C390
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001833BE000-0x00000001833BE3C0
	// [IDTag] // 0x0000000189A33A20-0x0000000189A33A60
	// [XID] // 0x0000000189A33A20-0x0000000189A33A60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833BEA70-0x00000001833BEB70
	// [XID] // 0x0000000189A3E430-0x0000000189A3E450
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NewActivityTimeGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001833BF1C0-0x00000001833BF4F0
	// [XID] // 0x0000000189A45AC0-0x0000000189A45AE0
	private static bool ParseConfigFromLine(string line, out NewActivityTimeGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001833BE680-0x00000001833BE7C0
	// [IDTag] // 0x0000000189A4D220-0x0000000189A4D260
	// [XID] // 0x0000000189A4D220-0x0000000189A4D260
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NewActivityTimeGroupExcelConfig> configList) => default; // 0x00000001833BE7C0-0x00000001833BEA70
	// [IDTag] // 0x0000000189A577D0-0x0000000189A57810
	// [XID] // 0x0000000189A577D0-0x0000000189A57810
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2ABE */, bool useObjectPool = false /* Metadata: 0x00AF2AC2 */) => default; // 0x00000001833BEEC0-0x00000001833BF110
	// [IDTag] // 0x0000000189A62050-0x0000000189A62090
	// [XID] // 0x0000000189A62050-0x0000000189A62090
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AC3 */, bool useObjectPool = false /* Metadata: 0x00AF2AC7 */) => default; // 0x00000001833BEB70-0x00000001833BEEC0
}

