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

public static class SceneExcelConfigLoader // TypeDefIndex: 16089
{
	// Fields
	private static Dictionary<uint, SceneExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SceneExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SceneExcelConfig, SceneExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SceneExcelConfig>, Dictionary<uint, SceneExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SceneExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B93A30-0x0000000189B93A50 */ get; } // 0x00000001834756D0-0x0000000183475780 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BA2810-0x0000000189BA2830 */ get; } // 0x0000000183474520-0x00000001834745C0 

	// Methods
	// [XID] // 0x0000000189B8C1A0-0x0000000189B8C1C0
	public static void Register() {} // 0x0000000183475AB0-0x0000000183475B50
	// [XID] // 0x0000000189B9B000-0x0000000189B9B020
	public static SceneExcelConfig GetData(uint id) => default; // 0x00000001834743F0-0x0000000183474520
	// [XID] // 0x0000000189BA9C60-0x0000000189BA9C80
	public static void LoadData() {} // 0x0000000183474B50-0x0000000183474C40
	// [XID] // 0x0000000189BB1530-0x0000000189BB1550
	private static void RegisterHotfixGenerated() {} // 0x0000000183474980-0x0000000183474B50
	// [XID] // 0x0000000189BB8500-0x0000000189BB8520
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001834745C0-0x0000000183474980
	// [IDTag] // 0x0000000189BBFD90-0x0000000189BBFDD0
	// [XID] // 0x0000000189BBFD90-0x0000000189BBFDD0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183474D80-0x0000000183474E80
	// [XID] // 0x0000000189BCACB0-0x0000000189BCACD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SceneExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183475780-0x0000000183475AB0
	// [XID] // 0x0000000189BD2360-0x0000000189BD2380
	private static bool ParseConfigFromLine(string line, out SceneExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183474C40-0x0000000183474D80
	// [IDTag] // 0x0000000189BD9900-0x0000000189BD9940
	// [XID] // 0x0000000189BD9900-0x0000000189BD9940
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SceneExcelConfig> configList) => default; // 0x0000000183474E80-0x0000000183475130
	// [IDTag] // 0x00000001895E9530-0x00000001895E9570
	// [XID] // 0x00000001895E9530-0x00000001895E9570
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2FF0 */, bool useObjectPool = false /* Metadata: 0x00AF2FF4 */) => default; // 0x0000000183475480-0x00000001834756D0
	// [IDTag] // 0x00000001895F3CB0-0x00000001895F3CF0
	// [XID] // 0x00000001895F3CB0-0x00000001895F3CF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FF5 */, bool useObjectPool = false /* Metadata: 0x00AF2FF9 */) => default; // 0x0000000183475130-0x0000000183475480
}

