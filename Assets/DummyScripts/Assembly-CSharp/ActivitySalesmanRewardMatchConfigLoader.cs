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

public static class ActivitySalesmanRewardMatchConfigLoader // TypeDefIndex: 15173
{
	// Fields
	private static Dictionary<uint, ActivitySalesmanRewardMatchConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ActivitySalesmanRewardMatchConfig>> customApplyHotfixAction; // 0x08
	public static Action<ActivitySalesmanRewardMatchConfig, ActivitySalesmanRewardMatchConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ActivitySalesmanRewardMatchConfig>, Dictionary<uint, ActivitySalesmanRewardMatchConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ActivitySalesmanRewardMatchConfig> dataDict { /* [XID] */ /* 0x0000000189B4C6E0-0x0000000189B4C700 */ get; } // 0x00000001843144F0-0x00000001843145A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B5B6B0-0x0000000189B5B6D0 */ get; } // 0x0000000184313340-0x00000001843133E0 

	// Methods
	// [XID] // 0x0000000189B44F10-0x0000000189B44F30
	public static void Register() {} // 0x00000001843148D0-0x0000000184314970
	// [XID] // 0x0000000189B53D60-0x0000000189B53D80
	public static ActivitySalesmanRewardMatchConfig GetData(uint rewardID) => default; // 0x0000000184313210-0x0000000184313340
	// [XID] // 0x0000000189B62AE0-0x0000000189B62B00
	public static void LoadData() {} // 0x0000000184313970-0x0000000184313A60
	// [XID] // 0x0000000189B6A5D0-0x0000000189B6A5F0
	private static void RegisterHotfixGenerated() {} // 0x00000001843137A0-0x0000000184313970
	// [XID] // 0x0000000189B71D50-0x0000000189B71D70
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843133E0-0x00000001843137A0
	// [IDTag] // 0x0000000189B79080-0x0000000189B790C0
	// [XID] // 0x0000000189B79080-0x0000000189B790C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184313E50-0x0000000184313F50
	// [XID] // 0x0000000189B839A0-0x0000000189B839C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ActivitySalesmanRewardMatchConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001843145A0-0x00000001843148D0
	// [XID] // 0x0000000189B8AC30-0x0000000189B8AC50
	private static bool ParseConfigFromLine(string line, out ActivitySalesmanRewardMatchConfig data) {
		data = default;
		return default;
	} // 0x0000000184313A60-0x0000000184313BA0
	// [IDTag] // 0x0000000189B92280-0x0000000189B922C0
	// [XID] // 0x0000000189B92280-0x0000000189B922C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ActivitySalesmanRewardMatchConfig> configList) => default; // 0x0000000184313BA0-0x0000000184313E50
	// [IDTag] // 0x0000000189B9C7C0-0x0000000189B9C800
	// [XID] // 0x0000000189B9C7C0-0x0000000189B9C800
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF02DB */, bool useObjectPool = false /* Metadata: 0x00AF02DF */) => default; // 0x00000001843142A0-0x00000001843144F0
	// [IDTag] // 0x0000000189BA6E00-0x0000000189BA6E40
	// [XID] // 0x0000000189BA6E00-0x0000000189BA6E40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02E0 */, bool useObjectPool = false /* Metadata: 0x00AF02E4 */) => default; // 0x0000000184313F50-0x00000001843142A0
}

