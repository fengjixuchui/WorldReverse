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

public static class MapTagDataConfigLoader // TypeDefIndex: 14928
{
	// Fields
	private static Dictionary<uint, MapTagDataConfig> _sceneId2MapTagDic; // 0x00
	private static Dictionary<uint, MapTagDataConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<MapTagDataConfig>> customApplyHotfixAction; // 0x10
	public static Action<MapTagDataConfig, MapTagDataConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<MapTagDataConfig>, Dictionary<uint, MapTagDataConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, MapTagDataConfig> dataDict { /* [XID] */ /* 0x00000001899D3690-0x00000001899D36B0 */ get; } // 0x00000001825C2BA0-0x00000001825C2C70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899E2500-0x00000001899E2520 */ get; } // 0x00000001825C1650-0x00000001825C16F0 

	// Constructors
	static MapTagDataConfigLoader() {} // 0x00000001825C3490-0x00000001825C3520

	// Methods
	// [XID] // 0x00000001899BCFB0-0x00000001899BCFD0
	public static void BuildIndex() {} // 0x00000001825C2D70-0x00000001825C3080
	// [XID] // 0x00000001899C4A60-0x00000001899C4A80
	public static MapTagDataConfig GetMapTagBySceneId(uint sceneId) => default; // 0x00000001825C2C70-0x00000001825C2D70
	// [XID] // 0x00000001899CC100-0x00000001899CC120
	public static void Register() {} // 0x00000001825C33D0-0x00000001825C3490
	// [XID] // 0x00000001899DAC20-0x00000001899DAC40
	public static MapTagDataConfig GetData(uint id) => default; // 0x00000001825C14B0-0x00000001825C1650
	// [XID] // 0x00000001899E9A40-0x00000001899E9A60
	public static void LoadData() {} // 0x00000001825C1E40-0x00000001825C1F70
	// [XID] // 0x00000001899F1250-0x00000001899F1270
	private static void RegisterHotfixGenerated() {} // 0x00000001825C1BD0-0x00000001825C1E40
	// [XID] // 0x00000001899F8AF0-0x00000001899F8B10
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001825C16F0-0x00000001825C1BD0
	// [IDTag] // 0x0000000189A00020-0x0000000189A00060
	// [XID] // 0x0000000189A00020-0x0000000189A00060
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001825C2400-0x00000001825C2560
	// [XID] // 0x0000000189A0A6A0-0x0000000189A0A6C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MapTagDataConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001825C3080-0x00000001825C33D0
	// [XID] // 0x0000000189A11F00-0x0000000189A11F20
	private static bool ParseConfigFromLine(string line, out MapTagDataConfig data) {
		data = default;
		return default;
	} // 0x00000001825C1F70-0x00000001825C20B0
	// [IDTag] // 0x0000000189A19310-0x0000000189A19350
	// [XID] // 0x0000000189A19310-0x0000000189A19350
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MapTagDataConfig> configList) => default; // 0x00000001825C20B0-0x00000001825C2400
	// [IDTag] // 0x0000000189A239A0-0x0000000189A239E0
	// [XID] // 0x0000000189A239A0-0x0000000189A239E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEFA4B */, bool useObjectPool = false /* Metadata: 0x00AEFA4F */) => default; // 0x00000001825C28F0-0x00000001825C2BA0
	// [IDTag] // 0x0000000189A2DB30-0x0000000189A2DB70
	// [XID] // 0x0000000189A2DB30-0x0000000189A2DB70
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA50 */, bool useObjectPool = false /* Metadata: 0x00AEFA54 */) => default; // 0x00000001825C2560-0x00000001825C28F0
}

