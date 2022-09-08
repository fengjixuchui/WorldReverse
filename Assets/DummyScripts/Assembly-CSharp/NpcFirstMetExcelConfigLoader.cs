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

public static class NpcFirstMetExcelConfigLoader // TypeDefIndex: 15914
{
	// Fields
	private static Dictionary<uint, NpcFirstMetExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NpcFirstMetExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NpcFirstMetExcelConfig, NpcFirstMetExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NpcFirstMetExcelConfig>, Dictionary<uint, NpcFirstMetExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NpcFirstMetExcelConfig> dataDict { /* [XID] */ /* 0x000000018992F8E0-0x000000018992F900 */ get; } // 0x0000000183C317C0-0x0000000183C31870 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018993E990-0x000000018993E9B0 */ get; } // 0x0000000183C30610-0x0000000183C306B0 

	// Methods
	// [XID] // 0x0000000189928330-0x0000000189928350
	public static void Register() {} // 0x0000000183C31BA0-0x0000000183C31C40
	// [XID] // 0x0000000189936DF0-0x0000000189936E10
	public static NpcFirstMetExcelConfig GetData(uint id) => default; // 0x0000000183C304E0-0x0000000183C30610
	// [XID] // 0x0000000189946000-0x0000000189946020
	public static void LoadData() {} // 0x0000000183C30C40-0x0000000183C30D30
	// [XID] // 0x000000018994D510-0x000000018994D530
	private static void RegisterHotfixGenerated() {} // 0x0000000183C30A70-0x0000000183C30C40
	// [XID] // 0x0000000189954BA0-0x0000000189954BC0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183C306B0-0x0000000183C30A70
	// [IDTag] // 0x000000018995C3C0-0x000000018995C400
	// [XID] // 0x000000018995C3C0-0x000000018995C400
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183C31120-0x0000000183C31220
	// [XID] // 0x0000000189966E50-0x0000000189966E70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NpcFirstMetExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183C31870-0x0000000183C31BA0
	// [XID] // 0x000000018996E1C0-0x000000018996E1E0
	private static bool ParseConfigFromLine(string line, out NpcFirstMetExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183C30D30-0x0000000183C30E70
	// [IDTag] // 0x0000000189975D70-0x0000000189975DB0
	// [XID] // 0x0000000189975D70-0x0000000189975DB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NpcFirstMetExcelConfig> configList) => default; // 0x0000000183C30E70-0x0000000183C31120
	// [IDTag] // 0x0000000189980380-0x00000001899803C0
	// [XID] // 0x0000000189980380-0x00000001899803C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B06 */, bool useObjectPool = false /* Metadata: 0x00AF2B0A */) => default; // 0x0000000183C31220-0x0000000183C31470
	// [IDTag] // 0x000000018998AFE0-0x000000018998B020
	// [XID] // 0x000000018998AFE0-0x000000018998B020
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B0B */, bool useObjectPool = false /* Metadata: 0x00AF2B0F */) => default; // 0x0000000183C31470-0x0000000183C317C0
}

