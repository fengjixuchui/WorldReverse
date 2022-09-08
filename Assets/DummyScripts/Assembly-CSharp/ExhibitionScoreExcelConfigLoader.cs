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

public static class ExhibitionScoreExcelConfigLoader // TypeDefIndex: 15592
{
	// Fields
	private static Dictionary<uint, ExhibitionScoreExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExhibitionScoreExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExhibitionScoreExcelConfig, ExhibitionScoreExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExhibitionScoreExcelConfig>, Dictionary<uint, ExhibitionScoreExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExhibitionScoreExcelConfig> dataDict { /* [XID] */ /* 0x000000018997CF90-0x000000018997CFB0 */ get; } // 0x00000001843B3890-0x00000001843B3940 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018998C7B0-0x000000018998C7D0 */ get; } // 0x00000001843B26E0-0x00000001843B2780 

	// Methods
	// [XID] // 0x0000000189975E50-0x0000000189975E70
	public static void Register() {} // 0x00000001843B3C70-0x00000001843B3D10
	// [XID] // 0x0000000189984BB0-0x0000000189984BD0
	public static ExhibitionScoreExcelConfig GetData(uint id) => default; // 0x00000001843B25B0-0x00000001843B26E0
	// [XID] // 0x00000001899944F0-0x0000000189994510
	public static void LoadData() {} // 0x00000001843B2D10-0x00000001843B2E00
	// [XID] // 0x000000018999BCC0-0x000000018999BCE0
	private static void RegisterHotfixGenerated() {} // 0x00000001843B2B40-0x00000001843B2D10
	// [XID] // 0x00000001899A3530-0x00000001899A3550
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001843B2780-0x00000001843B2B40
	// [IDTag] // 0x00000001899AB020-0x00000001899AB060
	// [XID] // 0x00000001899AB020-0x00000001899AB060
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001843B2F40-0x00000001843B3040
	// [XID] // 0x00000001899B5700-0x00000001899B5720
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExhibitionScoreExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001843B3940-0x00000001843B3C70
	// [XID] // 0x00000001899BCE90-0x00000001899BCEB0
	private static bool ParseConfigFromLine(string line, out ExhibitionScoreExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001843B2E00-0x00000001843B2F40
	// [IDTag] // 0x00000001899C4780-0x00000001899C47C0
	// [XID] // 0x00000001899C4780-0x00000001899C47C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExhibitionScoreExcelConfig> configList) => default; // 0x00000001843B3040-0x00000001843B32F0
	// [IDTag] // 0x00000001899CED20-0x00000001899CED60
	// [XID] // 0x00000001899CED20-0x00000001899CED60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1FFF */, bool useObjectPool = false /* Metadata: 0x00AF2003 */) => default; // 0x00000001843B32F0-0x00000001843B3540
	// [IDTag] // 0x00000001899D9270-0x00000001899D92B0
	// [XID] // 0x00000001899D9270-0x00000001899D92B0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2004 */, bool useObjectPool = false /* Metadata: 0x00AF2008 */) => default; // 0x00000001843B3540-0x00000001843B3890
}

