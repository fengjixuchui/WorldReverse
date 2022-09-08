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

public static class HomeWorldComfortLevelExcelConfigLoader // TypeDefIndex: 15731
{
	// Fields
	private static Dictionary<uint, HomeWorldComfortLevelExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HomeWorldComfortLevelExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HomeWorldComfortLevelExcelConfig, HomeWorldComfortLevelExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HomeWorldComfortLevelExcelConfig>, Dictionary<uint, HomeWorldComfortLevelExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HomeWorldComfortLevelExcelConfig> dataDict { /* [XID] */ /* 0x000000018968ECD0-0x000000018968ECF0 */ get; } // 0x000000018243C610-0x000000018243C6C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018969DC90-0x000000018969DCB0 */ get; } // 0x000000018243B460-0x000000018243B500 

	// Methods
	// [XID] // 0x0000000189686DF0-0x0000000189686E10
	public static void Register() {} // 0x000000018243C9F0-0x000000018243CA90
	// [XID] // 0x0000000189696630-0x0000000189696650
	public static HomeWorldComfortLevelExcelConfig GetData(uint levelID) => default; // 0x000000018243B330-0x000000018243B460
	// [XID] // 0x00000001896A4CC0-0x00000001896A4CE0
	public static void LoadData() {} // 0x000000018243BA90-0x000000018243BB80
	// [XID] // 0x00000001896AC470-0x00000001896AC490
	private static void RegisterHotfixGenerated() {} // 0x000000018243B8C0-0x000000018243BA90
	// [XID] // 0x00000001896B3710-0x00000001896B3730
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018243B500-0x000000018243B8C0
	// [IDTag] // 0x00000001896BAEB0-0x00000001896BAEF0
	// [XID] // 0x00000001896BAEB0-0x00000001896BAEF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018243BF70-0x000000018243C070
	// [XID] // 0x00000001896C51D0-0x00000001896C51F0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HomeWorldComfortLevelExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018243C6C0-0x000000018243C9F0
	// [XID] // 0x00000001896CC7D0-0x00000001896CC7F0
	private static bool ParseConfigFromLine(string line, out HomeWorldComfortLevelExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018243BB80-0x000000018243BCC0
	// [IDTag] // 0x00000001896D3A80-0x00000001896D3AC0
	// [XID] // 0x00000001896D3A80-0x00000001896D3AC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HomeWorldComfortLevelExcelConfig> configList) => default; // 0x000000018243BCC0-0x000000018243BF70
	// [IDTag] // 0x00000001896DE460-0x00000001896DE4A0
	// [XID] // 0x00000001896DE460-0x00000001896DE4A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF247C */, bool useObjectPool = false /* Metadata: 0x00AF2480 */) => default; // 0x000000018243C070-0x000000018243C2C0
	// [IDTag] // 0x00000001896E8860-0x00000001896E88A0
	// [XID] // 0x00000001896E8860-0x00000001896E88A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2481 */, bool useObjectPool = false /* Metadata: 0x00AF2485 */) => default; // 0x000000018243C2C0-0x000000018243C610
}

