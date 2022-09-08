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

public static class OpenStateConfigLoader // TypeDefIndex: 15935
{
	// Fields
	private static Dictionary<uint, OpenStateConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<OpenStateConfig>> customApplyHotfixAction; // 0x08
	public static Action<OpenStateConfig, OpenStateConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OpenStateConfig>, Dictionary<uint, OpenStateConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, OpenStateConfig> dataDict { /* [XID] */ /* 0x000000018996E1A0-0x000000018996E1C0 */ get; } // 0x00000001854A3950-0x00000001854A3A00 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018997CEB0-0x000000018997CED0 */ get; } // 0x00000001854A27A0-0x00000001854A2840 

	// Methods
	// [XID] // 0x0000000189966E30-0x0000000189966E50
	public static void Register() {} // 0x00000001854A3D30-0x00000001854A3DD0
	// [XID] // 0x0000000189975D50-0x0000000189975D70
	public static OpenStateConfig GetData(uint id) => default; // 0x00000001854A2670-0x00000001854A27A0
	// [XID] // 0x0000000189984B30-0x0000000189984B50
	public static void LoadData() {} // 0x00000001854A2DD0-0x00000001854A2EC0
	// [XID] // 0x000000018998C6D0-0x000000018998C6F0
	private static void RegisterHotfixGenerated() {} // 0x00000001854A2C00-0x00000001854A2DD0
	// [XID] // 0x0000000189994410-0x0000000189994430
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001854A2840-0x00000001854A2C00
	// [IDTag] // 0x000000018999BC40-0x000000018999BC80
	// [XID] // 0x000000018999BC40-0x000000018999BC80
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001854A32B0-0x00000001854A33B0
	// [XID] // 0x00000001899A66B0-0x00000001899A66D0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OpenStateConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001854A3A00-0x00000001854A3D30
	// [XID] // 0x00000001899ADE60-0x00000001899ADE80
	private static bool ParseConfigFromLine(string line, out OpenStateConfig data) {
		data = default;
		return default;
	} // 0x00000001854A2EC0-0x00000001854A3000
	// [IDTag] // 0x00000001899B5640-0x00000001899B5680
	// [XID] // 0x00000001899B5640-0x00000001899B5680
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OpenStateConfig> configList) => default; // 0x00000001854A3000-0x00000001854A32B0
	// [IDTag] // 0x00000001899BFE70-0x00000001899BFEB0
	// [XID] // 0x00000001899BFE70-0x00000001899BFEB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B9A */, bool useObjectPool = false /* Metadata: 0x00AF2B9E */) => default; // 0x00000001854A33B0-0x00000001854A3600
	// [IDTag] // 0x00000001899CA520-0x00000001899CA560
	// [XID] // 0x00000001899CA520-0x00000001899CA560
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B9F */, bool useObjectPool = false /* Metadata: 0x00AF2BA3 */) => default; // 0x00000001854A3600-0x00000001854A3950
}

