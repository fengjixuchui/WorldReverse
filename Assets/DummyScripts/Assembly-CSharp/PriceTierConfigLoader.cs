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

public static class PriceTierConfigLoader // TypeDefIndex: 16148
{
	// Fields
	private static Dictionary<string, PriceTierConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PriceTierConfig>> customApplyHotfixAction; // 0x08
	public static Action<PriceTierConfig, PriceTierConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PriceTierConfig>, Dictionary<string, PriceTierConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, PriceTierConfig> dataDict { /* [XID] */ /* 0x00000001896375E0-0x0000000189637600 */ get; } // 0x0000000183709280-0x0000000183709330 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189646260-0x0000000189646280 */ get; } // 0x00000001837080E0-0x0000000183708180 

	// Methods
	// [XID] // 0x000000018962FA00-0x000000018962FA20
	public static void Register() {} // 0x0000000183709660-0x0000000183709700
	// [XID] // 0x000000018963EB60-0x000000018963EB80
	public static PriceTierConfig GetData(string tierName) => default; // 0x0000000183707FA0-0x00000001837080E0
	// [XID] // 0x000000018964DAA0-0x000000018964DAC0
	public static void LoadData() {} // 0x0000000183708710-0x0000000183708800
	// [XID] // 0x00000001896552A0-0x00000001896552C0
	private static void RegisterHotfixGenerated() {} // 0x0000000183708540-0x0000000183708710
	// [XID] // 0x000000018965CB00-0x000000018965CB20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183708180-0x0000000183708540
	// [IDTag] // 0x0000000189663FC0-0x0000000189664000
	// [XID] // 0x0000000189663FC0-0x0000000189664000
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183708BE0-0x0000000183708CE0
	// [XID] // 0x000000018966EA80-0x000000018966EAA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PriceTierConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183709330-0x0000000183709660
	// [XID] // 0x00000001896764E0-0x0000000189676500
	private static bool ParseConfigFromLine(string line, out PriceTierConfig data) {
		data = default;
		return default;
	} // 0x0000000183708800-0x0000000183708940
	// [IDTag] // 0x000000018967DCC0-0x000000018967DD00
	// [XID] // 0x000000018967DCC0-0x000000018967DD00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PriceTierConfig> configList) => default; // 0x0000000183708940-0x0000000183708BE0
	// [IDTag] // 0x00000001896889E0-0x0000000189688A20
	// [XID] // 0x00000001896889E0-0x0000000189688A20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF327C */, bool useObjectPool = false /* Metadata: 0x00AF3280 */) => default; // 0x0000000183708CE0-0x0000000183708F30
	// [IDTag] // 0x0000000189693500-0x0000000189693540
	// [XID] // 0x0000000189693500-0x0000000189693540
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3281 */, bool useObjectPool = false /* Metadata: 0x00AF3285 */) => default; // 0x0000000183708F30-0x0000000183709280
}

