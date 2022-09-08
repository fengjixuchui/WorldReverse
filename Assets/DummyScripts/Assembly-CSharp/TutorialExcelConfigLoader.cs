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

public static class TutorialExcelConfigLoader // TypeDefIndex: 16249
{
	// Fields
	private static Dictionary<uint, TutorialExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TutorialExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TutorialExcelConfig, TutorialExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TutorialExcelConfig>, Dictionary<uint, TutorialExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TutorialExcelConfig> dataDict { /* [XID] */ /* 0x000000018970AB40-0x000000018970AB60 */ get; } // 0x0000000184031480-0x0000000184031530 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189719CB0-0x0000000189719CD0 */ get; } // 0x00000001840302D0-0x0000000184030370 

	// Methods
	// [XID] // 0x0000000189703470-0x0000000189703490
	public static void Register() {} // 0x0000000184031860-0x0000000184031900
	// [XID] // 0x0000000189712530-0x0000000189712550
	public static TutorialExcelConfig GetData(uint id) => default; // 0x00000001840301A0-0x00000001840302D0
	// [XID] // 0x0000000189721290-0x00000001897212B0
	public static void LoadData() {} // 0x0000000184030900-0x00000001840309F0
	// [XID] // 0x00000001897288D0-0x00000001897288F0
	private static void RegisterHotfixGenerated() {} // 0x0000000184030730-0x0000000184030900
	// [XID] // 0x0000000189730060-0x0000000189730080
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184030370-0x0000000184030730
	// [IDTag] // 0x0000000189737920-0x0000000189737960
	// [XID] // 0x0000000189737920-0x0000000189737960
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184030DE0-0x0000000184030EE0
	// [XID] // 0x0000000189741EE0-0x0000000189741F00
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TutorialExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184031530-0x0000000184031860
	// [XID] // 0x0000000189749960-0x0000000189749980
	private static bool ParseConfigFromLine(string line, out TutorialExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001840309F0-0x0000000184030B30
	// [IDTag] // 0x0000000189750E00-0x0000000189750E40
	// [XID] // 0x0000000189750E00-0x0000000189750E40
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TutorialExcelConfig> configList) => default; // 0x0000000184030B30-0x0000000184030DE0
	// [IDTag] // 0x000000018975B240-0x000000018975B280
	// [XID] // 0x000000018975B240-0x000000018975B280
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3580 */, bool useObjectPool = false /* Metadata: 0x00AF3584 */) => default; // 0x0000000184031230-0x0000000184031480
	// [IDTag] // 0x0000000189765AD0-0x0000000189765B10
	// [XID] // 0x0000000189765AD0-0x0000000189765B10
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3585 */, bool useObjectPool = false /* Metadata: 0x00AF3589 */) => default; // 0x0000000184030EE0-0x0000000184031230
}

