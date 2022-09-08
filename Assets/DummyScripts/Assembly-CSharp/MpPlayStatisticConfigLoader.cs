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

public static class MpPlayStatisticConfigLoader // TypeDefIndex: 15870
{
	// Fields
	private static Dictionary<uint, MpPlayStatisticConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MpPlayStatisticConfig>> customApplyHotfixAction; // 0x08
	public static Action<MpPlayStatisticConfig, MpPlayStatisticConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MpPlayStatisticConfig>, Dictionary<uint, MpPlayStatisticConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MpPlayStatisticConfig> dataDict { /* [XID] */ /* 0x0000000189AF9290-0x0000000189AF92B0 */ get; } // 0x0000000183C4C8E0-0x0000000183C4C990 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B07D90-0x0000000189B07DB0 */ get; } // 0x0000000183C4B730-0x0000000183C4B7D0 

	// Methods
	// [XID] // 0x0000000189AF1AB0-0x0000000189AF1AD0
	public static void Register() {} // 0x0000000183C4CCC0-0x0000000183C4CD60
	// [XID] // 0x0000000189B00730-0x0000000189B00750
	public static MpPlayStatisticConfig GetData(uint id) => default; // 0x0000000183C4B600-0x0000000183C4B730
	// [XID] // 0x0000000189B0F5B0-0x0000000189B0F5D0
	public static void LoadData() {} // 0x0000000183C4BD60-0x0000000183C4BE50
	// [XID] // 0x0000000189B16890-0x0000000189B168B0
	private static void RegisterHotfixGenerated() {} // 0x0000000183C4BB90-0x0000000183C4BD60
	// [XID] // 0x0000000189B1DFB0-0x0000000189B1DFD0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183C4B7D0-0x0000000183C4BB90
	// [IDTag] // 0x0000000189B25860-0x0000000189B258A0
	// [XID] // 0x0000000189B25860-0x0000000189B258A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183C4BF90-0x0000000183C4C090
	// [XID] // 0x0000000189B2F990-0x0000000189B2F9B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MpPlayStatisticConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183C4C990-0x0000000183C4CCC0
	// [XID] // 0x0000000189B37330-0x0000000189B37350
	private static bool ParseConfigFromLine(string line, out MpPlayStatisticConfig data) {
		data = default;
		return default;
	} // 0x0000000183C4BE50-0x0000000183C4BF90
	// [IDTag] // 0x0000000189B3EB60-0x0000000189B3EBA0
	// [XID] // 0x0000000189B3EB60-0x0000000189B3EBA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MpPlayStatisticConfig> configList) => default; // 0x0000000183C4C090-0x0000000183C4C340
	// [IDTag] // 0x0000000189B497A0-0x0000000189B497E0
	// [XID] // 0x0000000189B497A0-0x0000000189B497E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF28F1 */, bool useObjectPool = false /* Metadata: 0x00AF28F5 */) => default; // 0x0000000183C4C690-0x0000000183C4C8E0
	// [IDTag] // 0x0000000189B53C20-0x0000000189B53C60
	// [XID] // 0x0000000189B53C20-0x0000000189B53C60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28F6 */, bool useObjectPool = false /* Metadata: 0x00AF28FA */) => default; // 0x0000000183C4C340-0x0000000183C4C690
}

