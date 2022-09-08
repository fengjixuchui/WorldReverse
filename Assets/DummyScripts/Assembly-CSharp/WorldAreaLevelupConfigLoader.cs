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

public static class WorldAreaLevelupConfigLoader // TypeDefIndex: 16302
{
	// Fields
	private static List<WorldAreaLevelupConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<WorldAreaLevelupConfig>> customApplyHotfixAction; // 0x08
	public static Action<WorldAreaLevelupConfig, WorldAreaLevelupConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<WorldAreaLevelupConfig>, List<WorldAreaLevelupConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<WorldAreaLevelupConfig> dataList { /* [XID] */ /* 0x00000001899208D0-0x00000001899208F0 */ get; } // 0x00000001851AF420-0x00000001851AF4D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189928290-0x00000001899282B0 */ get; } // 0x00000001851AE230-0x00000001851AE2D0 

	// Methods
	// [XID] // 0x0000000189919340-0x0000000189919360
	public static void Register() {} // 0x00000001851AF800-0x00000001851AF8A0
	// [XID] // 0x000000018992F800-0x000000018992F820
	public static void LoadData() {} // 0x00000001851AE8D0-0x00000001851AE9C0
	// [XID] // 0x0000000189936CD0-0x0000000189936CF0
	private static void RegisterHotfixGenerated() {} // 0x00000001851AE700-0x00000001851AE8D0
	// [XID] // 0x000000018993E8D0-0x000000018993E8F0
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001851AE2D0-0x00000001851AE700
	// [IDTag] // 0x0000000189945E80-0x0000000189945EC0
	// [XID] // 0x0000000189945E80-0x0000000189945EC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001851AEB00-0x00000001851AEC00
	// [XID] // 0x00000001899506B0-0x00000001899506D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<WorldAreaLevelupConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001851AF4D0-0x00000001851AF800
	// [XID] // 0x0000000189957CC0-0x0000000189957CE0
	private static bool ParseConfigFromLine(string line, out WorldAreaLevelupConfig data) {
		data = default;
		return default;
	} // 0x00000001851AE9C0-0x00000001851AEB00
	// [IDTag] // 0x000000018995F590-0x000000018995F5D0
	// [XID] // 0x000000018995F590-0x000000018995F5D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<WorldAreaLevelupConfig> configList) => default; // 0x00000001851AEC00-0x00000001851AEEA0
	// [IDTag] // 0x0000000189969BC0-0x0000000189969C00
	// [XID] // 0x0000000189969BC0-0x0000000189969C00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3706 */, bool useObjectPool = false /* Metadata: 0x00AF370A */) => default; // 0x00000001851AF1D0-0x00000001851AF420
	// [IDTag] // 0x0000000189974590-0x00000001899745D0
	// [XID] // 0x0000000189974590-0x00000001899745D0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF370B */, bool useObjectPool = false /* Metadata: 0x00AF370F */) => default; // 0x00000001851AEEA0-0x00000001851AF1D0
}

