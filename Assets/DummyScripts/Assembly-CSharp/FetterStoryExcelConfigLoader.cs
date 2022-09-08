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

public static class FetterStoryExcelConfigLoader // TypeDefIndex: 15615
{
	// Fields
	private static Dictionary<uint, FetterStoryExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FetterStoryExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FetterStoryExcelConfig, FetterStoryExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FetterStoryExcelConfig>, Dictionary<uint, FetterStoryExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FetterStoryExcelConfig> dataDict { /* [XID] */ /* 0x0000000189911900-0x0000000189911920 */ get; } // 0x0000000181F08EC0-0x0000000181F08F70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899209F0-0x0000000189920A10 */ get; } // 0x0000000181F07D10-0x0000000181F07DB0 

	// Methods
	// [XID] // 0x0000000189909FE0-0x000000018990A000
	public static void Register() {} // 0x0000000181F092A0-0x0000000181F09340
	// [XID] // 0x0000000189919440-0x0000000189919460
	public static FetterStoryExcelConfig GetData(uint fetter_id) => default; // 0x0000000181F07BE0-0x0000000181F07D10
	// [XID] // 0x0000000189928390-0x00000001899283B0
	public static void LoadData() {} // 0x0000000181F08340-0x0000000181F08430
	// [XID] // 0x000000018992F920-0x000000018992F940
	private static void RegisterHotfixGenerated() {} // 0x0000000181F08170-0x0000000181F08340
	// [XID] // 0x0000000189936E30-0x0000000189936E50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F07DB0-0x0000000181F08170
	// [IDTag] // 0x000000018993E9D0-0x000000018993EA10
	// [XID] // 0x000000018993E9D0-0x000000018993EA10
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F08570-0x0000000181F08670
	// [XID] // 0x0000000189949060-0x0000000189949080
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FetterStoryExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F08F70-0x0000000181F092A0
	// [XID] // 0x0000000189950850-0x0000000189950870
	private static bool ParseConfigFromLine(string line, out FetterStoryExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F08430-0x0000000181F08570
	// [IDTag] // 0x0000000189957E40-0x0000000189957E80
	// [XID] // 0x0000000189957E40-0x0000000189957E80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FetterStoryExcelConfig> configList) => default; // 0x0000000181F08670-0x0000000181F08920
	// [IDTag] // 0x00000001899628B0-0x00000001899628F0
	// [XID] // 0x00000001899628B0-0x00000001899628F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF20AB */, bool useObjectPool = false /* Metadata: 0x00AF20AF */) => default; // 0x0000000181F08C70-0x0000000181F08EC0
	// [IDTag] // 0x000000018996CD10-0x000000018996CD50
	// [XID] // 0x000000018996CD10-0x000000018996CD50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20B0 */, bool useObjectPool = false /* Metadata: 0x00AF20B4 */) => default; // 0x0000000181F08920-0x0000000181F08C70
}

