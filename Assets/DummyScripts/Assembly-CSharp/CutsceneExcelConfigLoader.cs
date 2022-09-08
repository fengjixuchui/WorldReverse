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

public static class CutsceneExcelConfigLoader // TypeDefIndex: 15467
{
	// Fields
	private static Dictionary<uint, CutsceneExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<CutsceneExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<CutsceneExcelConfig, CutsceneExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<CutsceneExcelConfig>, Dictionary<uint, CutsceneExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, CutsceneExcelConfig> dataDict { /* [XID] */ /* 0x00000001898178A0-0x00000001898178C0 */ get; } // 0x0000000183D9F160-0x0000000183D9F210 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189826750-0x0000000189826770 */ get; } // 0x0000000183D9DFB0-0x0000000183D9E050 

	// Methods
	// [XID] // 0x0000000189810230-0x0000000189810250
	public static void Register() {} // 0x0000000183D9F540-0x0000000183D9F5E0
	// [XID] // 0x000000018981F240-0x000000018981F260
	public static CutsceneExcelConfig GetData(uint id) => default; // 0x0000000183D9DE80-0x0000000183D9DFB0
	// [XID] // 0x000000018982DDC0-0x000000018982DDE0
	public static void LoadData() {} // 0x0000000183D9E5E0-0x0000000183D9E6D0
	// [XID] // 0x0000000189835430-0x0000000189835450
	private static void RegisterHotfixGenerated() {} // 0x0000000183D9E410-0x0000000183D9E5E0
	// [XID] // 0x000000018983CC30-0x000000018983CC50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183D9E050-0x0000000183D9E410
	// [IDTag] // 0x0000000189844300-0x0000000189844340
	// [XID] // 0x0000000189844300-0x0000000189844340
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183D9EAC0-0x0000000183D9EBC0
	// [XID] // 0x000000018984E7A0-0x000000018984E7C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CutsceneExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183D9F210-0x0000000183D9F540
	// [XID] // 0x00000001898557F0-0x0000000189855810
	private static bool ParseConfigFromLine(string line, out CutsceneExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183D9E6D0-0x0000000183D9E810
	// [IDTag] // 0x000000018985CC30-0x000000018985CC70
	// [XID] // 0x000000018985CC30-0x000000018985CC70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CutsceneExcelConfig> configList) => default; // 0x0000000183D9E810-0x0000000183D9EAC0
	// [IDTag] // 0x00000001898673D0-0x0000000189867410
	// [XID] // 0x00000001898673D0-0x0000000189867410
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1B4A */, bool useObjectPool = false /* Metadata: 0x00AF1B4E */) => default; // 0x0000000183D9EBC0-0x0000000183D9EE10
	// [IDTag] // 0x0000000189871950-0x0000000189871990
	// [XID] // 0x0000000189871950-0x0000000189871990
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B4F */, bool useObjectPool = false /* Metadata: 0x00AF1B53 */) => default; // 0x0000000183D9EE10-0x0000000183D9F160
}

