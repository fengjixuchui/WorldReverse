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

public static class RoutineTypeExcelConfigLoader // TypeDefIndex: 16079
{
	// Fields
	private static Dictionary<int, RoutineTypeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RoutineTypeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RoutineTypeExcelConfig, RoutineTypeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RoutineTypeExcelConfig>, Dictionary<int, RoutineTypeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<int, RoutineTypeExcelConfig> dataDict { /* [XID] */ /* 0x00000001898296F0-0x0000000189829710 */ get; } // 0x0000000181187080-0x0000000181187130 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898383E0-0x0000000189838400 */ get; } // 0x0000000181185ED0-0x0000000181185F70 

	// Methods
	// [XID] // 0x00000001898221B0-0x00000001898221D0
	public static void Register() {} // 0x0000000181187460-0x0000000181187500
	// [XID] // 0x0000000189830CC0-0x0000000189830CE0
	public static RoutineTypeExcelConfig GetData(GeneralRoutineType routineType) => default; // 0x0000000181185DA0-0x0000000181185ED0
	// [XID] // 0x000000018983FA70-0x000000018983FA90
	public static void LoadData() {} // 0x0000000181186500-0x00000001811865F0
	// [XID] // 0x00000001898470D0-0x00000001898470F0
	private static void RegisterHotfixGenerated() {} // 0x0000000181186330-0x0000000181186500
	// [XID] // 0x000000018984E680-0x000000018984E6A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181185F70-0x0000000181186330
	// [IDTag] // 0x00000001898556F0-0x0000000189855730
	// [XID] // 0x00000001898556F0-0x0000000189855730
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001811869E0-0x0000000181186AE0
	// [XID] // 0x000000018985FBF0-0x000000018985FC10
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RoutineTypeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181187130-0x0000000181187460
	// [XID] // 0x0000000189867310-0x0000000189867330
	private static bool ParseConfigFromLine(string line, out RoutineTypeExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001811865F0-0x0000000181186730
	// [IDTag] // 0x000000018986EA70-0x000000018986EAB0
	// [XID] // 0x000000018986EA70-0x000000018986EAB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RoutineTypeExcelConfig> configList) => default; // 0x0000000181186730-0x00000001811869E0
	// [IDTag] // 0x0000000189878FB0-0x0000000189878FF0
	// [XID] // 0x0000000189878FB0-0x0000000189878FF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2FA8 */, bool useObjectPool = false /* Metadata: 0x00AF2FAC */) => default; // 0x0000000181186E30-0x0000000181187080
	// [IDTag] // 0x0000000189883110-0x0000000189883150
	// [XID] // 0x0000000189883110-0x0000000189883150
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FAD */, bool useObjectPool = false /* Metadata: 0x00AF2FB1 */) => default; // 0x0000000181186AE0-0x0000000181186E30
}

