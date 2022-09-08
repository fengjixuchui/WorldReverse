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

public static class AsterMissionExcelConfigLoader // TypeDefIndex: 14830
{
	// Fields
	private static List<uint> _midMissionList; // 0x00
	private static Dictionary<uint, AsterMissionExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<AsterMissionExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<AsterMissionExcelConfig, AsterMissionExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<AsterMissionExcelConfig>, Dictionary<uint, AsterMissionExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, AsterMissionExcelConfig> dataDict { /* [XID] */ /* 0x0000000189605FD0-0x0000000189605FF0 */ get; } // 0x0000000184193420-0x00000001841934F0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189615040-0x0000000189615060 */ get; } // 0x0000000184191ED0-0x0000000184191F70 

	// Constructors
	static AsterMissionExcelConfigLoader() {} // 0x0000000184193C60-0x0000000184193CC0

	// Methods
	// [XID] // 0x00000001895F7260-0x00000001895F7280
	public static List<uint> GetMidStageWatcherList() => default; // 0x00000001841934F0-0x0000000184193850
	// [XID] // 0x00000001895FE660-0x00000001895FE680
	public static void Register() {} // 0x0000000184193BA0-0x0000000184193C60
	// [XID] // 0x000000018960D7E0-0x000000018960D800
	public static AsterMissionExcelConfig GetData(uint missionId) => default; // 0x0000000184191D30-0x0000000184191ED0
	// [XID] // 0x000000018961C7A0-0x000000018961C7C0
	public static void LoadData() {} // 0x00000001841926C0-0x00000001841927F0
	// [XID] // 0x0000000189623C00-0x0000000189623C20
	private static void RegisterHotfixGenerated() {} // 0x0000000184192450-0x00000001841926C0
	// [XID] // 0x000000018962B4C0-0x000000018962B4E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184191F70-0x0000000184192450
	// [IDTag] // 0x0000000189632C40-0x0000000189632C80
	// [XID] // 0x0000000189632C40-0x0000000189632C80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184192930-0x0000000184192A90
	// [XID] // 0x000000018963D810-0x000000018963D830
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterMissionExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184193850-0x0000000184193BA0
	// [XID] // 0x0000000189644D50-0x0000000189644D70
	private static bool ParseConfigFromLine(string line, out AsterMissionExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001841927F0-0x0000000184192930
	// [IDTag] // 0x000000018964C7D0-0x000000018964C810
	// [XID] // 0x000000018964C7D0-0x000000018964C810
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterMissionExcelConfig> configList) => default; // 0x0000000184192A90-0x0000000184192DE0
	// [IDTag] // 0x0000000189656DB0-0x0000000189656DF0
	// [XID] // 0x0000000189656DB0-0x0000000189656DF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6D9 */, bool useObjectPool = false /* Metadata: 0x00AEF6DD */) => default; // 0x0000000184193170-0x0000000184193420
	// [IDTag] // 0x0000000189661350-0x0000000189661390
	// [XID] // 0x0000000189661350-0x0000000189661390
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6DE */, bool useObjectPool = false /* Metadata: 0x00AEF6E2 */) => default; // 0x0000000184192DE0-0x0000000184193170
}

