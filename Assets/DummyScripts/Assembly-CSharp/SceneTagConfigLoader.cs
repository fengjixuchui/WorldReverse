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

public static class SceneTagConfigLoader // TypeDefIndex: 16100
{
	// Fields
	private static Dictionary<uint, SceneTagConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<SceneTagConfig>> customApplyHotfixAction; // 0x08
	public static Action<SceneTagConfig, SceneTagConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SceneTagConfig>, Dictionary<uint, SceneTagConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, SceneTagConfig> dataDict { /* [XID] */ /* 0x0000000189B59C60-0x0000000189B59C80 */ get; } // 0x0000000185706D80-0x0000000185706E30 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B68DA0-0x0000000189B68DC0 */ get; } // 0x0000000185705BD0-0x0000000185705C70 

	// Methods
	// [XID] // 0x0000000189B522A0-0x0000000189B522C0
	public static void Register() {} // 0x0000000185707160-0x0000000185707200
	// [XID] // 0x0000000189B61370-0x0000000189B61390
	public static SceneTagConfig GetData(uint id) => default; // 0x0000000185705AA0-0x0000000185705BD0
	// [XID] // 0x0000000189B70260-0x0000000189B70280
	public static void LoadData() {} // 0x0000000185706200-0x00000001857062F0
	// [XID] // 0x0000000189B77770-0x0000000189B77790
	private static void RegisterHotfixGenerated() {} // 0x0000000185706030-0x0000000185706200
	// [XID] // 0x0000000189B7ECA0-0x0000000189B7ECC0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185705C70-0x0000000185706030
	// [IDTag] // 0x0000000189B868A0-0x0000000189B868E0
	// [XID] // 0x0000000189B868A0-0x0000000189B868E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001857066E0-0x00000001857067E0
	// [XID] // 0x0000000189B90C70-0x0000000189B90C90
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SceneTagConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185706E30-0x0000000185707160
	// [XID] // 0x0000000189B97F60-0x0000000189B97F80
	private static bool ParseConfigFromLine(string line, out SceneTagConfig data) {
		data = default;
		return default;
	} // 0x00000001857062F0-0x0000000185706430
	// [IDTag] // 0x0000000189B9F3B0-0x0000000189B9F3F0
	// [XID] // 0x0000000189B9F3B0-0x0000000189B9F3F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SceneTagConfig> configList) => default; // 0x0000000185706430-0x00000001857066E0
	// [IDTag] // 0x0000000189BA9C20-0x0000000189BA9C60
	// [XID] // 0x0000000189BA9C20-0x0000000189BA9C60
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF3040 */, bool useObjectPool = false /* Metadata: 0x00AF3044 */) => default; // 0x00000001857067E0-0x0000000185706A30
	// [IDTag] // 0x0000000189BB3FD0-0x0000000189BB4010
	// [XID] // 0x0000000189BB3FD0-0x0000000189BB4010
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3045 */, bool useObjectPool = false /* Metadata: 0x00AF3049 */) => default; // 0x0000000185706A30-0x0000000185706D80
}

