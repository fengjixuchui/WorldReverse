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

public static class RandTaskRewardConfigLoader // TypeDefIndex: 16002
{
	// Fields
	private static Dictionary<uint, RandTaskRewardConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandTaskRewardConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandTaskRewardConfig, RandTaskRewardConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandTaskRewardConfig>, Dictionary<uint, RandTaskRewardConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, RandTaskRewardConfig> dataDict { /* [XID] */ /* 0x0000000189635E50-0x0000000189635E70 */ get; } // 0x0000000182D14710-0x0000000182D147C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189644B50-0x0000000189644B70 */ get; } // 0x0000000182D13560-0x0000000182D13600 

	// Methods
	// [XID] // 0x000000018962E290-0x000000018962E2B0
	public static void Register() {} // 0x0000000182D14AF0-0x0000000182D14B90
	// [XID] // 0x000000018963D590-0x000000018963D5B0
	public static RandTaskRewardConfig GetData(uint ID) => default; // 0x0000000182D13430-0x0000000182D13560
	// [XID] // 0x000000018964C4F0-0x000000018964C510
	public static void LoadData() {} // 0x0000000182D13B90-0x0000000182D13C80
	// [XID] // 0x0000000189653AC0-0x0000000189653AE0
	private static void RegisterHotfixGenerated() {} // 0x0000000182D139C0-0x0000000182D13B90
	// [XID] // 0x000000018965B330-0x000000018965B350
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182D13600-0x0000000182D139C0
	// [IDTag] // 0x00000001896627C0-0x0000000189662800
	// [XID] // 0x00000001896627C0-0x0000000189662800
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182D14070-0x0000000182D14170
	// [XID] // 0x000000018966CF60-0x000000018966CF80
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandTaskRewardConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182D147C0-0x0000000182D14AF0
	// [XID] // 0x0000000189674E10-0x0000000189674E30
	private static bool ParseConfigFromLine(string line, out RandTaskRewardConfig data) {
		data = default;
		return default;
	} // 0x0000000182D13C80-0x0000000182D13DC0
	// [IDTag] // 0x000000018967C620-0x000000018967C660
	// [XID] // 0x000000018967C620-0x000000018967C660
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandTaskRewardConfig> configList) => default; // 0x0000000182D13DC0-0x0000000182D14070
	// [IDTag] // 0x0000000189686D10-0x0000000189686D50
	// [XID] // 0x0000000189686D10-0x0000000189686D50
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D6D */, bool useObjectPool = false /* Metadata: 0x00AF2D71 */) => default; // 0x0000000182D14170-0x0000000182D143C0
	// [IDTag] // 0x0000000189691D50-0x0000000189691D90
	// [XID] // 0x0000000189691D50-0x0000000189691D90
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D72 */, bool useObjectPool = false /* Metadata: 0x00AF2D76 */) => default; // 0x0000000182D143C0-0x0000000182D14710
}

