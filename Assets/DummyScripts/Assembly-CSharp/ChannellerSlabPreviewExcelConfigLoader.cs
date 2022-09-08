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

public static class ChannellerSlabPreviewExcelConfigLoader // TypeDefIndex: 14808
{
	// Fields
	private static Dictionary<uint, ChannellerSlabPreviewExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabPreviewExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabPreviewExcelConfig, ChannellerSlabPreviewExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabPreviewExcelConfig>, Dictionary<uint, ChannellerSlabPreviewExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabPreviewExcelConfig> dataDict { /* [XID] */ /* 0x000000018964C810-0x000000018964C830 */ get; } // 0x0000000185A6D4E0-0x0000000185A6D590 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018965B590-0x000000018965B5B0 */ get; } // 0x0000000185A6C330-0x0000000185A6C3D0 

	// Methods
	// [XID] // 0x000000018963D830-0x000000018963D850
	public static ChannellerSlabPreviewExcelConfig GetDataByActivity(uint id) => default; // 0x0000000185A6D590-0x0000000185A6D7C0
	// [XID] // 0x0000000189644D70-0x0000000189644D90
	public static void Register() {} // 0x0000000185A6DAF0-0x0000000185A6DB90
	// [XID] // 0x0000000189653CC0-0x0000000189653CE0
	public static ChannellerSlabPreviewExcelConfig GetData(uint activityId) => default; // 0x0000000185A6C200-0x0000000185A6C330
	// [XID] // 0x00000001896629E0-0x0000000189662A00
	public static void LoadData() {} // 0x0000000185A6C960-0x0000000185A6CA50
	// [XID] // 0x000000018966A580-0x000000018966A5A0
	private static void RegisterHotfixGenerated() {} // 0x0000000185A6C790-0x0000000185A6C960
	// [XID] // 0x00000001896721C0-0x00000001896721E0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185A6C3D0-0x0000000185A6C790
	// [IDTag] // 0x0000000189679A50-0x0000000189679A90
	// [XID] // 0x0000000189679A50-0x0000000189679A90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185A6CB90-0x0000000185A6CC90
	// [XID] // 0x0000000189683F90-0x0000000189683FB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabPreviewExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185A6D7C0-0x0000000185A6DAF0
	// [XID] // 0x000000018968BB70-0x000000018968BB90
	private static bool ParseConfigFromLine(string line, out ChannellerSlabPreviewExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185A6CA50-0x0000000185A6CB90
	// [IDTag] // 0x0000000189693780-0x00000001896937C0
	// [XID] // 0x0000000189693780-0x00000001896937C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabPreviewExcelConfig> configList) => default; // 0x0000000185A6CC90-0x0000000185A6CF40
	// [IDTag] // 0x000000018969DE70-0x000000018969DEB0
	// [XID] // 0x000000018969DE70-0x000000018969DEB0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF60C */, bool useObjectPool = false /* Metadata: 0x00AEF610 */) => default; // 0x0000000185A6D290-0x0000000185A6D4E0
	// [IDTag] // 0x00000001896A7F60-0x00000001896A7FA0
	// [XID] // 0x00000001896A7F60-0x00000001896A7FA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF611 */, bool useObjectPool = false /* Metadata: 0x00AEF615 */) => default; // 0x0000000185A6CF40-0x0000000185A6D290
}

