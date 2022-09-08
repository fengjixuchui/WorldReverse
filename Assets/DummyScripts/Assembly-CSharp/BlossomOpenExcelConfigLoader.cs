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

public static class BlossomOpenExcelConfigLoader // TypeDefIndex: 15266
{
	// Fields
	private static Dictionary<uint, BlossomOpenExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BlossomOpenExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BlossomOpenExcelConfig, BlossomOpenExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BlossomOpenExcelConfig>, Dictionary<uint, BlossomOpenExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BlossomOpenExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A444F0-0x0000000189A44510 */ get; } // 0x0000000183822490-0x0000000183822540 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A531A0-0x0000000189A531C0 */ get; } // 0x00000001838212E0-0x0000000183821380 

	// Methods
	// [XID] // 0x0000000189A3CAE0-0x0000000189A3CB00
	public static void Register() {} // 0x0000000183822870-0x0000000183822970
	// [XID] // 0x0000000189A4BAC0-0x0000000189A4BAE0
	public static BlossomOpenExcelConfig GetData(uint cityId) => default; // 0x00000001838211B0-0x00000001838212E0
	// [XID] // 0x0000000189A5A950-0x0000000189A5A970
	public static void LoadData() {} // 0x0000000183821910-0x0000000183821A00
	// [XID] // 0x0000000189A62150-0x0000000189A62170
	private static void RegisterHotfixGenerated() {} // 0x0000000183821740-0x0000000183821910
	// [XID] // 0x0000000189A6A010-0x0000000189A6A030
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183821380-0x0000000183821740
	// [IDTag] // 0x0000000189A71300-0x0000000189A71340
	// [XID] // 0x0000000189A71300-0x0000000189A71340
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183821B40-0x0000000183821C40
	// [XID] // 0x0000000189A7BE60-0x0000000189A7BE80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BlossomOpenExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183822540-0x0000000183822870
	// [XID] // 0x0000000189A83880-0x0000000189A838A0
	private static bool ParseConfigFromLine(string line, out BlossomOpenExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183821A00-0x0000000183821B40
	// [IDTag] // 0x0000000189A8B040-0x0000000189A8B080
	// [XID] // 0x0000000189A8B040-0x0000000189A8B080
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BlossomOpenExcelConfig> configList) => default; // 0x0000000183821C40-0x0000000183821EF0
	// [IDTag] // 0x0000000189A955B0-0x0000000189A955F0
	// [XID] // 0x0000000189A955B0-0x0000000189A955F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF05B9 */, bool useObjectPool = false /* Metadata: 0x00AF05BD */) => default; // 0x0000000183821EF0-0x0000000183822140
	// [IDTag] // 0x0000000189A9FD50-0x0000000189A9FD90
	// [XID] // 0x0000000189A9FD50-0x0000000189A9FD90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05BE */, bool useObjectPool = false /* Metadata: 0x00AF05C2 */) => default; // 0x0000000183822140-0x0000000183822490
}

