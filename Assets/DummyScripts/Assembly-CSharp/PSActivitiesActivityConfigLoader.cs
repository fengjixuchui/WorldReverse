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

public static class PSActivitiesActivityConfigLoader // TypeDefIndex: 15958
{
	// Fields
	private static Dictionary<uint, PSActivitiesActivityConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PSActivitiesActivityConfig>> customApplyHotfixAction; // 0x08
	public static Action<PSActivitiesActivityConfig, PSActivitiesActivityConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PSActivitiesActivityConfig>, Dictionary<uint, PSActivitiesActivityConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PSActivitiesActivityConfig> dataDict { /* [XID] */ /* 0x0000000189945FE0-0x0000000189946000 */ get; } // 0x00000001828379D0-0x0000000182837A80 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189954B80-0x0000000189954BA0 */ get; } // 0x0000000182836820-0x00000001828368C0 

	// Methods
	// [XID] // 0x000000018993E970-0x000000018993E990
	public static void Register() {} // 0x0000000182837DB0-0x0000000182837E50
	// [XID] // 0x000000018994D4B0-0x000000018994D4D0
	public static PSActivitiesActivityConfig GetData(uint ID) => default; // 0x00000001828366F0-0x0000000182836820
	// [XID] // 0x000000018995C3A0-0x000000018995C3C0
	public static void LoadData() {} // 0x0000000182836E50-0x0000000182836F40
	// [XID] // 0x0000000189963E00-0x0000000189963E20
	private static void RegisterHotfixGenerated() {} // 0x0000000182836C80-0x0000000182836E50
	// [XID] // 0x000000018996B330-0x000000018996B350
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001828368C0-0x0000000182836C80
	// [IDTag] // 0x0000000189972DF0-0x0000000189972E30
	// [XID] // 0x0000000189972DF0-0x0000000189972E30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182837330-0x0000000182837430
	// [XID] // 0x000000018997CE90-0x000000018997CEB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PSActivitiesActivityConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182837A80-0x0000000182837DB0
	// [XID] // 0x0000000189984B10-0x0000000189984B30
	private static bool ParseConfigFromLine(string line, out PSActivitiesActivityConfig data) {
		data = default;
		return default;
	} // 0x0000000182836F40-0x0000000182837080
	// [IDTag] // 0x000000018998C690-0x000000018998C6D0
	// [XID] // 0x000000018998C690-0x000000018998C6D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PSActivitiesActivityConfig> configList) => default; // 0x0000000182837080-0x0000000182837330
	// [IDTag] // 0x0000000189997140-0x0000000189997180
	// [XID] // 0x0000000189997140-0x0000000189997180
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C3E */, bool useObjectPool = false /* Metadata: 0x00AF2C42 */) => default; // 0x0000000182837780-0x00000001828379D0
	// [IDTag] // 0x00000001899A1D70-0x00000001899A1DB0
	// [XID] // 0x00000001899A1D70-0x00000001899A1DB0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C43 */, bool useObjectPool = false /* Metadata: 0x00AF2C47 */) => default; // 0x0000000182837430-0x0000000182837780
}

