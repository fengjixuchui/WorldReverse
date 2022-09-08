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

public static class NpcExcelConfigLoader // TypeDefIndex: 15912
{
	// Fields
	private static Dictionary<uint, NpcExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<NpcExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<NpcExcelConfig, NpcExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<NpcExcelConfig>, Dictionary<uint, NpcExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, NpcExcelConfig> dataDict { /* [XID] */ /* 0x0000000189811720-0x0000000189811740 */ get; } // 0x0000000183ABB7B0-0x0000000183ABB860 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189820B50-0x0000000189820B70 */ get; } // 0x0000000183ABA600-0x0000000183ABA6A0 

	// Methods
	// [XID] // 0x000000018980A0B0-0x000000018980A0D0
	public static void Register() {} // 0x0000000183ABBB90-0x0000000183ABBC30
	// [XID] // 0x0000000189819370-0x0000000189819390
	public static NpcExcelConfig GetData(uint id) => default; // 0x0000000183ABA4D0-0x0000000183ABA600
	// [XID] // 0x00000001898280E0-0x0000000189828100
	public static void LoadData() {} // 0x0000000183ABAC30-0x0000000183ABAD20
	// [XID] // 0x000000018982F340-0x000000018982F360
	private static void RegisterHotfixGenerated() {} // 0x0000000183ABAA60-0x0000000183ABAC30
	// [XID] // 0x0000000189836C70-0x0000000189836C90
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183ABA6A0-0x0000000183ABAA60
	// [IDTag] // 0x000000018983E080-0x000000018983E0C0
	// [XID] // 0x000000018983E080-0x000000018983E0C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183ABB110-0x0000000183ABB210
	// [XID] // 0x00000001898483E0-0x0000000189848400
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<NpcExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183ABB860-0x0000000183ABBB90
	// [XID] // 0x000000018984FB60-0x000000018984FB80
	private static bool ParseConfigFromLine(string line, out NpcExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183ABAD20-0x0000000183ABAE60
	// [IDTag] // 0x0000000189856F20-0x0000000189856F60
	// [XID] // 0x0000000189856F20-0x0000000189856F60
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<NpcExcelConfig> configList) => default; // 0x0000000183ABAE60-0x0000000183ABB110
	// [IDTag] // 0x00000001898613B0-0x00000001898613F0
	// [XID] // 0x00000001898613B0-0x00000001898613F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2AF7 */, bool useObjectPool = false /* Metadata: 0x00AF2AFB */) => default; // 0x0000000183ABB210-0x0000000183ABB460
	// [IDTag] // 0x000000018986BBA0-0x000000018986BBE0
	// [XID] // 0x000000018986BBA0-0x000000018986BBE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AFC */, bool useObjectPool = false /* Metadata: 0x00AF2B00 */) => default; // 0x0000000183ABB460-0x0000000183ABB7B0
}

