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

public static class BargainExcelConfigLoader // TypeDefIndex: 15244
{
	// Fields
	private static Dictionary<uint, BargainExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BargainExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<BargainExcelConfig, BargainExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BargainExcelConfig>, Dictionary<uint, BargainExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BargainExcelConfig> dataDict { /* [XID] */ /* 0x0000000189994570-0x0000000189994590 */ get; } // 0x0000000183321F00-0x0000000183321FB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899A35B0-0x00000001899A35D0 */ get; } // 0x0000000183320D50-0x0000000183320DF0 

	// Methods
	// [XID] // 0x000000018998C850-0x000000018998C870
	public static void Register() {} // 0x00000001833222E0-0x0000000183322380
	// [XID] // 0x000000018999BD40-0x000000018999BD60
	public static BargainExcelConfig GetData(uint id) => default; // 0x0000000183320C20-0x0000000183320D50
	// [XID] // 0x00000001899AB100-0x00000001899AB120
	public static void LoadData() {} // 0x0000000183321380-0x0000000183321470
	// [XID] // 0x00000001899B2B50-0x00000001899B2B70
	private static void RegisterHotfixGenerated() {} // 0x00000001833211B0-0x0000000183321380
	// [XID] // 0x00000001899B9D10-0x00000001899B9D30
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183320DF0-0x00000001833211B0
	// [IDTag] // 0x00000001899C1810-0x00000001899C1850
	// [XID] // 0x00000001899C1810-0x00000001899C1850
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001833215B0-0x00000001833216B0
	// [XID] // 0x00000001899CC020-0x00000001899CC040
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BargainExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183321FB0-0x00000001833222E0
	// [XID] // 0x00000001899D3570-0x00000001899D3590
	private static bool ParseConfigFromLine(string line, out BargainExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183321470-0x00000001833215B0
	// [IDTag] // 0x00000001899DABA0-0x00000001899DABE0
	// [XID] // 0x00000001899DABA0-0x00000001899DABE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BargainExcelConfig> configList) => default; // 0x00000001833216B0-0x0000000183321960
	// [IDTag] // 0x00000001899E57A0-0x00000001899E57E0
	// [XID] // 0x00000001899E57A0-0x00000001899E57E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF050F */, bool useObjectPool = false /* Metadata: 0x00AF0513 */) => default; // 0x0000000183321960-0x0000000183321BB0
	// [IDTag] // 0x00000001899EFB90-0x00000001899EFBD0
	// [XID] // 0x00000001899EFB90-0x00000001899EFBD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0514 */, bool useObjectPool = false /* Metadata: 0x00AF0518 */) => default; // 0x0000000183321BB0-0x0000000183321F00
}

