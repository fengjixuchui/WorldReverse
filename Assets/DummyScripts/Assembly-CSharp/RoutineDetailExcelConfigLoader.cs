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

public static class RoutineDetailExcelConfigLoader // TypeDefIndex: 16083
{
	// Fields
	private static Dictionary<uint, RoutineDetailExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RoutineDetailExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RoutineDetailExcelConfig, RoutineDetailExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RoutineDetailExcelConfig>, Dictionary<uint, RoutineDetailExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RoutineDetailExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A1A730-0x0000000189A1A750 */ get; } // 0x00000001811C05F0-0x00000001811C06A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A293E0-0x0000000189A29400 */ get; } // 0x00000001811BF440-0x00000001811BF4E0 

	// Methods
	// [XID] // 0x0000000189A13580-0x0000000189A135A0
	public static void Register() {} // 0x00000001811C09D0-0x00000001811C0A70
	// [XID] // 0x0000000189A21FB0-0x0000000189A21FD0
	public static RoutineDetailExcelConfig GetData(uint routineId) => default; // 0x00000001811BF310-0x00000001811BF440
	// [XID] // 0x0000000189A309B0-0x0000000189A309D0
	public static void LoadData() {} // 0x00000001811BFA70-0x00000001811BFB60
	// [XID] // 0x0000000189A383D0-0x0000000189A383F0
	private static void RegisterHotfixGenerated() {} // 0x00000001811BF8A0-0x00000001811BFA70
	// [XID] // 0x0000000189A3FB60-0x0000000189A3FB80
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001811BF4E0-0x00000001811BF8A0
	// [IDTag] // 0x0000000189A47230-0x0000000189A47270
	// [XID] // 0x0000000189A47230-0x0000000189A47270
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001811BFF50-0x00000001811C0050
	// [XID] // 0x0000000189A51990-0x0000000189A519B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RoutineDetailExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001811C06A0-0x00000001811C09D0
	// [XID] // 0x0000000189A59200-0x0000000189A59220
	private static bool ParseConfigFromLine(string line, out RoutineDetailExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001811BFB60-0x00000001811BFCA0
	// [IDTag] // 0x0000000189A60B20-0x0000000189A60B60
	// [XID] // 0x0000000189A60B20-0x0000000189A60B60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RoutineDetailExcelConfig> configList) => default; // 0x00000001811BFCA0-0x00000001811BFF50
	// [IDTag] // 0x0000000189A6B610-0x0000000189A6B650
	// [XID] // 0x0000000189A6B610-0x0000000189A6B650
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2FC1 */, bool useObjectPool = false /* Metadata: 0x00AF2FC5 */) => default; // 0x00000001811C03A0-0x00000001811C05F0
	// [IDTag] // 0x0000000189A75B30-0x0000000189A75B70
	// [XID] // 0x0000000189A75B30-0x0000000189A75B70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FC6 */, bool useObjectPool = false /* Metadata: 0x00AF2FCA */) => default; // 0x00000001811C0050-0x00000001811C03A0
}

