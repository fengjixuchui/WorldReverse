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

public static class RandTaskLevelConfigLoader // TypeDefIndex: 16004
{
	// Fields
	private static List<RandTaskLevelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<RandTaskLevelConfig>> customApplyHotfixAction; // 0x08
	public static Action<RandTaskLevelConfig, RandTaskLevelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<RandTaskLevelConfig>, List<RandTaskLevelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<RandTaskLevelConfig> dataList { /* [XID] */ /* 0x0000000189744EF0-0x0000000189744F10 */ get; } // 0x0000000181F12AC0-0x0000000181F12B70 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018974CAA0-0x000000018974CAC0 */ get; } // 0x0000000181F118D0-0x0000000181F11970 

	// Methods
	// [XID] // 0x000000018973DB70-0x000000018973DB90
	public static void Register() {} // 0x0000000181F12EA0-0x0000000181F12F40
	// [XID] // 0x0000000189753DE0-0x0000000189753E00
	public static void LoadData() {} // 0x0000000181F11F70-0x0000000181F12060
	// [XID] // 0x000000018975B2E0-0x000000018975B300
	private static void RegisterHotfixGenerated() {} // 0x0000000181F11DA0-0x0000000181F11F70
	// [XID] // 0x0000000189762CD0-0x0000000189762CF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F11970-0x0000000181F11DA0
	// [IDTag] // 0x000000018976A2B0-0x000000018976A2F0
	// [XID] // 0x000000018976A2B0-0x000000018976A2F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F121A0-0x0000000181F122A0
	// [XID] // 0x0000000189774730-0x0000000189774750
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<RandTaskLevelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F12B70-0x0000000181F12EA0
	// [XID] // 0x000000018977C160-0x000000018977C180
	private static bool ParseConfigFromLine(string line, out RandTaskLevelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F12060-0x0000000181F121A0
	// [IDTag] // 0x0000000189783B10-0x0000000189783B50
	// [XID] // 0x0000000189783B10-0x0000000189783B50
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<RandTaskLevelConfig> configList) => default; // 0x0000000181F122A0-0x0000000181F12540
	// [IDTag] // 0x000000018978DF50-0x000000018978DF90
	// [XID] // 0x000000018978DF50-0x000000018978DF90
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D7C */, bool useObjectPool = false /* Metadata: 0x00AF2D80 */) => default; // 0x0000000181F12540-0x0000000181F12790
	// [IDTag] // 0x0000000189798660-0x00000001897986A0
	// [XID] // 0x0000000189798660-0x00000001897986A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D81 */, bool useObjectPool = false /* Metadata: 0x00AF2D85 */) => default; // 0x0000000181F12790-0x0000000181F12AC0
}

