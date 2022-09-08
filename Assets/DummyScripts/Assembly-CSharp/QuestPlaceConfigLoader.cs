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

public static class QuestPlaceConfigLoader // TypeDefIndex: 15995
{
	// Fields
	private static Dictionary<uint, QuestPlaceConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<QuestPlaceConfig>> customApplyHotfixAction; // 0x08
	public static Action<QuestPlaceConfig, QuestPlaceConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<QuestPlaceConfig>, Dictionary<uint, QuestPlaceConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, QuestPlaceConfig> dataDict { /* [XID] */ /* 0x0000000189963DA0-0x0000000189963DC0 */ get; } // 0x0000000183FCE350-0x0000000183FCE400 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189972DD0-0x0000000189972DF0 */ get; } // 0x0000000183FCD1A0-0x0000000183FCD240 

	// Methods
	// [XID] // 0x000000018995C360-0x000000018995C380
	public static void Register() {} // 0x0000000183FCE730-0x0000000183FCE7D0
	// [XID] // 0x000000018996B310-0x000000018996B330
	public static QuestPlaceConfig GetData(uint placeId) => default; // 0x0000000183FCD070-0x0000000183FCD1A0
	// [XID] // 0x000000018997A6F0-0x000000018997A710
	public static void LoadData() {} // 0x0000000183FCD7D0-0x0000000183FCD8C0
	// [XID] // 0x0000000189982080-0x00000001899820A0
	private static void RegisterHotfixGenerated() {} // 0x0000000183FCD600-0x0000000183FCD7D0
	// [XID] // 0x0000000189989900-0x0000000189989920
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183FCD240-0x0000000183FCD600
	// [IDTag] // 0x0000000189991150-0x0000000189991190
	// [XID] // 0x0000000189991150-0x0000000189991190
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183FCDA00-0x0000000183FCDB00
	// [XID] // 0x000000018999BC20-0x000000018999BC40
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<QuestPlaceConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183FCE400-0x0000000183FCE730
	// [XID] // 0x00000001899A33F0-0x00000001899A3410
	private static bool ParseConfigFromLine(string line, out QuestPlaceConfig data) {
		data = default;
		return default;
	} // 0x0000000183FCD8C0-0x0000000183FCDA00
	// [IDTag] // 0x00000001899AAEE0-0x00000001899AAF20
	// [XID] // 0x00000001899AAEE0-0x00000001899AAF20
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<QuestPlaceConfig> configList) => default; // 0x0000000183FCDB00-0x0000000183FCDDB0
	// [IDTag] // 0x00000001899B5600-0x00000001899B5640
	// [XID] // 0x00000001899B5600-0x00000001899B5640
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D42 */, bool useObjectPool = false /* Metadata: 0x00AF2D46 */) => default; // 0x0000000183FCE100-0x0000000183FCE350
	// [IDTag] // 0x00000001899BFE10-0x00000001899BFE50
	// [XID] // 0x00000001899BFE10-0x00000001899BFE50
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D47 */, bool useObjectPool = false /* Metadata: 0x00AF2D4B */) => default; // 0x0000000183FCDDB0-0x0000000183FCE100
}

