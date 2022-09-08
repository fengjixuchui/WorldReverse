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

public static class GuideRatingExcelConfigLoader // TypeDefIndex: 14869
{
	// Fields
	private static string _url; // 0x00
	private static uint _defaultChannelId; // 0x08
	private static List<GuideRatingExcelConfig> _dataList; // 0x10
	public static Action<List<DataHotfixMeta>, List<GuideRatingExcelConfig>> customApplyHotfixAction; // 0x18
	public static Action<GuideRatingExcelConfig, GuideRatingExcelConfig> onUpdateConfig; // 0x20
	public static Action onApplyHotfixFinish; // 0x28
	public static Func<List<DataHotfixMeta>, List<GuideRatingExcelConfig>, List<GuideRatingExcelConfig>, string, bool> customValidateFunc; // 0x30

	// Properties
	public static List<GuideRatingExcelConfig> dataList { /* [XID] */ /* 0x0000000189BB58F0-0x0000000189BB5910 */ get; } // 0x0000000183BD4D40-0x0000000183BD4E10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BBD080-0x0000000189BBD0A0 */ get; } // 0x0000000183BD3570-0x0000000183BD3610 

	// Constructors
	static GuideRatingExcelConfigLoader() {} // 0x0000000183BD5220-0x0000000183BD52D0

	// Methods
	// [XID] // 0x0000000189B9F6B0-0x0000000189B9F6D0
	public static string GetURL() => default; // 0x0000000183BD3DD0-0x0000000183BD4010
	// [XID] // 0x0000000189BA6EC0-0x0000000189BA6EE0
	private static string GetPlatformUrl(GuidePlatformType platformType) => default; // 0x0000000183BD3100-0x0000000183BD3570
	// [XID] // 0x0000000189BAE040-0x0000000189BAE060
	public static void Register() {} // 0x0000000183BD5160-0x0000000183BD5220
	// [XID] // 0x0000000189BC4C60-0x0000000189BC4C80
	public static void LoadData() {} // 0x0000000183BD4010-0x0000000183BD4140
	// [XID] // 0x0000000189BCC780-0x0000000189BCC7A0
	private static void RegisterHotfixGenerated() {} // 0x0000000183BD3B60-0x0000000183BD3DD0
	// [XID] // 0x0000000189BD3D30-0x0000000189BD3D50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183BD3610-0x0000000183BD3B60
	// [IDTag] // 0x0000000189BDB620-0x0000000189BDB660
	// [XID] // 0x0000000189BDB620-0x0000000189BDB660
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183BD45B0-0x0000000183BD4710
	// [XID] // 0x00000001895EB190-0x00000001895EB1B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GuideRatingExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183BD4E10-0x0000000183BD5160
	// [XID] // 0x00000001895F2670-0x00000001895F2690
	private static bool ParseConfigFromLine(string line, out GuideRatingExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183BD4140-0x0000000183BD4280
	// [IDTag] // 0x00000001895FA080-0x00000001895FA0C0
	// [XID] // 0x00000001895FA080-0x00000001895FA0C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GuideRatingExcelConfig> configList) => default; // 0x0000000183BD4280-0x0000000183BD45B0
	// [IDTag] // 0x0000000189604870-0x00000001896048B0
	// [XID] // 0x0000000189604870-0x00000001896048B0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF878 */, bool useObjectPool = false /* Metadata: 0x00AEF87C */) => default; // 0x0000000183BD4A90-0x0000000183BD4D40
	// [IDTag] // 0x000000018960F060-0x000000018960F0A0
	// [XID] // 0x000000018960F060-0x000000018960F0A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF87D */, bool useObjectPool = false /* Metadata: 0x00AEF881 */) => default; // 0x0000000183BD4710-0x0000000183BD4A90
}

