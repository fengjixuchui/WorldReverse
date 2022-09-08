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

public static class SystemOpenUIConfigLoader // TypeDefIndex: 15937
{
	// Fields
	private static Dictionary<uint, SystemOpenUIConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SystemOpenUIConfig>> customApplyHotfixAction; // 0x08
	public static Action<SystemOpenUIConfig, SystemOpenUIConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SystemOpenUIConfig>, Dictionary<uint, SystemOpenUIConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SystemOpenUIConfig> dataDict { /* [XID] */ /* 0x0000000189AABAB0-0x0000000189AABAD0 */ get; } // 0x000000018212DA60-0x000000018212DB10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189ABB1D0-0x0000000189ABB1F0 */ get; } // 0x000000018212C8B0-0x000000018212C950 

	// Methods
	// [XID] // 0x0000000189AA4520-0x0000000189AA4540
	public static void Register() {} // 0x000000018212DE40-0x000000018212DEE0
	// [XID] // 0x0000000189AB3460-0x0000000189AB3480
	public static SystemOpenUIConfig GetData(uint id) => default; // 0x000000018212C780-0x000000018212C8B0
	// [XID] // 0x0000000189AC29A0-0x0000000189AC29C0
	public static void LoadData() {} // 0x000000018212CEE0-0x000000018212CFD0
	// [XID] // 0x0000000189ACA000-0x0000000189ACA020
	private static void RegisterHotfixGenerated() {} // 0x000000018212CD10-0x000000018212CEE0
	// [XID] // 0x0000000189AD17F0-0x0000000189AD1810
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018212C950-0x000000018212CD10
	// [IDTag] // 0x0000000189AD9590-0x0000000189AD95D0
	// [XID] // 0x0000000189AD9590-0x0000000189AD95D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018212D110-0x000000018212D210
	// [XID] // 0x0000000189AE3F90-0x0000000189AE3FB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SystemOpenUIConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018212DB10-0x000000018212DE40
	// [XID] // 0x0000000189AEB870-0x0000000189AEB890
	private static bool ParseConfigFromLine(string line, out SystemOpenUIConfig data) {
		data = default;
		return default;
	} // 0x000000018212CFD0-0x000000018212D110
	// [IDTag] // 0x0000000189AF31B0-0x0000000189AF31F0
	// [XID] // 0x0000000189AF31B0-0x0000000189AF31F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SystemOpenUIConfig> configList) => default; // 0x000000018212D210-0x000000018212D4C0
	// [IDTag] // 0x0000000189AFD670-0x0000000189AFD6B0
	// [XID] // 0x0000000189AFD670-0x0000000189AFD6B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BA9 */, bool useObjectPool = false /* Metadata: 0x00AF2BAD */) => default; // 0x000000018212D4C0-0x000000018212D710
	// [IDTag] // 0x0000000189B07D50-0x0000000189B07D90
	// [XID] // 0x0000000189B07D50-0x0000000189B07D90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BAE */, bool useObjectPool = false /* Metadata: 0x00AF2BB2 */) => default; // 0x000000018212D710-0x000000018212DA60
}

