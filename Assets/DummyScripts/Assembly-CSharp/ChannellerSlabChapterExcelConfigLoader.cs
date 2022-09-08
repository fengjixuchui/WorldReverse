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

public static class ChannellerSlabChapterExcelConfigLoader // TypeDefIndex: 14809
{
	// Fields
	private static Dictionary<uint, ChannellerSlabChapterExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabChapterExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabChapterExcelConfig, ChannellerSlabChapterExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabChapterExcelConfig>, Dictionary<uint, ChannellerSlabChapterExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabChapterExcelConfig> dataDict { /* [XID] */ /* 0x00000001896CFCF0-0x00000001896CFD10 */ get; } // 0x000000018396CCC0-0x000000018396CD70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896DE6C0-0x00000001896DE6E0 */ get; } // 0x000000018396BB10-0x000000018396BBB0 

	// Methods
	// [XID] // 0x00000001896C0C20-0x00000001896C0C40
	public static ChannellerSlabChapterExcelConfig GetByStageID(uint stageID) => default; // 0x000000018396D0A0-0x000000018396D2D0
	// [XID] // 0x00000001896C82F0-0x00000001896C8310
	public static void Register() {} // 0x000000018396D2D0-0x000000018396D370
	// [XID] // 0x00000001896D6F60-0x00000001896D6F80
	public static ChannellerSlabChapterExcelConfig GetData(uint id) => default; // 0x000000018396B9E0-0x000000018396BB10
	// [XID] // 0x00000001896E5A70-0x00000001896E5A90
	public static void LoadData() {} // 0x000000018396C140-0x000000018396C230
	// [XID] // 0x00000001896ED0C0-0x00000001896ED0E0
	private static void RegisterHotfixGenerated() {} // 0x000000018396BF70-0x000000018396C140
	// [XID] // 0x00000001896F49A0-0x00000001896F49C0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018396BBB0-0x000000018396BF70
	// [IDTag] // 0x00000001896FC1B0-0x00000001896FC1F0
	// [XID] // 0x00000001896FC1B0-0x00000001896FC1F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018396C370-0x000000018396C470
	// [XID] // 0x0000000189706580-0x00000001897065A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabChapterExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018396CD70-0x000000018396D0A0
	// [XID] // 0x000000018970DE70-0x000000018970DE90
	private static bool ParseConfigFromLine(string line, out ChannellerSlabChapterExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018396C230-0x000000018396C370
	// [IDTag] // 0x00000001897152F0-0x0000000189715330
	// [XID] // 0x00000001897152F0-0x0000000189715330
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabChapterExcelConfig> configList) => default; // 0x000000018396C470-0x000000018396C720
	// [IDTag] // 0x000000018971FDB0-0x000000018971FDF0
	// [XID] // 0x000000018971FDB0-0x000000018971FDF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF616 */, bool useObjectPool = false /* Metadata: 0x00AEF61A */) => default; // 0x000000018396CA70-0x000000018396CCC0
	// [IDTag] // 0x000000018972A1E0-0x000000018972A220
	// [XID] // 0x000000018972A1E0-0x000000018972A220
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF61B */, bool useObjectPool = false /* Metadata: 0x00AEF61F */) => default; // 0x000000018396C720-0x000000018396CA70
}

