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

public static class ChestLevelSetConfigLoader // TypeDefIndex: 15512
{
	// Fields
	private static List<ChestLevelSetConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChestLevelSetConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChestLevelSetConfig, ChestLevelSetConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChestLevelSetConfig>, List<ChestLevelSetConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ChestLevelSetConfig> dataList { /* [XID] */ /* 0x00000001899A3570-0x00000001899A3590 */ get; } // 0x00000001851C3D90-0x00000001851C3E40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899AB080-0x00000001899AB0A0 */ get; } // 0x00000001851C2BA0-0x00000001851C2C40 

	// Methods
	// [XID] // 0x000000018999BD00-0x000000018999BD20
	public static void Register() {} // 0x00000001851C4170-0x00000001851C4210
	// [XID] // 0x00000001899B2AD0-0x00000001899B2AF0
	public static void LoadData() {} // 0x00000001851C3240-0x00000001851C3330
	// [XID] // 0x00000001899B9C30-0x00000001899B9C50
	private static void RegisterHotfixGenerated() {} // 0x00000001851C3070-0x00000001851C3240
	// [XID] // 0x00000001899C1790-0x00000001899C17B0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001851C2C40-0x00000001851C3070
	// [IDTag] // 0x00000001899C8D00-0x00000001899C8D40
	// [XID] // 0x00000001899C8D00-0x00000001899C8D40
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001851C3710-0x00000001851C3810
	// [XID] // 0x00000001899D3530-0x00000001899D3550
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChestLevelSetConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001851C3E40-0x00000001851C4170
	// [XID] // 0x00000001899DAB60-0x00000001899DAB80
	private static bool ParseConfigFromLine(string line, out ChestLevelSetConfig data) {
		data = default;
		return default;
	} // 0x00000001851C3330-0x00000001851C3470
	// [IDTag] // 0x00000001899E2400-0x00000001899E2440
	// [XID] // 0x00000001899E2400-0x00000001899E2440
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChestLevelSetConfig> configList) => default; // 0x00000001851C3470-0x00000001851C3710
	// [IDTag] // 0x00000001899EC8B0-0x00000001899EC8F0
	// [XID] // 0x00000001899EC8B0-0x00000001899EC8F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1CB1 */, bool useObjectPool = false /* Metadata: 0x00AF1CB5 */) => default; // 0x00000001851C3B40-0x00000001851C3D90
	// [IDTag] // 0x00000001899F7230-0x00000001899F7270
	// [XID] // 0x00000001899F7230-0x00000001899F7270
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CB6 */, bool useObjectPool = false /* Metadata: 0x00AF1CBA */) => default; // 0x00000001851C3810-0x00000001851C3B40
}

